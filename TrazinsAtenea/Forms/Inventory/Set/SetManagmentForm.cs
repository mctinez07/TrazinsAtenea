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
using TrazinsAtenea.Forms.GlobalForms;
using TrazinsAtenea.GlobalEngine;
using DevExpress.XtraTab;

namespace TrazinsAtenea.Forms.Inventory.Set
{
    public partial class SetManagmentForm : DevExpress.XtraEditors.XtraForm
    {
        public SetManagmentForm()
        {
            InitializeComponent();
        }

        private void MultilanguageFormat()
        {
            
            foreach (Control item in this.Controls)
            {
                if(item is PanelControl)
                {
                    foreach (Control subItem in item.Controls)
                    {
                        if(subItem is XtraTabControl)
                        {
                            foreach (XtraTabPage tb in subItem.Controls)
                            {
                                //Traducir Cabeceras
                                tb.Text = Engine.GetLanguageResource(tb.Name);
                                foreach (LabelControl lbl in tb.Controls)
                                {
                                    //Traducimos los labels
                                    lbl.Text = Engine.GetLanguageResource(lbl.Name);
                                }
                            }
                        }

                        //Traducir elementos de los paneles
                        subItem.Text = Engine.GetLanguageResource(subItem.Name);
                    }
                }
                
            };
        }

        private void pcbBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SetManagmentForm_Load(object sender, EventArgs e)
        {
            //MultilanguageFormat();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            MessageForm frm = new MessageForm(190);
            frm.ShowDialog();

            if(frm.DialogResult == DialogResult.Yes)
            {
                this.Close();
            }
        }       

    }
}