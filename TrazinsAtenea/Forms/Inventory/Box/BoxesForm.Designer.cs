﻿namespace TrazinsAtenea.Forms.Inventory.Box
{
    partial class BoxesForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.gdcBoxes = new DevExpress.XtraGrid.GridControl();
            this.gdvBoxes = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gvcSpeciality = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gvcCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gvcBox = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gvcLocate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gvcUbication = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gvcActive = new DevExpress.XtraGrid.Columns.GridColumn();
            this.pnlNewItem = new DevExpress.XtraEditors.PanelControl();
            this.btnNew = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gdcBoxes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gdvBoxes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlNewItem)).BeginInit();
            this.pnlNewItem.SuspendLayout();
            this.SuspendLayout();
            // 
            // gdcBoxes
            // 
            this.gdcBoxes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gdcBoxes.Location = new System.Drawing.Point(0, 62);
            this.gdcBoxes.MainView = this.gdvBoxes;
            this.gdcBoxes.Name = "gdcBoxes";
            this.gdcBoxes.Size = new System.Drawing.Size(1384, 694);
            this.gdcBoxes.TabIndex = 0;
            this.gdcBoxes.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gdvBoxes});
            // 
            // gdvBoxes
            // 
            this.gdvBoxes.Appearance.GroupPanel.BackColor = System.Drawing.Color.White;
            this.gdvBoxes.Appearance.GroupPanel.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gdvBoxes.Appearance.GroupPanel.Options.UseBackColor = true;
            this.gdvBoxes.Appearance.GroupPanel.Options.UseFont = true;
            this.gdvBoxes.Appearance.GroupRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(251)))), ((int)(((byte)(253)))));
            this.gdvBoxes.Appearance.GroupRow.Font = new System.Drawing.Font("Trebuchet MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gdvBoxes.Appearance.GroupRow.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(116)))), ((int)(((byte)(195)))));
            this.gdvBoxes.Appearance.GroupRow.Options.UseBackColor = true;
            this.gdvBoxes.Appearance.GroupRow.Options.UseFont = true;
            this.gdvBoxes.Appearance.GroupRow.Options.UseForeColor = true;
            this.gdvBoxes.Appearance.HeaderPanel.BackColor = System.Drawing.Color.White;
            this.gdvBoxes.Appearance.HeaderPanel.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gdvBoxes.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(116)))), ((int)(((byte)(195)))));
            this.gdvBoxes.Appearance.HeaderPanel.Options.UseBackColor = true;
            this.gdvBoxes.Appearance.HeaderPanel.Options.UseFont = true;
            this.gdvBoxes.Appearance.HeaderPanel.Options.UseForeColor = true;
            this.gdvBoxes.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.White;
            this.gdvBoxes.Appearance.HideSelectionRow.Options.UseBackColor = true;
            this.gdvBoxes.Appearance.Row.Font = new System.Drawing.Font("Trebuchet MS", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gdvBoxes.Appearance.Row.Options.UseFont = true;
            this.gdvBoxes.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gvcSpeciality,
            this.gvcCode,
            this.gvcBox,
            this.gvcLocate,
            this.gvcUbication,
            this.gvcActive});
            this.gdvBoxes.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.None;
            this.gdvBoxes.GridControl = this.gdcBoxes;
            this.gdvBoxes.Name = "gdvBoxes";
            this.gdvBoxes.OptionsBehavior.Editable = false;
            this.gdvBoxes.OptionsScrollAnnotations.ShowFocusedRow = DevExpress.Utils.DefaultBoolean.False;
            this.gdvBoxes.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gdvBoxes.OptionsView.ShowIndicator = false;
            this.gdvBoxes.OptionsView.ShowVerticalLines = DevExpress.Utils.DefaultBoolean.False;
            // 
            // gvcSpeciality
            // 
            this.gvcSpeciality.Caption = "Especialidad";
            this.gvcSpeciality.FieldName = "Especialidad_Descripcion";
            this.gvcSpeciality.Name = "gvcSpeciality";
            this.gvcSpeciality.Visible = true;
            this.gvcSpeciality.VisibleIndex = 0;
            // 
            // gvcCode
            // 
            this.gvcCode.Caption = "Código Caja/Id";
            this.gvcCode.FieldName = "CajaId_CodigoCaja";
            this.gvcCode.Name = "gvcCode";
            this.gvcCode.Visible = true;
            this.gvcCode.VisibleIndex = 1;
            // 
            // gvcBox
            // 
            this.gvcBox.Caption = "Caja";
            this.gvcBox.FieldName = "Descripcion";
            this.gvcBox.Name = "gvcBox";
            this.gvcBox.Visible = true;
            this.gvcBox.VisibleIndex = 2;
            // 
            // gvcLocate
            // 
            this.gvcLocate.Caption = "Localización";
            this.gvcLocate.Name = "gvcLocate";
            this.gvcLocate.Visible = true;
            this.gvcLocate.VisibleIndex = 3;
            // 
            // gvcUbication
            // 
            this.gvcUbication.Caption = "Ubicación";
            this.gvcUbication.Name = "gvcUbication";
            this.gvcUbication.Visible = true;
            this.gvcUbication.VisibleIndex = 4;
            // 
            // gvcActive
            // 
            this.gvcActive.Caption = "Activa";
            this.gvcActive.FieldName = "Activa";
            this.gvcActive.Name = "gvcActive";
            // 
            // pnlNewItem
            // 
            this.pnlNewItem.Controls.Add(this.btnNew);
            this.pnlNewItem.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlNewItem.Location = new System.Drawing.Point(0, 0);
            this.pnlNewItem.Name = "pnlNewItem";
            this.pnlNewItem.Size = new System.Drawing.Size(1384, 62);
            this.pnlNewItem.TabIndex = 2;
            // 
            // btnNew
            // 
            this.btnNew.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNew.BackColor = System.Drawing.Color.White;
            this.btnNew.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(116)))), ((int)(((byte)(195)))));
            this.btnNew.FlatAppearance.BorderSize = 2;
            this.btnNew.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNew.Font = new System.Drawing.Font("Trebuchet MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNew.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(116)))), ((int)(((byte)(195)))));
            this.btnNew.Location = new System.Drawing.Point(1256, 7);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(116, 48);
            this.btnNew.TabIndex = 2;
            this.btnNew.Text = "Nuevo";
            this.btnNew.UseVisualStyleBackColor = false;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // BoxesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1384, 756);
            this.Controls.Add(this.gdcBoxes);
            this.Controls.Add(this.pnlNewItem);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "BoxesForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BoxesForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.BoxesForm_Load);
            this.Shown += new System.EventHandler(this.BoxesForm_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.gdcBoxes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gdvBoxes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlNewItem)).EndInit();
            this.pnlNewItem.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gdcBoxes;
        private DevExpress.XtraGrid.Views.Grid.GridView gdvBoxes;
        private DevExpress.XtraGrid.Columns.GridColumn gvcSpeciality;
        private DevExpress.XtraGrid.Columns.GridColumn gvcCode;
        private DevExpress.XtraGrid.Columns.GridColumn gvcBox;
        private DevExpress.XtraGrid.Columns.GridColumn gvcLocate;
        private DevExpress.XtraGrid.Columns.GridColumn gvcUbication;
        private DevExpress.XtraGrid.Columns.GridColumn gvcActive;
        private DevExpress.XtraEditors.PanelControl pnlNewItem;
        private System.Windows.Forms.Button btnNew;
    }
}