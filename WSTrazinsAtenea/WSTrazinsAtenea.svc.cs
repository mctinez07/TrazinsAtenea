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

        #region Embalajes

        public string Embalaje_Insert(Embalaje embalaje)
        {
            return EmbalajeManager.Embalaje_Insert(embalaje);
        }

        public Embalaje Embalaje_Select(Embalaje embalaje)
        {
            return EmbalajeManager.Embalaje_Select(embalaje);
        }

        public List<Embalaje> Embalaje_Select_List(Embalaje embalaje)
        {
            return EmbalajeManager.Embalaje_Select_List(embalaje);
        }

        public string Embalaje_Update(Embalaje embalaje)
        {
            return EmbalajeManager.Embalaje_Update(embalaje);
        }
        #endregion

        #region Hospitales

        public List<Hospital> Hospital_Select_List(Hospital hospital)
        {
            return HospitalManager.Hospital_Select_List(hospital);
        }

        public Hospital Hospital_Select(Hospital hospital)
        {
            return HospitalManager.Hospital_Select(hospital);
        }

        public string Hospital_Insert(Hospital hospital)
        {
            return HospitalManager.Hospital_Insert(hospital);
        }

        public string Hospital_Update(Hospital hospital)
        {
            return HospitalManager.Hospital_Update(hospital);
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
