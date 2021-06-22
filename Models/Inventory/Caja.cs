using System;
using System.Collections.Generic;
using System.ComponentModel;
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
                _cajaId = value;
                InvokePropertyChanged(new PropertyChangedEventArgs("CajaId"));
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
                _cHIdPropietario = value;
                InvokePropertyChanged(new PropertyChangedEventArgs("CHIdPropietario"));
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
                _hosIdPropietario = value;
                InvokePropertyChanged(new PropertyChangedEventArgs("HosIdPropietario"));
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
                //if (value == Descripcion) return;
                //_descripcion = value;
                _descripcion = value;
                InvokePropertyChanged(new PropertyChangedEventArgs("Descripcion"));
                
            }
        }

        private int? _espId;

        [DataMember]
        public int? EspId
        {
            get { return _espId; }
            set
            {
                //if (value == EspId) return;
                //_espId = value;
                _espId = value;
                InvokePropertyChanged(new PropertyChangedEventArgs("EspId"));                
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
                _especialidadDescripcion = value;
                InvokePropertyChanged(new PropertyChangedEventArgs("EspecialidadDescripcion"));
            }
        }

        private bool _activa;

        [DataMember]
        public bool Activa
        {
            get { return _activa; }
            set
            {
                _activa = value;
                InvokePropertyChanged(new PropertyChangedEventArgs("Activa"));
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
                _codigoCaja = value;
                InvokePropertyChanged(new PropertyChangedEventArgs("CodigoCaja"));
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
                _cajaId_CodigoCaja = value;
                InvokePropertyChanged(new PropertyChangedEventArgs("CajaId_CodigoCaja"));
            }
        }

        private int? _tipoCajaId;

        [DataMember]
        public int? TipoCajaId
        {
            get { return _tipoCajaId; }
            set
            {
                _tipoCajaId = value;
                InvokePropertyChanged(new PropertyChangedEventArgs("TipoCajaId"));
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
                _tipoCajaDescripcion = value;
                InvokePropertyChanged(new PropertyChangedEventArgs("TipoCajaDescripcion"));
            }
        }

        private int? _embId;

        [DataMember]
        public int? EmbId
        {
            get { return _embId; }
            set
            {
                _embId = value;
                InvokePropertyChanged(new PropertyChangedEventArgs("EmbId"));
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
                _embalajeDescripcion = value;
                InvokePropertyChanged(new PropertyChangedEventArgs("EmbalajeDescripcion"));
            }
        }

        private int? _centroCosteId;

        [DataMember]        
        public int? CentroCosteId
        {
            get { return _centroCosteId; }
            set
            {
                _centroCosteId = value;
                InvokePropertyChanged(new PropertyChangedEventArgs("CentroCosteId"));
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
                _centroCosteDescripcion = value;
                InvokePropertyChanged(new PropertyChangedEventArgs("CentroCosteDescripcion"));
            }
        }

        private int? _tipoLavId1;

        [DataMember]
        public int? TipoLavId1
        {
            get { return _tipoLavId1; }
            set
            {
                _tipoLavId1 = value;
                InvokePropertyChanged(new PropertyChangedEventArgs("TipoLavId1"));
            }
        }

        private int? _tipoLavId2;

        [DataMember]
        public int? TipoLavId2
        {
            get { return _tipoLavId2; }
            set
            {
                _tipoLavId2 = value;
                InvokePropertyChanged(new PropertyChangedEventArgs("TipoLavId2"));
            }
        }

        private int? _tipoLavId3;

        [DataMember]
        public int? TipoLavId3
        {
            get { return _tipoLavId3; }
            set
            {
                _tipoLavId3 = value;
                InvokePropertyChanged(new PropertyChangedEventArgs("TipoLavId3"));
            }
        }

        private int? _estId1;

        [DataMember]
        public int? EstId1
        {
            get { return _estId1; }
            set
            {
                _estId1 = value;
                InvokePropertyChanged(new PropertyChangedEventArgs("EstId1"));
            }
        }

        private int? _estId2;

        [DataMember]
        public int? EstId2
        {
            get { return _estId2; }
            set
            {
                _estId2 = value;
                InvokePropertyChanged(new PropertyChangedEventArgs("EstId2"));
            }
        }

        private int? _estId3;

        [DataMember]
        public int? EstId3
        {
            get { return _estId3; }
            set
            {
                _estId3 = value;
                InvokePropertyChanged(new PropertyChangedEventArgs("EstId3"));
            }
        }

        private int? _contMantCiclos;

        [DataMember]
        public int? ContMantCiclos
        {
            get { return _contMantCiclos; }
            set
            {
                _contMantCiclos = value;
                InvokePropertyChanged(new PropertyChangedEventArgs("ContMantCiclos"));
            }
        }

        private int? _mantCiclos;

        [DataMember]
        public int? MantCiclos
        {
            get { return _mantCiclos; }
            set
            {
                _mantCiclos = value;
                InvokePropertyChanged(new PropertyChangedEventArgs("MantCiclos"));
            }
        }

        private bool _cajaMuestra;

        [DataMember]
        public bool CajaMuestra
        {
            get { return _cajaMuestra; }
            set
            {
                _cajaMuestra = value;
                InvokePropertyChanged(new PropertyChangedEventArgs("CajaMuestra"));
            }
        }

        private bool _cajaSuelto;

        [DataMember]
        public bool CajaSuelto
        {
            get { return _cajaSuelto; }
            set
            {
                _cajaSuelto = value;
                InvokePropertyChanged(new PropertyChangedEventArgs("CajaSuelto"));
            }
        }

        private decimal? _peso;

        [DataMember]        
        public decimal? Peso
        {
            get { return _peso; }
            set
            {
                _peso = value;
                InvokePropertyChanged(new PropertyChangedEventArgs("Peso"));
            }
        }

        private int? _ubiId;

        [DataMember]        
        public int? UbiId
        {
            get { return _ubiId; }
            set
            {
                _ubiId = value;
                InvokePropertyChanged(new PropertyChangedEventArgs("UbiId"));
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
                _ubicacion = value;
                InvokePropertyChanged(new PropertyChangedEventArgs("Ubicacion"));
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
                _observEmp = value;
                InvokePropertyChanged(new PropertyChangedEventArgs("ObservEmp"));
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
                _observCic = value;
                InvokePropertyChanged(new PropertyChangedEventArgs("ObservCic"));
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
                _observLav = value;
                InvokePropertyChanged(new PropertyChangedEventArgs("ObservLav"));
            }
        }        
    }
}
