namespace TrazinsAtenea.Forms.Inventory.Box
{
    partial class BoxManagmentForm
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
            this.btnExit = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.lblNewBoxTitle = new DevExpress.XtraEditors.LabelControl();
            this.spcBackArrow = new DevExpress.XtraEditors.SeparatorControl();
            this.pcbBack = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pnlHeader)).BeginInit();
            this.pnlHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spcBackArrow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbBack)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlHeader
            // 
            this.pnlHeader.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(227)))), ((int)(((byte)(243)))));
            this.pnlHeader.Appearance.BorderColor = System.Drawing.Color.Silver;
            this.pnlHeader.Appearance.Options.UseBackColor = true;
            this.pnlHeader.Appearance.Options.UseBorderColor = true;
            this.pnlHeader.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.pnlHeader.Controls.Add(this.btnExit);
            this.pnlHeader.Controls.Add(this.btnSave);
            this.pnlHeader.Controls.Add(this.lblNewBoxTitle);
            this.pnlHeader.Controls.Add(this.spcBackArrow);
            this.pnlHeader.Controls.Add(this.pcbBack);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.UltraFlat;
            this.pnlHeader.LookAndFeel.UseDefaultLookAndFeel = false;
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(1384, 75);
            this.pnlHeader.TabIndex = 0;
            // 
            // btnExit
            // 
            this.btnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExit.BackColor = System.Drawing.Color.White;
            this.btnExit.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(116)))), ((int)(((byte)(195)))));
            this.btnExit.FlatAppearance.BorderSize = 2;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Trebuchet MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(116)))), ((int)(((byte)(195)))));
            this.btnExit.Location = new System.Drawing.Point(1193, 13);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(74, 48);
            this.btnExit.TabIndex = 4;
            this.btnExit.Text = "Salir";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(116)))), ((int)(((byte)(195)))));
            this.btnSave.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(116)))), ((int)(((byte)(195)))));
            this.btnSave.FlatAppearance.BorderSize = 2;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Trebuchet MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(1273, 13);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(106, 48);
            this.btnSave.TabIndex = 3;
            this.btnSave.Text = "Guardar";
            this.btnSave.UseVisualStyleBackColor = false;
            // 
            // lblNewBoxTitle
            // 
            this.lblNewBoxTitle.Appearance.Font = new System.Drawing.Font("Trebuchet MS", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNewBoxTitle.Appearance.Options.UseFont = true;
            this.lblNewBoxTitle.ImageAlignToText = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.lblNewBoxTitle.ImageOptions.Alignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblNewBoxTitle.ImageOptions.Image = global::TrazinsAtenea.Properties.Resources.caja_24x24;
            this.lblNewBoxTitle.Location = new System.Drawing.Point(98, 17);
            this.lblNewBoxTitle.Name = "lblNewBoxTitle";
            this.lblNewBoxTitle.Size = new System.Drawing.Size(197, 40);
            this.lblNewBoxTitle.TabIndex = 2;
            this.lblNewBoxTitle.Text = "Nueva Caja";
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
            // BoxManagmentForm
            // 
            this.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(227)))), ((int)(((byte)(243)))));
            this.Appearance.Options.UseBackColor = true;
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1384, 756);
            this.Controls.Add(this.pnlHeader);
            this.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "BoxManagmentForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BoxManagmentForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.BoxManagmentForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pnlHeader)).EndInit();
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spcBackArrow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbBack)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl pnlHeader;
        private System.Windows.Forms.PictureBox pcbBack;
        private DevExpress.XtraEditors.SeparatorControl spcBackArrow;
        private DevExpress.XtraEditors.LabelControl lblNewBoxTitle;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnSave;
    }
}