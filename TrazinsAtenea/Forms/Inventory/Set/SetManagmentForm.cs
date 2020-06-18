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
using TrazinsAtenea.ServiceWSTrazinsAtenea;

namespace TrazinsAtenea.Forms.Inventory.Set
{
    public partial class SetManagmentForm : DevExpress.XtraEditors.XtraForm
    {
        public Caja Caja;
        private BaseModelClient BaseModelClient = BaseModelClient.Instance;
        public EnumOperationType Operation;
        private List<Limpieza> MethodsWashingList;
        private List<Esterilizacion> MethodsSteriList;
        private List<AlmacenesUbicaciones> UbicationList;

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

            if (frm.DialogResult == DialogResult.Yes)
            {
                this.Close();
            }
        }

        //La carga de modelos se hará desde la clase GlobalEngine
        //Revisar try-catch
        #region Data and Proceses TabPage

        #region Load Data ComboBoxes

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

        private void MethodsSteriLoad()
        {
            try
            {
                MethodsSteriList = BaseModelClient.Service.Esterilizacion_Select_List(new Esterilizacion()
                { ChId = BaseModelClient.BaseModel.ChId }).ToList();

                Engine.ComboBoxFormat(cmbFirstMethodSteri, "Descripcion", "EstId", MethodsSteriList);

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
                MethodsWashingList = BaseModelClient.Service.Limpieza_Select_List(new Limpieza()
                { ChId = BaseModelClient.BaseModel.ChId }).ToList();

                Engine.ComboBoxFormat(cmbFirstMethodWashing, "Descripcion", "TipoLavId", MethodsWashingList);
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

                //Solo se pueden añadir cajas al hospital con el que nos hemos logeado
                if (Operation == EnumOperationType.Nuevo)
                {
                    cmbProperty.Enabled = false;
                    cmbProperty.SelectedValue = BaseModelClient.BaseModel.HosId;
                }

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

        #region Combobox Methods

        private void cmbFirstMethodWashing_SelectionChangeCommitted(object sender, EventArgs e)
        {
            var selected = (Limpieza)cmbFirstMethodWashing.SelectedItem;

            if (cmbSecondMethodWashing.SelectedIndex == -1)
            {
                var list = MethodsWashingList.Where(l => l.TipoLavId != selected.TipoLavId).ToList();
                Engine.ComboBoxFormat(cmbSecondMethodWashing, "Descripcion", "TipoLavId", list);
            }
            else
            {
                if (selected == (Limpieza)cmbSecondMethodWashing.SelectedItem)
                {
                    var list = MethodsWashingList.Where(l => l.TipoLavId != selected.TipoLavId).ToList();
                    Engine.ComboBoxFormat(cmbSecondMethodWashing, "Descripcion", "TipoLavId", list);
                }

                if (selected == (Limpieza)cmbThirdMethodWashing.SelectedItem)
                {
                    var selected2 = (Limpieza)cmbSecondMethodWashing.SelectedItem;
                    var list = MethodsWashingList.Where
                    (l => l.TipoLavId != selected.TipoLavId && l.TipoLavId != selected2.TipoLavId).ToList();

                    Engine.ComboBoxFormat(cmbThirdMethodWashing, "Descripcion", "TipoLavId", list);
                }
            }

        }

        private void cmbSecondMethodWashing_SelectionChangeCommitted(object sender, EventArgs e)
        {
            var selected2 = (Limpieza)cmbSecondMethodWashing.SelectedItem;
            var selected = (Limpieza)cmbFirstMethodWashing.SelectedItem;

            if (cmbThirdMethodWashing.SelectedIndex == -1 && cmbSecondMethodWashing.SelectedIndex != -1)
            {
                var list = MethodsWashingList.Where
                    (l => l.TipoLavId != selected.TipoLavId && l.TipoLavId != selected2.TipoLavId).ToList();

                Engine.ComboBoxFormat(cmbThirdMethodWashing, "Descripcion", "TipoLavId", list);
            }
            else
            {
                if ((Limpieza)cmbThirdMethodWashing.SelectedItem == selected2)
                {
                    var list = MethodsWashingList.Where
                    (l => l.TipoLavId != selected.TipoLavId && l.TipoLavId != selected2.TipoLavId).ToList();

                    Engine.ComboBoxFormat(cmbThirdMethodWashing, "Descripcion", "TipoLavId", list);
                }
            }
        }

        private void cmbFirstMethodSteri_SelectionChangeCommitted(object sender, EventArgs e)
        {
            var selected = (Esterilizacion)cmbFirstMethodSteri.SelectedItem;

            if (cmbSecondMethodSteri.SelectedIndex == -1)
            {
                var list = MethodsSteriList.Where(l => l.EstId != selected.EstId).ToList();
                Engine.ComboBoxFormat(cmbSecondMethodSteri, "Descripcion", "EstId", list);
            }
            else
            {
                if (selected == (Esterilizacion)cmbSecondMethodSteri.SelectedItem)
                {
                    var list = MethodsSteriList.Where(l => l.EstId != selected.EstId).ToList();
                    Engine.ComboBoxFormat(cmbSecondMethodSteri, "Descripcion", "EstId", list);
                }

                if (selected == (Esterilizacion)cmbThirdMethodSteri.SelectedItem)
                {
                    var selected2 = (Esterilizacion)cmbSecondMethodSteri.SelectedItem;
                    var list = MethodsSteriList.Where
                    (l => l.EstId != selected.EstId && l.EstId != selected2.EstId).ToList();

                    Engine.ComboBoxFormat(cmbThirdMethodSteri, "Descripcion", "EstId", list);
                }
            }
        }

        private void cmbSecondMethodSteri_SelectionChangeCommitted(object sender, EventArgs e)
        {
            var selected = (Esterilizacion)cmbFirstMethodSteri.SelectedItem;
            var selected2 = (Esterilizacion)cmbSecondMethodSteri.SelectedItem;

            if (cmbThirdMethodSteri.SelectedIndex == -1 && cmbSecondMethodSteri.SelectedIndex != -1)
            {
                var list = MethodsSteriList.Where
                    (es => es.EstId != selected.EstId && es.EstId != selected2.EstId).ToList();
                Engine.ComboBoxFormat(cmbThirdMethodSteri, "Descripcion", "EstId", list);
            }
            else
            {
                if ((Esterilizacion)cmbThirdMethodSteri.SelectedItem == selected2)
                {
                    var list = MethodsSteriList.Where
                    (es => es.EstId != selected.EstId && es.EstId != selected2.EstId).ToList();
                    Engine.ComboBoxFormat(cmbThirdMethodSteri, "Descripcion", "EstId", list);
                }
            }
        }

        private void cmbDefaultUbication_SelectionChangeCommitted(object sender, EventArgs e)
        {
            try
            {
                var selected = (Almacen)cmbDefaultUbication.SelectedItem;
                UbicationList = BaseModelClient.Service.AlmacenesUbicaciones_Select_List(new AlmacenesUbicaciones()
                {
                    ChId = BaseModelClient.BaseModel.ChId,
                    HosId = BaseModelClient.BaseModel.HosId,
                    AlmId = selected.AlmId
                }).ToList();

                Engine.ComboBoxFormat(cmbBlock, "Bloque", "Bloque", UbicationList);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error en cmbDefaultUbication_SelectionChangeCommitted: " + ex.Message);
            }
        }

        private void cmbBlock_SelectionChangeCommitted(object sender, EventArgs e)
        {
            var selected = (AlmacenesUbicaciones)cmbBlock.SelectedItem;
            var list = UbicationList.Where(b => b.Bloque == selected.Bloque && b.AlmId == selected.AlmId).ToList();
            Engine.ComboBoxFormat(cmbSelf, "Estante", "Estante", list);
        }

        private void cmbSelf_SelectionChangeCommitted(object sender, EventArgs e)
        {
            var block = (AlmacenesUbicaciones)cmbBlock.SelectedItem;
            var self = (AlmacenesUbicaciones)cmbSelf.SelectedItem;

            var list = UbicationList.Where
                (b => b.Bloque == block.Bloque && b.AlmId == block.AlmId && b.Estante == self.Estante).ToList();
            Engine.ComboBoxFormat(cmbPosition, "Posicion", "Posicion", list);
        }

        #endregion

        private void btnRestart_Click(object sender, EventArgs e)
        {
            //Reiniciar y salir o necesario click guardar
            speMaintenance.Value = 0;
        } 

        #endregion

        private void btnFromComputer_Click(object sender, EventArgs e)
        {
            try
            {
                //Comprobamos que hay algún sitio disponible
                //PTDE. probar
                int numImages = 0;

                foreach (PanelControl panel in tableLayoutPanel1.Controls)
                {
                    foreach (Control item in panel.Controls)
                    {
                        if (item is PictureBox)
                        {
                            var pictureBox = (PictureBox)item;

                            if(pictureBox.Image != null && !pictureBox.Name.Equals("pcbSixthPosition"))
                            {
                                numImages++;
                                MessageBox.Show(item.Name + "imagen asociada");
                            }
                               
                        }
                    }

                    if(numImages == 5)
                    {
                        //Traducir desde bd
                        MessageBox.Show("No hay hueco");
                    }
                    
                }

                //Pasarlo al archivo de recursos
                ofdImageVideo.Filter = GlobalResources.TrazinsAtenea.FilterType +
                    " (*.jpeg, *.jpg, *.png, *.gif)|*.jpeg;*.jpg;*.png;*.gif";
                ofdImageVideo.Filter += "|Archivos vídeo (*.avi,*.mp4, *.mpeg, *.mpg, *.wmv)|*.avi;*.mp4;*.mpeg;*.mpg;*.wmv";
                ofdImageVideo.FilterIndex = 1;
                ofdImageVideo.InitialDirectory = @"C:\";
                ofdImageVideo.Title = "Open File";
                ofdImageVideo.CheckFileExists = false;

                DialogResult = ofdImageVideo.ShowDialog();
                if(DialogResult == DialogResult.OK)
                { 
                    //Creamos un nuevo modelo de CajaImagen
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error en btnFromComputer: " + ex.Message);
            }
        }
    }
}