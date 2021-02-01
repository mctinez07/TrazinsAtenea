﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Models;

namespace TrazinsAtenea.Bases
{
    public class CustomBinding : Binding
    {
        public CustomBinding(string propiedadControl, object modelo, string propiedadModelo)
            : base(propiedadControl, modelo, propiedadModelo, true)
        {
            DataSourceNullValue = null;
            DataSourceUpdateMode = DataSourceUpdateMode.OnPropertyChanged;
            FormattingEnabled = true;

            //Esto es para evitar que cuando una propiedad cambie, el framework intente
            //actualizar las propiedades de todos los controles enlazados y no sólo del que cambia
            if (modelo is INotifyPropertyChanged)
                (modelo as INotifyPropertyChanged).PropertyChanged += new PropertyChangedEventHandler(OnPropertyChanged);
        }

        public bool DisableBaseParsingAndFormatting { get; set; }

        protected override void OnParse(ConvertEventArgs e)
        {
            base.OnParse(e);

            if (!DisableBaseParsingAndFormatting)
            {
                if (this.Control is ListControl && PropertyName == "SelectedItem")
                    SelectedItemParse(e);
                else
                    DefaultParse(e);
            }
        }

        private bool? _isListControl;
        protected override void OnFormat(ConvertEventArgs e)
        {
            if (!DisableBaseParsingAndFormatting)
            {
                if (_isListControl == null)
                {
                    _isListControl = this.Control is ListControl;
                }

                if ((_isListControl == true) && PropertyName == "SelectedItem")
                    SelectedItemFormat(e);
            }
            base.OnFormat(e);
        }

        void SelectedItemFormat(ConvertEventArgs e)
        {
            var binding = this;
            //Es posible que tenga que añadir las interfaces del modelo base de trazins
            var target = binding.DataSource as BaseModel;
            var combo = binding.Control as ListControl;

            var primaryKeys = GetPrimaryKeysFromDataSource(combo.DataSource);
            var targetProp = primaryKeys.Values.FirstOrDefault();
            if (targetProp == null)
                return;

            //Hay que seleccionar el elemento del combo según el valor especificado en e.Value            
            foreach (object item in (combo.DataSource as IList))
            {
                var propValue = targetProp.GetValue(item, null);
                if (object.Equals(propValue, e.Value))
                {
                    e.Value = item;
                    //Tambien está deshabilitado en el origen
                    //if (combo is ComboBox)
                    //    (combo as ComboBox).SelectedItem = item;
                    //else if (combo is ListBox)
                    //{
                    //    var list = (ListBox)combo;
                    //    list.SelectedItem = item;
                    //    //(combo as ListBox).SetSelected((combo as ListBox).SelectedIndex, true);
                    //}
                    return;
                }
            }
        }

        public T GetSelectedValue<T>()
        {
            return (T)((ListControl)Control).SelectedValue;
        }

        private Dictionary<string, PropertyInfo> GetPrimaryKeysFromDataSource(object dataSource)
        {
            var lista = (dataSource as IList);
            if (lista == null)
                return new Dictionary<string, PropertyInfo>();

            if (lista.Count == 0)
                return new Dictionary<string, PropertyInfo>();

            BaseModel first = lista[0] as BaseModel;
            if (first == null)
                return new Dictionary<string, PropertyInfo>();

            return first.PrimaryKeys;
            
        }

        Type _targetPropertyType;

        void DefaultParse(ConvertEventArgs e)
        {
            if (_targetPropertyType == null)
                _targetPropertyType = BindingManagerBase.GetItemProperties().Find(BindingMemberInfo.BindingField, true).PropertyType;
            e.Value = ConvertValues(e.Value, _targetPropertyType);
        }

        public static object ConvertValues(object loValue, Type loDestinationType)
        {
            var loConvertedValue = loValue;
            var lbAsignableDirect = (loValue != null && loDestinationType.IsAssignableFrom(loValue.GetType()));

            //Convertimos la cadena vacía a null
            if ("".Equals(loValue) || loValue == DBNull.Value)
                loConvertedValue = null;

            if (!lbAsignableDirect)
            {
                //Estas variables se emplean para agilizar la evaluación de las condiciones
                ///bool lbDestinoEsNullable = (loPropType.IsGenericType && loPropType.GetGenericTypeDefinition() == typeof(Nullable<>));
                bool lbDestinoEsNullable = !loDestinationType.IsValueType || (Nullable.GetUnderlyingType(loDestinationType) != null);
                bool lbDestinoEsString = loDestinationType == typeof(string);
                bool lbHayQueConvertir = (loValue != null && !loDestinationType.IsAssignableFrom(loValue.GetType()));

                if (lbDestinoEsNullable && loConvertedValue == null)
                    return loConvertedValue;

                if (lbDestinoEsNullable || lbDestinoEsString)
                {
                    if (lbHayQueConvertir)
                    {
                        if (lbDestinoEsNullable)
                            loConvertedValue = ValueChangeType(loConvertedValue, loDestinationType.GetGenericArguments()[0]);
                        else
                            loConvertedValue = ValueChangeType(loConvertedValue, loDestinationType);
                    }

                }
                else
                    if (lbHayQueConvertir)
                    loConvertedValue = ValueChangeType(loConvertedValue, loDestinationType);
                else if (loValue == null)
                {
                    loConvertedValue = Activator.CreateInstance(loDestinationType);
                }
            }

            return loConvertedValue;
        }


        private static object ValueChangeType(object loValue, Type loDestinationType)
        {
            if (loDestinationType.IsEnum)
                return Enum.Parse(loDestinationType, loValue.ToString(), true);
            else
                return System.Convert.ChangeType(loValue, loDestinationType);
        }

        void SelectedItemParse(ConvertEventArgs e)
        {
            var binding = this;
            var selected = e.Value as BaseModel;
            var target = binding.DataSource as BaseModel;
            if (selected == null)
            {
                e.Value = null;
            }
            else
            {
                if (selected.PrimaryKeys.Count == 1)
                {
                    var pkProperty = selected.PrimaryKeys.Values.First();
                    var selectedValue = pkProperty.GetValue(selected, null);
                    e.Value = selectedValue;
                    return;
                }
                //Hay que mover las propiedades primary key del elemento seleccionado
                //al objeto de destino.
                foreach (var loProp in selected.PrimaryKeys.Values)
                {
                    System.Reflection.PropertyInfo targetProp = null;
                    if (target.Properties.TryGetValue(loProp.Name, out targetProp))
                    {
                        var selectedValue = loProp.GetValue(selected, null);
                        targetProp.SetValue(target, selectedValue, null);
                        //Para que mueva el valor que debe
                        if (loProp.Name == binding.BindingMemberInfo.BindingMember)
                            e.Value = selectedValue;
                    }

                }
            }

            //Comentado en el origen.
            //target.GetType().GetProperty(binding.BindingMemberInfo.BindingMember).SetValue(target, e.Value, null);
        }

        private void OnPropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            this.ControlUpdateMode = ControlUpdateMode.Never;
            if (e.PropertyName == this.BindingMemberInfo.BindingField)
            {
                this.ReadValue();
            }
        }


    }

    public class DataBindingList : List<Binding>
    {
        public DataBindingList() : base()
        {
        }

        public Binding this[Control control, string controlPropertyName, string dataSourcePropertyName]
        {
            get
            {
                return this.FirstOrDefault((b) =>
                    (b.Control == control) && (b.PropertyName == controlPropertyName) && (b.BindingMemberInfo.BindingField == dataSourcePropertyName));
            }
        }
    }
}
