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
using TrazinsAtenea.GlobalEngine;
using Models.Inventory;

namespace TrazinsAtenea.Forms.Inventory.Group
{
    public partial class GroupsForm : DevExpress.XtraEditors.XtraForm
    {
        private Caja Caja;
        public GroupsForm(Caja caja)
        {
            InitializeComponent();
            this.Caja = caja;
            lblSetName.Text = caja.Descripcion;
            Multilanguage();
        }
        
        private void Multilanguage()
        {
            foreach (PanelControl panel in this.Controls)
            {
                //Traducimos los controles dentor del panel
                foreach (Control item in panel.Controls)
                {
                    if(item is SimpleButton || item is LabelControl)
                    {
                        item.Text = Engine.GetLanguageResource(item.Name);
                    }
                }
            }
        }

        private void pcbBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGroupNew_Click(object sender, EventArgs e)
        {
            GroupManagmentForm frm = new GroupManagmentForm();
            frm.Caja = this.Caja;
            frm.ShowDialog();
        }
    }
}