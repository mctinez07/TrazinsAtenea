using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    [DataContract(Namespace = "http://WSTrazinsAtenea.com")]
    public class BaseModel
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
    }
}
