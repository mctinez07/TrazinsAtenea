namespace TrazinsAtenea.Forms.Inventory.Group
{
    partial class GroupsForm
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
            this.pnlGroupFooter = new DevExpress.XtraEditors.PanelControl();
            this.pnlHeader = new DevExpress.XtraEditors.PanelControl();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.lblGroupTitle = new DevExpress.XtraEditors.LabelControl();
            this.spcBackArrow = new DevExpress.XtraEditors.SeparatorControl();
            this.pcbBack = new System.Windows.Forms.PictureBox();
            this.pnlSetName = new DevExpress.XtraEditors.PanelControl();
            this.lblSetName = new DevExpress.XtraEditors.LabelControl();
            this.btnGroupNew = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.pnlGroupFooter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlHeader)).BeginInit();
            this.pnlHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spcBackArrow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbBack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlSetName)).BeginInit();
            this.pnlSetName.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlGroupFooter
            // 
            this.pnlGroupFooter.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(227)))), ((int)(((byte)(243)))));
            this.pnlGroupFooter.Appearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.pnlGroupFooter.Appearance.Options.UseBackColor = true;
            this.pnlGroupFooter.Appearance.Options.UseBorderColor = true;
            this.pnlGroupFooter.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.pnlGroupFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlGroupFooter.Location = new System.Drawing.Point(0, 452);
            this.pnlGroupFooter.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Flat;
            this.pnlGroupFooter.LookAndFeel.UseDefaultLookAndFeel = false;
            this.pnlGroupFooter.Name = "pnlGroupFooter";
            this.pnlGroupFooter.Size = new System.Drawing.Size(895, 73);
            this.pnlGroupFooter.TabIndex = 0;
            // 
            // pnlHeader
            // 
            this.pnlHeader.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(227)))), ((int)(((byte)(243)))));
            this.pnlHeader.Appearance.BorderColor = System.Drawing.Color.Silver;
            this.pnlHeader.Appearance.Options.UseBackColor = true;
            this.pnlHeader.Appearance.Options.UseBorderColor = true;
            this.pnlHeader.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.pnlHeader.Controls.Add(this.simpleButton1);
            this.pnlHeader.Controls.Add(this.simpleButton2);
            this.pnlHeader.Controls.Add(this.lblGroupTitle);
            this.pnlHeader.Controls.Add(this.spcBackArrow);
            this.pnlHeader.Controls.Add(this.pcbBack);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.UltraFlat;
            this.pnlHeader.LookAndFeel.UseDefaultLookAndFeel = false;
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(895, 75);
            this.pnlHeader.TabIndex = 9;
            // 
            // simpleButton1
            // 
            this.simpleButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.simpleButton1.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(116)))), ((int)(((byte)(195)))));
            this.simpleButton1.Appearance.Font = new System.Drawing.Font("Trebuchet MS", 15.75F, System.Drawing.FontStyle.Bold);
            this.simpleButton1.Appearance.ForeColor = System.Drawing.Color.White;
            this.simpleButton1.Appearance.Options.UseBackColor = true;
            this.simpleButton1.Appearance.Options.UseFont = true;
            this.simpleButton1.Appearance.Options.UseForeColor = true;
            this.simpleButton1.Location = new System.Drawing.Point(784, 13);
            this.simpleButton1.LookAndFeel.SkinName = "DevExpress Style";
            this.simpleButton1.LookAndFeel.UseDefaultLookAndFeel = false;
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(106, 48);
            this.simpleButton1.TabIndex = 6;
            this.simpleButton1.Text = "Guardar";
            // 
            // simpleButton2
            // 
            this.simpleButton2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.simpleButton2.Appearance.Font = new System.Drawing.Font("Trebuchet MS", 15.75F, System.Drawing.FontStyle.Bold);
            this.simpleButton2.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(116)))), ((int)(((byte)(195)))));
            this.simpleButton2.Appearance.Options.UseFont = true;
            this.simpleButton2.Appearance.Options.UseForeColor = true;
            this.simpleButton2.Location = new System.Drawing.Point(704, 13);
            this.simpleButton2.LookAndFeel.SkinName = "DevExpress Style";
            this.simpleButton2.LookAndFeel.UseDefaultLookAndFeel = false;
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(74, 48);
            this.simpleButton2.TabIndex = 5;
            this.simpleButton2.Text = "Salir";
            // 
            // lblGroupTitle
            // 
            this.lblGroupTitle.Appearance.Font = new System.Drawing.Font("Trebuchet MS", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGroupTitle.Appearance.Options.UseFont = true;
            this.lblGroupTitle.ImageAlignToText = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.lblGroupTitle.ImageOptions.Alignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblGroupTitle.ImageOptions.Image = global::TrazinsAtenea.Properties.Resources.group_24x24;
            this.lblGroupTitle.Location = new System.Drawing.Point(98, 17);
            this.lblGroupTitle.Name = "lblGroupTitle";
            this.lblGroupTitle.Size = new System.Drawing.Size(304, 40);
            this.lblGroupTitle.TabIndex = 2;
            this.lblGroupTitle.Text = "Gestión de Grupos";
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
            // 
            // pnlSetName
            // 
            this.pnlSetName.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.pnlSetName.Controls.Add(this.btnGroupNew);
            this.pnlSetName.Controls.Add(this.lblSetName);
            this.pnlSetName.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlSetName.Location = new System.Drawing.Point(0, 75);
            this.pnlSetName.Name = "pnlSetName";
            this.pnlSetName.Size = new System.Drawing.Size(895, 73);
            this.pnlSetName.TabIndex = 10;
            // 
            // lblSetName
            // 
            this.lblSetName.Appearance.Font = new System.Drawing.Font("Trebuchet MS", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSetName.Appearance.Options.UseFont = true;
            this.lblSetName.Location = new System.Drawing.Point(12, 26);
            this.lblSetName.Name = "lblSetName";
            this.lblSetName.Size = new System.Drawing.Size(205, 29);
            this.lblSetName.TabIndex = 0;
            this.lblSetName.Text = "Nombre de la caja";
            // 
            // btnGroupNew
            // 
            this.btnGroupNew.Appearance.Font = new System.Drawing.Font("Trebuchet MS", 15.75F, System.Drawing.FontStyle.Bold);
            this.btnGroupNew.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(116)))), ((int)(((byte)(195)))));
            this.btnGroupNew.Appearance.Options.UseFont = true;
            this.btnGroupNew.Appearance.Options.UseForeColor = true;
            this.btnGroupNew.ImageOptions.Image = global::TrazinsAtenea.Properties.Resources.add_24x24;
            this.btnGroupNew.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnGroupNew.Location = new System.Drawing.Point(724, 12);
            this.btnGroupNew.LookAndFeel.SkinName = "DevExpress Style";
            this.btnGroupNew.LookAndFeel.UseDefaultLookAndFeel = false;
            this.btnGroupNew.Name = "btnGroupNew";
            this.btnGroupNew.Size = new System.Drawing.Size(166, 48);
            this.btnGroupNew.TabIndex = 8;
            this.btnGroupNew.Text = "Nuevo Grupo";
            // 
            // GroupsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(251)))), ((int)(((byte)(253)))));
            this.ClientSize = new System.Drawing.Size(895, 525);
            this.Controls.Add(this.pnlSetName);
            this.Controls.Add(this.pnlHeader);
            this.Controls.Add(this.pnlGroupFooter);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "GroupsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GroupForm";
            ((System.ComponentModel.ISupportInitialize)(this.pnlGroupFooter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlHeader)).EndInit();
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spcBackArrow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbBack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlSetName)).EndInit();
            this.pnlSetName.ResumeLayout(false);
            this.pnlSetName.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl pnlGroupFooter;
        private DevExpress.XtraEditors.PanelControl pnlHeader;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private DevExpress.XtraEditors.LabelControl lblGroupTitle;
        private DevExpress.XtraEditors.SeparatorControl spcBackArrow;
        private System.Windows.Forms.PictureBox pcbBack;
        private DevExpress.XtraEditors.PanelControl pnlSetName;
        private DevExpress.XtraEditors.LabelControl lblSetName;
        private DevExpress.XtraEditors.SimpleButton btnGroupNew;
    }
}