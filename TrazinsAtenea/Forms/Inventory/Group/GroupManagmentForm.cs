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
using System.Reflection;

namespace TrazinsAtenea.Forms.Inventory.Group
{
    public partial class GroupManagmentForm : DevExpress.XtraEditors.XtraForm
    {
        public Caja Caja;
        private CajasGrupo CajasGrupoMain = new CajasGrupo();
        private EnumOperationType OperationType;

        public GroupManagmentForm()
        {
            InitializeComponent();
            this.OperationType = EnumOperationType.New;
        }

        public GroupManagmentForm(CajasGrupo cajasGrupo)
        {
            InitializeComponent();
            this.CajasGrupoMain = cajasGrupo;
            this.OperationType = EnumOperationType.Modify;
        }

        private void GroupManagmentForm_Load(object sender, EventArgs e)
        {
            try
            {
                //Traducir
                Multilanguage();

                SetFormLocation();

                BindigControls();
            }
            catch (Exception ex)
            {
                ErrorMessage.ShowErrorMessage(MethodBase.GetCurrentMethod().Name, ex.Message);                
            }
            
        }

        private void SetFormLocation()
        {
            Screen screen = Screen.FromPoint(Location);
            Location = new Point(screen.WorkingArea.Left, screen.WorkingArea.Top);
        }

        private void BindigControls()
        {
            Engine.BindingControlProperty(TxtGroupName, "NomGrupo", CajasGrupoMain);
            Engine.BindingControlProperty(TxtGroupDes, "DesGrupo", CajasGrupoMain);
            Engine.BindingControlProperty(TxtGroupRemarks, "Observaciones", CajasGrupoMain);
        }

        private void Multilanguage()
        {
            foreach (Control item in this.Controls)
            {
                if(item is LabelControl)
                {
                    Engine.GetLanguageResource(item.Name);
                }
            }
        }

        private void pcbBack_Click(object sender, EventArgs e)
        {            
            this.Close();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult = Engine.OpenMessageForm(190);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                CajasGrupoMain.CajaId = this.Caja.CajaId;
                switch (OperationType)
                {
                    case EnumOperationType.New:
                        BaseModelClient.Instance.Service.CajasGrupos_Insert(CajasGrupoMain);
                        break;
                    case EnumOperationType.Modify:
                        BaseModelClient.Instance.Service.CajasGrupos_Update(CajasGrupoMain);
                        break;
                    case EnumOperationType.Delete:
                        break;
                    default:
                        break;
                }
                
                
            }
            catch (Exception ex)
            {
                ErrorMessage.ShowErrorMessage(MethodBase.GetCurrentMethod().Name, ex.Message);
            }
        }

        
    }
}