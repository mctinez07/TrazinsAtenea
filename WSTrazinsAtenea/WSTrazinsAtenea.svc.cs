using ManagerModels.Inventory;
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
    [ServiceBehavior(Namespace = "http://WSTrazinsAtenea.com")]
    public class WSTrazinsAtenea : IWSTrazinsAtenea
    {
        #region Caja

        public string Caja_Insert(Caja caja)
        {
            return CajaManager.Caja_Insert(caja);
        }

        public List<Caja> Caja_Select(Caja caja)
        {
            return CajaManager.Caja_Select(caja);
        }

        public string Caja_Update(Caja caja)
        {
            return CajaManager.Caja_Update(caja);
        }

        #endregion

        //public List<Usuario> Usuario_Select(Usuario usuario)
        //{
        //    throw new NotImplementedException();
        //}
    }
}
