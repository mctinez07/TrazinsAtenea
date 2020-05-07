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
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error en MessageForm_Load: " + ex.Message);
            }
            
        }
    }
}