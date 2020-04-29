using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrazinsAtenea.Controls
{
    public partial class DoubleLabelMenu : UserControl
    {
        public delegate void LabelClick(object sender, EventArgs e);
        public event LabelClick OnLabelClick;

        //Asociar los eventos click de todos los componentes.
        public DoubleLabelMenu()
        {
            InitializeComponent();

            lblUserLogin.Click += new EventHandler((sender, args) =>
            {
                OnLabelClick?.Invoke(this, null);
            });

            lblHospitalLogin.Click += new EventHandler((sender, args) =>
            {
                OnLabelClick?.Invoke(this, null);
            });
        }

        public void SetValues(string userName, string hospital)
        {
            lblHospitalLogin.Text = hospital;
            lblUserLogin.Text = userName;
            lblUserLogin.Dock = DockStyle.Top;
            lblHospitalLogin.Dock = DockStyle.Top;
            this.Size = lblUserLogin.Size;

        }
    }
}
