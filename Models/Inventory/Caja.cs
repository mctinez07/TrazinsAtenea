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
        private string _cajaId;

        [DataMember]
        [StringLength(14)]
        public string CajaId
        {
            get { return _cajaId; }
            set
            {
                if (value == CajaId) return;
                _cajaId = value;
            }
        }

        [DataMember]
        public string CHIdPropietario { get; set; }

        [DataMember]
        public string HosIdPropietario { get; set; }

        private string _descripcion;
        [DataMember]
        [StringLength(50)]
        public string Descripcion
        {
            get { return _descripcion; }
            set
            {
                if (value == Descripcion) return;
                _descripcion = value;
            }
        }

        private int? _espId;
        [DataMember]
        public int? EspId
        {
            get { return _espId; }
            set
            {
                if (value == EspId) return;
                _espId = value;
            }
        }

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

        private string _observEmp;
        [DataMember]        
        [StringLength(50)]
        public string ObservEmp
        {
            get { return _observEmp; }
            set
            {
                if (value == ObservEmp) return;
                _observEmp = value;
            }
        }
        [DataMember]
        public string ObservCic { get; set; }

        [DataMember]
        public string ObservLav { get; set; }
    }
}
