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
using TrazinsAtenea.Bases;
using TrazinsAtenea.Forms.GlobalForms;
using Utils;

namespace TrazinsAtenea.GlobalEngine
{
    //Indica el tipo de operación para la gestión de los formularios.
    public enum EnumOperationType { New, Modify, Delete}    

    public class Engine
    {
        protected static IList<ValidationResult> Success = new List<ValidationResult>().AsReadOnly();
        public static DataBindingList Links { get; protected set; }

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
                MessageBox.Show("Error en ComboBoxFormat: " + ex.Message);
            }
            
        }

        public static CustomBinding BindingControlProperty(Control ctrl, object model, string propiedad)
        {
            if (ctrl is ListControl)
                return BindingControlProperty(ctrl, "SelectedItem", model, propiedad);
            else if (ctrl is CheckBox)
                return BindingControlProperty(ctrl, "CheckState", model, propiedad);
            else if (ctrl is DateTimePicker)
                return BindingControlProperty(ctrl, "Value", model, propiedad);
            else
                return BindingControlProperty(ctrl, "Text", model, propiedad);
        }

        private static CustomBinding BindingControlProperty(Control ctrl, string ctrlProperty, object model, string property, bool disableParsingAndFormatting = false)
        {
            //Validación del control
            ctrl.Validated -= new EventHandler(ctrl_Validated);
            ctrl.Validated += new EventHandler(ctrl_Validated);

            var binding = new CustomBinding(ctrlProperty, model, property);
            binding.DisableBaseParsingAndFormatting = disableParsingAndFormatting;

            Links = new DataBindingList();
            var existing = Links[ctrl, ctrlProperty, property];

            if (existing != null)
            {
                ctrl.DataBindings.Remove(existing);
                Links.Remove(existing);
            }

            if (model is BaseModel)
                SetUp(ctrl, ctrlProperty, (BaseModel)model, property);

            ctrl.DataBindings.Add(binding);
            Links.Add(binding);

            if (!disableParsingAndFormatting && ctrl is ListControl)
            {
                binding.ReadValue();
                binding.WriteValue();
            }
            else
            {
                //Los textedit de devexpress no cumplen esta condición
                if (binding.Control is TextBox)
                    binding.NullValue = "";
            }

            return binding;
        }

        private static void SetUp(Control ctrl, string ctrlControl, BaseModel model, string property)
        {
            var textBox = ctrl as TextBox;

            if (textBox != null && ctrlControl == "Text")
            {
                var prop = model.Properties[property];
                var attr = GetAttribute<StringLengthAttribute>(prop);
                if (attr != null)
                    textBox.MaxLength = attr.MaximumLength;
            }

            var numeric = ctrl as NumericUpDown;
            if (numeric != null)
            {
                var prop = model.Properties[property];

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

        // Abreviatura para obtener un atributo dado desde una propiedad.
        private static T GetAttribute<T>(System.Reflection.PropertyInfo prop)
           where T : System.Attribute
        {
            return prop.GetCustomAttributes(typeof(T), true).Cast<T>().FirstOrDefault();
        }

        static void ctrl_Validated(object sender, EventArgs e)
        {
            foreach (Binding item in ((Control)sender).DataBindings)
            {
                ValidateBinding(item);
            }
        }

        protected static IEnumerable<ValidationResult> ValidateBinding(Binding binding)
        {
            //No mostramos errores nada más abrir el formulario
            //if (boolMostradoPorPrimeraVez)
            //    return Success;

            //if (!ValidationEnabled)
            //    return Success;

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

                var modelPropertyValue = model.Properties[modelPropertyName].GetValue(model, null);

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

        protected static void SetError(Control control, string errorMessage)
        {
            MessageBox.Show(errorMessage);
            //errorProvider1.SetError(control, errorMessage);
        }

    }
}
