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

namespace TrazinsAtenea.Forms.Inventory.Group
{
    public partial class GroupManagmentForm : DevExpress.XtraEditors.XtraForm
    {
        public GroupManagmentForm()
        {
            InitializeComponent();
            //Traducir
            //si es edición rellenar los campos
            
        }

        private void pcbBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult = Engine.OpenMessageForm(190);
        }
    }
}