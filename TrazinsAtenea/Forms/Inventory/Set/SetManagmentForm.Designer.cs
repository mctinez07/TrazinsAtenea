namespace TrazinsAtenea.Forms.Inventory.Set
{
    partial class SetManagmentForm
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
            this.pnlHeader = new DevExpress.XtraEditors.PanelControl();
            this.btnSave = new DevExpress.XtraEditors.SimpleButton();
            this.btnExit = new DevExpress.XtraEditors.SimpleButton();
            this.lblNewSetTitle = new DevExpress.XtraEditors.LabelControl();
            this.spcBackArrow = new DevExpress.XtraEditors.SeparatorControl();
            this.pcbBack = new System.Windows.Forms.PictureBox();
            this.pnlBody = new DevExpress.XtraEditors.PanelControl();
            this.tbcSet = new DevExpress.XtraTab.XtraTabControl();
            this.xtpImageVideo = new DevExpress.XtraTab.XtraTabPage();
            this.xtpInstrumentalSet = new DevExpress.XtraTab.XtraTabPage();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.xtraTabPage1 = new DevExpress.XtraTab.XtraTabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.lblSpeciality = new DevExpress.XtraEditors.LabelControl();
            this.lblGeneralInformation = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.pnlHeader)).BeginInit();
            this.pnlHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spcBackArrow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbBack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlBody)).BeginInit();
            this.pnlBody.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbcSet)).BeginInit();
            this.tbcSet.SuspendLayout();
            this.xtpImageVideo.SuspendLayout();
            this.xtpInstrumentalSet.SuspendLayout();
            this.xtraTabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlHeader
            // 
            this.pnlHeader.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(227)))), ((int)(((byte)(243)))));
            this.pnlHeader.Appearance.BorderColor = System.Drawing.Color.Silver;
            this.pnlHeader.Appearance.Options.UseBackColor = true;
            this.pnlHeader.Appearance.Options.UseBorderColor = true;
            this.pnlHeader.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.pnlHeader.Controls.Add(this.btnSave);
            this.pnlHeader.Controls.Add(this.btnExit);
            this.pnlHeader.Controls.Add(this.lblNewSetTitle);
            this.pnlHeader.Controls.Add(this.spcBackArrow);
            this.pnlHeader.Controls.Add(this.pcbBack);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.UltraFlat;
            this.pnlHeader.LookAndFeel.UseDefaultLookAndFeel = false;
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(1384, 75);
            this.pnlHeader.TabIndex = 1;
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(116)))), ((int)(((byte)(195)))));
            this.btnSave.Appearance.Font = new System.Drawing.Font("Trebuchet MS", 15.75F, System.Drawing.FontStyle.Bold);
            this.btnSave.Appearance.ForeColor = System.Drawing.Color.White;
            this.btnSave.Appearance.Options.UseBackColor = true;
            this.btnSave.Appearance.Options.UseFont = true;
            this.btnSave.Appearance.Options.UseForeColor = true;
            this.btnSave.Location = new System.Drawing.Point(1273, 13);
            this.btnSave.LookAndFeel.SkinName = "DevExpress Style";
            this.btnSave.LookAndFeel.UseDefaultLookAndFeel = false;
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(106, 48);
            this.btnSave.TabIndex = 6;
            this.btnSave.Text = "Guardar";
            // 
            // btnExit
            // 
            this.btnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExit.Appearance.Font = new System.Drawing.Font("Trebuchet MS", 15.75F, System.Drawing.FontStyle.Bold);
            this.btnExit.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(116)))), ((int)(((byte)(195)))));
            this.btnExit.Appearance.Options.UseFont = true;
            this.btnExit.Appearance.Options.UseForeColor = true;
            this.btnExit.Location = new System.Drawing.Point(1193, 13);
            this.btnExit.LookAndFeel.SkinName = "DevExpress Style";
            this.btnExit.LookAndFeel.UseDefaultLookAndFeel = false;
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(74, 48);
            this.btnExit.TabIndex = 5;
            this.btnExit.Text = "Salir";
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lblNewSetTitle
            // 
            this.lblNewSetTitle.Appearance.Font = new System.Drawing.Font("Trebuchet MS", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNewSetTitle.Appearance.Options.UseFont = true;
            this.lblNewSetTitle.ImageAlignToText = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.lblNewSetTitle.ImageOptions.Alignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblNewSetTitle.ImageOptions.Image = global::TrazinsAtenea.Properties.Resources.caja_24x24;
            this.lblNewSetTitle.Location = new System.Drawing.Point(98, 17);
            this.lblNewSetTitle.Name = "lblNewSetTitle";
            this.lblNewSetTitle.Size = new System.Drawing.Size(197, 40);
            this.lblNewSetTitle.TabIndex = 2;
            this.lblNewSetTitle.Text = "Nueva Caja";
            // 
            // spcBackArrow
            // 
            this.spcBackArrow.Dock = System.Windows.Forms.DockStyle.Left;
            this.spcBackArrow.LineOrientation = System.Windows.Forms.Orientation.Vertical;
            this.spcBackArrow.Location = new System.Drawing.Point(77, 2);
            this.spcBackArrow.Name = "spcBackArrow";
            this.spcBackArrow.Padding = new System.Windows.Forms.Padding(0, 0, 9, 0);
            this.spcBackArrow.Size = new System.Drawing.Size(15, 71);
            this.spcBackArrow.TabIndex = 1;
            // 
            // pcbBack
            // 
            this.pcbBack.Dock = System.Windows.Forms.DockStyle.Left;
            this.pcbBack.Image = global::TrazinsAtenea.Properties.Resources.arrow_back_48x48;
            this.pcbBack.Location = new System.Drawing.Point(2, 2);
            this.pcbBack.Name = "pcbBack";
            this.pcbBack.Size = new System.Drawing.Size(75, 71);
            this.pcbBack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pcbBack.TabIndex = 0;
            this.pcbBack.TabStop = false;
            this.pcbBack.Click += new System.EventHandler(this.pcbBack_Click);
            // 
            // pnlBody
            // 
            this.pnlBody.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(227)))), ((int)(((byte)(243)))));
            this.pnlBody.Appearance.Options.UseBackColor = true;
            this.pnlBody.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.pnlBody.Controls.Add(this.tbcSet);
            this.pnlBody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlBody.Location = new System.Drawing.Point(0, 75);
            this.pnlBody.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.UltraFlat;
            this.pnlBody.LookAndFeel.UseDefaultLookAndFeel = false;
            this.pnlBody.Name = "pnlBody";
            this.pnlBody.Size = new System.Drawing.Size(1384, 681);
            this.pnlBody.TabIndex = 2;
            // 
            // tbcSet
            // 
            this.tbcSet.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(227)))), ((int)(((byte)(243)))));
            this.tbcSet.Appearance.Font = new System.Drawing.Font("Trebuchet MS", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbcSet.Appearance.Options.UseBackColor = true;
            this.tbcSet.Appearance.Options.UseFont = true;
            this.tbcSet.Appearance.Options.UseTextOptions = true;
            this.tbcSet.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.tbcSet.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Top;
            this.tbcSet.AppearancePage.Header.Font = new System.Drawing.Font("Trebuchet MS", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbcSet.AppearancePage.Header.Options.UseFont = true;
            this.tbcSet.AppearancePage.Header.Options.UseTextOptions = true;
            this.tbcSet.AppearancePage.Header.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.tbcSet.AppearancePage.Header.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.tbcSet.AppearancePage.HeaderActive.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(227)))), ((int)(((byte)(243)))));
            this.tbcSet.AppearancePage.HeaderActive.Options.UseBackColor = true;
            this.tbcSet.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbcSet.HeaderAutoFill = DevExpress.Utils.DefaultBoolean.False;
            this.tbcSet.HeaderLocation = DevExpress.XtraTab.TabHeaderLocation.Left;
            this.tbcSet.HeaderOrientation = DevExpress.XtraTab.TabOrientation.Horizontal;
            this.tbcSet.Location = new System.Drawing.Point(0, 0);
            this.tbcSet.LookAndFeel.UseDefaultLookAndFeel = false;
            this.tbcSet.Margin = new System.Windows.Forms.Padding(0);
            this.tbcSet.Name = "tbcSet";
            this.tbcSet.SelectedTabPage = this.xtpImageVideo;
            this.tbcSet.Size = new System.Drawing.Size(1384, 681);
            this.tbcSet.TabIndex = 0;
            this.tbcSet.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtpImageVideo,
            this.xtpInstrumentalSet,
            this.xtraTabPage1});
            // 
            // xtpImageVideo
            // 
            this.xtpImageVideo.Appearance.Header.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(227)))), ((int)(((byte)(243)))));
            this.xtpImageVideo.Appearance.Header.Options.UseBackColor = true;
            this.xtpImageVideo.Appearance.Header.Options.UseTextOptions = true;
            this.xtpImageVideo.Appearance.Header.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.xtpImageVideo.Controls.Add(this.button2);
            this.xtpImageVideo.Name = "xtpImageVideo";
            this.xtpImageVideo.Size = new System.Drawing.Size(1136, 679);
            this.xtpImageVideo.Text = "2 - Imágenes y videos";
            // 
            // xtpInstrumentalSet
            // 
            this.xtpInstrumentalSet.Appearance.Header.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(227)))), ((int)(((byte)(243)))));
            this.xtpInstrumentalSet.Appearance.Header.Options.UseBackColor = true;
            this.xtpInstrumentalSet.Appearance.Header.Options.UseTextOptions = true;
            this.xtpInstrumentalSet.Appearance.Header.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.xtpInstrumentalSet.Controls.Add(this.button3);
            this.xtpInstrumentalSet.Name = "xtpInstrumentalSet";
            this.xtpInstrumentalSet.Size = new System.Drawing.Size(1136, 679);
            this.xtpInstrumentalSet.Text = "3 - Instrumental";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(50, 72);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 0;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(155, 90);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 0;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // xtraTabPage1
            // 
            this.xtraTabPage1.Controls.Add(this.button1);
            this.xtraTabPage1.Controls.Add(this.lblSpeciality);
            this.xtraTabPage1.Controls.Add(this.lblGeneralInformation);
            this.xtraTabPage1.Name = "xtraTabPage1";
            this.xtraTabPage1.Size = new System.Drawing.Size(1136, 679);
            this.xtraTabPage1.Text = "xtraTabPage1";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(118, 192);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // lblSpeciality
            // 
            this.lblSpeciality.Appearance.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSpeciality.Appearance.Options.UseFont = true;
            this.lblSpeciality.Location = new System.Drawing.Point(19, 90);
            this.lblSpeciality.Name = "lblSpeciality";
            this.lblSpeciality.Size = new System.Drawing.Size(106, 24);
            this.lblSpeciality.TabIndex = 5;
            this.lblSpeciality.Text = "Especialidad";
            // 
            // lblGeneralInformation
            // 
            this.lblGeneralInformation.Appearance.Font = new System.Drawing.Font("Trebuchet MS", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGeneralInformation.Appearance.Options.UseFont = true;
            this.lblGeneralInformation.Location = new System.Drawing.Point(19, 17);
            this.lblGeneralInformation.Name = "lblGeneralInformation";
            this.lblGeneralInformation.Size = new System.Drawing.Size(241, 40);
            this.lblGeneralInformation.TabIndex = 4;
            this.lblGeneralInformation.Text = "Datos Generales";
            // 
            // SetManagmentForm
            // 
            this.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(227)))), ((int)(((byte)(243)))));
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1384, 756);
            this.Controls.Add(this.pnlBody);
            this.Controls.Add(this.pnlHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SetManagmentForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SetManagmentForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.SetManagmentForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pnlHeader)).EndInit();
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spcBackArrow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbBack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlBody)).EndInit();
            this.pnlBody.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tbcSet)).EndInit();
            this.tbcSet.ResumeLayout(false);
            this.xtpImageVideo.ResumeLayout(false);
            this.xtpInstrumentalSet.ResumeLayout(false);
            this.xtraTabPage1.ResumeLayout(false);
            this.xtraTabPage1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl pnlHeader;
        private DevExpress.XtraEditors.LabelControl lblNewSetTitle;
        private DevExpress.XtraEditors.SeparatorControl spcBackArrow;
        private System.Windows.Forms.PictureBox pcbBack;
        private DevExpress.XtraEditors.SimpleButton btnSave;
        private DevExpress.XtraEditors.SimpleButton btnExit;
        private DevExpress.XtraEditors.PanelControl pnlBody;
        private DevExpress.XtraTab.XtraTabControl tbcSet;
        private DevExpress.XtraTab.XtraTabPage xtpImageVideo;
        private DevExpress.XtraTab.XtraTabPage xtpInstrumentalSet;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage1;
        private System.Windows.Forms.Button button1;
        private DevExpress.XtraEditors.LabelControl lblSpeciality;
        private DevExpress.XtraEditors.LabelControl lblGeneralInformation;
    }
}