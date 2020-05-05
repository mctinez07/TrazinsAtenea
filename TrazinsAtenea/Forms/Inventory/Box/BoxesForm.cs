﻿using System;
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
            try
            {
                //Mostrar que está cargando datos
                Cursor.Current = Cursors.WaitCursor;

                ServiceWSTrazinsAtenea.WSTrazinsAteneaClient service = new ServiceWSTrazinsAtenea.WSTrazinsAteneaClient();

                var boxes = service.Caja_Select(new ServiceWSTrazinsAtenea.Caja() { HosId = "002", ChId = "002" });

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