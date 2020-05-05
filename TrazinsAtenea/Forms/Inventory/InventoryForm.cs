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
using TrazinsAtenea.Forms.Inventory.Box;

namespace TrazinsAtenea.Forms.Inventory
{
    public partial class InventoryForm : DevExpress.XtraEditors.XtraForm
    {
        public InventoryForm()
        {
            InitializeComponent();
        }

        private void InventoryForm_Load(object sender, EventArgs e)
        {
            try
            {
                foreach (Control item in this.pnlInventoryMenu.Controls)
                {
                    if (!string.IsNullOrEmpty(item.Text))
                    {
                        var a = Engine.GetLanguageResource(item.Name);
                        item.Text = a;
                    }
                }

                Engine.OpenForm(new BoxesForm(), pnlInventoryBody);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error en InventoryForm_Load: " + ex.Message);
            }
            
        }
    }
}