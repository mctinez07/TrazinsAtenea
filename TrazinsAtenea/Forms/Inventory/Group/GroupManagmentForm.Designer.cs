﻿namespace TrazinsAtenea.Forms.Inventory.Group
{
    partial class GroupManagmentForm
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
            this.pnlHeader = new DevExpress.XtraEditors.PanelControl();
            this.lblGroupNew = new DevExpress.XtraEditors.LabelControl();
            this.spcBackArrow = new DevExpress.XtraEditors.SeparatorControl();
            this.pcbBack = new System.Windows.Forms.PictureBox();
            this.btnSave = new DevExpress.XtraEditors.SimpleButton();
            this.btnExit = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtGroupName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlHeader)).BeginInit();
            this.pnlHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spcBackArrow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbBack)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(248, 201);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(415, 126);
            this.textBox1.TabIndex = 19;
            // 
            // lblGroupObservations
            // 
            this.lblGroupObservations.Appearance.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGroupObservations.Appearance.Options.UseFont = true;
            this.lblGroupObservations.Location = new System.Drawing.Point(21, 203);
            this.lblGroupObservations.Name = "lblGroupObservations";
            this.lblGroupObservations.Size = new System.Drawing.Size(204, 24);
            this.lblGroupObservations.TabIndex = 18;
            this.lblGroupObservations.Text = "Observaciones de Grupo";
            // 
            // lblGroupDescription
            // 
            this.lblGroupDescription.Appearance.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGroupDescription.Appearance.Options.UseFont = true;
            this.lblGroupDescription.Location = new System.Drawing.Point(21, 154);
            this.lblGroupDescription.Name = "lblGroupDescription";
            this.lblGroupDescription.Size = new System.Drawing.Size(180, 24);
            this.lblGroupDescription.TabIndex = 17;
            this.lblGroupDescription.Text = "Descripción de Grupo";
            // 
            // textEdit1
            // 
            this.textEdit1.Location = new System.Drawing.Point(248, 151);
            this.textEdit1.Name = "textEdit1";
            this.textEdit1.Properties.Appearance.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textEdit1.Properties.Appearance.Options.UseFont = true;
            this.textEdit1.Size = new System.Drawing.Size(415, 30);
            this.textEdit1.TabIndex = 16;
            // 
            // lblGroupName
            // 
            this.lblGroupName.Appearance.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGroupName.Appearance.Options.UseFont = true;
            this.lblGroupName.Location = new System.Drawing.Point(21, 108);
            this.lblGroupName.Name = "lblGroupName";
            this.lblGroupName.Size = new System.Drawing.Size(150, 24);
            this.lblGroupName.TabIndex = 15;
            this.lblGroupName.Text = "Nombre de Grupo";
            // 
            // txtGroupName
            // 
            this.txtGroupName.Location = new System.Drawing.Point(248, 105);
            this.txtGroupName.Name = "txtGroupName";
            this.txtGroupName.Properties.Appearance.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGroupName.Properties.Appearance.Options.UseFont = true;
            this.txtGroupName.Size = new System.Drawing.Size(415, 30);
            this.txtGroupName.TabIndex = 14;
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
            this.pnlHeader.Controls.Add(this.lblGroupNew);
            this.pnlHeader.Controls.Add(this.spcBackArrow);
            this.pnlHeader.Controls.Add(this.pcbBack);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.UltraFlat;
            this.pnlHeader.LookAndFeel.UseDefaultLookAndFeel = false;
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(675, 75);
            this.pnlHeader.TabIndex = 20;
            // 
            // lblGroupNew
            // 
            this.lblGroupNew.Appearance.Font = new System.Drawing.Font("Trebuchet MS", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGroupNew.Appearance.Options.UseFont = true;
            this.lblGroupNew.ImageAlignToText = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.lblGroupNew.ImageOptions.Alignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblGroupNew.ImageOptions.Image = global::TrazinsAtenea.Properties.Resources.group_24x24;
            this.lblGroupNew.Location = new System.Drawing.Point(98, 17);
            this.lblGroupNew.Name = "lblGroupNew";
            this.lblGroupNew.Size = new System.Drawing.Size(223, 40);
            this.lblGroupNew.TabIndex = 2;
            this.lblGroupNew.Text = "Nuevo Grupo";
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
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(116)))), ((int)(((byte)(195)))));
            this.btnSave.Appearance.Font = new System.Drawing.Font("Trebuchet MS", 15.75F, System.Drawing.FontStyle.Bold);
            this.btnSave.Appearance.ForeColor = System.Drawing.Color.White;
            this.btnSave.Appearance.Options.UseBackColor = true;
            this.btnSave.Appearance.Options.UseFont = true;
            this.btnSave.Appearance.Options.UseForeColor = true;
            this.btnSave.Location = new System.Drawing.Point(557, 13);
            this.btnSave.LookAndFeel.SkinName = "DevExpress Style";
            this.btnSave.LookAndFeel.UseDefaultLookAndFeel = false;
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(106, 48);
            this.btnSave.TabIndex = 8;
            this.btnSave.Text = "Guardar";
            // 
            // btnExit
            // 
            this.btnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExit.Appearance.Font = new System.Drawing.Font("Trebuchet MS", 15.75F, System.Drawing.FontStyle.Bold);
            this.btnExit.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(116)))), ((int)(((byte)(195)))));
            this.btnExit.Appearance.Options.UseFont = true;
            this.btnExit.Appearance.Options.UseForeColor = true;
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.Location = new System.Drawing.Point(477, 13);
            this.btnExit.LookAndFeel.SkinName = "DevExpress Style";
            this.btnExit.LookAndFeel.UseDefaultLookAndFeel = false;
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(74, 48);
            this.btnExit.TabIndex = 7;
            this.btnExit.Text = "Salir";
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // GroupManagmentForm
            // 
            this.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(251)))), ((int)(((byte)(253)))));
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(675, 343);
            this.Controls.Add(this.pnlHeader);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lblGroupObservations);
            this.Controls.Add(this.lblGroupDescription);
            this.Controls.Add(this.textEdit1);
            this.Controls.Add(this.lblGroupName);
            this.Controls.Add(this.txtGroupName);
            this.FormBorderEffect = DevExpress.XtraEditors.FormBorderEffect.Shadow;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "GroupManagmentForm";
            this.Text = "GroupManagmentForm";
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtGroupName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlHeader)).EndInit();
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spcBackArrow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbBack)).EndInit();
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
        private DevExpress.XtraEditors.PanelControl pnlHeader;
        private DevExpress.XtraEditors.LabelControl lblGroupNew;
        private DevExpress.XtraEditors.SeparatorControl spcBackArrow;
        private System.Windows.Forms.PictureBox pcbBack;
        private DevExpress.XtraEditors.SimpleButton btnSave;
        private DevExpress.XtraEditors.SimpleButton btnExit;
    }
}