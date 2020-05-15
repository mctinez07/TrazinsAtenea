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
using Models.Processes.Methods;
using ManagerModels.Processes.Methods;
using Models.Masters.Storage;
using ManagerModels.Masters.Storage;

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

        #region TiposCajas

        public List<TipoCaja> TipoCaja_Select_List(TipoCaja tipoCaja)
        {
            return TipoCajaManager.TipoCaja_Select_List(tipoCaja);
        }

        public TipoCaja TipoCaja_Select(TipoCaja tipoCaja)
        {
            return TipoCajaManager.TipoCaja_Select(tipoCaja);
        }

        public string TipoCaja_Insert(TipoCaja tipoCaja)
        {
            return TipoCajaManager.TipoCaja_Insert(tipoCaja);
        }

        public string TipoCaja_Update(TipoCaja tipoCaja)
        {
            return TipoCajaManager.TipoCaja_Update(tipoCaja);
        }

        #endregion

        #region Métodos Limpieza

        public List<Limpieza> Limpieza_Select_List(Limpieza limpieza)
        {
            return LimpiezaManager.Limpieza_Select_List(limpieza);
        }

        public Limpieza Limpieza_Select(Limpieza limpieza)
        {
            return LimpiezaManager.Limpieza_Select(limpieza);
        }

        public string Limpieza_Insert(Limpieza limpieza)
        {
            return LimpiezaManager.Limpieza_Insert(limpieza);
        }

        public string Limpieza_Update(Limpieza limpieza)
        {
            return LimpiezaManager.Limpieza_Update(limpieza);
        }

        #endregion

        #region Métodos Esterilización

        public List<Esterilizacion> Esterilizacion_Select_List(Esterilizacion esterilizacion)
        {
            return EsterilizacionManager.Esterilizacion_Select_List(esterilizacion);
        }

        public Esterilizacion Esterilizacion_Select(Esterilizacion esterilizacion)
        {
            return EsterilizacionManager.Esterilizacion_Select(esterilizacion);
        }

        public string Esterilizacion_Insert(Esterilizacion esterilizacion)
        {
            return EsterilizacionManager.Esterilizacion_Insert(esterilizacion);
        }

        public string Esterilizacion_Update(Esterilizacion esterilizacion)
        {
            return EsterilizacionManager.Esterilizacion_Update(esterilizacion);
        }

        #endregion

        #region Almacenes

        public List<Almacen> Almacen_Select_List(Almacen almacen)
        {
            return AlmacenManager.Almacen_Select_List(almacen);
        }

        public Almacen Almacen_Select(Almacen almacen)
        {
            return AlmacenManager.Almacen_Select(almacen);
        }

        public string Almacen_Insert(Almacen almacen)
        {
            return AlmacenManager.Almacen_Insert(almacen);
        }

        public string Almacen_Update(Almacen almacen)
        {
            return AlmacenManager.Almacen_Update(almacen);
        }

        #endregion

        #region AlmacenesUbicaciones

        public List<AlmacenesUbicaciones> AlmacenesUbicaciones_Select_List(AlmacenesUbicaciones almacenesUbicaciones)
        {            
            return AlmacenesUbicacionesManager.AlmacenesUbicaciones_Select_List(almacenesUbicaciones);
        }

        public AlmacenesUbicaciones AlmacenesUbicaciones_Select(AlmacenesUbicaciones almacenesUbicaciones)
        {
            return AlmacenesUbicacionesManager.AlmacenesUbicaciones_Select(almacenesUbicaciones);
        }

        public string AlmacenesUbicaciones_Insert(AlmacenesUbicaciones almacenesUbicaciones)
        {
            return AlmacenesUbicacionesManager.AlmacenesUbicaciones_Insert(almacenesUbicaciones);
        }

        public string AlmacenesUbicaciones_Update(AlmacenesUbicaciones almacenesUbicaciones)
        {
            return AlmacenesUbicacionesManager.AlmacenesUbicaciones_Update(almacenesUbicaciones);
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
