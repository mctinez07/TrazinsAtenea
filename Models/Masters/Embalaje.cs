using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Models.Masters
{
    [DataContract(Namespace ="http://WSTrazinsAtenea.com")]
    public class Embalaje : BaseModel
    {
        [DataMember]
        public int? ConId { get; set; }

        [DataMember]
        public string Descripcion { get; set; }

        [DataMember]
        public int? CaducidadDias { get; set; }

        [DataMember]
        public int? CaducidadMeses { get; set; }
    }
}
