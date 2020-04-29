using ConnectionBuilder;
using SqlEngine;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;

namespace WSTrazinsAtenea
{
    public class ClassInitConnections
    {
        private static bool bolConected;

        //Aqui empieza la carga de información desde el archivo global.
        public static bool InitConnections()
        {
            string strPort;
            string strFile;
            string strFileSMS;

            //Obtiene la ruta del archivo
            ConnectionBuilder.ClassInitConnection.m_strPath = HttpRuntime.AppDomainAppPath;            

            //Se utiliza para que no desencripte el fichero si ya está conectado.
            if (bolConected)
            {
                return true;
            }

            strPort = ConfigurationManager.AppSettings["PuertoConexion"];

            //Asigando en el web config el nombre del archivo.
            strFile = ConfigurationManager.AppSettings["FicheroConexion"];
            strFileSMS = ConfigurationManager.AppSettings["FicheroConexionSMS"];

            //Una vez obtenido el nombre de fichero hay que desencriptarlo.
            if ((strFile.Trim() != "") || (strFileSMS.Trim() != ""))
            {
                bolConected = InitConnections(strFile, strPort);

            }
            else
            {
                bolConected = false;
            }

            return bolConected;
        }

        public static bool InitConnections(string strFile, string strPort)
        {
            bool bolReadFile;
            bool bolValidConnection = false;

            string strError = "";

            //Lee el fichero encriptado ¿Para que se usa el puerto?
            bolReadFile = ClassInitConnection.ReadingFile(strFile, ref strError);

            //Cargamos los datos de la conexión
            if (bolReadFile)
            {
                bolValidConnection = ClassInitConnection.LoadConnections();
            }
            else
            {
                //Por si queremos agregar un log de errores
                //ClaseRegistroErrores.EscribeLog((string) ("No se ha podido leer el fichero: " + strError));
            }

            //Creamos la cadena de conexión.
            //Hay que crear una clase base que recupere la información de conexion
            //y que todas las demás hereden de esta.
            MainSqlEngine.InitializeBindingDB(true);

            return bolReadFile && bolValidConnection;
        }
    }
}