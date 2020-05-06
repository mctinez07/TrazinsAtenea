﻿namespace TrazinsAtenea.Forms.GlobalForms
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
            this.pcbAtention = new System.Windows.Forms.PictureBox();
            this.lblMessage = new System.Windows.Forms.Label();
            this.lbl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pcbAtention)).BeginInit();
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
            // 
            // pcbAtention
            // 
            this.pcbAtention.BackColor = System.Drawing.Color.White;
            this.pcbAtention.Location = new System.Drawing.Point(169, 12);
            this.pcbAtention.Name = "pcbAtention";
            this.pcbAtention.Size = new System.Drawing.Size(126, 126);
            this.pcbAtention.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbAtention.TabIndex = 15;
            this.pcbAtention.TabStop = false;
            // 
            // lblMessage
            // 
            this.lblMessage.BackColor = System.Drawing.Color.White;
            this.lblMessage.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMessage.ForeColor = System.Drawing.Color.Black;
            this.lblMessage.Location = new System.Drawing.Point(44, 196);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(363, 22);
            this.lblMessage.TabIndex = 14;
            this.lblMessage.Text = "Mensaje";
            this.lblMessage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.BackColor = System.Drawing.Color.White;
            this.lbl.Font = new System.Drawing.Font("Trebuchet MS", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl.ForeColor = System.Drawing.Color.Black;
            this.lbl.Location = new System.Drawing.Point(157, 152);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(150, 40);
            this.lbl.TabIndex = 13;
            this.lbl.Text = "Atención";
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
            this.Controls.Add(this.pcbAtention);
            this.Controls.Add(this.lblMessage);
            this.Controls.Add(this.lbl);
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
            ((System.ComponentModel.ISupportInitialize)(this.pcbAtention)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btnYes;
        private DevExpress.XtraEditors.SimpleButton btnNo;
        private System.Windows.Forms.PictureBox pcbAtention;
        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.Label lbl;
    }
}