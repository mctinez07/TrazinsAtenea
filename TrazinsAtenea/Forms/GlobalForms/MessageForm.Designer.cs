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
            this.SuspendLayout();
            // 
            // btnYes
            // 
            this.btnYes.Appearance.BackColor = System.Drawing.Color.Navy;
            this.btnYes.Appearance.BackColor2 = DevExpress.LookAndFeel.DXSkinColors.IconColors.White;
            this.btnYes.Appearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnYes.Appearance.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnYes.Appearance.ForeColor = System.Drawing.Color.Black;
            this.btnYes.Appearance.Options.UseBackColor = true;
            this.btnYes.Appearance.Options.UseBorderColor = true;
            this.btnYes.Appearance.Options.UseFont = true;
            this.btnYes.Appearance.Options.UseForeColor = true;
            this.btnYes.Location = new System.Drawing.Point(386, 415);
            this.btnYes.LookAndFeel.SkinMaskColor = System.Drawing.Color.White;
            this.btnYes.LookAndFeel.SkinMaskColor2 = System.Drawing.Color.White;
            this.btnYes.LookAndFeel.SkinName = "DevExpress Style";
            this.btnYes.LookAndFeel.UseDefaultLookAndFeel = false;
            this.btnYes.Name = "btnYes";
            this.btnYes.Size = new System.Drawing.Size(75, 54);
            this.btnYes.TabIndex = 0;
            this.btnYes.Text = "Sí";
            // 
            // MessageForm
            // 
            this.Appearance.BackColor = System.Drawing.Color.White;
            this.Appearance.ForeColor = System.Drawing.Color.GreenYellow;
            this.Appearance.Options.UseBackColor = true;
            this.Appearance.Options.UseFont = true;
            this.Appearance.Options.UseForeColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(473, 481);
            this.Controls.Add(this.btnYes);
            this.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.IconOptions.ShowIcon = false;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MessageForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btnYes;
    }
}