namespace TrazinsAtenea.Controls
{
    partial class DoubleLabelMenu
    {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblHospitalLogin = new DevExpress.XtraEditors.LabelControl();
            this.lblUserLogin = new DevExpress.XtraEditors.LabelControl();
            this.SuspendLayout();
            // 
            // lblHospitalLogin
            // 
            this.lblHospitalLogin.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblHospitalLogin.Appearance.Font = new System.Drawing.Font("Trebuchet MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHospitalLogin.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(76)))), ((int)(((byte)(90)))));
            this.lblHospitalLogin.Appearance.Options.UseFont = true;
            this.lblHospitalLogin.Appearance.Options.UseForeColor = true;
            this.lblHospitalLogin.Location = new System.Drawing.Point(3, 25);
            this.lblHospitalLogin.Name = "lblHospitalLogin";
            this.lblHospitalLogin.Size = new System.Drawing.Size(126, 27);
            this.lblHospitalLogin.TabIndex = 7;
            this.lblHospitalLogin.Text = "labelControl1";
            // 
            // lblUserLogin
            // 
            this.lblUserLogin.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblUserLogin.Appearance.Font = new System.Drawing.Font("Trebuchet MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserLogin.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(76)))), ((int)(((byte)(90)))));
            this.lblUserLogin.Appearance.Options.UseFont = true;
            this.lblUserLogin.Appearance.Options.UseForeColor = true;
            this.lblUserLogin.ImageAlignToText = DevExpress.XtraEditors.ImageAlignToText.RightCenter;
            this.lblUserLogin.ImageOptions.Alignment = System.Drawing.ContentAlignment.MiddleRight;
            this.lblUserLogin.ImageOptions.Image = global::TrazinsAtenea.Properties.Resources.ic_arrow_drop_down;
            this.lblUserLogin.Location = new System.Drawing.Point(3, 0);
            this.lblUserLogin.Name = "lblUserLogin";
            this.lblUserLogin.Size = new System.Drawing.Size(147, 27);
            this.lblUserLogin.TabIndex = 6;
            this.lblUserLogin.Text = "labelControl1";
            // 
            // DoubleLabelMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblHospitalLogin);
            this.Controls.Add(this.lblUserLogin);
            this.Name = "DoubleLabelMenu";
            this.Size = new System.Drawing.Size(155, 52);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl lblHospitalLogin;
        private DevExpress.XtraEditors.LabelControl lblUserLogin;
    }
}
