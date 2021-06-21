using DevExpress.XtraEditors;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.Grid;
using Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Reflection;
using System.Resources;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TrazinsAtenea.Forms.GlobalForms;
using Utils;

namespace TrazinsAtenea.GlobalEngine
{
    //Indica el tipo de operación para la gestión de los formularios.
    public enum EnumOperationType { New, Modify, Delete}    

    public class Engine
    { 
        //Modelo a enlazar para los controles;
        public static object _bindedModel;        

        //Método para obtener el texto a mostrar.
        public static string GetLanguageResource(string resource)
        {
            try
            {
                //El nombre del recurso tiene que coincidir con el del control
                //eliminando los tres primeros caracteres que indican el tipo de control.
                var resourceKey = resource.Substring(3);
                Assembly assembly = Assembly.Load("TrazinsAtenea");

                ResourceManager rm = new ResourceManager("TrazinsAtenea.GlobalResources.TrazinsAtenea", assembly);
                var result = rm.GetString(resourceKey);

                return result;
            }
            catch (Exception ex)
            {                
                MessageBox.Show("Error en GetLanguageResource: " + ex.Message);
                return string.Empty;
            }
        }

        #region Formularios

        //Método para abrir los formularios en los paneles.
        public static void OpenForm(object Form, PanelControl panel)
        {
            try
            {
                Form frm = Form as Form;

                if (panel.Controls.Count > 0)
                {
                    panel.Controls.RemoveAt(0);
                }

                frm.TopLevel = false;
                frm.Dock = DockStyle.Fill;

                panel.Controls.Add(frm);
                panel.Tag = frm;

                frm.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error en OpenForm: " + ex.Message);
            }

        }

        //Método para mostrar el formulario de mensajes para el usuario.
        public static DialogResult OpenMessageForm(int messageId)
        {
            MessageForm messageForm = new MessageForm(messageId);
            messageForm.ShowDialog();
            return messageForm.DialogResult;
        }

        //Modificar funcionamiento!!!
        //Método para mostrar el formulario de mensajes para el usuario con información añadida
        public static DialogResult OpenMessageForm(int messageId, params object[] args)
        {
            MessageForm messageForm = new MessageForm(messageId);
            var b = messageForm.lblMessage.Text;
            messageForm.lblMessage.Text = string.Format(messageForm.lblMessage.Text, args);
            var a = messageForm.lblMessage.Text;
            messageForm.ShowDialog();
            return messageForm.DialogResult;
        }

        #endregion

        //Método para cargar y dar formato a los comboboxes.
        public static void ComboBoxFormat
            (System.Windows.Forms.ComboBox combo, string displayMember, string valueMember, object dataSource)
        {
            try
            {
                if (dataSource != null)
                {
                    combo.DataSource = dataSource;
                    combo.DisplayMember = displayMember;
                    combo.ValueMember = valueMember;
                    combo.SelectedIndex = -1;
                    combo.Select(0, 0);
                }
            }
            catch (Exception ex)
            {
                ErrorMessage.ShowErrorMessage(MethodBase.GetCurrentMethod().Name, ex.Message);
            }
            
        }

        #region Enlace de propiedades a Control   
        public static DataBindingList Enlaces { get; protected set; }
        //Probar cuando es combo y enlazar SelectedItem??
        public static void BindingControlProperty(Control ctrl,string property)
        {
            if (ctrl is ListControl)
                ctrl.DataBindings.Add("SelectedValue", _bindedModel, property, true, DataSourceUpdateMode.OnPropertyChanged);
            else if(ctrl is CheckBox || ctrl is CheckEdit)
                ctrl.DataBindings.Add("CheckState", _bindedModel, property, true, DataSourceUpdateMode.OnPropertyChanged);
            else if (ctrl is DateTimePicker || ctrl is SpinEdit)
                ctrl.DataBindings.Add("Value", _bindedModel, property, true, DataSourceUpdateMode.OnPropertyChanged);
            else if (ctrl is ToggleSwitch)
                ctrl.DataBindings.Add("IsOn", _bindedModel, property, true, DataSourceUpdateMode.OnPropertyChanged);
            else
            {
                ctrl.DataBindings.Add("Text", _bindedModel, property, false, DataSourceUpdateMode.OnPropertyChanged);

                //Asignamos el tamaño según las propiedades del modelo.
                if (ctrl is TextEdit || ctrl is TextBox)
                {
                    var textbox = ctrl as TextBox;
                    var textEdit = ctrl as TextEdit;
                    var prop = _bindedModel.GetType().GetProperty(property);
                    var attr = GetAttribute<StringLengthAttribute>(prop);
                    if (attr != null)
                    {
                        if (ctrl is TextEdit)
                        {
                            textEdit.Properties.MaxLength = attr.MaximumLength;
                        }
                        else
                        {
                            textbox.MaxLength = attr.MaximumLength;
                        }
                    }

                }
            }
            
        }       

        // Abreviatura para obtener un atributo dado desde una propiedad.
        private static T GetAttribute<T>(System.Reflection.PropertyInfo prop)
           where T : System.Attribute
        {
            return prop.GetCustomAttributes(typeof(T), true).Cast<T>().FirstOrDefault();
        }

        public virtual CustomBinding Enlazar(Control ctrl, string propiedadControl, object modelo, string propiedadModelo, bool disableParsingAndFormatting = false)
        {
            ctrl.Validated -= new EventHandler(ctrl_Validated);
            ctrl.Validated += new EventHandler(ctrl_Validated);

            var binding = new CustomBinding(propiedadControl, modelo, propiedadModelo);
            binding.DisableBaseParsingAndFormatting = disableParsingAndFormatting;

            var existing = Enlaces[ctrl, propiedadControl, propiedadModelo];

            if (existing != null)
            {
                ctrl.DataBindings.Remove(existing);
                Enlaces.Remove(existing);
            }

            if (modelo is BaseModel)
                Configurar(ctrl, propiedadControl, (BaseModel)modelo, propiedadModelo);

            ctrl.DataBindings.Add(binding);
            Enlaces.Add(binding);

            if (!disableParsingAndFormatting && ctrl is ListControl)
            {
                binding.ReadValue();
                binding.WriteValue();
            }
            else
            {
                if (binding.Control is TextBox || binding.Control is TextEdit)
                    binding.NullValue = "";
            }

            return binding;

        }

        private void Configurar(Control ctrl, string propiedadControl, BaseModel modelo, string propiedadModelo)
        {
            var textBox = ctrl as TextBox;

            if (textBox != null && propiedadControl == "Text")
            {
                var prop = modelo.Propiedades[propiedadModelo];
                var attr = GetAttribute<StringLengthAttribute>(prop);
                if (attr != null)
                    textBox.MaxLength = attr.MaximumLength;
            }

            var textEdit = ctrl as TextEdit;
            if (textEdit != null && propiedadControl == "Text")
            {
                var prop = modelo.Propiedades[propiedadModelo];
                var attr = GetAttribute<StringLengthAttribute>(prop);
                if (attr != null)
                    textEdit.Properties.MaxLength = attr.MaximumLength;
            }

            var numeric = ctrl as NumericUpDown;
            if (numeric != null)
            {
                var prop = modelo.Propiedades[propiedadModelo];

                var mapping = GetAttribute<MappingAttribute>(prop);
                if (mapping != null)
                {

                    if (mapping.PrecisionHasValue)
                    {
                        var precision = mapping.Precision;
                        var scale = mapping.ScaleHasValue ? mapping.Scale : 0;

                        numeric.DecimalPlaces = scale;
                    }
                }

                var attr = GetAttribute<RangeAttribute>(prop);
                if (attr != null)
                {
                    numeric.Minimum = Convert.ToDecimal(attr.Minimum);
                    numeric.Maximum = Convert.ToDecimal(attr.Maximum);
                }
            }

        }

        void ctrl_Validated(object sender, EventArgs e)
        {
            foreach (Binding item in ((Control)sender).DataBindings)
            {
                ValidateBinding(item);
            }
        }

        protected IEnumerable<ValidationResult> ValidateBinding(Binding binding)
        {
            //No mostramos errores nada más abrir el formulario
            if (boolMostradoPorPrimeraVez)
                return Success;

            if (!ValidationEnabled)
                return Success;

            var control = binding.Control;
            var model = binding.DataSource as BaseModel;
            if (model != null)
            {
                //Antes de validar propiamente, forzamos al control a que escriba su valor
                //en la fuente de datos
                if (binding.Control is ListControl)
                {
                    binding.WriteValue();
                }

                var modelPropertyName = binding.BindingMemberInfo.BindingField;

                var modelPropertyValue = model.Propiedades[modelPropertyName].GetValue(model, null);

                var result = model.ValidateProperty(binding.BindingMemberInfo.BindingField, modelPropertyValue);
                if (result.Count() > 0)
                    SetError(control, result.First().ErrorMessage);
                else
                    SetError(control, "");
                return result;
            }
            else
                return Success;
        }

        protected bool boolMostradoPorPrimeraVez = true;
        public bool ValidationEnabled { get; set; }

        protected void SetError(Control control, string errorMessage)
        {
            //errorProvider1.SetError(control, errorMessage);
            MessageBox.Show(errorMessage);
        }

        #region Validacion

        protected static IList<ValidationResult> Success = new List<ValidationResult>().AsReadOnly();

        public virtual IEnumerable<ValidationResult> Validar()
        {
            var result = new List<ValidationResult>();
            foreach (var enlace in Enlaces)
            {
                result.AddRange(ValidateBinding(enlace));
            }
            return result;
        }

        //protected void MTDMostrarErrores(IEnumerable<ValidationResult> errores)
        //{
        //    if (errores.Count() > 0)
        //        //Mensajes.Mostrar(new Mensaje() { Texto = errores.GetMessage(), Tipo = TipoMensaje.Aviso });
                
        //}

        #endregion

        #endregion
        
    }
    
}
