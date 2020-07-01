using DevExpress.XtraEditors;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.Grid;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Resources;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TrazinsAtenea.Forms.GlobalForms;

namespace TrazinsAtenea.GlobalEngine
{
    //Indica el tipo de operación para la gestión de los formularios.
    public enum EnumOperationType { New, Modify, Delete}

    public class Engine
    {
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

        public static void BindingControlProperty(Control ctrl, object model, string propiedad)
        {
            if (ctrl is ListControl)
                BindingControlProperty(ctrl, "SelectedItem", model, propiedad);
            else if (ctrl is CheckBox)
                BindingControlProperty(ctrl, "CheckState", model, propiedad);
            else if (ctrl is DateTimePicker)
                BindingControlProperty(ctrl, "Value", model, propiedad);
            else
                BindingControlProperty(ctrl, "Text", model, propiedad);
        }

        private static void BindingControlProperty(Control ctrl, string ctrlProperty, object model, string property)
        {
            //Validación del control Demomento no se usa
            //ctrl.Validated -= new EventHandler(ctrl_Validated);
            //ctrl.Validated += new EventHandler(ctrl_Validated);   

            var binding = new CustomBinding(ctrlProperty, model, property);
        }



    }
}
