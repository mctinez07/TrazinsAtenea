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
using TrazinsAtenea.ServiceWSTrazinsAtenea;
using System.Reflection;
using Models.Messages;

namespace TrazinsAtenea.Forms.GlobalForms
{
    public partial class MessageForm : DevExpress.XtraEditors.XtraForm
    {
        private string Lang;
        private int MessageId;

        //Pendiente desarrollo recuperar mensaje desde DB
        //Es posible que cambie el titulo según el tipo de mensaje.

        public MessageForm(int messageId)
        {
            InitializeComponent();

            this.MessageId = messageId;

            //Obtenemos el idioma para la traducción de los mensajes desde DB
            this.Lang = System.Threading.Thread.CurrentThread.CurrentUICulture.ToString();
        }

        private void MessageForm_Load(object sender, EventArgs e)
        {
            try
            {
                var service = BaseModelClient.Instance.Service;

                var message = service.Mensaje_Select(new Mensaje() { Id = MessageId, Idioma = Lang });

                foreach (Control item in this.Controls)
                {
                    if (item is SimpleButton)
                        item.Text = Engine.GetLanguageResource(item.Name);
                }

                lblMessageTitle.Text = message.Titulo;
                lblMessage.Text = message.Texto;

                //Establecemos los botones según el tipo de mensaje
                SetButtonsStates(message.TipoId);
            }
            catch (Exception ex)
            {
                ErrorMessage.ShowErrorMessage(MethodBase.GetCurrentMethod().Name, ex.Message);
            }
            
        }

        private void SetButtonsStates(int tipo)
        {
            switch (tipo)
            {
                case 1: //Atención
                    btnAccept.Visible = false;
                    pcbMessageIcon.Image = Properties.Resources.warning_48x48;
                    break;
                case 2://Información.
                    btnNo.Visible = false;
                    btnYes.Visible = false;
                    pcbMessageIcon.Image = Properties.Resources.info_48x48;
                    btnAccept.Location = new Point(355, 415);
                    break;
                default:
                    break;
            };
        }

        private void btnYes_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Yes;
        }

        private void btnNo_Click(object sender, EventArgs e)
        {
            DisposeExit();
        }       

        private void btnAccept_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }

        private void pcbExit_Click(object sender, EventArgs e)
        {
            DisposeExit();
        }

        private void DisposeExit()
        {
            this.Dispose();
            DialogResult = DialogResult.None;
        }
    }
}