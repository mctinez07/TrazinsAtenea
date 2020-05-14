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

namespace TrazinsAtenea.GlobalEngine
{
    //Indica el tipo de operación para la gestión de los formularios.
    public enum EnumOperationType { Nuevo, Modificar, Eliminar}

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

        public static void ComboBoxFormat
            (System.Windows.Forms.ComboBox combo, string displayMember, string valueMember, object dataSource)
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
    }
}
