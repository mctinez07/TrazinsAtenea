using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using TrazinsAtenea.Controls;

namespace TrazinsAtenea
{
    public partial class MainForm : DevExpress.XtraEditors.XtraForm
    {
        public MainForm()
        {
            InitializeComponent();            

            dlmLoginInfo.SetValues("María García", "TAP");

            lblMainTimer.Text = DateTime.Now.ToString();
        }

        private void MainForm_Shown(object sender, EventArgs e)
        {
            LoadHeaderMenu(btnMainMenu, cmsMainMenu);
            LoadHeaderMenu(dlmLoginInfo, cmsExit);
        }

        #region Gestión Botones menú principal 

        private void LoadHeaderMenu(Control ctrl, ContextMenuStrip cms)
        {
            //Asignar la posición del menú.
            if (ctrl is Button)
            {
                ctrl.Click -= (s, e) => SetMenuPosition(ctrl);
                ctrl.Click += (s, e) => SetMenuPosition(ctrl);
            }

            if (ctrl is DoubleLabelMenu)
            {
                var control = (DoubleLabelMenu)ctrl;
                control.Click -= (s, e) => SetMenuPosition(ctrl);
                control.Click += (s, e) => SetMenuPosition(ctrl);
                control.OnLabelClick -= (s, e) => SetMenuPosition(ctrl);
                control.OnLabelClick += (s, e) => SetMenuPosition(ctrl);
            }

            cms.AutoSize = true;
            cms.ShowImageMargin = false;

            ctrl.ContextMenuStrip = cms;

            foreach (ToolStripMenuItem item in cms.Items)
            {
                item.DisplayStyle = ToolStripItemDisplayStyle.Text;

                //Cambiar color de los items.
                item.ForeColor = Color.FromArgb(63, 76, 90);

                item.Padding = new Padding(5);

                //Obtener la traducción del elemento                
                item.Text = GetResource(item.Name);

                item.Click += new EventHandler(ContextMenuItem_Click);
                item.TextAlign = ContentAlignment.BottomLeft;

                if (cms.Items.Count > 0 && ctrl is Button)
                {
                    item.AutoSize = false;
                    item.Height = btnMainMenu.Height;
                    item.Width = btnMainMenu.Width;
                    cms.AutoSize = false;
                    cms.Height = (cms.Items[0].Height * (cms.Items.Count) + 4);
                    cms.Width = btnMainMenu.Width;
                }
                else if (ctrl is DoubleLabelMenu)
                {
                    item.Height = ctrl.Height;
                    item.Width = ctrl.Width;
                    cms.AutoSize = true;
                }
                else
                {
                    cms.Size = Size.Empty;
                }

            }

        }

        private void SetMenuPosition(Control crtl)
        {
            if (crtl.ContextMenuStrip != null)
            {

                Point Posicion = new Point();

                Posicion.X = crtl.Parent.Left + crtl.Left;
                Posicion.Y = crtl.Parent.Top + crtl.Height;

                crtl.ContextMenuStrip.Show(this, Posicion);
            };
        }

        //Obtiene el recurso para el multilenguaje.
        //Poner en bases. Modificarlo para cualquier control??
        //El valor del tag lo puedo usar para saber que recurso coger.
        private string GetResource(string value)
        {
            switch (value)
            {
                case "tsiChangeUser":
                    return GlobalResources.TrazinsAtenea.ChangeUser;
                case "tsiExit":
                    return GlobalResources.TrazinsAtenea.Exit;
                case "tsiInventory":
                    return GlobalResources.TrazinsAtenea.Inventory;
                default:
                    return string.Empty;
            }
        }

        private void ContextMenuItem_Click(object sender, EventArgs e)
        {
            SubMenuItemClick((ToolStripMenuItem)sender);
        }

        private void SubMenuItemClick(ToolStripMenuItem element)
        {
            switch (element.Name)
            {
                case "tliInventory":
                    //Cambiar por la traducción del recurso                    
                    btnMainMenu.Text = GlobalResources.TrazinsAtenea.Inventory;
                    //OpenForm(new frmInventory());
                    break;
                case "tliExit":
                    MessageBox.Show("Exit");
                    //OpenForm(new frmWashes());
                    break;
                case "tliChange":
                    MessageBox.Show("ChangeUser");
                    break;
                default:
                    break;
            };
        }

        #endregion

        private void tmrMain_Tick(object sender, EventArgs e)
        {
            lblMainTimer.Text = DateTime.Now.ToString();
        }
    }
}