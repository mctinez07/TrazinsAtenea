namespace TrazinsAtenea.Forms.GlobalForms
{
    partial class WebCamForm
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
            this.wbcImage = new DevExpress.XtraEditors.Camera.CameraControl();
            this.pcbImage = new System.Windows.Forms.PictureBox();
            this.btnAccept = new DevExpress.XtraEditors.SimpleButton();
            this.btnExit = new DevExpress.XtraEditors.SimpleButton();
            this.btnCapture = new DevExpress.XtraEditors.SimpleButton();
            this.pnlCameraControls = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pcbImage)).BeginInit();
            this.pnlCameraControls.SuspendLayout();
            this.SuspendLayout();
            // 
            // wbcImage
            // 
            this.wbcImage.Location = new System.Drawing.Point(12, 12);
            this.wbcImage.Name = "wbcImage";
            this.wbcImage.Size = new System.Drawing.Size(400, 250);
            this.wbcImage.TabIndex = 0;
            this.wbcImage.Text = "cameraControl1";
            // 
            // pcbImage
            // 
            this.pcbImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pcbImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pcbImage.Location = new System.Drawing.Point(446, 12);
            this.pcbImage.Name = "pcbImage";
            this.pcbImage.Size = new System.Drawing.Size(400, 250);
            this.pcbImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbImage.TabIndex = 4;
            this.pcbImage.TabStop = false;
            // 
            // btnAccept
            // 
            this.btnAccept.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAccept.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(116)))), ((int)(((byte)(195)))));
            this.btnAccept.Appearance.Font = new System.Drawing.Font("Trebuchet MS", 15.75F, System.Drawing.FontStyle.Bold);
            this.btnAccept.Appearance.ForeColor = System.Drawing.Color.White;
            this.btnAccept.Appearance.Options.UseBackColor = true;
            this.btnAccept.Appearance.Options.UseFont = true;
            this.btnAccept.Appearance.Options.UseForeColor = true;
            this.btnAccept.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnAccept.Location = new System.Drawing.Point(662, 18);
            this.btnAccept.LookAndFeel.SkinName = "DevExpress Style";
            this.btnAccept.LookAndFeel.UseDefaultLookAndFeel = false;
            this.btnAccept.Name = "btnAccept";
            this.btnAccept.Size = new System.Drawing.Size(94, 48);
            this.btnAccept.TabIndex = 7;
            this.btnAccept.Text = "Aceptar";
            // 
            // btnExit
            // 
            this.btnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExit.Appearance.Font = new System.Drawing.Font("Trebuchet MS", 15.75F, System.Drawing.FontStyle.Bold);
            this.btnExit.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(116)))), ((int)(((byte)(195)))));
            this.btnExit.Appearance.Options.UseFont = true;
            this.btnExit.Appearance.Options.UseForeColor = true;
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.Location = new System.Drawing.Point(772, 18);
            this.btnExit.LookAndFeel.SkinName = "DevExpress Style";
            this.btnExit.LookAndFeel.UseDefaultLookAndFeel = false;
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(74, 48);
            this.btnExit.TabIndex = 8;
            this.btnExit.Text = "Salir";
            // 
            // btnCapture
            // 
            this.btnCapture.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCapture.Appearance.Font = new System.Drawing.Font("Trebuchet MS", 15.75F, System.Drawing.FontStyle.Bold);
            this.btnCapture.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(116)))), ((int)(((byte)(195)))));
            this.btnCapture.Appearance.Options.UseFont = true;
            this.btnCapture.Appearance.Options.UseForeColor = true;
            this.btnCapture.Location = new System.Drawing.Point(305, 18);
            this.btnCapture.LookAndFeel.SkinName = "DevExpress Style";
            this.btnCapture.LookAndFeel.UseDefaultLookAndFeel = false;
            this.btnCapture.Name = "btnCapture";
            this.btnCapture.Size = new System.Drawing.Size(107, 48);
            this.btnCapture.TabIndex = 9;
            this.btnCapture.Text = "Capturar";
            this.btnCapture.Click += new System.EventHandler(this.btnCapture_Click);
            // 
            // pnlCameraControls
            // 
            this.pnlCameraControls.Controls.Add(this.btnExit);
            this.pnlCameraControls.Controls.Add(this.btnCapture);
            this.pnlCameraControls.Controls.Add(this.btnAccept);
            this.pnlCameraControls.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlCameraControls.Location = new System.Drawing.Point(0, 268);
            this.pnlCameraControls.Name = "pnlCameraControls";
            this.pnlCameraControls.Size = new System.Drawing.Size(860, 78);
            this.pnlCameraControls.TabIndex = 10;
            // 
            // WebCamForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(227)))), ((int)(((byte)(243)))));
            this.ClientSize = new System.Drawing.Size(860, 346);
            this.Controls.Add(this.pcbImage);
            this.Controls.Add(this.wbcImage);
            this.Controls.Add(this.pnlCameraControls);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "WebCamForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "WebCamForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.WebCamForm_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.pcbImage)).EndInit();
            this.pnlCameraControls.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.Camera.CameraControl wbcImage;
        private System.Windows.Forms.PictureBox pcbImage;
        private DevExpress.XtraEditors.SimpleButton btnAccept;
        private DevExpress.XtraEditors.SimpleButton btnExit;
        private DevExpress.XtraEditors.SimpleButton btnCapture;
        private System.Windows.Forms.Panel pnlCameraControls;
    }
}