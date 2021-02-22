using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using Utils;

namespace Models
{
    [DataContract(Namespace = "http://WSTrazinsAtenea.com")]
    
    public class BaseModel : INotifyPropertyChanged
    {
        [DataMember]
        public string ChId { get; set; }

        [DataMember]
        public string HosId { get; set; }

        //Usuario que firma??
        [DataMember]
        public string AuditUsuario { get; set; }

        [DataMember]
        public string AuditMaquina { get; set; }

        [DataMember]
        public string AuditProceso { get; set; }

        

        #region INotifyPropertyChanged     

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged(string propertyName)
        { 
            if(PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }       

        #endregion
    }
}
