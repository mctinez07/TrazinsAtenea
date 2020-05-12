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

        #region Mensajes

        [OperationContract]
        Mensaje Mensaje_Select(Mensaje mensaje); 

        #endregion

    }
}
