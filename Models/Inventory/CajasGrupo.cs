using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Models.Inventory
{
    [DataContract(Namespace = "http://WSTrazinsAtenea.com")]
    public class CajasGrupo
    {
        [DataMember]
        public int? GrupoId { get; set; }

        [DataMember]
        public string CajaId { get; set; }

        [DataMember]
        public string NomGrupo { get; set; }

        [DataMember]
        public string DesGrupo { get; set; }

        [DataMember]
        public string Observaciones { get; set; }

        [DataMember]
        public int? NumOrden { get; set; }

        //Número de articulos del grupo
        [DataMember]
        public int? Contador { get; set; }
    }
}
