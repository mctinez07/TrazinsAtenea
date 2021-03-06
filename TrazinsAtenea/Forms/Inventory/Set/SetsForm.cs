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
using TrazinsAtenea.ServiceWSTrazinsAtenea;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Columns;
using System.Reflection;
using Models.Inventory;
using DevExpress.XtraGrid.Controls;

namespace TrazinsAtenea.Forms.Inventory.Set
{
    public partial class SetsForm : DevExpress.XtraEditors.XtraForm
    {
        private BaseModelClient BaseModelClient;        

        public SetsForm()
        {
            InitializeComponent();
            this.BaseModelClient = BaseModelClient.Instance;
            gdcSet.Layout += GridLayout_FindPanel;
        }

        private void GridLayout_FindPanel(object sender, LayoutEventArgs e)
        {
            if (gdvSets.IsFindPanelVisible)
            {
                FindControl findPanel = gdvSets.GridControl.Controls.Find("FindControlCore", false).FirstOrDefault() as FindControl;

                if (findPanel != null)
                {
                    findPanel.FindEdit.Font = new Font("Trebuchet MS", 14);
                    findPanel.Width = 400;
                }
            }
        }

        private void GridFormat(GridView gridView)
        {
            foreach (GridColumn item in gridView.Columns)
            {
                item.Caption = Engine.GetLanguageResource(item.Name);
            }

            
        }

        private void SetsForm_Load(object sender, EventArgs e)
        {
            try
            {
                splashScreenManager1.ShowWaitForm();

                UpdateDatasource();

                GridFormat(gdvSets);
                btnNew.Text = Engine.GetLanguageResource(btnNew.Name);

                splashScreenManager1.CloseWaitForm();
                
            }
            catch (Exception ex)
            {
                ErrorMessage.ShowErrorMessage(MethodBase.GetCurrentMethod().Name, ex.Message);
            }
        }

        private void UpdateDatasource()
        {
            var service = BaseModelClient.Service;

            var setList = service.Caja_Select_List(new Caja()
            { HosId = BaseModelClient.BaseModel.HosId, ChId = BaseModelClient.BaseModel.ChId }).ToList();

            gdcSet.DataSource = setList;
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            SetManagmentForm frm = new SetManagmentForm
            {
                Operation = EnumOperationType.New
            };

            frm.ShowDialog();
            UpdateDatasource();
        }

    }
}