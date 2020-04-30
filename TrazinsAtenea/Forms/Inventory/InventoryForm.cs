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
            Engine.OpenForm(new BoxesForm(), pnlInventoryBody);
        }
    }
}