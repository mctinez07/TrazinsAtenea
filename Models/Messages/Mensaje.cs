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
        public int Tipo { get; set; }

        //El idioma lo recuperamos desde DB
        [DataMember]
        public string Texto { get; set; }
    }
}
