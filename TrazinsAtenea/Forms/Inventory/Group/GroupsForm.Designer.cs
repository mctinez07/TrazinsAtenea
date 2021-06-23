namespace TrazinsAtenea.Forms.Inventory.Group
{
    partial class GroupsForm
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
            this.pnlSetName = new DevExpress.XtraEditors.PanelControl();
            this.btnGroupNew = new DevExpress.XtraEditors.SimpleButton();
            this.lblSetName = new DevExpress.XtraEditors.LabelControl();
            this.pnlHeader = new DevExpress.XtraEditors.PanelControl();
            this.lblGroupTitle = new DevExpress.XtraEditors.LabelControl();
            this.spcBackArrow = new DevExpress.XtraEditors.SeparatorControl();
            this.pcbBack = new System.Windows.Forms.PictureBox();
            this.pnlGroupFooter = new DevExpress.XtraEditors.PanelControl();
            this.btnDelete = new DevExpress.XtraEditors.SimpleButton();
            this.btnModify = new DevExpress.XtraEditors.SimpleButton();
            this.pnlWorkBench = new DevExpress.XtraEditors.PanelControl();
            this.dgcGroups = new DevExpress.XtraGrid.GridControl();
            this.gdvGroups = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gdcGroupName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gdcGroupDescription = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gdcGroupObservations = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.pnlSetName)).BeginInit();
            this.pnlSetName.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pnlHeader)).BeginInit();
            this.pnlHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spcBackArrow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbBack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlGroupFooter)).BeginInit();
            this.pnlGroupFooter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pnlWorkBench)).BeginInit();
            this.pnlWorkBench.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgcGroups)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gdvGroups)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlSetName
            // 
            this.pnlSetName.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(251)))), ((int)(((byte)(253)))));
            this.pnlSetName.Appearance.BorderColor = System.Drawing.Color.Silver;
            this.pnlSetName.Appearance.Options.UseBackColor = true;
            this.pnlSetName.Appearance.Options.UseBorderColor = true;
            this.pnlSetName.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.pnlSetName.Controls.Add(this.btnGroupNew);
            this.pnlSetName.Controls.Add(this.lblSetName);
            this.pnlSetName.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlSetName.Location = new System.Drawing.Point(0, 92);
            this.pnlSetName.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Flat;
            this.pnlSetName.LookAndFeel.UseDefaultLookAndFeel = false;
            this.pnlSetName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pnlSetName.Name = "pnlSetName";
            this.pnlSetName.Size = new System.Drawing.Size(1114, 90);
            this.pnlSetName.TabIndex = 17;
            // 
            // btnGroupNew
            // 
            this.btnGroupNew.Appearance.Font = new System.Drawing.Font("Trebuchet MS", 15.75F, System.Drawing.FontStyle.Bold);
            this.btnGroupNew.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(116)))), ((int)(((byte)(195)))));
            this.btnGroupNew.Appearance.Options.UseFont = true;
            this.btnGroupNew.Appearance.Options.UseForeColor = true;
            this.btnGroupNew.ImageOptions.Image = global::TrazinsAtenea.Properties.Resources.add_24x24;
            this.btnGroupNew.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnGroupNew.Location = new System.Drawing.Point(906, 15);
            this.btnGroupNew.LookAndFeel.SkinName = "DevExpress Style";
            this.btnGroupNew.LookAndFeel.UseDefaultLookAndFeel = false;
            this.btnGroupNew.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnGroupNew.Name = "btnGroupNew";
            this.btnGroupNew.Size = new System.Drawing.Size(194, 59);
            this.btnGroupNew.TabIndex = 8;
            this.btnGroupNew.Text = "Nuevo Grupo";
            this.btnGroupNew.Click += new System.EventHandler(this.btnGroupNew_Click);
            // 
            // lblSetName
            // 
            this.lblSetName.Appearance.Font = new System.Drawing.Font("Trebuchet MS", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSetName.Appearance.Options.UseFont = true;
            this.lblSetName.Location = new System.Drawing.Point(16, 27);
            this.lblSetName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lblSetName.Name = "lblSetName";
            this.lblSetName.Size = new System.Drawing.Size(254, 38);
            this.lblSetName.TabIndex = 0;
            this.lblSetName.Text = "Nombre de la caja";
            // 
            // pnlHeader
            // 
            this.pnlHeader.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(227)))), ((int)(((byte)(243)))));
            this.pnlHeader.Appearance.BorderColor = System.Drawing.Color.Silver;
            this.pnlHeader.Appearance.Options.UseBackColor = true;
            this.pnlHeader.Appearance.Options.UseBorderColor = true;
            this.pnlHeader.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.pnlHeader.Controls.Add(this.lblGroupTitle);
            this.pnlHeader.Controls.Add(this.spcBackArrow);
            this.pnlHeader.Controls.Add(this.pcbBack);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.UltraFlat;
            this.pnlHeader.LookAndFeel.UseDefaultLookAndFeel = false;
            this.pnlHeader.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(1114, 92);
            this.pnlHeader.TabIndex = 16;
            // 
            // lblGroupTitle
            // 
            this.lblGroupTitle.Appearance.Font = new System.Drawing.Font("Trebuchet MS", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGroupTitle.Appearance.Options.UseFont = true;
            this.lblGroupTitle.ImageAlignToText = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.lblGroupTitle.ImageOptions.Alignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblGroupTitle.ImageOptions.Image = global::TrazinsAtenea.Properties.Resources.group_24x24;
            this.lblGroupTitle.Location = new System.Drawing.Point(114, 21);
            this.lblGroupTitle.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lblGroupTitle.Name = "lblGroupTitle";
            this.lblGroupTitle.Size = new System.Drawing.Size(372, 49);
            this.lblGroupTitle.TabIndex = 2;
            this.lblGroupTitle.Text = "Gestión de Grupos";
            // 
            // spcBackArrow
            // 
            this.spcBackArrow.Dock = System.Windows.Forms.DockStyle.Left;
            this.spcBackArrow.LineOrientation = System.Windows.Forms.Orientation.Vertical;
            this.spcBackArrow.Location = new System.Drawing.Point(89, 2);
            this.spcBackArrow.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.spcBackArrow.Name = "spcBackArrow";
            this.spcBackArrow.Padding = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.spcBackArrow.Size = new System.Drawing.Size(17, 88);
            this.spcBackArrow.TabIndex = 1;
            // 
            // pcbBack
            // 
            this.pcbBack.Dock = System.Windows.Forms.DockStyle.Left;
            this.pcbBack.Image = global::TrazinsAtenea.Properties.Resources.arrow_back_48x48;
            this.pcbBack.Location = new System.Drawing.Point(2, 2);
            this.pcbBack.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pcbBack.Name = "pcbBack";
            this.pcbBack.Size = new System.Drawing.Size(87, 88);
            this.pcbBack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pcbBack.TabIndex = 0;
            this.pcbBack.TabStop = false;
            this.pcbBack.Click += new System.EventHandler(this.pcbBack_Click);
            // 
            // pnlGroupFooter
            // 
            this.pnlGroupFooter.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(227)))), ((int)(((byte)(243)))));
            this.pnlGroupFooter.Appearance.BorderColor = System.Drawing.Color.Silver;
            this.pnlGroupFooter.Appearance.Options.UseBackColor = true;
            this.pnlGroupFooter.Appearance.Options.UseBorderColor = true;
            this.pnlGroupFooter.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.pnlGroupFooter.Controls.Add(this.btnDelete);
            this.pnlGroupFooter.Controls.Add(this.btnModify);
            this.pnlGroupFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlGroupFooter.Location = new System.Drawing.Point(0, 618);
            this.pnlGroupFooter.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Flat;
            this.pnlGroupFooter.LookAndFeel.UseDefaultLookAndFeel = false;
            this.pnlGroupFooter.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pnlGroupFooter.Name = "pnlGroupFooter";
            this.pnlGroupFooter.Size = new System.Drawing.Size(1114, 90);
            this.pnlGroupFooter.TabIndex = 15;
            // 
            // btnDelete
            // 
            this.btnDelete.Appearance.Font = new System.Drawing.Font("Trebuchet MS", 15.75F, System.Drawing.FontStyle.Bold);
            this.btnDelete.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(116)))), ((int)(((byte)(195)))));
            this.btnDelete.Appearance.Options.UseFont = true;
            this.btnDelete.Appearance.Options.UseForeColor = true;
            this.btnDelete.ImageOptions.Image = global::TrazinsAtenea.Properties.Resources.delete_24x241;
            this.btnDelete.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnDelete.Location = new System.Drawing.Point(952, 15);
            this.btnDelete.LookAndFeel.SkinName = "DevExpress Style";
            this.btnDelete.LookAndFeel.UseDefaultLookAndFeel = false;
            this.btnDelete.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(148, 59);
            this.btnDelete.TabIndex = 10;
            this.btnDelete.Text = "Eliminar";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnModify
            // 
            this.btnModify.Appearance.Font = new System.Drawing.Font("Trebuchet MS", 15.75F, System.Drawing.FontStyle.Bold);
            this.btnModify.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(116)))), ((int)(((byte)(195)))));
            this.btnModify.Appearance.Options.UseFont = true;
            this.btnModify.Appearance.Options.UseForeColor = true;
            this.btnModify.ImageOptions.Image = global::TrazinsAtenea.Properties.Resources.modificar_24x24;
            this.btnModify.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnModify.Location = new System.Drawing.Point(777, 15);
            this.btnModify.LookAndFeel.SkinName = "DevExpress Style";
            this.btnModify.LookAndFeel.UseDefaultLookAndFeel = false;
            this.btnModify.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnModify.Name = "btnModify";
            this.btnModify.Size = new System.Drawing.Size(156, 59);
            this.btnModify.TabIndex = 9;
            this.btnModify.Text = "Modificar";
            this.btnModify.Click += new System.EventHandler(this.btnModify_Click);
            // 
            // pnlWorkBench
            // 
            this.pnlWorkBench.Controls.Add(this.dgcGroups);
            this.pnlWorkBench.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlWorkBench.Location = new System.Drawing.Point(0, 182);
            this.pnlWorkBench.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pnlWorkBench.Name = "pnlWorkBench";
            this.pnlWorkBench.Size = new System.Drawing.Size(1114, 436);
            this.pnlWorkBench.TabIndex = 18;
            // 
            // dgcGroups
            // 
            this.dgcGroups.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgcGroups.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgcGroups.Location = new System.Drawing.Point(2, 2);
            this.dgcGroups.MainView = this.gdvGroups;
            this.dgcGroups.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgcGroups.Name = "dgcGroups";
            this.dgcGroups.Size = new System.Drawing.Size(1110, 432);
            this.dgcGroups.TabIndex = 19;
            this.dgcGroups.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gdvGroups});
            // 
            // gdvGroups
            // 
            this.gdvGroups.Appearance.GroupPanel.BackColor = System.Drawing.Color.White;
            this.gdvGroups.Appearance.GroupPanel.Font = new System.Drawing.Font("Trebuchet MS", 12F);
            this.gdvGroups.Appearance.GroupPanel.Options.UseBackColor = true;
            this.gdvGroups.Appearance.GroupPanel.Options.UseFont = true;
            this.gdvGroups.Appearance.GroupRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(251)))), ((int)(((byte)(253)))));
            this.gdvGroups.Appearance.GroupRow.Font = new System.Drawing.Font("Trebuchet MS", 15.75F);
            this.gdvGroups.Appearance.GroupRow.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(116)))), ((int)(((byte)(195)))));
            this.gdvGroups.Appearance.GroupRow.Options.UseBackColor = true;
            this.gdvGroups.Appearance.GroupRow.Options.UseFont = true;
            this.gdvGroups.Appearance.GroupRow.Options.UseForeColor = true;
            this.gdvGroups.Appearance.HeaderPanel.BackColor = System.Drawing.Color.White;
            this.gdvGroups.Appearance.HeaderPanel.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Bold);
            this.gdvGroups.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(116)))), ((int)(((byte)(195)))));
            this.gdvGroups.Appearance.HeaderPanel.Options.UseBackColor = true;
            this.gdvGroups.Appearance.HeaderPanel.Options.UseFont = true;
            this.gdvGroups.Appearance.HeaderPanel.Options.UseForeColor = true;
            this.gdvGroups.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.White;
            this.gdvGroups.Appearance.HideSelectionRow.Options.UseBackColor = true;
            this.gdvGroups.Appearance.Row.Font = new System.Drawing.Font("Trebuchet MS", 18F);
            this.gdvGroups.Appearance.Row.Options.UseFont = true;
            this.gdvGroups.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gdcGroupName,
            this.gdcGroupDescription,
            this.gdcGroupObservations});
            this.gdvGroups.DetailHeight = 431;
            this.gdvGroups.GridControl = this.dgcGroups;
            this.gdvGroups.Name = "gdvGroups";
            // 
            // gdcGroupName
            // 
            this.gdcGroupName.Caption = "Nombre de Grupo";
            this.gdcGroupName.FieldName = "NomGrupo";
            this.gdcGroupName.MinWidth = 23;
            this.gdcGroupName.Name = "gdcGroupName";
            this.gdcGroupName.Visible = true;
            this.gdcGroupName.VisibleIndex = 0;
            this.gdcGroupName.Width = 87;
            // 
            // gdcGroupDescription
            // 
            this.gdcGroupDescription.Caption = "Descripción de Grupo";
            this.gdcGroupDescription.FieldName = "DesGrupo";
            this.gdcGroupDescription.MinWidth = 23;
            this.gdcGroupDescription.Name = "gdcGroupDescription";
            this.gdcGroupDescription.Visible = true;
            this.gdcGroupDescription.VisibleIndex = 1;
            this.gdcGroupDescription.Width = 87;
            // 
            // gdcGroupObservations
            // 
            this.gdcGroupObservations.Caption = "Observaciones de Grupo";
            this.gdcGroupObservations.FieldName = "Observaciones";
            this.gdcGroupObservations.MinWidth = 23;
            this.gdcGroupObservations.Name = "gdcGroupObservations";
            this.gdcGroupObservations.Visible = true;
            this.gdcGroupObservations.VisibleIndex = 2;
            this.gdcGroupObservations.Width = 87;
            // 
            // GroupsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1114, 708);
            this.Controls.Add(this.pnlWorkBench);
            this.Controls.Add(this.pnlSetName);
            this.Controls.Add(this.pnlHeader);
            this.Controls.Add(this.pnlGroupFooter);
            this.FormBorderEffect = DevExpress.XtraEditors.FormBorderEffect.Shadow;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "GroupsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GroupForm";
            this.Load += new System.EventHandler(this.GroupsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pnlSetName)).EndInit();
            this.pnlSetName.ResumeLayout(false);
            this.pnlSetName.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pnlHeader)).EndInit();
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spcBackArrow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbBack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlGroupFooter)).EndInit();
            this.pnlGroupFooter.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pnlWorkBench)).EndInit();
            this.pnlWorkBench.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgcGroups)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gdvGroups)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraEditors.PanelControl pnlSetName;
        private DevExpress.XtraEditors.SimpleButton btnGroupNew;
        private DevExpress.XtraEditors.LabelControl lblSetName;
        private DevExpress.XtraEditors.PanelControl pnlHeader;
        private DevExpress.XtraEditors.LabelControl lblGroupTitle;
        private DevExpress.XtraEditors.SeparatorControl spcBackArrow;
        private System.Windows.Forms.PictureBox pcbBack;
        private DevExpress.XtraEditors.PanelControl pnlGroupFooter;
        private DevExpress.XtraEditors.SimpleButton btnDelete;
        private DevExpress.XtraEditors.SimpleButton btnModify;
        private DevExpress.XtraEditors.PanelControl pnlWorkBench;
        private DevExpress.XtraGrid.Views.Grid.GridView gdvGroups;
        private DevExpress.XtraGrid.Columns.GridColumn gdcGroupName;
        private DevExpress.XtraGrid.Columns.GridColumn gdcGroupDescription;
        private DevExpress.XtraGrid.Columns.GridColumn gdcGroupObservations;
        public DevExpress.XtraGrid.GridControl dgcGroups;
    }
}