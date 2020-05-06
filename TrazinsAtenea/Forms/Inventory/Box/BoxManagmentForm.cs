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
using TrazinsAtenea.Forms.GlobalForms;

namespace TrazinsAtenea.Forms.Inventory.Box
{
    public partial class BoxManagmentForm : DevExpress.XtraEditors.XtraForm
    {
        public BoxManagmentForm()
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

        private void BoxManagmentForm_Load(object sender, EventArgs e)
        {
            MultilanguageFormat();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            MessageForm frm = new MessageForm();
            frm.ShowDialog();
            
        }
    }
}