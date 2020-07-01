﻿using Models.Inventory;
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

        #region Cajas

        [OperationContract]
        List<Caja> Caja_Select_List(Caja caja);

        [OperationContract]
        Caja Caja_Select(Caja caja);

        [OperationContract]
        string Caja_Insert(Caja caja);

        [OperationContract]
        string Caja_Update(Caja caja);

        #endregion

        #region CajaImagen

        [OperationContract]
        List<CajaImagen> CajaImagen_Select_List(CajaImagen cajaImagen);

        [OperationContract]
        CajaImagen CajaImagen_Select(CajaImagen cajaImagen);

        [OperationContract]
        string CajaImagen_Insert(CajaImagen cajaImagen);

        [OperationContract]
        string CajaImagen_Update(CajaImagen cajaImagen);

        #endregion

        #region CajasGrupos

        [OperationContract]
        List<CajasGrupo> CajasGrupos_Select_List(CajasGrupo cajasGrupo);

        [OperationContract]
        CajasGrupo CajasGrupos_Select(CajasGrupo cajasGrupo);

        [OperationContract]
        string CajasGrupos_Insert(CajasGrupo cajasGrupo);

        [OperationContract]
        string CajasGrupos_Update(CajasGrupo cajasGrupo);

        [OperationContract]
        string CajasGrupos_Delete(CajasGrupo cajasGrupo);

        #endregion

        #region Especialidades

        [OperationContract]
        List<Especialidad> Especialidad_Select_List(Especialidad especialidad);

        [OperationContract]
        Especialidad Especialidad_Select(Especialidad especialidad);

        [OperationContract]
        string Especialidad_Insert(Especialidad especialidad);

        [OperationContract]
        string Especialidad_Update(Especialidad especialidad);

        #endregion

        #region Embalajes

        [OperationContract]
        List<Embalaje> Embalaje_Select_List(Embalaje embalaje);

        [OperationContract]
        Embalaje Embalaje_Select(Embalaje embalaje);

        [OperationContract]
        string Embalaje_Insert(Embalaje embalaje);

        [OperationContract]
        string Embalaje_Update(Embalaje embalaje);

        #endregion

        #region Hospitales

        [OperationContract]
        List<Hospital> Hospital_Select_List(Hospital hospital);

        [OperationContract]
        Hospital Hospital_Select(Hospital hospital);

        [OperationContract]
        string Hospital_Insert(Hospital hospital);

        [OperationContract]
        string Hospital_Update(Hospital hospital);

        #endregion

        #region TiposCajas

        [OperationContract]
        List<TipoCaja> TipoCaja_Select_List(TipoCaja tipoCaja);

        [OperationContract]
        TipoCaja TipoCaja_Select(TipoCaja tipoCaja);

        [OperationContract]
        string TipoCaja_Insert(TipoCaja tipoCaja);

        [OperationContract]
        string TipoCaja_Update(TipoCaja tipoCaja);

        #endregion

        #region Métodos Limpieza

        [OperationContract]
        List<Limpieza> Limpieza_Select_List(Limpieza limpieza);

        [OperationContract]
        Limpieza Limpieza_Select(Limpieza limpieza);

        [OperationContract]
        string Limpieza_Insert(Limpieza limpieza);

        [OperationContract]
        string Limpieza_Update(Limpieza limpieza);

        #endregion

        #region Métodos Esterilización

        [OperationContract]
        List<Esterilizacion> Esterilizacion_Select_List(Esterilizacion esterilizacion);

        [OperationContract]
        Esterilizacion Esterilizacion_Select(Esterilizacion esterilizacion);

        [OperationContract]
        string Esterilizacion_Insert(Esterilizacion esterilizacion);

        [OperationContract]
        string Esterilizacion_Update(Esterilizacion esterilizacion);

        #endregion

        #region Almacenes

        [OperationContract]
        List<Almacen> Almacen_Select_List(Almacen almacen);

        [OperationContract]
        Almacen Almacen_Select(Almacen almacen);

        [OperationContract]
        string Almacen_Insert(Almacen almacen);

        [OperationContract]
        string Almacen_Update(Almacen almacen);

        #endregion

        #region Almacenes Ubicaciones

        [OperationContract]
        List<AlmacenesUbicaciones> AlmacenesUbicaciones_Select_List(AlmacenesUbicaciones almacenesUbicaciones);

        [OperationContract]
        AlmacenesUbicaciones AlmacenesUbicaciones_Select(AlmacenesUbicaciones almacenesUbicaciones);

        [OperationContract]
        string AlmacenesUbicaciones_Insert(AlmacenesUbicaciones almacenesUbicaciones);

        [OperationContract]
        string AlmacenesUbicaciones_Update(AlmacenesUbicaciones almacenesUbicaciones);

        #endregion

        #region Mensajes

        [OperationContract]
        Mensaje Mensaje_Select(Mensaje mensaje); 

        #endregion

    }
}
