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

namespace TrazinsAtenea.Forms.Inventory.Box
{
    public partial class BoxesForm : DevExpress.XtraEditors.XtraForm
    {
        public BoxesForm()
        {
            InitializeComponent();
        }

        private void BoxesForm_Load(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            ServiceWSTrazinsAtenea.WSTrazinsAteneaClient service = new ServiceWSTrazinsAtenea.WSTrazinsAteneaClient();

            var boxes = service.Caja_Select(new ServiceWSTrazinsAtenea.Caja() { HosId = "002", ChId = "002" });

            gdcBoxes.DataSource = boxes;

            gdcSpeciality.Caption = Engine.GetLanguageResource(gdcSpeciality.Name);
            Cursor.Current = Cursors.Default;
            
        }

        
    }
}