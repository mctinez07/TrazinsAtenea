using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
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

        [DataMember]
        public int? TipoCajaId { get; set; }

        [DataMember]
        public string TipoCaja_Descripcion { get; set; }

        [DataMember]
        public int? EmbId { get; set; }

        [DataMember]
        public string Embalaje_Descripcion { get; set; }

        [DataMember]
        public int? CentroCosteId { get; set; }

        [DataMember]
        public string CentroCoste_Descripcion { get; set; }

        [DataMember]
        public int? TipoLavId1 { get; set; }

        [DataMember]
        public int? TipoLavId2 { get; set; }

        [DataMember]
        public int? TipoLavId3 { get; set; }

        [DataMember]
        public int? EstId1 { get; set; }

        [DataMember]
        public int? EstId2 { get; set; }

        [DataMember]
        public int? EstId3 { get; set; }

        [DataMember]
        public int? MantCiclos { get; set; }

        [DataMember]
        public bool CajaMuestra { get; set; }

        [DataMember]
        public int? Precio { get; set; }

        [DataMember]
        //Pendiente verificar
        [StringLength(50)]
        public string ObservEmp { get; set; }

        [DataMember]
        public string ObservCic { get; set; }

        [DataMember]
        public string ObservLav { get; set; }
    }
}
