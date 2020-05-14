using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Models.Masters.Storage
{
    [DataContract(Namespace ="http://WSTrazinsAtenea.com")]
    public class Almacen : BaseModel
    {
        [DataMember]
        public int? AlmId { get; set; }

        [DataMember]
        public string Codigo { get; set; }

        [DataMember]
        public string Descripcion { get; set; }
    }
}
