using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using TrazinsAtenea.GlobalEngine;

namespace TrazinsAtenea.Forms.GlobalForms
{
    public partial class DeleteForm : DevExpress.XtraEditors.XtraForm
    {
        public DeleteForm()
        {
            InitializeComponent();
        }

        private void DeleteForm_Load(object sender, EventArgs e)
        {
            Multilanguage();
        }

        private void Multilanguage()
        {
            foreach (Control item in this.Controls)
            {
                Engine.GetLanguageResource(item.Name);
            }
        }

        public void GetElement<T>(T model, string objectName)
        {
            var a = model.GetType().Name;

            DeleteObject deleteObject = new DeleteObject();
            deleteObject.Name = objectName;
            if (a.Equals("CajasGrupos"))
            {
                deleteObject.Image = Properties.Resources.group_18x18;
                
            }

            gdvDeleteObjects.DataSource = deleteObject;
        }

        public class DeleteObject
        {
            public string Name { get; set; }
            public Image Image { get; set; }
        }
    }
}