using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Models.Processes.Methods
{
    [DataContract(Namespace ="http://WSTrazinsAtenea.com")]
    public class Esterilizacion : BaseModel
    {
        [DataMember]
        public int? EstId { get; set; }

        [DataMember]
        public string Descripcion { get; set; }

        [DataMember]
        public bool Control1 { get; set; }

        [DataMember]
        public bool Control2 { get; set; }

        [DataMember]
        public bool Control3 { get; set; }

        [DataMember]
        public bool Control4 { get; set; }
    }
}
