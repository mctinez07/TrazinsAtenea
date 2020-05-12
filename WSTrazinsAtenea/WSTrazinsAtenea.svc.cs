using ManagerModels.Inventory;
using Models.Inventory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using Models.Messages;
using ManagerModels.Messages;
using Models.Masters;
using ManagerModels.Masters;

namespace WSTrazinsAtenea
{
    [ServiceBehavior(Namespace = "http://WSTrazinsAtenea.com")]
    public class WSTrazinsAtenea : IWSTrazinsAtenea
    {
        #region Cajas

        public string Caja_Insert(Caja caja)
        {
            return CajaManager.Caja_Insert(caja);
        }

        public Caja Caja_Select(Caja caja)
        {
            return CajaManager.Caja_Select(caja);
        }

        public List<Caja> Caja_Select_List(Caja caja)
        {
            return CajaManager.Caja_Select_List(caja);
        }

        public string Caja_Update(Caja caja)
        {
            return CajaManager.Caja_Update(caja);
        }

        #endregion

        #region Especialidades

        public string Especialidad_Insert(Especialidad especialidad)
        {
            return EspecialidadManager.Especialidad_Insert(especialidad);
        }

        public Especialidad Especialidad_Select(Especialidad especialidad)
        {
            return EspecialidadManager.Especialidad_Select(especialidad);
        }

        public List<Especialidad> Especialidad_Select_List(Especialidad especialidad)
        {
            return EspecialidadManager.Especialidad_Select_List(especialidad);
        }

        public string Especialidad_Update(Especialidad especialidad)
        {
            return EspecialidadManager.Especialidad_Update(especialidad);
        }

        #endregion

        #region Mensajes

        public Mensaje Mensaje_Select(Mensaje mensaje)
        {
            return MensajesManager.Mensaje_Select(mensaje);
        }

        #endregion

        //public List<Usuario> Usuario_Select(Usuario usuario)
        //{
        //    throw new NotImplementedException();
        //}
    }
}
