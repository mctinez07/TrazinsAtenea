using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Collections;
using System.Reflection;
using System.ComponentModel;
using Models;

namespace TrazinsAtenea.GlobalEngine
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
            var target = binding.DataSource as Models.BaseModel;
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
            e.Value = Comun.Convertir(e.Value, _targetPropertyType);
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
                    if (target.Propiedades.TryGetValue(loProp.Name, out targetProp))
                    {
                        var selectedValue = loProp.GetValue(selected, null);
                        targetProp.SetValue(target, selectedValue, null);
                        //Para que mueva el valor que debe
                        if (loProp.Name == binding.BindingMemberInfo.BindingMember)
                            e.Value = selectedValue;
                    }

                }
            }


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

    public class ValidationResultEqualityComparer : EqualityComparer<System.ComponentModel.DataAnnotations.ValidationResult>
    {
        public override bool Equals(System.ComponentModel.DataAnnotations.ValidationResult x, System.ComponentModel.DataAnnotations.ValidationResult y)
        {
            return (x.ErrorMessage == y.ErrorMessage) && (x.MemberNames.SequenceEqual(y.MemberNames));
        }

        public override int GetHashCode(System.ComponentModel.DataAnnotations.ValidationResult obj)
        {
            //int hCode = obj.Control.GetHashCode() ^ obj.PropertyName.GetHashCode() ^ obj.BindingMemberInfo.BindingField.GetHashCode();
            //return hCode.GetHashCode();
            return 0;
        }
    }
}
