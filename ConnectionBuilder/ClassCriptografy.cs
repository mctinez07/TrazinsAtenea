using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ConnectionBuilder
{
    public class ClassCriptografy
    {
        private int _type = 0;
        private SymmetricAlgorithm algoritmSym;

        public ClassCriptografy(Type type)
        {
            this._type = (int)type;
        }

        public enum Type
        {
            MD5 = 0,
            SHA1 = 1,
            DES = 2,
            TripleDes = 3
        }

        private HashAlgorithm CalculationHash()
        {
            switch (this._type)
            {
                case (int)Type.MD5:
                    return new MD5CryptoServiceProvider();
                case (int)Type.SHA1:
                    return new SHA1CryptoServiceProvider();
            }
            return new SHA1CryptoServiceProvider();
        }

        private string CreateSalt()
        {
            byte[] bySalt = new byte[9];
            RNGCryptoServiceProvider rng = new RNGCryptoServiceProvider();

            rng.GetBytes(bySalt);
            return Convert.ToBase64String(bySalt);
        }

        public string InitializeHash(string Value)
        {
            byte[] byteValue;
            HashAlgorithm algoritmHash;
            byte[] stringHash;
            string salt = "";

            if (this._type == ((int)Type.DES | (int)Type.TripleDes))
            {
                return "ERROR";
            }

            algoritmHash = CalculationHash();

            byteValue = Encoding.UTF8.GetBytes(salt + Value);

            stringHash = algoritmHash.ComputeHash(byteValue);

            algoritmHash.Clear();

            return Convert.ToBase64String(stringHash);
        }

        public byte[] getKeyGen()
        {
            return algoritmSym.Key;
        }

        public byte[] getIV()
        {
            return algoritmSym.IV;
        }

        private SymmetricAlgorithm CalculationTypeDES()
        {
            switch (this._type)
            {
                case (int)Type.DES:
                    return new DESCryptoServiceProvider();
                case (int)Type.TripleDes:
                    return new TripleDESCryptoServiceProvider();
            }
            return null;
        }

        public string Encrypt(string valueToEnc)
        {
            ICryptoTransform encryptor;
            MemoryStream memoryStr;
            CryptoStream cryptoStr;
            byte[] stringByte;

            if (this._type == ((int)Type.MD5 | (int)Type.SHA1))
            {
                return "ERROR";
            }

            algoritmSym = CalculationTypeDES();

            algoritmSym.GenerateKey();

            algoritmSym.GenerateIV();

            encryptor = algoritmSym.CreateEncryptor(algoritmSym.Key, algoritmSym.IV);

            stringByte = Encoding.UTF8.GetBytes(valueToEnc);

            memoryStr = new MemoryStream();
            cryptoStr = new CryptoStream(memoryStr, encryptor, CryptoStreamMode.Write);

            cryptoStr.Write(stringByte, 0, stringByte.Length);
            cryptoStr.FlushFinalBlock();

            cryptoStr.Close();

            return Convert.ToBase64String(memoryStr.ToArray());

        }

        public string Decrypt(string valueToDes, byte[] key, byte[] iv)
        {
            ICryptoTransform encryptor;
            MemoryStream memoryStr;
            CryptoStream cryptoStr;
            byte[] stringByte;

            if (this._type == ((int)Type.MD5 | (int)Type.SHA1))
            {
                return "ERROR";
            }

            algoritmSym = CalculationTypeDES();
            encryptor = algoritmSym.CreateDecryptor(key, iv);

            stringByte = Convert.FromBase64String(valueToDes);

            memoryStr = new MemoryStream();
            cryptoStr = new CryptoStream(memoryStr, encryptor, CryptoStreamMode.Write);
            cryptoStr.Write(stringByte, 0, stringByte.Length);
            cryptoStr.FlushFinalBlock();

            cryptoStr.Close();

            return Encoding.UTF8.GetString(memoryStr.ToArray());
        }
    }
}
