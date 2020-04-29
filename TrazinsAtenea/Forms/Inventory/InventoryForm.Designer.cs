namespace TrazinsAtenea.Forms.Inventory
{
    partial class InventoryForm
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
            this.pnlInventoryMenu = new DevExpress.XtraEditors.PanelControl();
            this.pnlInventoryBody = new DevExpress.XtraEditors.PanelControl();
            this.btnCajas = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.pnlInventoryMenu)).BeginInit();
            this.pnlInventoryMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pnlInventoryBody)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlInventoryMenu
            // 
            this.pnlInventoryMenu.Controls.Add(this.btnCajas);
            this.pnlInventoryMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlInventoryMenu.Location = new System.Drawing.Point(0, 0);
            this.pnlInventoryMenu.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.UltraFlat;
            this.pnlInventoryMenu.LookAndFeel.UseDefaultLookAndFeel = false;
            this.pnlInventoryMenu.Name = "pnlInventoryMenu";
            this.pnlInventoryMenu.Size = new System.Drawing.Size(1384, 60);
            this.pnlInventoryMenu.TabIndex = 0;
            // 
            // pnlInventoryBody
            // 
            this.pnlInventoryBody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlInventoryBody.Location = new System.Drawing.Point(0, 60);
            this.pnlInventoryBody.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.UltraFlat;
            this.pnlInventoryBody.LookAndFeel.UseDefaultLookAndFeel = false;
            this.pnlInventoryBody.Name = "pnlInventoryBody";
            this.pnlInventoryBody.Size = new System.Drawing.Size(1384, 696);
            this.pnlInventoryBody.TabIndex = 1;
            // 
            // btnCajas
            // 
            this.btnCajas.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnCajas.Location = new System.Drawing.Point(3, 3);
            this.btnCajas.Name = "btnCajas";
            this.btnCajas.Size = new System.Drawing.Size(112, 54);
            this.btnCajas.TabIndex = 0;
            this.btnCajas.Text = "Cajas";
            // 
            // InventoryForm
            // 
            this.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(251)))), ((int)(((byte)(253)))));
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1384, 756);
            this.Controls.Add(this.pnlInventoryBody);
            this.Controls.Add(this.pnlInventoryMenu);
            this.FormBorderEffect = DevExpress.XtraEditors.FormBorderEffect.None;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "InventoryForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "InventoryForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.pnlInventoryMenu)).EndInit();
            this.pnlInventoryMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pnlInventoryBody)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl pnlInventoryMenu;
        private DevExpress.XtraEditors.PanelControl pnlInventoryBody;
        private DevExpress.XtraEditors.SimpleButton btnCajas;
    }
}