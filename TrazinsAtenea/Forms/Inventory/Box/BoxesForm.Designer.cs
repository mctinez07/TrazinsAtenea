namespace TrazinsAtenea.Forms.Inventory.Box
{
    partial class BoxesForm
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
            this.gdcBoxes = new DevExpress.XtraGrid.GridControl();
            this.gdvBoxes = new DevExpress.XtraGrid.Views.Grid.GridView();
            ((System.ComponentModel.ISupportInitialize)(this.gdcBoxes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gdvBoxes)).BeginInit();
            this.SuspendLayout();
            // 
            // gdcBoxes
            // 
            this.gdcBoxes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gdcBoxes.Location = new System.Drawing.Point(0, 0);
            this.gdcBoxes.MainView = this.gdvBoxes;
            this.gdcBoxes.Name = "gdcBoxes";
            this.gdcBoxes.Size = new System.Drawing.Size(1384, 756);
            this.gdcBoxes.TabIndex = 0;
            this.gdcBoxes.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gdvBoxes});
            // 
            // gdvBoxes
            // 
            this.gdvBoxes.GridControl = this.gdcBoxes;
            this.gdvBoxes.Name = "gdvBoxes";
            // 
            // BoxesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1384, 756);
            this.Controls.Add(this.gdcBoxes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "BoxesForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BoxesForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.gdcBoxes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gdvBoxes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gdcBoxes;
        private DevExpress.XtraGrid.Views.Grid.GridView gdvBoxes;
    }
}