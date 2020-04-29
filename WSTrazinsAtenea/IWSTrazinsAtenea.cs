using Models.Inventory;
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
        List<Caja> Caja_Select(Caja caja);

        [OperationContract]
        string Caja_Insert(Caja caja);

        [OperationContract]
        string Caja_Update(Caja caja);

        #endregion

    }
}
