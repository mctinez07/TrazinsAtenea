using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Models.Masters
{
    [DataContract(Namespace ="http://WSTrazinsAtenea.com")]
    public class TipoCaja : BaseModel
    {
        [DataMember]
        public int? Id { get; set; }

        [DataMember]
        public string Descripcion { get; set; }
        
    }
}
