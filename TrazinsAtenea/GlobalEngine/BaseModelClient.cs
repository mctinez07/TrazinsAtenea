using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrazinsAtenea.ServiceWSTrazinsAtenea;

namespace TrazinsAtenea.GlobalEngine
{
    //Patrón Singleton para el Modelo Base del Cliente
    public class BaseModelClient
    {
        #region Atributtes

        private static BaseModelClient instance;

        #endregion

        #region Properties

        public string ChId { get; set; }

        public string HosId { get; set; }

        public string AuditUsuario { get; set; }

        public WSTrazinsAteneaClient Service;

        #endregion

        #region Constructor

        public BaseModelClient()
        {
            //Asigno temporalmente los valores del modelo
            this.ChId = "002";
            this.HosId = "002";
            this.AuditUsuario = "andres";

            //Instanciamos el Web Service
            this.Service = new WSTrazinsAteneaClient();

        }

        #endregion

        #region Singleton

        public static BaseModelClient Instance
        {
            get
            {
                if(instance == null)
                {
                    instance = new BaseModelClient();
                }
                return instance;
            }
        }

        #endregion

    }
}
