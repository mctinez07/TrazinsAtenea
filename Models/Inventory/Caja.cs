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

        private string _cHIdPropietario;

        [DataMember]
        [StringLength(3)]
        public string CHIdPropietario
        {
            get { return _cHIdPropietario; }
            set
            {
                if (value == CHIdPropietario) return;
                _cHIdPropietario = value;
            }
        }

        private string _hosIdPropietario;

        [DataMember]
        [StringLength(3)]
        public string HosIdPropietario
        {
            get { return _hosIdPropietario; }
            set
            {
                if (value == HosIdPropietario) return;
                _hosIdPropietario = value;
            }
        }

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

        private string _especialidadDescripcion;

        [DataMember]
        [StringLength(50)]
        public string EspecialidadDescripcion
        {
            get { return _especialidadDescripcion; }
            set
            {
                if (value == EspecialidadDescripcion) return;
                _especialidadDescripcion = value;
            }
        }

        private bool _activa;

        [DataMember]
        public bool Activa
        {
            get { return _activa; }
            set
            {
                if (value == Activa) return;
                _activa = value;
            }
        }

        private string _codigoCaja;

        [DataMember]
        [StringLength(14)]
        public string CodigoCaja
        {
            get { return _codigoCaja; }
            set
            {
                if (value == CodigoCaja) return;
                _codigoCaja = value;
            }
        }

        private string _cajaId_CodigoCaja;

        [DataMember]
        [StringLength(14)]
        public string CajaId_CodigoCaja
        {
            get
            {
                return _cajaId_CodigoCaja;
            }
            set
            {
                if (value == CajaId_CodigoCaja) return;
                _cajaId_CodigoCaja = value;
            }
        }

        private int? _tipoCajaId;

        [DataMember]
        public int? TipoCajaId
        {
            get { return _tipoCajaId; }
            set
            {
                if (value == TipoCajaId) return;
                _tipoCajaId = value;
            }
        }

        private string _tipoCajaDescripcion;

        [DataMember]
        [StringLength(50)]
        public string TipoCajaDescripcion
        {
            get { return _tipoCajaDescripcion; }
            set
            {
                if (value == TipoCajaDescripcion) return;
                _tipoCajaDescripcion = value;
            }
        }

        private int? _embId;

        [DataMember]
        public int? EmbId
        {
            get { return _embId; }
            set
            {
                if (value == EmbId) return;
                _embId = value;
            }
        }

        private string _embalajeDescripcion;

        [DataMember]
        [StringLength(50)]
        public string EmbalajeDescripcion
        {
            get { return _embalajeDescripcion; }
            set
            {
                if (value == EmbalajeDescripcion) return;
                _embalajeDescripcion = value;
            }
        }

        private int? _centroCosteId;

        [DataMember]        
        public int? CentroCosteId
        {
            get { return _centroCosteId; }
            set
            {
                if (value == CentroCosteId) return;
                _centroCosteId = value;
            }
        }

        private string _centroCosteDescripcion;

        [DataMember]
        [StringLength(50)]
        public string CentroCosteDescripcion
        {
            get { return _centroCosteDescripcion; }
            set
            {
                if (value == CentroCosteDescripcion) return;
                _centroCosteDescripcion = value;
            }
        }

        private int? _tipoLavId1;

        [DataMember]
        public int? TipoLavId1
        {
            get { return _tipoLavId1; }
            set
            {
                if (value == TipoLavId1) return;
                _tipoLavId1 = value;
            }
        }

        private int? _tipoLavId2;

        [DataMember]
        public int? TipoLavId2
        {
            get { return _tipoLavId2; }
            set
            {
                if (value == TipoLavId2) return;
                _tipoLavId2 = value;
            }
        }

        private int? _tipoLavId3;

        [DataMember]
        public int? TipoLavId3
        {
            get { return _tipoLavId3; }
            set
            {
                if (value == TipoLavId3) return;
                _tipoLavId3 = value;
            }
        }

        private int? _estId1;

        [DataMember]
        public int? EstId1
        {
            get { return _estId1; }
            set
            {
                if (value == EstId1) return;
                _estId1 = value;
            }
        }

        private int? _estId2;

        [DataMember]
        public int? EstId2
        {
            get { return _estId2; }
            set
            {
                if (value == EstId2) return;
                _estId2 = value;
            }
        }

        private int? _estId3;

        [DataMember]
        public int? EstId3
        {
            get { return _estId3; }
            set
            {
                if (value == EstId3) return;
                _estId3 = value;
            }
        }

        private int? _contMantCiclos;

        [DataMember]
        public int? ContMantCiclos
        {
            get { return _contMantCiclos; }
            set
            {
                if (value == ContMantCiclos) return;
                _contMantCiclos = value;
            }
        }

        private int? _mantCiclos;

        [DataMember]
        public int? MantCiclos
        {
            get { return _mantCiclos; }
            set
            {
                if (value == MantCiclos) return;
                _mantCiclos = value;
            }
        }

        private bool _cajaMuestra;

        [DataMember]
        public bool CajaMuestra
        {
            get { return _cajaMuestra; }
            set
            {
                if (value == CajaMuestra) return;
                _cajaMuestra = value;
            }
        }

        private bool _cajaSuelto;

        [DataMember]
        public bool CajaSuelto
        {
            get { return _cajaSuelto; }
            set
            {
                if (value == CajaSuelto) return;
                _cajaSuelto = value;
            }
        }

        private decimal? _peso;

        [DataMember]        
        public decimal? Peso
        {
            get { return _peso; }
            set
            {
                if (value == Peso) return;
                _peso = value;
            }
        }

        private int? _ubiId;

        [DataMember]        
        public int? UbiId
        {
            get { return _ubiId; }
            set
            {
                if (value == UbiId) return;
                _ubiId = value;
            }
        }

        private string _ubicacion;

        [DataMember]
        [StringLength(255)]
        public string Ubicacion
        {
            get { return _ubicacion; }
            set
            {
                if (value == Ubicacion) return;
                _ubicacion = value;
            }
        }

        private string _observEmp;

        [DataMember]        
        [StringLength(512)]
        public string ObservEmp
        {
            get { return _observEmp; }
            set
            {
                if (value == ObservEmp) return;
                _observEmp = value;
            }
        }

        private string _observCic;

        [DataMember]
        [StringLength(512)]
        public string ObservCic
        {
            get { return _observCic; }
            set
            {
                if (value == ObservCic) return;
                _observCic = value;
            }
        }

        private string _observLav;

        [DataMember]
        [StringLength(512)]
        public string ObservLav
        {
            get { return _observLav; }
            set
            {
                if (value == ObservLav) return;
                _observLav = value;
            }
        }
    }
}
