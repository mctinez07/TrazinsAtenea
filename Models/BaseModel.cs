using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using Utils;

namespace Models
{
    [DataContract(Namespace = "http://WSTrazinsAtenea.com")]
    //Mirar que herede com en la palicación android??Pendiente
    public class BaseModel : INotifyPropertyChanged
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

        Dictionary<string, PropertyInfo> _properties;

        [XmlIgnore()]
        public Dictionary<string, PropertyInfo> Properties
        {
            get
            {
                if (_properties == null)
                {
                    _properties = new Dictionary<string, PropertyInfo>();
                    _mappings = new Dictionary<string, MappingAttribute>();
                    _primaryKeys = new Dictionary<string, PropertyInfo>();
                    var props = this.GetType().GetProperties();
                    foreach (var prop in props)
                    {
                        _properties.Add(prop.Name, prop);
                        var attrs = prop.GetCustomAttributes(typeof(MappingAttribute), true).Cast<MappingAttribute>();
                        foreach (var attr in attrs)
                        {
                            if (!attr.Exclude)
                                _mappings.Add(prop.Name, attr);
                        }


                        var key = prop.GetCustomAttributes(typeof(KeyAttribute), true).Cast<KeyAttribute>().FirstOrDefault();
                        if (key != null)
                        {
                            _primaryKeys.Add(prop.Name, prop);
                        }

                    }
                }
                return _properties;
            }
        }
        Dictionary<string, MappingAttribute> _mappings;        

        [XmlIgnore()]
        public Dictionary<string, PropertyInfo> PrimaryKeys
        {
            get
            {
                if (_properties == null)
                {
                    var dummy = Properties;
                }
                return _primaryKeys;
            }
        }

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


        Dictionary<string, PropertyInfo> _propiedades;

        [XmlIgnore()]
        public Dictionary<string, PropertyInfo> Propiedades
        {
            get
            {
                if (_propiedades == null)
                {
                    _propiedades = new Dictionary<string, PropertyInfo>();
                    _mappings = new Dictionary<string, MappingAttribute>();
                    _primaryKeys = new Dictionary<string, PropertyInfo>();
                    var props = this.GetType().GetProperties();
                    foreach (var prop in props)
                    {
                        _propiedades.Add(prop.Name, prop);
                        var attrs = prop.GetCustomAttributes(typeof(MappingAttribute), true).Cast<MappingAttribute>();
                        foreach (var attr in attrs)
                        {
                            if (!attr.Exclude)
                                _mappings.Add(prop.Name, attr);
                        }


                        var key = prop.GetCustomAttributes(typeof(KeyAttribute), true).Cast<KeyAttribute>().FirstOrDefault();
                        if (key != null)
                        {
                            _primaryKeys.Add(prop.Name, prop);
                        }

                    }
                }
                return _propiedades;
            }
        }

        public virtual IEnumerable<ValidationResult> ValidateProperty(string propertyName, object value)
        {
            var context = new ValidationContext(this, serviceProvider: null, items: null);
            context.MemberName = propertyName;

            var results = new List<ValidationResult>();
            var isValid = Validator.TryValidateProperty(value, context, results);

            return results;
        }

        #region INotifyPropertyChanged + Changing

        public event PropertyChangingEventHandler PropertyChanging;

        //protected virtual bool OnPropertyChanging<T>(string propertyName, T originalValue, T newValue)
        //{
        //    //if (!Notificaciones)
        //    //    return true;

        //    var handler = this.PropertyChanging;
        //    if (handler != null)
        //    {
        //        var args = new PropertyChangingCancelEventArgs<T>(propertyName, originalValue, newValue);
        //        handler(this, args);
        //        return !args.Cancel;
        //    }
        //    return true;
        //}

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged(string propertyName)
        { 
            if(PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        //protected virtual void OnPropertyChanged<T>(string propertyName, T previousValue, T currentValue)
        //{
        //    //if (!Notificaciones)
        //    //    return;

        //    //if (Estado == EnumEstadoModelo.SinCambios)
        //    //    Estado = EnumEstadoModelo.Modificado;

        //    var handler = this.PropertyChanged;
        //    if (handler != null)
        //        handler(this, new PropertyChangedEventArgs<T>(propertyName, previousValue, currentValue));
        //}

        //protected bool Establecer<T>(ref T field, T value, string propertyName)
        //{
        //    if (EqualityComparer<T>.Default.Equals(field, value)) return false;

        //    if (this.OnPropertyChanging<T>(propertyName, field, value))
        //    {
        //        var previousValue = field;
        //        field = value;
        //        OnPropertyChanged<T>(propertyName, previousValue, field);
        //        return true;
        //    }

        //    return false;
        //}

        private static object MTDCrearInstanciaTipo(Type t)
        {
            if (t == typeof(string))
                return null;
            else
                return Activator.CreateInstance(t);
        }

        #endregion
    }
}
