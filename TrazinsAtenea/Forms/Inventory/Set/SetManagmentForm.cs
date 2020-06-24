﻿using System;
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

            wmpVideo.Visible = false;
            wmpVideo.settings.autoStart = false;
            wmpVideo.settings.mute = true;
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
            wmpVideo.Ctlcontrols.stop();
            this.Close();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            MessageForm frm = new MessageForm(190);
            frm.ShowDialog();

            if (frm.DialogResult == DialogResult.Yes)
            {
                wmpVideo.Ctlcontrols.stop();
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
                if (!SearchEmptyPictureBox(null))
                {
                    return;
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
                    CreateImageModel(false);
                }

                DialogResult = DialogResult.None;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error en btnFromComputer_Click: " + ex.Message);
            }
        }

        private void AddImageVideo(CajaImagen cajaImagen, string url)
        {
            if (cajaImagen.EsVideo)
            {
                wmpVideo.Visible = true;
                wmpVideo.URL = url;
            }
            if (cajaImagen.EsImagen)
            {
                SearchEmptyPictureBox(cajaImagen.Image);
            }
        }

        private bool SearchEmptyPictureBox(Image image)
        {
            int numImages = 0;
            
            foreach (PanelControl panel in tableLayoutPanel1.Controls)
            {                
                foreach (Control item in panel.Controls)
                {
                    if (item is PictureBox)
                    {
                        var pictureBox = (PictureBox)item;
                        if (pictureBox.Image != null)
                        {
                            numImages++;                            
                        }
                        else
                        {
                            if(image != null)
                            {
                                    pictureBox.Image = image;
                                    return true;
                            }
                        }
                        
                    }

                    if (numImages == 5 && string.IsNullOrEmpty(wmpVideo.URL))
                    {
                        //Traducir desde bd
                        MessageBox.Show("NO se pueden añadir más elementos");
                        return false;
                    }
                    else if(numImages == 5 && !string.IsNullOrEmpty(wmpVideo.URL))
                    {
                        MessageBox.Show("Solo se puede añadir video");
                    }
                }
            }            

            return true;
        }

        #region Video Panel
        private void btnPlayVideo_Click(object sender, EventArgs e)
        {
            wmpVideo.Ctlcontrols.play();
            wmpVideo.settings.mute = true;
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            wmpVideo.Ctlcontrols.stop();
        }

        private void btnSixthPosition_Click(object sender, EventArgs e)
        {
            DeleteImageVideo(wmpVideo);
        }
        #endregion

        #region Delete Buttons

        private void btnFirstPosition_Click(object sender, EventArgs e)
        {
            DeleteImageVideo(pcbFirstPosition);
        }

        private void btnSecondPosition_Click(object sender, EventArgs e)
        {
            DeleteImageVideo(pcbSecondPosition);
        }

        private void btnTirthPosition_Click(object sender, EventArgs e)
        {
            DeleteImageVideo(pcbTirthPosition);
        }

        private void btnFourthPosition_Click(object sender, EventArgs e)
        {
            DeleteImageVideo(pcbFourthPosition);
        }

        private void btnFifthPosition_Click(object sender, EventArgs e)
        {
            DeleteImageVideo(pcbFifthPosition);
        }


        #endregion

        private void DeleteImageVideo(Control control)
        {
            if(control is PictureBox)
            {
                var pcb = (PictureBox)control;
                pcb.Image = null;
            }
            else
            {
                wmpVideo.URL = null;
                wmpVideo.Visible = false;
            }
        }

        private void btnFromCam_Click(object sender, EventArgs e)
        {
            WebCamForm frm = new WebCamForm();
            if(frm.ShowDialog() == DialogResult.OK)
            {
                CapturedImage = frm.ImageData;
                CreateImageModel(true);
            }
        }

        private Image CapturedImage;

        private void CreateImageModel(bool fromWebCam)
        {  
            CajaImagen cajaImagen = new CajaImagen();
            string type = string.Empty;

            if (fromWebCam)
            {
                using (MemoryStream stream = new MemoryStream())
                {
                    //Creamos un nuevo modelo de CajaImagen desde la webcam
                    CapturedImage.Save(stream, ImageFormat.Jpeg);
                    cajaImagen.Imagen = stream.ToArray();
                    cajaImagen.Image = CapturedImage;
                    cajaImagen.Nombre = DateTime.Now.ToShortDateString().ToString();
                    cajaImagen.Tipo = "image/jpeg";
                    type = "image";                    
                }
                
                
            }
            else
            {
                //Creamos un nuevo modelo de CajaImagen desde el archivo
                cajaImagen.Imagen = System.IO.File.ReadAllBytes(ofdImageVideo.FileName);
                cajaImagen.Nombre = ofdImageVideo.SafeFileName;
                cajaImagen.Tipo = MIMEAssistant.GetMIMEType(ofdImageVideo.FileName);
                
                //Obtenemos el tipo de archivo para asignar el valor.
                type = MIMEAssistant.FromFileName(ofdImageVideo.FileName).Type;
            }                        

            switch (type)
            {
                case "image":
                    cajaImagen.EsImagen = true;

                    //Obtenemos la imagen para mostrar en el picturebox
                    using (MemoryStream ms = new MemoryStream(cajaImagen.Imagen))
                    {
                        cajaImagen.Image = Image.FromStream(ms);
                        var weight = ms.Length;

                        if (!GetWeightImage(ms))
                        {
                            MessageBox.Show("Tamaño de imagen superior al permitido");
                            DialogResult = DialogResult.None;
                            return;
                        }                        
                    }

                    AddImageVideo(cajaImagen, null);
                    break;

                case "video":
                    //Comprobar que no machaque si hay uno asociado
                    if (!string.IsNullOrEmpty(wmpVideo.URL))
                    {
                        MessageBox.Show("Hay un video asociado");
                        DialogResult = DialogResult.None;
                        return;
                    }
                    cajaImagen.EsVideo = true;
                    AddImageVideo(cajaImagen, ofdImageVideo.FileName);
                    break;
                default:
                    break;
            }
        }

        private bool GetWeightImage(MemoryStream ms)
        {
            //Falta probar tamaño de vídeos...
            if (ms.Length > 3670016)//3,5 MB
            {
                return false;
            }
            return true;
        }
    }
}