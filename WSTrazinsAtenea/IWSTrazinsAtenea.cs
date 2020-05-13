using Models.Inventory;
using Models.Masters;
using Models.Messages;
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

        #region Mensajes

        [OperationContract]
        Mensaje Mensaje_Select(Mensaje mensaje); 

        #endregion

    }
}
