using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Models.Masters
{
    [DataContract(Namespace = "http://WSTrazinsAtenea.com")]
    public class CentroCoste : BaseModel
    {
        private int? _id;

        [DataMember]        
        public int? Id
        {
            get { return _id; }
            set
            {
                if (value == Id) return;
                _id = value;
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

        private string _codigoCentro;

        [DataMember]
        [StringLength(5)]
        public string CodigoCentro
        {
            get { return _codigoCentro; }
            set
            {
                if (value == CodigoCentro) return;
                _codigoCentro = value;
            }
        }

    }
}
