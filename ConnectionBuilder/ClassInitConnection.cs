using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConnectionBuilder
{
    //Clase para Gestionar la creación de la cadena de conexión.
    public class ClassInitConnection
    {
        #region Iniciar Cadena de conexión

        public static string m_strPath = string.Empty;

        private static byte[] m_bytKey;
        private static byte[] m_bytIV;

        private static string m_strDataFiles = string.Empty;

        private static ClassCriptografy m_objCryto = new ClassCriptografy(ClassCriptografy.Type.TripleDes);

        public static bool ReadingFile(string strFile, ref string strError)
        {
            bool returnValue;

            string sPath;
            strError = "";
            returnValue = true;

            sPath = m_strPath + "\\" + strFile;

            //Con la ruta y el nombre de fichero lo envíamos a leer
            //para obtener los datos bynarios.
            if (!ReadFile(sPath, ref strError))
            {
                returnValue = false;
            }
            return returnValue;
        }

        private static bool ReadFile(string strFileName, ref string strError)
        {
            bool returnValue;
            FileStream objFileStream;
            BinaryReader objBinaryReader;
            int intLength;
            string strText = string.Empty;

            returnValue = true;


            try
            {
                objFileStream = new FileStream(strFileName, FileMode.Open, FileAccess.Read);

            }
            catch (Exception ex)
            {
                returnValue = false;
                strError = ex.Message;
                return returnValue;
            }

            objBinaryReader = new BinaryReader(objFileStream);

            try
            {
                intLength = objBinaryReader.ReadInt32();

                m_bytKey = objBinaryReader.ReadBytes(intLength);
            }
            catch (Exception ex)
            {
                returnValue = false;
                strError = ex.Message;
                return returnValue;
            }

            //m_bytIV
            try
            {
                intLength = objBinaryReader.ReadInt32();
                m_bytIV = objBinaryReader.ReadBytes(intLength);
            }
            catch (Exception ex)
            {
                returnValue = false;
                strError = ex.Message;
                return returnValue;
            }

            try
            {
                m_strDataFiles = string.Empty;

                //Mientras hay información en el fichero desencryta la linea
                while (ReadData(objBinaryReader, ref intLength, ref strText))
                {
                    m_strDataFiles = m_strDataFiles + "\r\n" + DecryptData(strText);
                }

            }
            catch (Exception ex)
            {
                strError = ex.Message;
                returnValue = false;
            }

            objFileStream.Close();

            return returnValue;
        }

        private static bool ReadData(BinaryReader brdFile, ref int intLength, ref string strLine)
        {
            bool returnValue;

            try
            {
                if (brdFile.BaseStream.Position == brdFile.BaseStream.Length)
                    return false;

                intLength = brdFile.ReadInt32();
                brdFile.ReadChar();
                strLine = new string(brdFile.ReadChars(intLength));
            }
            catch (Exception)
            {
                returnValue = false;
                return returnValue;
            }

            returnValue = true;

            return returnValue;
        }

        private static string DecryptData(string strDatos)
        {
            return m_objCryto.Decrypt(strDatos, m_bytKey, m_bytIV);
        }

        #endregion

        public static bool LoadConnections()
        {
            bool returnValue;
            DataSet dsConnections = new DataSet();
            DataTable dttConnections;

            DataRow drConnection;

            string strIP;
            string strInstance;
            string strCatalog;
            string strUser;
            string strPasswd;
            string strIPFailover;
            string strInstanceFailover;

            string strArchitectureType = "0";

            System.IO.StringReader xmlSR;

            //Ya tenemos el archivo desencriptado y lo convertimos en xml.
            xmlSR = new System.IO.StringReader(m_strDataFiles);
            dsConnections.Clear();

            //Creamos el dataset en base al xml desencriptado.
            dsConnections.ReadXml(xmlSR, XmlReadMode.Auto);

            //Obtenemos las diferentes conexiones como tablas
            dttConnections = dsConnections.Tables["Conexion"];

            //Desglosamos y asignamos valores
            foreach (DataRow tempLoopVar_drConnection in dttConnections.Rows)
            {
                drConnection = tempLoopVar_drConnection;
                strIP = (string)(ClassGeneral.DataFormat(drConnection["IP"]) + "\\");
                strInstance = ClassGeneral.DataFormat(drConnection["Instancia"]);
                strCatalog = ClassGeneral.DataFormat(drConnection["Catalogo"]);
                strUser = ClassGeneral.DataFormat(drConnection["User"]);
                strPasswd = ClassGeneral.DataFormat(drConnection["Passwd"]);
                strIPFailover = ClassGeneral.DataFormat(drConnection["IPFailover"]);
                strInstanceFailover = ClassGeneral.DataFormat(drConnection["InstanciaFailOver"]);

                switch (ClassGeneral.DataFormat(drConnection["codigo"]))
                {

                    case "TRAZINS":
                        LoadMainConnection(strIP, strInstance, strCatalog, strUser, strPasswd, strIPFailover, strInstanceFailover);
                        break;
                    default:
                        break;
                }
            }

            returnValue = true;
            return returnValue;
        }

        private static void LoadMainConnection(
            string strIP, string strInstance, string strCatalog, string strUser,
            string strPasswd, string strIPFailover, string strInstanceFailover)
        {
            //Asigmanos los valores de conexión.
            ClassBindingConnection.IP = strIP;
            ClassBindingConnection.Instance = strInstance;
            ClassBindingConnection.Catalog = strCatalog;
            ClassBindingConnection.User = strUser;
            ClassBindingConnection.Passw = strPasswd;
            ClassBindingConnection.IPFailover = strIPFailover;
            ClassBindingConnection.InstanceFailover = strInstanceFailover;
        }
    }
}
