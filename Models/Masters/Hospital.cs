using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Models.Masters
{
    [DataContract(Namespace ="http://WSTrazinsAtenea.com")]
    public class Hospital : BaseModel
    { 
        [DataMember]
        public string Siglas { get; set; }

        [DataMember]
        public string NomHospital { get; set; }

        [DataMember]
        public int? EmbIdCaj { get; set; }

        [DataMember]
        public int? EmbIdArt { get; set; }

        [DataMember]
        public int? EmbIdSC { get; set; }

        [DataMember]
        public bool ConFirma { get; set; }

        [DataMember]
        public bool IntSelene { get; set; }

        [DataMember]
        public bool IntOrion { get; set; }
    }
}
