using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using TrazinsAtenea.Forms.GlobalForms;
using TrazinsAtenea.GlobalEngine;
using DevExpress.XtraTab;
using DevExpress.XtraLayout;
using TrazinsAtenea.ServiceWSTrazinsAtenea;

namespace TrazinsAtenea.Forms.Inventory.Set
{
    public partial class SetManagmentForm : DevExpress.XtraEditors.XtraForm
    {
        public Caja Caja;
        private BaseModelClient BaseModelClient = BaseModelClient.Instance;        

        public SetManagmentForm()
        {
            InitializeComponent();            
        }

        private void SetManagmentForm_Load(object sender, EventArgs e)
        {
            MultilanguageFormat();

            splashScreenManager1.ShowWaitForm();

            //CargarCombos
            LoadComboBoxInformation();

            splashScreenManager1.CloseWaitForm();
           
        }

        private void LoadComboBoxInformation()
        {
            //Tener en cuenta que si no es caja nueva hay que seleccionar los elementos
            //si es caja nueva el elemento seleccionado es 0;
            SpecialitiesLoad();
            PackagingLoad();            
            PropertyLoad();
            SetTypeLoad();
            MethodsWashingLoad();
            MethodsSteriLoad();
            StorageLoad();

            //Pendiente crear modelo
            //CostCenterLoad();           

        }

        private void StorageLoad()
        {
            try
            {
                var storageList = BaseModelClient.Service.Almacen_Select_List(new Almacen()
                { ChId = BaseModelClient.BaseModel.ChId, HosId = BaseModelClient.BaseModel.HosId });

                Engine.ComboBoxFormat(cmbDefaultUbication, "Descripcion", "AlmId", storageList);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error en StorageLoad: " + ex.Message);
            }
        }

        #region Load Data ComboBoxes

        private void MethodsSteriLoad()
        {
            try
            {
                var steriMethodsList = BaseModelClient.Service.Esterilizacion_Select_List(new Esterilizacion()
                { ChId = BaseModelClient.BaseModel.ChId });

                Engine.ComboBoxFormat(cmbFirstMethodSteri, "Descripcion", "EstId", steriMethodsList);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error en MethodsSterisLoad: " + ex.Message);
            }
        }

        private void MethodsWashingLoad()
        {
            try
            {
                var methodsWashingList = BaseModelClient.Service.Limpieza_Select_List(new Limpieza()
                { ChId = BaseModelClient.BaseModel.ChId });

                Engine.ComboBoxFormat(cmbFirstMethodWashing, "Descripcion", "TipoLavId", methodsWashingList);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error en MethodWashingLoad: " + ex.Message);
            }
        }

        private void SetTypeLoad()
        {
            try
            {
                var setTypeList = BaseModelClient.Service.TipoCaja_Select_List(new TipoCaja()
                { ChId = BaseModelClient.BaseModel.ChId, HosId = BaseModelClient.BaseModel.HosId });

                Engine.ComboBoxFormat(cmbSetType, "Descripcion", "Id", setTypeList);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error en SetTypeLoad: " + ex.Message);
            }
        }

        //Mostrar los hospitales
        private void PropertyLoad()
        {
            try
            {
                var hospitalList = BaseModelClient.Service.Hospital_Select_List(new Hospital()
                { ChId = BaseModelClient.BaseModel.ChId, HosId = BaseModelClient.BaseModel.HosId });

                Engine.ComboBoxFormat(cmbProperty, "NomHospital", "HosId", hospitalList);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error en PropertyLoad:" + ex.Message);
            }
        }

        private void PackagingLoad()
        {
            try
            {
                var packagesList = BaseModelClient.Service.Embalaje_Select_List(new Embalaje()
                { ChId = BaseModelClient.BaseModel.ChId });

                Engine.ComboBoxFormat(cmbPackage, "Descripcion", "ConId", packagesList);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error en PackagingLoad: " + ex.Message);
            }
        }

        private void SpecialitiesLoad()
        {
            try
            {

                var specialitiesList = BaseModelClient.Service.Especialidad_Select_List(new Especialidad()
                { ChId = BaseModelClient.BaseModel.ChId });

                Engine.ComboBoxFormat(cmbSpeciality, "Descripcion", "EspId", specialitiesList);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error en SpecialitiesLoad: " + ex.Message);
            }
        }

        #endregion

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

        private void btnRestart_Click(object sender, EventArgs e)
        {
            //Reiniciar y salir o necesario click guardar
            speMaintenance.Value = 0;
        }
    }
}