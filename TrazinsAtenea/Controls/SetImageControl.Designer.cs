namespace TrazinsAtenea.Controls
{
    partial class SetImageControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ImagePictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.ImagePictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // ImagePictureBox
            // 
            this.ImagePictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ImagePictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ImagePictureBox.Location = new System.Drawing.Point(0, 0);
            this.ImagePictureBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ImagePictureBox.Name = "ImagePictureBox";
            this.ImagePictureBox.Size = new System.Drawing.Size(373, 189);
            this.ImagePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ImagePictureBox.TabIndex = 1;
            this.ImagePictureBox.TabStop = false;
            // 
            // SetImageControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ImagePictureBox);
            this.Name = "SetImageControl";
            this.Size = new System.Drawing.Size(373, 189);
            ((System.ComponentModel.ISupportInitialize)(this.ImagePictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.PictureBox ImagePictureBox;
    }
}
