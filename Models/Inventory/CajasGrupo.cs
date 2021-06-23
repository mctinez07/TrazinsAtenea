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
    public class CajasGrupo : BaseModel
    {
        private int? _grupoId;

        [DataMember]
        public int? GrupoId
        {
            get { return _grupoId; }
            set
            {
                _grupoId = value;
                InvokePropertyChanged(new PropertyChangedEventArgs("GrupoId"));
            }
        }

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

        private string _nomGrupo;

        [DataMember]
        [StringLength(50)]
        public string NomGrupo
        {
            get { return _nomGrupo; }
            set
            {
                _nomGrupo = value;
                InvokePropertyChanged(new PropertyChangedEventArgs("NomGrupo"));
            }
        }

        private string _desGrupo;
        [DataMember]
        [StringLength(50)]
        public string DesGrupo
        {
            get { return _desGrupo; }
            set
            {
                _desGrupo = value;
                InvokePropertyChanged(new PropertyChangedEventArgs("DesGrupo"));
            }
        }

        private string _observaciones;

        [DataMember]
        [StringLength(100)]
        public string Observaciones
        {
            get { return _observaciones; }
            set
            {
                _observaciones = value;
                InvokePropertyChanged(new PropertyChangedEventArgs("Observaciones"));
            }
        }

        public int? _numOrden;

        [DataMember]
        public int? NumOrden
        {
            get { return _numOrden; }
            set
            {
                _numOrden = value;
                InvokePropertyChanged(new PropertyChangedEventArgs("NumOrden"));
            }
        }

        private int? _contador;

        //Número de articulos del grupo
        [DataMember]
        public int? Contador
        {
            get { return _contador; }
            set
            {
                _contador = value;
                InvokePropertyChanged(new PropertyChangedEventArgs("Contador"));
            }
        }
    }
}
