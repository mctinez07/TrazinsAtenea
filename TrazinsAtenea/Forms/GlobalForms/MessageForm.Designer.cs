namespace TrazinsAtenea.Forms.GlobalForms
{
    partial class MessageForm
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
            this.btnYes = new DevExpress.XtraEditors.SimpleButton();
            this.btnNo = new DevExpress.XtraEditors.SimpleButton();
            this.lblMessage = new System.Windows.Forms.Label();
            this.lblMessageTitle = new System.Windows.Forms.Label();
            this.btnAccept = new DevExpress.XtraEditors.SimpleButton();
            this.pcbMessageIcon = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pcbMessageIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // btnYes
            // 
            this.btnYes.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(116)))), ((int)(((byte)(195)))));
            this.btnYes.Appearance.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnYes.Appearance.ForeColor = System.Drawing.Color.Black;
            this.btnYes.Appearance.Options.UseBackColor = true;
            this.btnYes.Appearance.Options.UseFont = true;
            this.btnYes.Appearance.Options.UseForeColor = true;
            this.btnYes.Location = new System.Drawing.Point(355, 415);
            this.btnYes.LookAndFeel.SkinMaskColor = System.Drawing.Color.White;
            this.btnYes.LookAndFeel.SkinMaskColor2 = System.Drawing.Color.White;
            this.btnYes.LookAndFeel.SkinName = "DevExpress Style";
            this.btnYes.LookAndFeel.UseDefaultLookAndFeel = false;
            this.btnYes.Name = "btnYes";
            this.btnYes.Size = new System.Drawing.Size(106, 52);
            this.btnYes.TabIndex = 0;
            this.btnYes.Text = "Sí";
            this.btnYes.Click += new System.EventHandler(this.btnYes_Click);
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
            this.btnNo.Location = new System.Drawing.Point(12, 415);
            this.btnNo.LookAndFeel.SkinMaskColor = System.Drawing.Color.White;
            this.btnNo.LookAndFeel.SkinMaskColor2 = System.Drawing.Color.White;
            this.btnNo.LookAndFeel.SkinName = "DevExpress Style";
            this.btnNo.LookAndFeel.UseDefaultLookAndFeel = false;
            this.btnNo.Name = "btnNo";
            this.btnNo.Size = new System.Drawing.Size(106, 52);
            this.btnNo.TabIndex = 1;
            this.btnNo.Text = "No";
            this.btnNo.Click += new System.EventHandler(this.btnNo_Click);
            // 
            // lblMessage
            // 
            this.lblMessage.BackColor = System.Drawing.Color.White;
            this.lblMessage.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMessage.ForeColor = System.Drawing.Color.Black;
            this.lblMessage.Location = new System.Drawing.Point(55, 228);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(363, 22);
            this.lblMessage.TabIndex = 14;
            this.lblMessage.Text = "Mensaje";
            this.lblMessage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblMessageTitle
            // 
            this.lblMessageTitle.AutoSize = true;
            this.lblMessageTitle.BackColor = System.Drawing.Color.White;
            this.lblMessageTitle.Font = new System.Drawing.Font("Trebuchet MS", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMessageTitle.ForeColor = System.Drawing.Color.Black;
            this.lblMessageTitle.Location = new System.Drawing.Point(161, 184);
            this.lblMessageTitle.Name = "lblMessageTitle";
            this.lblMessageTitle.Size = new System.Drawing.Size(150, 40);
            this.lblMessageTitle.TabIndex = 13;
            this.lblMessageTitle.Text = "Atención";
            // 
            // btnAccept
            // 
            this.btnAccept.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(116)))), ((int)(((byte)(195)))));
            this.btnAccept.Appearance.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAccept.Appearance.ForeColor = System.Drawing.Color.Black;
            this.btnAccept.Appearance.Options.UseBackColor = true;
            this.btnAccept.Appearance.Options.UseFont = true;
            this.btnAccept.Appearance.Options.UseForeColor = true;
            this.btnAccept.Location = new System.Drawing.Point(243, 415);
            this.btnAccept.LookAndFeel.SkinMaskColor = System.Drawing.Color.White;
            this.btnAccept.LookAndFeel.SkinMaskColor2 = System.Drawing.Color.White;
            this.btnAccept.LookAndFeel.SkinName = "DevExpress Style";
            this.btnAccept.LookAndFeel.UseDefaultLookAndFeel = false;
            this.btnAccept.Name = "btnAccept";
            this.btnAccept.Size = new System.Drawing.Size(106, 52);
            this.btnAccept.TabIndex = 16;
            this.btnAccept.Text = "Aceptar";
            this.btnAccept.Click += new System.EventHandler(this.btnAccept_Click);
            // 
            // pcbMessageIcon
            // 
            this.pcbMessageIcon.BackColor = System.Drawing.Color.White;
            this.pcbMessageIcon.Image = global::TrazinsAtenea.Properties.Resources.info_48x48;
            this.pcbMessageIcon.Location = new System.Drawing.Point(180, 44);
            this.pcbMessageIcon.Name = "pcbMessageIcon";
            this.pcbMessageIcon.Size = new System.Drawing.Size(126, 126);
            this.pcbMessageIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbMessageIcon.TabIndex = 15;
            this.pcbMessageIcon.TabStop = false;
            // 
            // MessageForm
            // 
            this.Appearance.BackColor = System.Drawing.Color.White;
            this.Appearance.ForeColor = System.Drawing.Color.Black;
            this.Appearance.Options.UseBackColor = true;
            this.Appearance.Options.UseFont = true;
            this.Appearance.Options.UseForeColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(473, 481);
            this.Controls.Add(this.btnAccept);
            this.Controls.Add(this.pcbMessageIcon);
            this.Controls.Add(this.lblMessage);
            this.Controls.Add(this.lblMessageTitle);
            this.Controls.Add(this.btnNo);
            this.Controls.Add(this.btnYes);
            this.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.IconOptions.ShowIcon = false;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MessageForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.MessageForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pcbMessageIcon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btnYes;
        private DevExpress.XtraEditors.SimpleButton btnNo;
        private System.Windows.Forms.PictureBox pcbMessageIcon;
        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.Label lblMessageTitle;
        private DevExpress.XtraEditors.SimpleButton btnAccept;
    }
}