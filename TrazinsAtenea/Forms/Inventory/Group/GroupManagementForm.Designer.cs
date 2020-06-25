namespace TrazinsAtenea.Forms.Inventory.Group
{
    partial class GroupManagementForm
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblGroupObservations = new DevExpress.XtraEditors.LabelControl();
            this.lblGroupDescription = new DevExpress.XtraEditors.LabelControl();
            this.textEdit1 = new DevExpress.XtraEditors.TextEdit();
            this.lblGroupName = new DevExpress.XtraEditors.LabelControl();
            this.txtGroupName = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtGroupName.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(325, 210);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(378, 126);
            this.textBox1.TabIndex = 13;
            // 
            // lblGroupObservations
            // 
            this.lblGroupObservations.Appearance.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGroupObservations.Appearance.Options.UseFont = true;
            this.lblGroupObservations.Location = new System.Drawing.Point(98, 212);
            this.lblGroupObservations.Name = "lblGroupObservations";
            this.lblGroupObservations.Size = new System.Drawing.Size(204, 24);
            this.lblGroupObservations.TabIndex = 12;
            this.lblGroupObservations.Text = "Observaciones de Grupo";
            // 
            // lblGroupDescription
            // 
            this.lblGroupDescription.Appearance.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGroupDescription.Appearance.Options.UseFont = true;
            this.lblGroupDescription.Location = new System.Drawing.Point(98, 163);
            this.lblGroupDescription.Name = "lblGroupDescription";
            this.lblGroupDescription.Size = new System.Drawing.Size(180, 24);
            this.lblGroupDescription.TabIndex = 11;
            this.lblGroupDescription.Text = "Descripción de Grupo";
            // 
            // textEdit1
            // 
            this.textEdit1.Location = new System.Drawing.Point(325, 160);
            this.textEdit1.Name = "textEdit1";
            this.textEdit1.Properties.Appearance.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textEdit1.Properties.Appearance.Options.UseFont = true;
            this.textEdit1.Size = new System.Drawing.Size(378, 30);
            this.textEdit1.TabIndex = 10;
            // 
            // lblGroupName
            // 
            this.lblGroupName.Appearance.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGroupName.Appearance.Options.UseFont = true;
            this.lblGroupName.Location = new System.Drawing.Point(98, 117);
            this.lblGroupName.Name = "lblGroupName";
            this.lblGroupName.Size = new System.Drawing.Size(150, 24);
            this.lblGroupName.TabIndex = 9;
            this.lblGroupName.Text = "Nombre de Grupo";
            // 
            // txtGroupName
            // 
            this.txtGroupName.Location = new System.Drawing.Point(325, 114);
            this.txtGroupName.Name = "txtGroupName";
            this.txtGroupName.Properties.Appearance.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGroupName.Properties.Appearance.Options.UseFont = true;
            this.txtGroupName.Size = new System.Drawing.Size(378, 30);
            this.txtGroupName.TabIndex = 8;
            // 
            // GroupManagementForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lblGroupObservations);
            this.Controls.Add(this.lblGroupDescription);
            this.Controls.Add(this.textEdit1);
            this.Controls.Add(this.lblGroupName);
            this.Controls.Add(this.txtGroupName);
            this.Name = "GroupManagementForm";
            this.Text = "GroupManagementForm";
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtGroupName.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private DevExpress.XtraEditors.LabelControl lblGroupObservations;
        private DevExpress.XtraEditors.LabelControl lblGroupDescription;
        private DevExpress.XtraEditors.TextEdit textEdit1;
        private DevExpress.XtraEditors.LabelControl lblGroupName;
        private DevExpress.XtraEditors.TextEdit txtGroupName;
    }
}