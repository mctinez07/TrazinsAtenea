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
using DevExpress.XtraLayout;

namespace TrazinsAtenea.Forms.Inventory.Set
{
    public partial class SetManagmentForm : DevExpress.XtraEditors.XtraForm
    {
        public SetManagmentForm()
        {
            InitializeComponent();
        }

        private void SetManagmentForm_Load(object sender, EventArgs e)
        {
            MultilanguageFormat();
        }

        private void MultilanguageFormat()
        {
            try
            {
                foreach (Control item in this.Controls)
                {
                    if (item is PanelControl)
                    {
                        foreach (Control subItem in item.Controls)
                        {
                            if (subItem is XtraTabControl)
                            {
                                foreach (XtraTabPage tb in subItem.Controls)
                                {
                                    //Traducir Cabeceras
                                    tb.Text = Engine.GetLanguageResource(tb.Name);
                                    foreach (Control control in tb.Controls)
                                    {
                                        //Traducimos los controles labels y buttons
                                        if (control is SimpleButton || control is LabelControl)
                                            control.Text = Engine.GetLanguageResource(control.Name);
                                    }
                                }
                            }
                            //Traducir elementos de los paneles
                            subItem.Text = Engine.GetLanguageResource(subItem.Name);
                        }
                    }
                };

                //Traducimos los controles del tableLayoutPrincipal
                foreach (LayoutControlItem layoutControl in Root.Items)
                {
                    layoutControl.Text = Engine.GetLanguageResource(layoutControl.Name);
                    if (layoutControl.Control is LabelControl || layoutControl.Control is SimpleButton)
                        layoutControl.Control.Text = Engine.GetLanguageResource(layoutControl.Control.Name);
                }

                //Traducir el subroot layout
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error en MultilanguageFormat: " + ex.Message);  
            }
            
        }

        private void pcbBack_Click(object sender, EventArgs e)
        {
            this.Close();
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