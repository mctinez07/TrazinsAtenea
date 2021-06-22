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
using Utils;
using System.IO;
using System.Drawing.Imaging;
using System.Reflection;
using TrazinsAtenea.Forms.Inventory.Group;
using Models.Masters.Storage;
using Models.Inventory;
using Models.Processes.Methods;
using Models.Masters;
using TrazinsAtenea.Controls;

namespace TrazinsAtenea.Forms.Inventory.Set
{
    public partial class SetManagmentForm : DevExpress.XtraEditors.XtraForm
    {
        public Caja Caja = new Caja();

        //Creamos la instancia con los valores cargados en memoria
        private BaseModelClient BaseModelClient = BaseModelClient.Instance;
        private SetImageControl LastImageAdded = new SetImageControl();

        //Nos indica que tipo de operación hay que realizar para la gestión de la interfaz
        public EnumOperationType Operation;

        //Listas para la gestión en memória de los datos de BD
        private List<Limpieza> MethodsWashingList;
        private List<Esterilizacion> MethodsSteriList;             

        private bool onlyVideos = false;
        private Image CapturedImage;

        //Propiedades para la obtención automáica de los elementos seleccionados en los combo.
        #region Properties Getters 

        private Almacen StorageSelected
        {
            get { return (Almacen)cmbDefaultUbication.SelectedItem; }
        }
        private Limpieza FirstWashingMethodSelected
        {
            get { return (Limpieza)cmbFirstMethodWashing.SelectedItem; }
        }
        private Limpieza SecondWashingMethodSelected
        {
            get { return (Limpieza)cmbSecondMethodWashing.SelectedItem; }
        }
        private Limpieza ThirdWashingMethodSelected
        {
            get { return (Limpieza)cmbThirdMethodWashing.SelectedItem; }
        }
        private Esterilizacion FirstSteriMethodSelected
        {
            get { return (Esterilizacion)cmbFirstMethodSteri.SelectedItem; }
        }
        private Esterilizacion SecondSteriMethodSelected
        {
            get { return (Esterilizacion)cmbSecondMethodSteri.SelectedItem; }
        }
        private Esterilizacion ThirdSteriMethodSelected
        {
            get { return (Esterilizacion)cmbThirdMethodSteri.SelectedItem; }
        }
        private Embalaje PackageSelected
        {
            get { return (Embalaje)cmbPackage.SelectedItem; }
        }
        private CentroCoste CostCenterSelected
        {
            get { return (CentroCoste)cmbCostCenter.SelectedItem; }
        }
        private Especialidad SpecilitySelected
        {
            get { return (Especialidad)cmbSpeciality.SelectedItem; }
        }
        private TipoCaja SetTypeSelected
        {
            get { return (TipoCaja)cmbSetType.SelectedItem; }
        }
        private Hospital OwnerSelected
        {
            get { return (Hospital)cmbProperty.SelectedItem; }
        }

        #endregion

        public SetManagmentForm()
        {
            InitializeComponent();            
        }

        private void SetManagmentForm_Load(object sender, EventArgs e)
        {
            try
            {
                LoadDataToForm();               

            }
            catch (Exception ex)
            {
                splashScreenManager1.CloseWaitForm();
                ErrorMessage.ShowErrorMessage(MethodBase.GetCurrentMethod().Name, ex.Message);                
            }            
                        
        }

        //Método que carga todos los valores para crear el modelo
        private void LoadDataToForm()
        {            
            MultilanguageFormat();

            splashScreenManager1.ShowWaitForm();

            //CargarCombos
            LoadComboBoxInformation();

            //Enlazar Controles para que se actualicen automáticamente los valores de los controles.    
            //Crear metodo que coja los valores del atributo
            //BindingControls();

            //Establecer estado de los controles
            ControlsState();

            Caja.HosId = BaseModelClient.BaseModel.HosId;
            Caja.ChId = BaseModelClient.BaseModel.ChId;
            Caja.CHIdPropietario = Caja.ChId;//Pendiente saber si es necesaria esta propiedad

            splashScreenManager1.CloseWaitForm();
        }

        private void ControlsState()
        {           

            if (Operation == EnumOperationType.New)
            {
                xtpImageVideo.PageVisible = false;
                xtpInstrumentalSet.PageVisible = false;
                btnSave.Visible = false;
                btnSaveContinue.Location = new Point(1135, 13);
                //Solo se pueden añadir cajas nuevas al hospital con el que nos hemos logeado
                cmbProperty.Enabled = false;
                cmbProperty.SelectedValue = BaseModelClient.BaseModel.HosId;
            }

            if (Operation == EnumOperationType.Modify)
            {                
                btnSaveContinue.Visible = false;
                btnSave.Visible = true;
            }

            wmpVideo.Visible = false;
            wmpVideo.settings.autoStart = false;
            wmpVideo.settings.mute = true;
        }        

        //No funciona, lo edjo por si en un futuro lo podemos cambiar.
        private void BindingControls()
        {
            //Quitar el enlace y configurar solo las carcteristicas de los controle
            Engine._bindedModel = Caja;          

            //////Controles TextBox
            Engine.BindingControlProperty(txtSetName, "Descripcion");
            Engine.BindingControlProperty(speWheight, "Peso");
            
            Engine.BindingControlProperty(txtSetCode, "CodigoCaja");
            Engine.BindingControlProperty(txtRemarksAssemblyPackaging, "ObservEmp");
            Engine.BindingControlProperty(txtRemarksSteri, "ObservCic");
            Engine.BindingControlProperty(txtRemarksWashes, "ObservLav");

            ////Controles Combo Cabecera
            Engine.BindingControlProperty(cmbSpeciality, "EspId");
            Engine.BindingControlProperty(cmbSetType, "TipoCajaId");
            Engine.BindingControlProperty(cmbProperty, "HosIdPropietario");
            Engine.BindingControlProperty(cmbPackage, "EmbId");
            Engine.BindingControlProperty(cmbCostCenter, "CentroCosteId");

            ////Controles Combo Ubicación
            ////El valor de la posicion es el que nos indica la ubicación exacta.
            Engine.BindingControlProperty(cmbPosition, "UbiId");            

            ////Otros Controles
            Engine.BindingControlProperty(speMaintenance, "MantCiclos");
            Engine.BindingControlProperty(tgsYesNo, "Activa");
            Engine.BindingControlProperty(ckbSetSample, "CajaMuestra");
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
                                        //Tendré que traducir los subpaneles dentro de las tabPage!!!                                        
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
                ErrorMessage.ShowErrorMessage(MethodBase.GetCurrentMethod().Name, ex.Message);
            }

        }

        private void pcbBack_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult = Engine.OpenMessageForm(190);

                if (DialogResult == DialogResult.Yes)
                {
                    wmpVideo.Ctlcontrols.stop();
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                ErrorMessage.ShowErrorMessage(MethodBase.GetCurrentMethod().Name, ex.Message);
            }            
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            try
            {
                MessageForm frm = new MessageForm(190);
                frm.ShowDialog();

                if (frm.DialogResult == DialogResult.Yes)
                {
                    wmpVideo.Ctlcontrols.stop();
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                ErrorMessage.ShowErrorMessage(MethodBase.GetCurrentMethod().Name, ex.Message);
            }
            
        }       

        //La carga de modelos se hará desde la clase GlobalEngine        
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
            CostCenterLoad();
        }

        private void StorageLoad()
        {
            try
            {
                var storageList = BaseModelClient.Service.Almacen_Select_List(new Almacen()
                { ChId = BaseModelClient.BaseModel.ChId, HosId = BaseModelClient.BaseModel.HosId });

                Engine.ComboBoxFormat(cmbDefaultUbication, "Descripcion", "AlmId", storageList);

                if(Operation == EnumOperationType.Modify)
                {
                    if(Caja.UbiId!= null)
                    {
                        //Asignamos el valor y ahora hay que recuperar los otros datos de la ubicación
                        var storage = BaseModelClient.Service.AlmacenesUbicaciones_Select(new AlmacenesUbicaciones()
                            { UbiId = Caja.UbiId });
                        if(storage!= null)
                        {
                            cmbDefaultUbication.SelectedValue = storage.AlmId;

                            //Cargamos los combos de la estructura.
                            var storageStructure = BaseModelClient.Service.AlmacenesUbicaciones_GetStructure(new AlmacenesUbicaciones()
                            { Bloque = storage.Bloque, Estante = storage.Estante, Posicion = storage.Posicion, AlmId = storage.AlmId });
                            LoadDefaultUbicationSelectedSet(storageStructure);

                            cmbBlock.SelectedValue = storage.Bloque;
                            cmbSelf.SelectedValue = storage.Estante;
                            cmbPosition.SelectedValue = storage.Posicion;

                        }                        
                    }
                }

            }
            catch (Exception ex)
            {
                ErrorMessage.ShowErrorMessage(MethodBase.GetCurrentMethod().Name, ex.Message);
            }
        }

        private void LoadDefaultUbicationSelectedSet(AlmacenesUbicaciones[] storageStructure)
        {
            Engine.ComboBoxFormat(cmbBlock, "Bloque", "Bloque", storageStructure);
            Engine.ComboBoxFormat(cmbSelf, "Estante", "Estante", storageStructure);
            Engine.ComboBoxFormat(cmbPosition, "Posicion", "UbiId", storageStructure);
        }

        private void MethodsSteriLoad()
        {
            try
            {
                MethodsSteriList = BaseModelClient.Service.Esterilizacion_Select_List(new Esterilizacion()
                { ChId = BaseModelClient.BaseModel.ChId }).ToList();

                Engine.ComboBoxFormat(cmbFirstMethodSteri, "Descripcion", "EstId", MethodsSteriList);

                if (Operation == EnumOperationType.Modify)
                {
                    if (Caja.EstId1 != null)
                    {
                        cmbFirstMethodSteri.SelectedValue = Caja.EstId1;
                    }

                    if (Caja.EstId2 != null)
                    {
                        Engine.ComboBoxFormat(cmbSecondMethodSteri, "Descripcion", "EstId", MethodsSteriList);
                        GetEsteriMethodValues();
                        cmbSecondMethodSteri.SelectedValue = Caja.EstId2;
                    }
                    
                    if (Caja.EstId3 != null)
                    {
                        Engine.ComboBoxFormat(cmbThirdMethodSteri, "Descripcion", "EstId", MethodsSteriList);
                        GetSecondEsteriMethodValues();
                        cmbThirdMethodSteri.SelectedValue = Caja.EstId3;
                    }
                }

            }
            catch (Exception ex)
            {
                ErrorMessage.ShowErrorMessage(MethodBase.GetCurrentMethod().Name, ex.Message);
            }
        }

        private void MethodsWashingLoad()
        {
            try
            {
                MethodsWashingList = BaseModelClient.Service.Limpieza_Select_List(new Limpieza()
                { ChId = BaseModelClient.BaseModel.ChId }).ToList();

                Engine.ComboBoxFormat(cmbFirstMethodWashing, "Descripcion", "TipoLavId", MethodsWashingList);

                if(Operation == EnumOperationType.Modify)
                {
                    if (Caja.TipoLavId1 != null)
                    {
                        cmbFirstMethodWashing.SelectedValue = Caja.TipoLavId1;
                    }

                    if (Caja.TipoLavId2 != null)
                    {
                        Engine.ComboBoxFormat(cmbSecondMethodWashing, "Descripcion", "TipoLavId", MethodsWashingList);
                        GetMethodsWashingValues();
                        cmbSecondMethodWashing.SelectedValue = Caja.TipoLavId2;
                    }

                    if (Caja.TipoLavId3 != null)
                    {
                        Engine.ComboBoxFormat(cmbThirdMethodWashing, "Descripcion", "TipoLavId", MethodsWashingList);
                        GetSecondMethodWashingValues();
                        cmbThirdMethodWashing.SelectedValue = Caja.TipoLavId3;
                    }
                }                
            }
            catch (Exception ex)
            {
                ErrorMessage.ShowErrorMessage(MethodBase.GetCurrentMethod().Name, ex.Message);
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
                ErrorMessage.ShowErrorMessage(MethodBase.GetCurrentMethod().Name, ex.Message);
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
                ErrorMessage.ShowErrorMessage(MethodBase.GetCurrentMethod().Name, ex.Message);
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
                ErrorMessage.ShowErrorMessage(MethodBase.GetCurrentMethod().Name, ex.Message);
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
                ErrorMessage.ShowErrorMessage(MethodBase.GetCurrentMethod().Name, ex.Message);
            }
        }

        private void CostCenterLoad()
        {
            try
            {

                var costcenterList = BaseModelClient.Service.CentroCoste_Select_List(new CentroCoste()
                { ChId = BaseModelClient.BaseModel.ChId });

                Engine.ComboBoxFormat(cmbCostCenter, "Descripcion", "Id", costcenterList);

            }
            catch (Exception ex)
            {
                ErrorMessage.ShowErrorMessage(MethodBase.GetCurrentMethod().Name, ex.Message);
            }
        }

        #endregion

        #region Combobox Methods

        private void cmbFirstMethodWashing_SelectionChangeCommitted(object sender, EventArgs e)
        {
            try
            {
                GetMethodsWashingValues();                
            }
            catch (Exception ex)
            {
                ErrorMessage.ShowErrorMessage(MethodBase.GetCurrentMethod().Name, ex.Message);
            }
        }        

        private void cmbSecondMethodWashing_SelectionChangeCommitted(object sender, EventArgs e)
        {
            try
            {
                GetSecondMethodWashingValues();
            }
            catch (Exception ex)
            {
                ErrorMessage.ShowErrorMessage(MethodBase.GetCurrentMethod().Name, ex.Message);
            }
            
        }

        private void GetMethodsWashingValues()
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

        private void GetSecondMethodWashingValues()
        {
            var selected2 = (Limpieza)cmbSecondMethodWashing.SelectedItem;
            var selected = (Limpieza)cmbFirstMethodWashing.SelectedItem;

            if (selected == null)
            {
                return;
            }

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
            try
            {
                GetEsteriMethodValues();                           
            }
            catch (Exception ex)
            {
                ErrorMessage.ShowErrorMessage(MethodBase.GetCurrentMethod().Name, ex.Message);
            }
            
        }        

        private void cmbSecondMethodSteri_SelectionChangeCommitted(object sender, EventArgs e)
        {
            try
            {
                GetSecondEsteriMethodValues();
            }
            catch (Exception ex)
            {
                ErrorMessage.ShowErrorMessage(MethodBase.GetCurrentMethod().Name, ex.Message);
            }
            
        }

        private void GetEsteriMethodValues()
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

        private void GetSecondEsteriMethodValues()
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
                var blockList = BaseModelClient.Service.AlmacenesUbicaciones_GetStructure(new AlmacenesUbicaciones()
                {
                    AlmId = StorageSelected.AlmId
                }).ToList();

                Engine.ComboBoxFormat(cmbBlock, "Bloque", "Bloque", blockList);
                //Al cambiar debemos de asegurarnos que se borran los datos de los otros combos asociados.
                cmbSelf.DataSource = null;
                cmbPosition.DataSource = null;
            }
            catch (Exception ex)
            {
                ErrorMessage.ShowErrorMessage(MethodBase.GetCurrentMethod().Name, ex.Message);
            }
        }

        private void cmbBlock_SelectionChangeCommitted(object sender, EventArgs e)
        {
            try
            {
                var blockSelected = cmbBlock.SelectedValue;
                var selfList = BaseModelClient.Service.AlmacenesUbicaciones_GetStructure(new AlmacenesUbicaciones()
                {
                    AlmId = StorageSelected.AlmId,
                    Bloque = (int?)blockSelected
                }).ToList();
                Engine.ComboBoxFormat(cmbSelf, "Estante", "Estante", selfList);
            }
            catch (Exception ex)
            {
                ErrorMessage.ShowErrorMessage(MethodBase.GetCurrentMethod().Name, ex.Message);
            }
            
        }

        private void cmbSelf_SelectionChangeCommitted(object sender, EventArgs e)
        {
            try
            {
                var block = cmbBlock.SelectedValue;
                var self = cmbSelf.SelectedValue;

                var postionList = BaseModelClient.Service.AlmacenesUbicaciones_GetStructure(new AlmacenesUbicaciones()
                {
                    AlmId = StorageSelected.AlmId,
                    Bloque = (int?)block,
                    Estante = (int?)self
                }).ToList();

                Engine.ComboBoxFormat(cmbPosition, "Posicion", "UbiId", postionList);

            }
            catch (Exception ex)
            {
                ErrorMessage.ShowErrorMessage(MethodBase.GetCurrentMethod().Name, ex.Message);
            }
            
        }

        #endregion

        private void btnRestart_Click(object sender, EventArgs e)
        {
            //Reiniciar y salir o necesario click guardar
            speMaintenance.Value = 0;
        }

        #endregion

        #region Image/Video TabPage

        private void btnFromComputer_Click(object sender, EventArgs e)
        {
            try
            {
                //Comprobamos que hay algún sitio disponible
                if (!SearchEmptyPictureBox(null))
                {
                    return;
                }

                if (onlyVideos)
                {                    
                    var formatFilterVideo = GlobalResources.TrazinsAtenea.FilterVideoType.Replace('|', ' ');
                    ofdImageVideo.Filter = formatFilterVideo + GlobalResources.TrazinsAtenea.FilterVideoTypes;
                }
                else
                {
                    ofdImageVideo.Filter = GlobalResources.TrazinsAtenea.FilterImageType +
                    GlobalResources.TrazinsAtenea.FilterImageTypes;
                    //" (*.jpeg, *.jpg, *.png, *.gif)|*.jpeg;*.jpg;*.png;*.gif";
                    ofdImageVideo.Filter += GlobalResources.TrazinsAtenea.FilterVideoType +
                        GlobalResources.TrazinsAtenea.FilterVideoTypes;
                    //ofdImageVideo.Filter += "|Archivos vídeo (*.avi,*.mp4, *.mpeg, *.mpg, *.wmv)|*.avi;*.mp4;*.mpeg;*.mpg;*.wmv";
                }

                ofdImageVideo.FilterIndex = 1;
                ofdImageVideo.InitialDirectory = @"C:\";
                ofdImageVideo.Title = GlobalResources.TrazinsAtenea.OpenFileDialogTitle;
                ofdImageVideo.CheckFileExists = false;

                DialogResult = ofdImageVideo.ShowDialog();
                if (DialogResult == DialogResult.OK)
                {
                    CreateImageModel(false);
                }

                DialogResult = DialogResult.None;
            }
            catch (Exception ex)
            {
                ErrorMessage.ShowErrorMessage(MethodBase.GetCurrentMethod().Name, ex.Message);
            }
        }

        private void btnFromCam_Click(object sender, EventArgs e)
        {
            try
            {
                if (!SearchEmptyPictureBox(null))
                {
                    return;
                }

                WebCamForm frm = new WebCamForm();
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    CapturedImage = frm.ImageData;
                    CreateImageModel(true);
                }
            }
            catch (Exception ex)
            {
                ErrorMessage.ShowErrorMessage(MethodBase.GetCurrentMethod().Name, ex.Message);
            }

        }

        private bool SearchEmptyPictureBox(CajaImagen setImage)
        {
            int numImages = 0;

            foreach (PanelControl panel in tableLayoutPanel1.Controls)
            {
                foreach (Control item in panel.Controls)
                {
                    if (item is SetImageControl)
                    {
                        var setImageControl = (SetImageControl)item;
                        if (setImageControl.ImagePictureBox.Image != null)
                        {
                            numImages++;
                        }
                        else
                        {
                            if(setImage != null)
                            {
                                if (setImage.Image != null)
                                {
                                    setImageControl.ImagePictureBox.Image = setImage.Image;
                                    setImageControl.CajaImagen = setImage;
                                    LastImageAdded = setImageControl;
                                    return true;
                                }
                            }
                            
                        }

                    }

                    if (numImages == 5 && !string.IsNullOrEmpty(wmpVideo.URL))
                    {
                        //Traducir desde bd
                        MessageForm frm = new MessageForm(191);
                        frm.ShowDialog();
                        return false;
                    }
                    else if (numImages == 5 && string.IsNullOrEmpty(wmpVideo.URL))
                    {
                        //Crear campo que solo permita archivos de video en el filtro.
                        onlyVideos = true;
                        MessageForm frm = new MessageForm(192);
                        frm.ShowDialog();
                        return true;
                    }
                }
            }

            return true;
        }

        private void AddImageVideo(CajaImagen cajaImagen, string url)
        {
            if (cajaImagen.EsVideo)
            {
                if (!string.IsNullOrEmpty(wmpVideo.URL))
                {
                    MessageForm frm = new MessageForm(126);
                    frm.ShowDialog();
                    return;
                }

                wmpVideo.Visible = true;
                wmpVideo.URL = url;
            }
            if (cajaImagen.EsImagen)
            {
                if (SearchEmptyPictureBox(cajaImagen))
                {   
                    cajaImagen.CajaId = Caja.CajaId;
                    var res = BaseModelClient.Service.CajaImagen_Insert(cajaImagen);
                    LastImageAdded.CajaImagen.Id = res.Id;
                }
            }
        }

        private void CreateImageModel(bool fromWebCam)
        {            
            string type = string.Empty;
            CajaImagen imageSet = new CajaImagen();

            if (fromWebCam)
            {
                using (MemoryStream stream = new MemoryStream())
                {
                    //Creamos un nuevo modelo de CajaImagen desde la webcam
                    CapturedImage.Save(stream, ImageFormat.Jpeg);
                    imageSet.Imagen = stream.ToArray();                    
                    imageSet.Nombre = DateTime.Now.ToShortDateString().ToString();
                    imageSet.Tipo = "image/jpeg";
                    type = "image";
                }
            }
            else
            {
                //Creamos un nuevo modelo de CajaImagen desde el archivo
                imageSet.Imagen = System.IO.File.ReadAllBytes(ofdImageVideo.FileName);
                imageSet.Nombre = ofdImageVideo.SafeFileName;
                imageSet.Tipo = MIMEAssistant.GetMIMEType(ofdImageVideo.FileName);                
                //Obtenemos el tipo de archivo para asignar el valor.
                type = MIMEAssistant.FromFileName(ofdImageVideo.FileName).Type;
            }

            switch (type)
            {
                case "image":                    

                    //Obtenemos la imagen para mostrar en el picturebox
                    using (MemoryStream ms = new MemoryStream(imageSet.Imagen))
                    {
                        if (!GetWeightImage(ms))
                        {
                            MessageBox.Show("Tamaño de imagen superior al permitido");
                            DialogResult = DialogResult.None;
                            return;
                        }
                    }

                    AddImageVideo(imageSet, null);
                    break;

                case "video":
                    //Comprobar que no machaque si hay uno asociado
                    if (!string.IsNullOrEmpty(wmpVideo.URL))
                    {
                        MessageBox.Show("Hay un video asociado");
                        DialogResult = DialogResult.None;
                        return;
                    }
                    using (MemoryStream ms = new MemoryStream(imageSet.Imagen))
                    {
                        if (!GetWeightVideo(ms))
                        {
                            MessageBox.Show("Tamaño video superior al permitido");
                            DialogResult = DialogResult.None;
                            return;
                        }
                    }
                                 
                    AddImageVideo(imageSet, ofdImageVideo.FileName);
                    break;
                default:
                    break;
            }
        }

        private bool GetWeightImage(MemoryStream ms)
        {
            
            if (ms.Length > 3670016)//3,5 MB
            {
                return false;
            }
            return true;
        }

        private bool GetWeightVideo(MemoryStream ms)
        {
            //Falta probar tamaño de vídeos...
            if (ms.Length > 31457280)//30 MB
            {
                return false;
            }
            return true;
        }

        #region Video Panel Buttons

        private void btnPlayVideo_Click(object sender, EventArgs e)
        {
            wmpVideo.Ctlcontrols.play();
            wmpVideo.settings.mute = true;
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            wmpVideo.Ctlcontrols.stop();
        }
        
        #endregion

        #region Delete Buttons

        private void btnFirstPosition_Click(object sender, EventArgs e)
        {
            DeleteImageVideo(setImageControl1);
        }

        private void btnSecondPosition_Click(object sender, EventArgs e)
        {
            DeleteImageVideo(setImageControl2);
        }

        private void btnTirthPosition_Click(object sender, EventArgs e)
        {
            DeleteImageVideo(setImageControl3);
        }

        private void btnFourthPosition_Click(object sender, EventArgs e)
        {
            DeleteImageVideo(setImageControl4);
        }

        private void btnFifthPosition_Click(object sender, EventArgs e)
        {
            DeleteImageVideo(setImageControl5);
        }

        private void btnSixthPosition_Click(object sender, EventArgs e)
        {
            DeleteImageVideo(wmpVideo);
        }

        #endregion

        private void DeleteImageVideo(Control control)
        {
            //Borrar de base de datos.
            if (control is SetImageControl)
            {
                var pcb = (SetImageControl)control;
                pcb.ImagePictureBox.Image = null;
                BaseModelClient.Service.CajaImagen_Delete(pcb.CajaImagen);
            }
            else
            {
                wmpVideo.URL = null;
                wmpVideo.Visible = false;
            }

            
        }

        #endregion

        #region GroupManagment TabPage

        private void btnGroupManagment_Click(object sender, EventArgs e)
        {
            //Si no se asignado es necesario el texto escrito en textbox
            //La asociacion en tabla es con la cajaId por lo tanto tiene que estar creada 
            //para añadir los elementos.
            if (string.IsNullOrEmpty(Caja.CajaId))
            {
                MessageForm frmMessage = new MessageForm(193);
                frmMessage.ShowDialog();
                return;
            }

            GroupsForm frm = new GroupsForm(Caja);
            frm.ShowDialog();
        }

        #endregion        

        #region Main Buttons Actions

        //Guarda y vuelve abrir la pantalla de gestión de cajas
        private void btnSaveContinue_Click(object sender, EventArgs e)
        {
            //Este boton solo actúa cuando la caja es nueva.
            SaveSetModel(true);             
        }

        //Guarda y sale a la pantalla principal.
        private void btnSaveExit_Click(object sender, EventArgs e)
        {
            SaveSetModel(false);
            this.Close();
        }

        //Guarda los datos actuales manteniendo el formulario abierto
        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                //Hay que obtener manualmente los controles, el binding solo funciona una vez                          
                SaveSetModel(true);
            }
            catch (Exception ex)
            {
                ErrorMessage.ShowErrorMessage(MethodBase.GetCurrentMethod().Name, ex.Message);
            }

        }


        //Método que gestiona el guardado del modelo y la apertura del formulario
        //Cambiar nombre argumento
        private void SaveSetModel(bool openFormAgain)
        {
            try
            {                
                //Hay que asociar manualmente los métodos.
                SetComboMethodsValuesToModel();
                SetControlsTopropierties();

                //Comprobar los campos obligatorios.
                if (!CheckMandatoryAtributtes())
                    return;

                //Gestiones del modelo según el tipo de operación.          
                Caja res = new Caja();

                switch (Operation)
                {
                    case EnumOperationType.New:
                        res = BaseModelClient.Service.Caja_Insert(Caja);
                        break;
                    case EnumOperationType.Modify:
                        res = BaseModelClient.Service.Caja_Update(Caja);
                        break;                    
                    default:
                        break;
                }               

                //Para la gestión del formulario
                if (openFormAgain)
                {
                    xtpImageVideo.PageVisible = true;
                    xtpInstrumentalSet.PageVisible = true;
                    btnSaveContinue.Visible = false;
                    btnSave.Visible = true;
                    Operation = EnumOperationType.Modify;
                    Caja.CajaId = res.CajaId;                    
                    //Nos aseguramos de liberar recursos
                    //this.Close();
                    //this.Dispose();
                    //SetManagmentForm fr = new SetManagmentForm()
                    //{
                    //    Caja = res,
                    //    Operation = EnumOperationType.Modify
                    //};
                    //fr.ShowDialog();

                }                
            }
            catch (Exception ex)
            {
                ErrorMessage.ShowErrorMessage(MethodBase.GetCurrentMethod().Name, ex.Message);
            }

        }

        private void SetControlsTopropierties()
        {
            Caja.EspId = SpecilitySelected?.EspId;
            Caja.HosIdPropietario = OwnerSelected?.HosId;
            Caja.TipoCajaId = SetTypeSelected?.Id;

            Caja.EmbId = PackageSelected?.ConId;
            Caja.CentroCosteId = CostCenterSelected?.Id;            
            Caja.CodigoCaja = string.IsNullOrEmpty(txtSetCode.Text)? null: txtSetCode.Text;
            Caja.Descripcion = txtSetName.Text;

            Caja.Peso = speWheight.Value;
            Caja.MantCiclos = Convert.ToInt32(speMaintenance.Value);
            Caja.Activa = tgsYesNo.IsOn;
            Caja.CajaMuestra = ckbSetSample.Checked;

            Caja.ObservCic = txtRemarksSteri.Text;
            Caja.ObservLav = txtRemarksWashes.Text;
            Caja.ObservEmp = txtRemarksAssemblyPackaging.Text;
        }  

        //Método que comprueba los campos obligatorios.
        private bool CheckMandatoryAtributtes()
        {
            if(string.IsNullOrEmpty(Caja.Descripcion)|| Caja.EspId == null)
            {
                if (string.IsNullOrEmpty(Caja.Descripcion))
                {
                    string[] mandatoryAtributtes = new string[1];
                    mandatoryAtributtes[0] = lblSetName.Text;
                    Engine.OpenMessageForm(84, mandatoryAtributtes);
                    return false;
                }

                if(Caja.EspId == null)
                {
                    string[] mandatoryAtributtes = new string[1];
                    mandatoryAtributtes[0] = lblSpeciality.Text;
                    Engine.OpenMessageForm(84, mandatoryAtributtes);
                    return false;
                }
                
            }
            return true;
        }

        //Método que asigna los valores de los combo por que no se pueden elazar
        private void SetComboMethodsValuesToModel()
        {
            Caja.TipoLavId1 = FirstWashingMethodSelected?.TipoLavId;
            Caja.TipoLavId2 = SecondWashingMethodSelected?.TipoLavId;
            Caja.TipoLavId3 = ThirdWashingMethodSelected?.TipoLavId;
            Caja.EstId1 = FirstSteriMethodSelected?.EstId;
            Caja.EstId2 = SecondSteriMethodSelected?.EstId;
            Caja.EstId3 = ThirdSteriMethodSelected?.EstId;
        }

        
        #endregion

        
    }
}