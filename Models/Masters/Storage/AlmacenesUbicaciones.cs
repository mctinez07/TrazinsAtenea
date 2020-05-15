using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Models.Masters.Storage
{
    [DataContract(Namespace ="http://WSTrazinsAtenea.com")]
    public class AlmacenesUbicaciones : Almacen
    {
        [DataMember]
        public int? UbiId { get; set; }

        [DataMember]
        public int? Bloque { get; set; }

        [DataMember]
        public int? Estante { get; set; }

        [DataMember]
        public int? Posicion { get; set; }
    }
}
