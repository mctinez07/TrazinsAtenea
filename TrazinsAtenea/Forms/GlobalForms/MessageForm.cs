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

namespace TrazinsAtenea.Forms.GlobalForms
{
    public partial class MessageForm : DevExpress.XtraEditors.XtraForm
    {
        private string Lang;

        //Pendiente desarrollo recuperar mensaje desde DB
        //Es posible que cambie el titulo según el tipo de mensaje.

        public MessageForm()
        {
            InitializeComponent();

            //Obtenemos el idioma para la traducción de los mensajes desde DB
            this.Lang = System.Threading.Thread.CurrentThread.CurrentUICulture.ToString();
        }

        private void MessageForm_Load(object sender, EventArgs e)
        {
            foreach (Control item in this.Controls)
            {
                if(item is SimpleButton)
                    item.Text = Engine.GetLanguageResource(item.Name);
            }
        }
    }
}