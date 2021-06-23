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
        //public static object _bindedModel;        

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

        //Revisar fto.
        #region Enlace de propiedades a Control          

        //Probar cuando es combo y enlazar SelectedItem??
        public static void BindingControlProperty<T>(Control ctrl,string property, T model)
        {
            if (ctrl is ListControl)
            {
                ctrl.DataBindings.Add("SelectedValue", model, property, true, DataSourceUpdateMode.OnPropertyChanged);                
            }                
            else if(ctrl is CheckBox || ctrl is CheckEdit)
                ctrl.DataBindings.Add("CheckState", model, property, true, DataSourceUpdateMode.OnPropertyChanged);
            else if (ctrl is DateTimePicker || ctrl is SpinEdit)
                ctrl.DataBindings.Add("Value", model, property, true, DataSourceUpdateMode.OnPropertyChanged);
            else if (ctrl is ToggleSwitch)
                ctrl.DataBindings.Add("IsOn", model, property, true, DataSourceUpdateMode.OnPropertyChanged);
            else
            {
                ctrl.DataBindings.Add("Text", model, property, false, DataSourceUpdateMode.OnPropertyChanged);

                //Asignamos el tamaño según las propiedades del modelo.
                if (ctrl is TextEdit || ctrl is TextBox)
                {
                    var textbox = ctrl as TextBox;
                    var textEdit = ctrl as TextEdit;
                    var prop = model.GetType().GetProperty(property);
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

        public static void GetAttributeSettings<T>(Control ctrl, string property, T model)
        {
            if (ctrl is TextEdit || ctrl is TextBox)
            {
                var textbox = ctrl as TextBox;
                var textEdit = ctrl as TextEdit;
                var prop = model.GetType().GetProperty(property);
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

        // Abreviatura para obtener un atributo dado desde una propiedad.
        private static T GetAttribute<T>(System.Reflection.PropertyInfo prop)
           where T : System.Attribute
        {
            return prop.GetCustomAttributes(typeof(T), true).Cast<T>().FirstOrDefault();
        }
        #endregion
    }

}
