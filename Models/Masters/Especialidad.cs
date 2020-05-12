using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Models.Masters
{
    [DataContract(Namespace ="http://WSTrazinsAtenea.com")]
    public class Especialidad : BaseModel
    {
        [DataMember]
        public int? EspId { get; set; }

        [DataMember]
        public string Descripcion { get; set; }
    }
}
