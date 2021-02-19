using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Utils
{
    //Clase para el mapeo de parametros a propiedades
    public class MappingAttribute : System.Attribute
    {
        public bool Exclude { get; set; }
        public string ParameterName { get; set; }
        public SqlDbType? DbType { get; set; }
        public ParameterDirection? Direction { get; set; }
        public int? Size { get; set; }

        private byte? _precision;
        public byte Precision { get { return _precision.Value; } set { _precision = value; } }
        public bool PrecisionHasValue { get { return _precision.HasValue; } }

        private byte? _scale;
        public byte Scale { get { return _scale.Value; } set { _scale = value; } }
        public bool ScaleHasValue { get { return _scale.HasValue; } }

        private string _sourceColumn;
        public string SourceColumn
        {
            get
            {
                return string.IsNullOrEmpty(_sourceColumn) ? ParameterName : _sourceColumn;
            }
            set
            {
                _sourceColumn = value;
            }
        }

        public PropertyInfo PropertyInfo { get; set; }
    }
}
