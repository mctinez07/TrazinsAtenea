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
using TrazinsAtenea.Forms.GlobalForms;
using TrazinsAtenea.GlobalEngine;

namespace TrazinsAtenea.Forms.Inventory.Set
{
    public partial class SetManagmentForm : DevExpress.XtraEditors.XtraForm
    {
        public SetManagmentForm()
        {
            InitializeComponent();
        }

        private void MultilanguageFormat()
        {
            foreach (Control item in pnlHeader.Controls)
            {
                item.Text = Engine.GetLanguageResource(item.Name);
            };
        }

        private void pcbBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SetManagmentForm_Load(object sender, EventArgs e)
        {
            MultilanguageFormat();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            MessageForm frm = new MessageForm(190);
            frm.ShowDialog();
        }
        
    }
}