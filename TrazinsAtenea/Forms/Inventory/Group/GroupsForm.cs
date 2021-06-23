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
using Models.Inventory;
using TrazinsAtenea.Forms.GlobalForms;

namespace TrazinsAtenea.Forms.Inventory.Group
{
    public partial class GroupsForm : DevExpress.XtraEditors.XtraForm
    {
        private Caja Caja;

        public GroupsForm(Caja caja)
        {
            InitializeComponent();
            this.Caja = caja;            
        }

        private void GroupsForm_Load(object sender, EventArgs e)
        {            
            Multilanguage();
            lblSetName.Text = Caja.Descripcion;
            CargarDatos();
        }

        private void Multilanguage()
        {
            foreach (PanelControl panel in this.Controls)
            {
                //Traducimos los controles dentor del panel
                foreach (Control item in panel.Controls)
                {
                    if(item is SimpleButton || item is LabelControl)
                    {
                        item.Text = Engine.GetLanguageResource(item.Name);
                    }
                }
            }
        }

        private void pcbBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGroupNew_Click(object sender, EventArgs e)
        {
            GroupManagmentForm frm = new GroupManagmentForm(this)
            {
                Caja = this.Caja
            };

            frm.UpdateEventHandler += Agr_Prod_UpdateEventHandler;

            frm.ShowDialog();
        }        

        private void btnModify_Click(object sender, EventArgs e)
        {
            CajasGrupo selected = gdvGroups.GetRow(gdvGroups.FocusedRowHandle) as CajasGrupo;
            GroupManagmentForm frm = new GroupManagmentForm(selected, this);
            frm.Caja = this.Caja;
            frm.UpdateEventHandler += Agr_Prod_UpdateEventHandler;
            frm.ShowDialog();
        }

        private void CargarDatos()
        {
            var res = BaseModelClient.Instance.Service.CajasGrupos_Select_List(new CajasGrupo() { CajaId = Caja.CajaId });
            dgcGroups.DataSource = res;
        }

        private void Agr_Prod_UpdateEventHandler(object sender, GroupManagmentForm.UpdateEventArgs args)
        {
            CargarDatos();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            CajasGrupo selected = gdvGroups.GetRow(gdvGroups.FocusedRowHandle) as CajasGrupo;
            DeleteForm deleteForm = new DeleteForm();

        }
    }
}