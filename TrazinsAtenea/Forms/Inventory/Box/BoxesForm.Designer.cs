namespace TrazinsAtenea.Forms.Inventory.Box
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
            this.gdcSpeciality = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gdcCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gdcBox = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gdcLocate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gdcUbication = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gdcActive = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gdcBoxes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gdvBoxes)).BeginInit();
            this.SuspendLayout();
            // 
            // gdcBoxes
            // 
            this.gdcBoxes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gdcBoxes.Location = new System.Drawing.Point(0, 0);
            this.gdcBoxes.MainView = this.gdvBoxes;
            this.gdcBoxes.Name = "gdcBoxes";
            this.gdcBoxes.Size = new System.Drawing.Size(1384, 756);
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
            this.gdvBoxes.Appearance.Row.Font = new System.Drawing.Font("Trebuchet MS", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gdvBoxes.Appearance.Row.Options.UseFont = true;
            this.gdvBoxes.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gdcSpeciality,
            this.gdcCode,
            this.gdcBox,
            this.gdcLocate,
            this.gdcUbication,
            this.gdcActive});
            this.gdvBoxes.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.None;
            this.gdvBoxes.GridControl = this.gdcBoxes;
            this.gdvBoxes.Name = "gdvBoxes";
            this.gdvBoxes.OptionsBehavior.Editable = false;
            this.gdvBoxes.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gdvBoxes.OptionsView.ShowIndicator = false;
            this.gdvBoxes.OptionsView.ShowVerticalLines = DevExpress.Utils.DefaultBoolean.False;
            // 
            // gdcSpeciality
            // 
            this.gdcSpeciality.Caption = "Especialidad";
            this.gdcSpeciality.FieldName = "Especialidad_Descripcion";
            this.gdcSpeciality.Name = "gdcSpeciality";
            this.gdcSpeciality.Visible = true;
            this.gdcSpeciality.VisibleIndex = 0;
            // 
            // gdcCode
            // 
            this.gdcCode.Caption = "Código Caja/Id";
            this.gdcCode.FieldName = "CajaId_CodigoCaja";
            this.gdcCode.Name = "gdcCode";
            this.gdcCode.Visible = true;
            this.gdcCode.VisibleIndex = 1;
            // 
            // gdcBox
            // 
            this.gdcBox.Caption = "Caja";
            this.gdcBox.FieldName = "Descripcion";
            this.gdcBox.Name = "gdcBox";
            this.gdcBox.Visible = true;
            this.gdcBox.VisibleIndex = 2;
            // 
            // gdcLocate
            // 
            this.gdcLocate.Caption = "Localización";
            this.gdcLocate.Name = "gdcLocate";
            this.gdcLocate.Visible = true;
            this.gdcLocate.VisibleIndex = 3;
            // 
            // gdcUbication
            // 
            this.gdcUbication.Caption = "Ubicación";
            this.gdcUbication.Name = "gdcUbication";
            this.gdcUbication.Visible = true;
            this.gdcUbication.VisibleIndex = 4;
            // 
            // gdcActive
            // 
            this.gdcActive.Caption = "Activa";
            this.gdcActive.FieldName = "Activa";
            this.gdcActive.Name = "gdcActive";
            // 
            // BoxesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1384, 756);
            this.Controls.Add(this.gdcBoxes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "BoxesForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BoxesForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.BoxesForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gdcBoxes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gdvBoxes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gdcBoxes;
        private DevExpress.XtraGrid.Views.Grid.GridView gdvBoxes;
        private DevExpress.XtraGrid.Columns.GridColumn gdcSpeciality;
        private DevExpress.XtraGrid.Columns.GridColumn gdcCode;
        private DevExpress.XtraGrid.Columns.GridColumn gdcBox;
        private DevExpress.XtraGrid.Columns.GridColumn gdcLocate;
        private DevExpress.XtraGrid.Columns.GridColumn gdcUbication;
        private DevExpress.XtraGrid.Columns.GridColumn gdcActive;
    }
}