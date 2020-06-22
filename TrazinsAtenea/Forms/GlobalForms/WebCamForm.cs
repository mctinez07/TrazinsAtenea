using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TrazinsAtenea.GlobalEngine;

namespace TrazinsAtenea.Forms.GlobalForms
{
    public partial class WebCamForm : Form
    {
        //Campo donde almacenamos la imagen
        private Image _imageData;

        public Image ImageData
        {
            get { return _imageData; }
        }

        public WebCamForm()
        {
            InitializeComponent();
            Traduce();
        }

        private void WebCamForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            wbcImage.Stop();
            
        }

        private void Traduce()
        {
            foreach (Control item in pnlCameraControls.Controls)
            {
                item.Text = Engine.GetLanguageResource(item.Name);
            }
        }

        private void btnCapture_Click(object sender, EventArgs e)
        {
            Image capturedImage = wbcImage.TakeSnapshot();
            pcbImage.Image = capturedImage;
            _imageData = capturedImage;
        }
    }
}
