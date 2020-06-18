using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace SqlEngine
{
    public class MainSqlEngine
    {
        #region Atributos

        private static string ConnectionDB;

        private static SqlConnection Connection = null;

        private static object DataAdapter { get; set; }       

        #endregion

        #region Constructor

        public MainSqlEngine()
        {
        }

        #endregion

        #region Gestión Conexión

        public static void InitializeBindingDB(bool Failover)
        {
            try
            {
                if (Failover)
                {
                    //BBDD_Trazins = "packet size=4096;user id=" + ModLibrerias.ClaseEnlaceBBDD.UserTrazins + ";data source=\'TCP:" + ModLibrerias.ClaseEnlaceBBDD.IPTrazins + ModLibrerias.ClaseEnlaceBBDD.InstanciaTrazins + "\'; Failover Partner=\'" + ModLibrerias.ClaseEnlaceBBDD.IPTrazinsFailover + ModLibrerias.ClaseEnlaceBBDD.InstanciaTrazinsFailover + "\';persist security info=True;initial catalog=WSHNSGZ;password=" + ModLibrerias.ClaseEnlaceBBDD.PasswTrazins + ";Pooling=False;Connection TimeOut=300";
                    //Cuando hay nombre de instancia
                    //BBDD_Trazins = "Data Source = \'" + ModLibrerias.ClaseEnlaceBBDD.IPTrazins + ModLibrerias.ClaseEnlaceBBDD.InstanciaTrazins + "\'; Initial Catalog = WSTrazins; User Id = " + ModLibrerias.ClaseEnlaceBBDD.UserTrazins + "; Password = " + ModLibrerias.ClaseEnlaceBBDD.PasswTrazins + ";persist security info=True;Pooling=False;Connection TimeOut=300";
                    ConnectionDB = "Data Source = " + ConnectionBuilder.ClassBindingConnection.IP + ";Initial Catalog = " + ConnectionBuilder.ClassBindingConnection.Catalog + "; User Id = " + ConnectionBuilder.ClassBindingConnection.User + "; Password = " + ConnectionBuilder.ClassBindingConnection.Passw + ";persist security info=True;Pooling=False;Connection TimeOut=300";
                    //Para saltar el plantilla
                    //BBDD_Trazins = "Data Source = \'localhost\\WSTrazins\'; Initial Catalog = WSHNSGZ; User Id = sa; Password = W$Tr4zin$;persist security info=True;Pooling=False;Connection TimeOut=300";


                }
                else
                {
                    //BBDD_Trazins = "packet size=4096;user id=" + ModLibrerias.ClaseEnlaceBBDD.UserTrazins + ";data source=\'TCP:" + ModLibrerias.ClaseEnlaceBBDD.IPTrazins + ModLibrerias.ClaseEnlaceBBDD.InstanciaTrazins + "\';persist security info=True;initial catalog=WSHNSGZ;password=" + ModLibrerias.ClaseEnlaceBBDD.PasswTrazins + ";Pooling=False;Connection TimeOut=300";
                    //BBDD_Trazins = "Data Source = \'" + ModLibrerias.ClaseEnlaceBBDD.IPTrazins + ModLibrerias.ClaseEnlaceBBDD.InstanciaTrazins + "\'; Initial Catalog = WSTrazins; User Id = " + ModLibrerias.ClaseEnlaceBBDD.UserTrazins + "; Password = " + ModLibrerias.ClaseEnlaceBBDD.PasswTrazins + ";persist security info=True;Pooling=False;Connection TimeOut=300";
                    ConnectionDB = "Data Source = " + ConnectionBuilder.ClassBindingConnection.IP + ";Initial Catalog = " + ConnectionBuilder.ClassBindingConnection.Catalog + "; User Id = " + ConnectionBuilder.ClassBindingConnection.User + "; Password = " + ConnectionBuilder.ClassBindingConnection.Passw + ";persist security info=True;Pooling=False;Connection TimeOut=300";
                    //BBDD_Trazins = "Data Source = \'localhost\\WSTrazins\'; Initial Catalog = WSHNSGZ; User Id = sa; Password = W$Tr4zin$;persist security info=True;Pooling=False;Connection TimeOut=300";
                }

            }
            catch (Exception ex)
            {

                throw new Exception("Error en InicializeBindingDB: " + ex.Message);
            } 
        }

        public static string CNX_DB()
        {
            return ConnectionDB;
        }

        //Creamos la conexión.
        public static SqlConnection OpenConnection()
        {
            try
            {
                Connection = new SqlConnection(ConnectionDB);
                Connection.Open();
                return Connection;
            }
            catch (Exception ex)
            {

                throw new Exception("Error en OpenConnection: " + ex.Message);
            }
            
        }

        //Cerrar conexión
        public static void FinishConnection()
        {
            try
            {
                if (Connection.State == ConnectionState.Open)
                {
                    Connection.Close();
                    Connection.Dispose();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error en FinishConnection: " + ex.Message);
            }
            
        }

        #endregion

        #region Gestión Tipo Query

        public static List<T> IsSelectList<T>(T model)
        {
            try
            {
                //Abrimos la conexión
                OpenConnection();

                //Buscar el nombre del modelo
                string command = GetModelType(model) + "_Select";

                //Crear el SqlCommand según el modelo y los parámetros del procdure.
                var sqlCommand = CreateSqlCmd(Connection, command, model);

                return QueryTypeSelect(sqlCommand, model);

            }
            catch (Exception ex)
            {

                throw new Exception("Error en IsSelectList: "+ ex.Message);
            }
        }

        public static T IsSelect<T>(T model)
        {
            try
            {
                OpenConnection();

                string command = GetModelType(model) + "_Select";

                var sqlCommand = CreateSqlCmd(Connection, command, model);

                //Solo devolvemos un registro
                return QueryTypeSelect(sqlCommand, model).FirstOrDefault();

            }
            catch (Exception ex)
            {

                throw new Exception ("Error en IsSelect: "+ ex.Message);
            }
            
        }

        public static string IsInsert<T>(T model)
        {
            try
            {
                OpenConnection();
                string command = GetModelType(model) + "_Insert";

                var sqlCommand = CreateSqlCmd(Connection, command, model);

                return QueryTypeExecuteNonQuery(sqlCommand);

            }
            catch (Exception ex)
            {

                throw new Exception("Error en IsInsert: " + ex.Message);
            }
        }

        public static string IsUpdate<T>(T model)
        {
            try
            {
                OpenConnection();
                string command = GetModelType(model) + "_Update";

                var sqlCommand = CreateSqlCmd(Connection, command, model);

                return QueryTypeExecuteNonQuery(sqlCommand);
            }
            catch (Exception ex)
            {

                throw new Exception("Error en IsUpdate:" + ex.Message);
            }
            
        }

        public static string IsDelete<T>(T model)
        {
            try
            {
                OpenConnection();
                string command = GetModelType(model) + "_Delete";

                var sqlCommand = CreateSqlCmd(Connection, command, model);

                return QueryTypeExecuteNonQuery(sqlCommand);
            }
            catch (Exception ex)
            {

                throw new Exception ("Error en IsDelete: " + ex.Message);
            }
            
        }

        private static string GetModelType<T>(T model)
        {
            try
            {
                return model.GetType().Name;
            }
            catch (Exception ex)
            {

                throw new Exception ("Error en GetModelType: " + ex.Message);
            }
            
        }

        private static SqlCommand CreateSqlCmd<T>(SqlConnection con, string command, T modelo)
        {
            try
            {
                SqlParameter[] discoveredParameters;

                SqlCommand SqlCmd = new SqlCommand
                {
                    Connection = con,
                    CommandText = command,
                    CommandType = CommandType.StoredProcedure
                };

                //Obtener los parámetros del procedure
                SqlCommandBuilder.DeriveParameters(SqlCmd);

                discoveredParameters = new SqlParameter[SqlCmd.Parameters.Count - 1 + 1];
                SqlCmd.Parameters.CopyTo(discoveredParameters, 0);

                //Obtener las propiedades que necesita el procedure
                var Properties = modelo.GetType().GetProperties();

                List<PropertyInfo> result = new List<PropertyInfo>();
                foreach (var item in discoveredParameters)
                {
                    var item1 = item.ParameterName.Remove(0, 1);
                    PropertyInfo e = Properties.Where(p => p.Name.Equals(item1)).FirstOrDefault();
                    result.Add(e);
                }

                //Ya tenemos los propiedades que necesita el procedure
                //Quitamos los valores nulos para evitar errores
                foreach (PropertyInfo property in result.Where(p => p != null))
                {
                    var SqlParameter = discoveredParameters.FirstOrDefault((d) => string.Equals(d.ParameterName, "@" + property.Name, StringComparison.InvariantCultureIgnoreCase));
                    SqlParameter.Value = property.GetValue(modelo) ?? (object)DBNull.Value;
                }

                return SqlCmd;

            }
            catch (Exception ex)
            {

                throw new Exception("Error en CreateSqlCmd: "+ ex.Message);
            }
            
        }

        #endregion

        #region Querys

        private static List<T> QueryTypeSelect<T>(SqlCommand sqlcmd, T model)
        {
            List<T> returnList = new List<T>();
            try
            {
                T obj = default(T);
                SqlDataReader SqlDr = sqlcmd.ExecuteReader();

                List<string> columnName = new List<string>();

                for (int i = 0; i < SqlDr.FieldCount; i++)
                {
                    columnName.Add(SqlDr.GetName(i).ToLower());
                }
                //Tenemos los nombres de columnas que devuelve el procedure

                while (SqlDr.Read())
                {
                    obj = Activator.CreateInstance<T>();

                    //Convertir parametros a propiedades
                    List<PropertyInfo> returnedProperties = new List<PropertyInfo>();
                    var s = obj.GetType().GetProperties();

                    //Solo necesitamos asignar los valores devueltos en el procedimiento.
                    foreach (var item in columnName)
                    {
                        PropertyInfo pr = s.Where(t => t.Name.ToLower().Equals(item)).FirstOrDefault();
                        if(pr!= null)
                        {
                            returnedProperties.Add(pr);
                        }
                    }

                    foreach (PropertyInfo prop in returnedProperties)
                    {
                        if (!object.Equals(SqlDr[prop.Name], DBNull.Value))
                        {
                            //probar a que asigne valor null a la propiedad
                            prop.SetValue(obj, SqlDr[prop.Name], null);
                        }
                    }
                    returnList.Add(obj);
                }

                return returnList;
            }
            catch (Exception ex)
            {
                throw new Exception("Error en QueryTypeSelect: " + ex.Message);
            }
            finally
            {
                FinishConnection();
            }
        }

        //Crear metodo que devuelva el elemento insertad???
        //Tendre que mirar la direccion de parametro, creo que ya esta definido cuando obtnemos los argumentos del procedure
        private static string QueryTypeExecuteNonQuery(SqlCommand sqlCmd)
        {
            try
            {
                int result = sqlCmd.ExecuteNonQuery();

                if (result > 0)
                {
                    return "OK";
                }
                else
                {
                    return "ERROR";
                }
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
            finally
            {
                FinishConnection();
            }
        }

        #endregion
    }
}
