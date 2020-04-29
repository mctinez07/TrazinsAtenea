using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConnectionBuilder
{
    //Clase para gestionar los valores de la conexión y el formato.
    public enum EnumConnectionType
    {
        NuevoRegistro,
        EliminarRegistro,
        ModificarRegistro,
        NuevoAcceso,
        TerminarAcceso,
        ConsultarRegistro,
        ImprimirRegistro
    }

    public enum EnumConnectionExit
    {
        Si,
        No
    }

    public sealed class ClassGeneral
    {
        public static string DataFormat(object oCad)
        {
            string returnValue;
            if (oCad != null)
            {
                System.Type tipo = oCad.GetType();
                switch (tipo.Name)
                {
                    case "DateTime":
                        returnValue = System.Convert.ToDateTime(oCad).ToString("dd/MM/yyyy");
                        break;
                    case "DBNull":
                        returnValue = "";
                        break;
                    default:
                        returnValue = System.Convert.ToString(oCad).Trim();
                        break;
                }
            }
            else
            {
                returnValue = "";
            }

            return returnValue;
        }

        public static string DateFormat(object oCad)
        {
            string returnValue;

            returnValue = "";

            if (oCad != null)
            {

                if (oCad == DBNull.Value)
                {
                    returnValue = "";


                }
                else if (oCad.GetType().Name.ToUpper() == "DATETIME")
                {
                    if (oCad.GetType() == typeof(DateTime))
                    {
                        returnValue = System.Convert.ToDateTime(oCad).ToString("dd/MM/yyyy HH:mm");
                    }
                    else
                    {
                        returnValue = "";
                    }
                }
                else
                {

                    returnValue = System.Convert.ToString(oCad).Trim();
                }

            }
            return returnValue;
        }

    }
}
