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
    public partial class GroupManagmentForm : DevExpress.XtraEditors.XtraForm
    {
        public Caja Caja;

        public GroupManagmentForm()
        {
            InitializeComponent();             
        }

        private void GroupManagmentForm_Load(object sender, EventArgs e)
        {
            //Traducir
            Multilanguage();

            //si es edición rellenar los campos
            BindigControls();
        }

        private void BindigControls()
        {
            throw new NotImplementedException();
        }

        private void Multilanguage()
        {
            foreach (Control item in this.Controls)
            {
                if(item is LabelControl)
                {
                    Engine.GetLanguageResource(item.Name);
                }
            }
        }

        private void pcbBack_Click(object sender, EventArgs e)
        {            
            this.Close();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult = Engine.OpenMessageForm(190);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

        }

        
    }
}