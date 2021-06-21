using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace TrazinsAtenea.GlobalEngine
{
    public static class Comun
    {
        //Esta propiedad se establece a true  al arrancar el cliente para que las propiedades de
        //audit de los modelos se carguen automaticamente
        public static bool EsCliente { get; set; }

        public static void MTDEstablecerPropiedadConvirtiendo(object loObjeto, PropertyInfo loPropiedad, object loValue)
        {
            var loValorConvertido = Convertir(loValue, loPropiedad.PropertyType);
            loPropiedad.SetValue(loObjeto, loValorConvertido, null);
        }

        public static T Convertir<T>(object loValue)
        {
            return (T)Convertir(loValue, typeof(T));
        }

        public static object Convertir(object loValue, Type loDestinationType)
        {
            var loValorConvertido = loValue;
            var lbAsignableDirectamente = (loValue != null && loDestinationType.IsAssignableFrom(loValue.GetType()));

            //Convertimos la cadena vacía a null
            if ("".Equals(loValue) || loValue == DBNull.Value)
                loValorConvertido = null;

            if (!lbAsignableDirectamente)
            {
                //Estas variables se emplean para agilizar la evaluación de las condiciones
                ///bool lbDestinoEsNullable = (loPropType.IsGenericType && loPropType.GetGenericTypeDefinition() == typeof(Nullable<>));
                bool lbDestinoEsNullable = !loDestinationType.IsValueType || (Nullable.GetUnderlyingType(loDestinationType) != null);
                bool lbDestinoEsString = loDestinationType == typeof(string);
                bool lbHayQueConvertir = (loValue != null && !loDestinationType.IsAssignableFrom(loValue.GetType()));

                if (lbDestinoEsNullable && loValorConvertido == null)
                    return loValorConvertido;

                if (lbDestinoEsNullable || lbDestinoEsString)
                {
                    if (lbHayQueConvertir)
                    {
                        if (lbDestinoEsNullable)
                            loValorConvertido = MTDCambiarTipo(loValorConvertido, loDestinationType.GetGenericArguments()[0]);
                        else
                            loValorConvertido = MTDCambiarTipo(loValorConvertido, loDestinationType);
                    }

                }
                else
                    if (lbHayQueConvertir)
                    loValorConvertido = MTDCambiarTipo(loValorConvertido, loDestinationType);
                else if (loValue == null)
                {
                    loValorConvertido = Activator.CreateInstance(loDestinationType);
                }
            }

            return loValorConvertido;
        }


        private static object MTDCambiarTipo(object loValue, Type loDestinationType)
        {
            if (loDestinationType.IsEnum)
                return Enum.Parse(loDestinationType, loValue.ToString(), true);
            else
                return System.Convert.ChangeType(loValue, loDestinationType);
        }
    }
}
