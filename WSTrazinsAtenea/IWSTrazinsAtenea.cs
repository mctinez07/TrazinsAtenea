using Models.Inventory;
using Models.Masters;
using Models.Masters.Storage;
using Models.Messages;
using Models.Processes.Methods;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace WSTrazinsAtenea
{
    [ServiceContract(Namespace = "http://WSTrazinsAtenea.com")]
    public interface IWSTrazinsAtenea
    {

        //[OperationContract]
        //List<Usuario> Usuario_Select(Usuario usuario);
        #region Almacenes

        [OperationContract]
        List<Almacen> Almacen_Select_List(Almacen almacen);

        [OperationContract]
        Almacen Almacen_Select(Almacen almacen);

        [OperationContract]
        Almacen Almacen_Insert(Almacen almacen);

        [OperationContract]
        Almacen Almacen_Update(Almacen almacen);

        #endregion

        #region Almacenes Ubicaciones

        [OperationContract]
        List<AlmacenesUbicaciones> AlmacenesUbicaciones_GetStructure(AlmacenesUbicaciones almacenesUbicaciones);

        [OperationContract]
        List<AlmacenesUbicaciones> AlmacenesUbicaciones_Select_List(AlmacenesUbicaciones almacenesUbicaciones);

        [OperationContract]
        AlmacenesUbicaciones AlmacenesUbicaciones_Select(AlmacenesUbicaciones almacenesUbicaciones);

        [OperationContract]
        AlmacenesUbicaciones AlmacenesUbicaciones_Insert(AlmacenesUbicaciones almacenesUbicaciones);

        [OperationContract]
        AlmacenesUbicaciones AlmacenesUbicaciones_Update(AlmacenesUbicaciones almacenesUbicaciones);

        #endregion

        #region Cajas

        [OperationContract]
        List<Caja> Caja_Select_List(Caja caja);

        [OperationContract]
        Caja Caja_Select(Caja caja);

        [OperationContract]
        Caja Caja_Insert(Caja caja);

        [OperationContract]
        Caja Caja_Update(Caja caja);

        #endregion

        #region CajasGrupos

        [OperationContract]
        List<CajasGrupo> CajasGrupos_Select_List(CajasGrupo cajasGrupo);

        [OperationContract]
        CajasGrupo CajasGrupos_Select(CajasGrupo cajasGrupo);

        [OperationContract]
        CajasGrupo CajasGrupos_Insert(CajasGrupo cajasGrupo);

        [OperationContract]
        CajasGrupo CajasGrupos_Update(CajasGrupo cajasGrupo);

        [OperationContract]
        CajasGrupo CajasGrupos_Delete(CajasGrupo cajasGrupo);

        #endregion

        #region CajaImagen

        [OperationContract]
        List<CajaImagen> CajaImagen_Select_List(CajaImagen cajaImagen);

        [OperationContract]
        CajaImagen CajaImagen_Select(CajaImagen cajaImagen);

        [OperationContract]
        CajaImagen CajaImagen_Insert(CajaImagen cajaImagen);

        [OperationContract]
        CajaImagen CajaImagen_Update(CajaImagen cajaImagen);

        [OperationContract]
        CajaImagen CajaImagen_Delete(CajaImagen cajaImagen);

        #endregion

        #region CentroCoste

        [OperationContract]
        List<CentroCoste> CentroCoste_Select_List(CentroCoste centrocoste);

        [OperationContract]
        CentroCoste CentroCoste_Select(CentroCoste centrocoste);

        [OperationContract]
        CentroCoste CentroCoste_Insert(CentroCoste centrocoste);

        [OperationContract]
        CentroCoste CentroCoste_Update(CentroCoste centrocoste);

        #endregion

        #region Embalajes

        [OperationContract]
        List<Embalaje> Embalaje_Select_List(Embalaje embalaje);

        [OperationContract]
        Embalaje Embalaje_Select(Embalaje embalaje);

        [OperationContract]
        Embalaje Embalaje_Insert(Embalaje embalaje);

        [OperationContract]
        Embalaje Embalaje_Update(Embalaje embalaje);

        #endregion

        #region Especialidades

        [OperationContract]
        List<Especialidad> Especialidad_Select_List(Especialidad especialidad);

        [OperationContract]
        Especialidad Especialidad_Select(Especialidad especialidad);

        [OperationContract]
        Especialidad Especialidad_Insert(Especialidad especialidad);

        [OperationContract]
        Especialidad Especialidad_Update(Especialidad especialidad);

        #endregion        

        #region Hospitales

        [OperationContract]
        List<Hospital> Hospital_Select_List(Hospital hospital);

        [OperationContract]
        Hospital Hospital_Select(Hospital hospital);

        [OperationContract]
        Hospital Hospital_Insert(Hospital hospital);

        [OperationContract]
        Hospital Hospital_Update(Hospital hospital);

        #endregion

        #region Mensajes

        [OperationContract]
        Mensaje Mensaje_Select(Mensaje mensaje);

        #endregion

        #region Métodos Esterilización

        [OperationContract]
        List<Esterilizacion> Esterilizacion_Select_List(Esterilizacion esterilizacion);

        [OperationContract]
        Esterilizacion Esterilizacion_Select(Esterilizacion esterilizacion);

        [OperationContract]
        Esterilizacion Esterilizacion_Insert(Esterilizacion esterilizacion);

        [OperationContract]
        Esterilizacion Esterilizacion_Update(Esterilizacion esterilizacion);

        #endregion        

        #region Métodos Limpieza

        [OperationContract]
        List<Limpieza> Limpieza_Select_List(Limpieza limpieza);

        [OperationContract]
        Limpieza Limpieza_Select(Limpieza limpieza);

        [OperationContract]
        Limpieza Limpieza_Insert(Limpieza limpieza);

        [OperationContract]
        Limpieza Limpieza_Update(Limpieza limpieza);

        #endregion

        #region TiposCajas

        [OperationContract]
        List<TipoCaja> TipoCaja_Select_List(TipoCaja tipoCaja);

        [OperationContract]
        TipoCaja TipoCaja_Select(TipoCaja tipoCaja);

        [OperationContract]
        TipoCaja TipoCaja_Insert(TipoCaja tipoCaja);

        [OperationContract]
        TipoCaja TipoCaja_Update(TipoCaja tipoCaja);

        #endregion

    }
}
