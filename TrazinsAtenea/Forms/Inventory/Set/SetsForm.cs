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
using TrazinsAtenea.ServiceWSTrazinsAtenea;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Columns;

namespace TrazinsAtenea.Forms.Inventory.Set
{
    public partial class SetsForm : DevExpress.XtraEditors.XtraForm
    {
        private BaseModelClient BaseModel;

        public SetsForm()
        {
            InitializeComponent();
            this.BaseModel = BaseModelClient.Instance;
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
            SetManagmentForm frm = new SetManagmentForm();
            frm.ShowDialog();
        }

        private void SetsForm_Load(object sender, EventArgs e)
        {
            try
            {
                //Mostrar que está cargando datos
                //Añadir progrssForm
                Cursor.Current = Cursors.WaitCursor;

                var service = BaseModel.Service;

                var sets = service.Caja_Select_List(new Caja() { HosId = BaseModel.HosId, ChId = BaseModel.ChId });

                gdcSet.DataSource = sets;

                GridFormat(gdvSets);
                btnNew.Text = Engine.GetLanguageResource(btnNew.Name);
                btnNew.Focus();

                Cursor.Current = Cursors.Default;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error en SetsForm_Load: " + ex.Message);
            }
        }
    }
}