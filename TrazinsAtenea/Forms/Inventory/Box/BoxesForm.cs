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
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Columns;
using TrazinsAtenea.ServiceWSTrazinsAtenea;

namespace TrazinsAtenea.Forms.Inventory.Box
{
    public partial class BoxesForm : DevExpress.XtraEditors.XtraForm
    {
        private BaseModelClient BaseModel;

        public BoxesForm()
        {
            InitializeComponent();
            this.BaseModel = BaseModelClient.Instance;
        }

        private void BoxesForm_Load(object sender, EventArgs e)
        {
            try
            {
                //Mostrar que está cargando datos
                Cursor.Current = Cursors.WaitCursor;

                var service = BaseModel.Service;

                var boxes = service.Caja_Select_List(new Caja() { HosId = BaseModel.HosId, ChId = BaseModel.ChId });
                
                gdcBoxes.DataSource = boxes;                

                GridFormat(gdvBoxes);
                btnNew.Text = Engine.GetLanguageResource(btnNew.Name);
                btnNew.Focus();

                Cursor.Current = Cursors.Default;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error en BoxesForm_Load: " + ex.Message);
            }
        }

        private void GridFormat(GridView gridView)
        {
            foreach (GridColumn item in gridView.Columns)
            {
                item.Caption = Engine.GetLanguageResource(item.Name);
            }
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            BoxManagmentForm frm = new BoxManagmentForm();
            frm.ShowDialog();
        }

        private void BoxesForm_Shown(object sender, EventArgs e)
        {
            
        }
    }
}