namespace TrazinsAtenea.Forms.GlobalForms
{
    partial class DeleteForm
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
            this.pcbDeleteIcon = new System.Windows.Forms.PictureBox();
            this.btnNo = new DevExpress.XtraEditors.SimpleButton();
            this.btnYesSend = new DevExpress.XtraEditors.SimpleButton();
            this.lblDeleteMessageTitle = new System.Windows.Forms.Label();
            this.lblMessage = new System.Windows.Forms.Label();
            this.grcDeleteObjects = new DevExpress.XtraGrid.GridControl();
            this.gdvDeleteObjects = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colImage = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colObjectName = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.pcbDeleteIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grcDeleteObjects)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gdvDeleteObjects)).BeginInit();
            this.SuspendLayout();
            // 
            // pcbDeleteIcon
            // 
            this.pcbDeleteIcon.Image = global::TrazinsAtenea.Properties.Resources.delete_48x48;
            this.pcbDeleteIcon.Location = new System.Drawing.Point(172, 12);
            this.pcbDeleteIcon.Name = "pcbDeleteIcon";
            this.pcbDeleteIcon.Size = new System.Drawing.Size(126, 126);
            this.pcbDeleteIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbDeleteIcon.TabIndex = 0;
            this.pcbDeleteIcon.TabStop = false;
            // 
            // btnNo
            // 
            this.btnNo.Appearance.BackColor = System.Drawing.Color.White;
            this.btnNo.Appearance.BackColor2 = DevExpress.LookAndFeel.DXSkinColors.IconColors.White;
            this.btnNo.Appearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnNo.Appearance.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNo.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(116)))), ((int)(((byte)(195)))));
            this.btnNo.Appearance.Options.UseBackColor = true;
            this.btnNo.Appearance.Options.UseBorderColor = true;
            this.btnNo.Appearance.Options.UseFont = true;
            this.btnNo.Appearance.Options.UseForeColor = true;
            this.btnNo.Location = new System.Drawing.Point(12, 490);
            this.btnNo.LookAndFeel.SkinMaskColor = System.Drawing.Color.White;
            this.btnNo.LookAndFeel.SkinMaskColor2 = System.Drawing.Color.White;
            this.btnNo.LookAndFeel.SkinName = "DevExpress Style";
            this.btnNo.LookAndFeel.UseDefaultLookAndFeel = false;
            this.btnNo.Name = "btnNo";
            this.btnNo.Size = new System.Drawing.Size(106, 52);
            this.btnNo.TabIndex = 3;
            this.btnNo.Text = "No";
            // 
            // btnYesSend
            // 
            this.btnYesSend.Appearance.BackColor = System.Drawing.Color.Red;
            this.btnYesSend.Appearance.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnYesSend.Appearance.ForeColor = System.Drawing.Color.Black;
            this.btnYesSend.Appearance.Options.UseBackColor = true;
            this.btnYesSend.Appearance.Options.UseFont = true;
            this.btnYesSend.Appearance.Options.UseForeColor = true;
            this.btnYesSend.Location = new System.Drawing.Point(172, 490);
            this.btnYesSend.LookAndFeel.SkinMaskColor = System.Drawing.Color.White;
            this.btnYesSend.LookAndFeel.SkinMaskColor2 = System.Drawing.Color.White;
            this.btnYesSend.LookAndFeel.SkinName = "DevExpress Style";
            this.btnYesSend.LookAndFeel.UseDefaultLookAndFeel = false;
            this.btnYesSend.Name = "btnYesSend";
            this.btnYesSend.Size = new System.Drawing.Size(314, 52);
            this.btnYesSend.TabIndex = 2;
            this.btnYesSend.Text = "Sí, enviar a la papelera";
            // 
            // lblDeleteMessageTitle
            // 
            this.lblDeleteMessageTitle.AutoSize = true;
            this.lblDeleteMessageTitle.BackColor = System.Drawing.Color.White;
            this.lblDeleteMessageTitle.Font = new System.Drawing.Font("Trebuchet MS", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDeleteMessageTitle.ForeColor = System.Drawing.Color.Black;
            this.lblDeleteMessageTitle.Location = new System.Drawing.Point(100, 141);
            this.lblDeleteMessageTitle.Name = "lblDeleteMessageTitle";
            this.lblDeleteMessageTitle.Size = new System.Drawing.Size(271, 49);
            this.lblDeleteMessageTitle.TabIndex = 15;
            this.lblDeleteMessageTitle.Text = "¿Está seguro?";
            // 
            // lblMessage
            // 
            this.lblMessage.BackColor = System.Drawing.Color.White;
            this.lblMessage.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMessage.ForeColor = System.Drawing.Color.Black;
            this.lblMessage.Location = new System.Drawing.Point(10, 190);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(476, 27);
            this.lblMessage.TabIndex = 17;
            this.lblMessage.Text = "Va a enviar a la papelera los siguientes elementos";
            this.lblMessage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // grcDeleteObjects
            // 
            this.grcDeleteObjects.EmbeddedNavigator.Appearance.Font = new System.Drawing.Font("Trebuchet MS", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grcDeleteObjects.EmbeddedNavigator.Appearance.Options.UseFont = true;
            this.grcDeleteObjects.Enabled = false;
            this.grcDeleteObjects.Font = new System.Drawing.Font("Trebuchet MS", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grcDeleteObjects.Location = new System.Drawing.Point(12, 220);
            this.grcDeleteObjects.MainView = this.gdvDeleteObjects;
            this.grcDeleteObjects.Name = "grcDeleteObjects";
            this.grcDeleteObjects.Size = new System.Drawing.Size(474, 264);
            this.grcDeleteObjects.TabIndex = 18;
            this.grcDeleteObjects.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gdvDeleteObjects});
            // 
            // gdvDeleteObjects
            // 
            this.gdvDeleteObjects.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colImage,
            this.colObjectName});
            this.gdvDeleteObjects.GridControl = this.grcDeleteObjects;
            this.gdvDeleteObjects.Name = "gdvDeleteObjects";
            this.gdvDeleteObjects.OptionsFind.AllowFindPanel = false;
            this.gdvDeleteObjects.OptionsSelection.ShowCheckBoxSelectorInGroupRow = DevExpress.Utils.DefaultBoolean.False;
            this.gdvDeleteObjects.OptionsView.ColumnAutoWidth = false;
            this.gdvDeleteObjects.OptionsView.ShowColumnHeaders = false;
            this.gdvDeleteObjects.OptionsView.ShowGroupPanel = false;
            this.gdvDeleteObjects.OptionsView.ShowHorizontalLines = DevExpress.Utils.DefaultBoolean.False;
            this.gdvDeleteObjects.OptionsView.ShowIndicator = false;
            this.gdvDeleteObjects.OptionsView.ShowVerticalLines = DevExpress.Utils.DefaultBoolean.False;
            // 
            // colImage
            // 
            this.colImage.Caption = "gridColumn1";
            this.colImage.FieldName = "Image";
            this.colImage.MinWidth = 25;
            this.colImage.Name = "colImage";
            this.colImage.Visible = true;
            this.colImage.VisibleIndex = 0;
            this.colImage.Width = 94;
            // 
            // colObjectName
            // 
            this.colObjectName.Caption = "gridColumn1";
            this.colObjectName.FieldName = "Name";
            this.colObjectName.MinWidth = 25;
            this.colObjectName.Name = "colObjectName";
            this.colObjectName.OptionsColumn.AllowEdit = false;
            this.colObjectName.OptionsColumn.AllowFocus = false;
            this.colObjectName.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.colObjectName.Visible = true;
            this.colObjectName.VisibleIndex = 1;
            this.colObjectName.Width = 94;
            // 
            // DeleteForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(498, 554);
            this.Controls.Add(this.grcDeleteObjects);
            this.Controls.Add(this.lblMessage);
            this.Controls.Add(this.lblDeleteMessageTitle);
            this.Controls.Add(this.btnNo);
            this.Controls.Add(this.btnYesSend);
            this.Controls.Add(this.pcbDeleteIcon);
            this.FormBorderEffect = DevExpress.XtraEditors.FormBorderEffect.Shadow;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DeleteForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DeleteForm";
            this.Load += new System.EventHandler(this.DeleteForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pcbDeleteIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grcDeleteObjects)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gdvDeleteObjects)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pcbDeleteIcon;
        private DevExpress.XtraEditors.SimpleButton btnNo;
        private DevExpress.XtraEditors.SimpleButton btnYesSend;
        private System.Windows.Forms.Label lblDeleteMessageTitle;
        public System.Windows.Forms.Label lblMessage;
        private DevExpress.XtraGrid.GridControl grcDeleteObjects;
        private DevExpress.XtraGrid.Views.Grid.GridView gdvDeleteObjects;
        private DevExpress.XtraGrid.Columns.GridColumn colImage;
        private DevExpress.XtraGrid.Columns.GridColumn colObjectName;
    }
}