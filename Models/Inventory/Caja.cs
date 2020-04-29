using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Models.Inventory
{
    [DataContract(Namespace = "http://WSTrazinsAtenea.com")]
    public class Caja : BaseModel
    {
        [DataMember]
        public string CajaId { get; set; }

        [DataMember]
        public string CHIdPropietario { get; set; }

        [DataMember]
        public string HosIdPropietario { get; set; }

        [DataMember]
        public string Descripcion { get; set; }

        [DataMember]
        public int? EspId { get; set; }

        [DataMember]
        public string Especialidad_Descripcion { get; set; }

        [DataMember]
        public bool Activa { get; set; }

        [DataMember]
        public string CodigoCaja { get; set; }

        [DataMember]
        public string CajaId_CodigoCaja { get; set; }
    }
}
