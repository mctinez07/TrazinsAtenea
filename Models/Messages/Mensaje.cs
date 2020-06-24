using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Models.Messages
{
    [DataContract(Namespace = "http://WSTrazinsAtenea.com")]
    public class Mensaje
    {
        [DataMember]
        public int Id { get; set; }

        [DataMember]
        public int TipoId { get; set; }

        //La traducción se selecciona desde DB
        [DataMember]
        public string Texto { get; set; }

        [DataMember]
        public string Titulo { get; set; }

        //El idioma lo recuperamos desde DB
        [DataMember]
        public string Idioma { get; set; }
    }
}
