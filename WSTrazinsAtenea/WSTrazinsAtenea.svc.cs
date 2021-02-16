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

        public Caja Caja_Insert(Caja caja)
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

        public Caja Caja_Update(Caja caja)
        {
            return CajaManager.Caja_Update(caja);
        }

        #endregion

        #region CajaImagen

        public List<CajaImagen> CajaImagen_Select_List(CajaImagen cajaImagen)
        {
            return CajaImagenManager.CajaImagen_Select_List(cajaImagen);
        }

        public CajaImagen CajaImagen_Select(CajaImagen cajaImagen)
        {
            return CajaImagenManager.CajaImagen_Select(cajaImagen);
        }

        public CajaImagen CajaImagen_Insert(CajaImagen cajaImagen)
        {
            return CajaImagenManager.CajaImagen_Insert(cajaImagen);
        }

        public CajaImagen CajaImagen_Update(CajaImagen cajaImagen)
        {
            return CajaImagenManager.CajaImagen_Update(cajaImagen);
        }

        #endregion

        #region CajasGrupos

        public List<CajasGrupo> CajasGrupos_Select_List(CajasGrupo cajasGrupo)
        {
            return CajasGrupoManager.CajasGrupo_Select_List(cajasGrupo);
        }

        public CajasGrupo CajasGrupos_Select(CajasGrupo cajasGrupo)
        {
            return CajasGrupoManager.CajasGrupo_Select(cajasGrupo);
        }

        public CajasGrupo CajasGrupos_Insert(CajasGrupo cajasGrupo)
        {
            return CajasGrupoManager.CajasGrupo_Insert(cajasGrupo);
        }

        public CajasGrupo CajasGrupos_Update(CajasGrupo cajasGrupo)
        {
            return CajasGrupoManager.CajasGrupo_Update(cajasGrupo);
        }

        public CajasGrupo CajasGrupos_Delete(CajasGrupo cajasGrupo)
        {
            return CajasGrupoManager.CajasGrupo_Delete(cajasGrupo);
        }

        #endregion

        #region Especialidades

        public Especialidad Especialidad_Insert(Especialidad especialidad)
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

        public Especialidad Especialidad_Update(Especialidad especialidad)
        {
            return EspecialidadManager.Especialidad_Update(especialidad);
        }

        #endregion

        #region Embalajes

        public Embalaje Embalaje_Insert(Embalaje embalaje)
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

        public Embalaje Embalaje_Update(Embalaje embalaje)
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

        public Hospital Hospital_Insert(Hospital hospital)
        {
            return HospitalManager.Hospital_Insert(hospital);
        }

        public Hospital Hospital_Update(Hospital hospital)
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

        public TipoCaja TipoCaja_Insert(TipoCaja tipoCaja)
        {
            return TipoCajaManager.TipoCaja_Insert(tipoCaja);
        }

        public TipoCaja TipoCaja_Update(TipoCaja tipoCaja)
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

        public Limpieza Limpieza_Insert(Limpieza limpieza)
        {
            return LimpiezaManager.Limpieza_Insert(limpieza);
        }

        public Limpieza Limpieza_Update(Limpieza limpieza)
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

        public Esterilizacion Esterilizacion_Insert(Esterilizacion esterilizacion)
        {
            return EsterilizacionManager.Esterilizacion_Insert(esterilizacion);
        }

        public Esterilizacion Esterilizacion_Update(Esterilizacion esterilizacion)
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

        public Almacen Almacen_Insert(Almacen almacen)
        {
            return AlmacenManager.Almacen_Insert(almacen);
        }

        public Almacen Almacen_Update(Almacen almacen)
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

        public AlmacenesUbicaciones AlmacenesUbicaciones_Insert(AlmacenesUbicaciones almacenesUbicaciones)
        {
            return AlmacenesUbicacionesManager.AlmacenesUbicaciones_Insert(almacenesUbicaciones);
        }

        public AlmacenesUbicaciones AlmacenesUbicaciones_Update(AlmacenesUbicaciones almacenesUbicaciones)
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
