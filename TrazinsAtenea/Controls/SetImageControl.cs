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
    public partial class SetImageControl : UserControl
    {
        public Models.Inventory.CajaImagen CajaImagen;

        public SetImageControl()
        {
            InitializeComponent();
            this.CajaImagen = new Models.Inventory.CajaImagen();
        }
    }
}
