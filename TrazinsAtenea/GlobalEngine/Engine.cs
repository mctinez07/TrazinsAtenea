using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrazinsAtenea.GlobalEngine
{
    public class Engine
    {
        public static void Prueba()
        {

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
