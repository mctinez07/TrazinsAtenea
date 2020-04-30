using DevExpress.XtraEditors;
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
    public class Engine
    {
        //Metodo para obtener el texto a mostrar.
        public static string GetLanguageResource(string resource)
        {
            //El nombre del recurso tiene que coincidir con el del control
            //eliminando los tres primeros caracteres que indican el tipo de control.
            var resourceKey = resource.Substring(3);
            Assembly assembly = Assembly.Load("TrazinsAtenea");

            ResourceManager rm = new ResourceManager("TrazinsAtenea.GlobalResources.TrazinsAtenea", assembly);
            var e = rm.GetString(resourceKey);
            
            return e;
        }

        //Método para abrir los formularios en los paneles.
        public static void OpenForm(object Form, PanelControl panel)
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
    }
}
