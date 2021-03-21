namespace TrazinsAtenea.Forms.Inventory.Set
{
    partial class SetsForm
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
            this.gdcSet = new DevExpress.XtraGrid.GridControl();
            this.gdvSets = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gvcSpeciality = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gvcCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gvcBox = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gvcLocate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gvcUbication = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gvcActive = new DevExpress.XtraGrid.Columns.GridColumn();
            this.pnlNewItem = new DevExpress.XtraEditors.PanelControl();
            this.btnNew = new DevExpress.XtraEditors.SimpleButton();
            this.splashScreenManager1 = new DevExpress.XtraSplashScreen.SplashScreenManager(this, typeof(global::TrazinsAtenea.Forms.GlobalForms.GlobalWaitForm), true, true);
            ((System.ComponentModel.ISupportInitialize)(this.gdcSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gdvSets)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlNewItem)).BeginInit();
            this.pnlNewItem.SuspendLayout();
            this.SuspendLayout();
            // 
            // gdcSet
            // 
            this.gdcSet.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gdcSet.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gdcSet.Location = new System.Drawing.Point(0, 76);
            this.gdcSet.MainView = this.gdvSets;
            this.gdcSet.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gdcSet.Name = "gdcSet";
            this.gdcSet.Size = new System.Drawing.Size(1615, 854);
            this.gdcSet.TabIndex = 2;
            this.gdcSet.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gdvSets});
            // 
            // gdvSets
            // 
            this.gdvSets.Appearance.GroupPanel.BackColor = System.Drawing.Color.White;
            this.gdvSets.Appearance.GroupPanel.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gdvSets.Appearance.GroupPanel.Options.UseBackColor = true;
            this.gdvSets.Appearance.GroupPanel.Options.UseFont = true;
            this.gdvSets.Appearance.GroupRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(251)))), ((int)(((byte)(253)))));
            this.gdvSets.Appearance.GroupRow.Font = new System.Drawing.Font("Trebuchet MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gdvSets.Appearance.GroupRow.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(116)))), ((int)(((byte)(195)))));
            this.gdvSets.Appearance.GroupRow.Options.UseBackColor = true;
            this.gdvSets.Appearance.GroupRow.Options.UseFont = true;
            this.gdvSets.Appearance.GroupRow.Options.UseForeColor = true;
            this.gdvSets.Appearance.HeaderPanel.BackColor = System.Drawing.Color.White;
            this.gdvSets.Appearance.HeaderPanel.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gdvSets.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(116)))), ((int)(((byte)(195)))));
            this.gdvSets.Appearance.HeaderPanel.Options.UseBackColor = true;
            this.gdvSets.Appearance.HeaderPanel.Options.UseFont = true;
            this.gdvSets.Appearance.HeaderPanel.Options.UseForeColor = true;
            this.gdvSets.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.White;
            this.gdvSets.Appearance.HideSelectionRow.Options.UseBackColor = true;
            this.gdvSets.Appearance.Row.Font = new System.Drawing.Font("Trebuchet MS", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gdvSets.Appearance.Row.Options.UseFont = true;
            this.gdvSets.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gvcSpeciality,
            this.gvcCode,
            this.gvcBox,
            this.gvcLocate,
            this.gvcUbication,
            this.gvcActive});
            this.gdvSets.DetailHeight = 431;
            this.gdvSets.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.None;
            this.gdvSets.GridControl = this.gdcSet;
            this.gdvSets.Name = "gdvSets";
            this.gdvSets.OptionsBehavior.Editable = false;
            this.gdvSets.OptionsScrollAnnotations.ShowFocusedRow = DevExpress.Utils.DefaultBoolean.False;
            this.gdvSets.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gdvSets.OptionsView.ShowIndicator = false;
            this.gdvSets.OptionsView.ShowVerticalLines = DevExpress.Utils.DefaultBoolean.False;
            // 
            // gvcSpeciality
            // 
            this.gvcSpeciality.Caption = "Especialidad";
            this.gvcSpeciality.FieldName = "EspecialidadDescripcion";
            this.gvcSpeciality.MinWidth = 23;
            this.gvcSpeciality.Name = "gvcSpeciality";
            this.gvcSpeciality.Visible = true;
            this.gvcSpeciality.VisibleIndex = 0;
            this.gvcSpeciality.Width = 87;
            // 
            // gvcCode
            // 
            this.gvcCode.Caption = "Código Caja/Id";
            this.gvcCode.FieldName = "CajaId_CodigoCaja";
            this.gvcCode.MinWidth = 23;
            this.gvcCode.Name = "gvcCode";
            this.gvcCode.Visible = true;
            this.gvcCode.VisibleIndex = 1;
            this.gvcCode.Width = 87;
            // 
            // gvcBox
            // 
            this.gvcBox.Caption = "Caja";
            this.gvcBox.FieldName = "Descripcion";
            this.gvcBox.MinWidth = 23;
            this.gvcBox.Name = "gvcBox";
            this.gvcBox.Visible = true;
            this.gvcBox.VisibleIndex = 2;
            this.gvcBox.Width = 87;
            // 
            // gvcLocate
            // 
            this.gvcLocate.Caption = "Localización";
            this.gvcLocate.MinWidth = 23;
            this.gvcLocate.Name = "gvcLocate";
            this.gvcLocate.Visible = true;
            this.gvcLocate.VisibleIndex = 3;
            this.gvcLocate.Width = 87;
            // 
            // gvcUbication
            // 
            this.gvcUbication.Caption = "Ubicación";
            this.gvcUbication.FieldName = "Ubicacion";
            this.gvcUbication.MinWidth = 23;
            this.gvcUbication.Name = "gvcUbication";
            this.gvcUbication.Visible = true;
            this.gvcUbication.VisibleIndex = 4;
            this.gvcUbication.Width = 87;
            // 
            // gvcActive
            // 
            this.gvcActive.Caption = "Activa";
            this.gvcActive.FieldName = "Activa";
            this.gvcActive.MinWidth = 23;
            this.gvcActive.Name = "gvcActive";
            this.gvcActive.Width = 87;
            // 
            // pnlNewItem
            // 
            this.pnlNewItem.Controls.Add(this.btnNew);
            this.pnlNewItem.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlNewItem.Location = new System.Drawing.Point(0, 0);
            this.pnlNewItem.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pnlNewItem.Name = "pnlNewItem";
            this.pnlNewItem.Size = new System.Drawing.Size(1615, 76);
            this.pnlNewItem.TabIndex = 0;
            // 
            // btnNew
            // 
            this.btnNew.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNew.Appearance.Font = new System.Drawing.Font("Trebuchet MS", 15.75F, System.Drawing.FontStyle.Bold);
            this.btnNew.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(116)))), ((int)(((byte)(195)))));
            this.btnNew.Appearance.Options.UseFont = true;
            this.btnNew.Appearance.Options.UseForeColor = true;
            this.btnNew.Location = new System.Drawing.Point(1473, 9);
            this.btnNew.LookAndFeel.SkinName = "DevExpress Style";
            this.btnNew.LookAndFeel.UseDefaultLookAndFeel = false;
            this.btnNew.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(135, 59);
            this.btnNew.TabIndex = 1;
            this.btnNew.Text = "Nuevo";
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // splashScreenManager1
            // 
            this.splashScreenManager1.ClosingDelay = 500;
            // 
            // SetsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1615, 930);
            this.Controls.Add(this.gdcSet);
            this.Controls.Add(this.pnlNewItem);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "SetsForm";
            this.Text = "SetsForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.SetsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gdcSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gdvSets)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlNewItem)).EndInit();
            this.pnlNewItem.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gdcSet;
        private DevExpress.XtraGrid.Views.Grid.GridView gdvSets;
        private DevExpress.XtraGrid.Columns.GridColumn gvcSpeciality;
        private DevExpress.XtraGrid.Columns.GridColumn gvcCode;
        private DevExpress.XtraGrid.Columns.GridColumn gvcBox;
        private DevExpress.XtraGrid.Columns.GridColumn gvcLocate;
        private DevExpress.XtraGrid.Columns.GridColumn gvcUbication;
        private DevExpress.XtraGrid.Columns.GridColumn gvcActive;
        private DevExpress.XtraEditors.PanelControl pnlNewItem;
        private DevExpress.XtraEditors.SimpleButton btnNew;
        private DevExpress.XtraSplashScreen.SplashScreenManager splashScreenManager1;
    }
}