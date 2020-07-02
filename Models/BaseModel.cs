using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using Utils;

namespace Models
{
    [DataContract(Namespace = "http://WSTrazinsAtenea.com")]
    //Mirar que herede com en la palicación android??Pendiente
    public class BaseModel
    {
        [DataMember]
        public string ChId { get; set; }

        [DataMember]
        public string HosId { get; set; }

        //Usuario que firma??
        [DataMember]
        public string AuditUsuario { get; set; }

        [DataMember]
        public string AuditMaquina { get; set; }

        [DataMember]
        public string AuditProceso { get; set; }

        Dictionary<string, PropertyInfo> _primaryKeys;

        Dictionary<string, PropertyInfo> _propiedades;

        //[XmlIgnore()]
        //public Dictionary<string, PropertyInfo> Propiedades
        //{
        //    get
        //    {
        //        //if (_propiedades == null)
        //        //{
        //        //    _propiedades = new Dictionary<string, PropertyInfo>();
        //        //    _mappings = new Dictionary<string, MappingAttribute>();
        //        //    _primaryKeys = new Dictionary<string, PropertyInfo>();
        //        //    var props = this.GetType().GetProperties();
        //        //    foreach (var prop in props)
        //        //    {
        //        //        _propiedades.Add(prop.Name, prop);
        //        //        var attrs = prop.GetCustomAttributes(typeof(MappingAttribute), true).Cast<MappingAttribute>();
        //        //        foreach (var attr in attrs)
        //        //        {
        //        //            if (!attr.Exclude)
        //        //                _mappings.Add(prop.Name, attr);
        //        //        }


        //        //        var key = prop.GetCustomAttributes(typeof(KeyAttribute), true).Cast<KeyAttribute>().FirstOrDefault();
        //        //        if (key != null)
        //        //        {
        //        //            _primaryKeys.Add(prop.Name, prop);
        //        //        }

        //        //    }
        //        }
        //        return _propiedades;
        //    }
        //}

        //[XmlIgnore()]
        //public Dictionary<string, PropertyInfo> PrimaryKeys
        //{
        //    get
        //    {
        //        if (_propiedades == null)
        //        {
        //            var dummy = Propiedades;
        //        }
        //        return _primaryKeys;
        //    }
        //}

        //[XmlIgnore()]
        //public PrimaryKeysValueList PrimaryKeysValues
        //{
        //    get
        //    {
        //        var result = new PrimaryKeysValueList();

        //        foreach (var item in PrimaryKeys)
        //        {
        //            result.Add(item.Key, item.Value.GetValue(this, null));
        //        }
        //        return result;
        //    }
        //}
    }
}
