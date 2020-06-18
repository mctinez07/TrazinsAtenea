using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Xml.Serialization;
using Utils;

namespace Models.Inventory
{
    [DataContract(Namespace = "http://WSTrazinsAtenea.com")]
    public class CajaImagen : BaseModel
    {
        [DataMember]
        public int? Id { get; set; }

        [DataMember]
        public string CajaId { get; set; }

        //Array de bits que contendrá la imagen
        [DataMember]
        public byte[] Imagen { get; set; }

        private Image _image;

        [DataMember]
        public Image Image
        {
            get
            {
                if (ContentType.Type != "image" || Imagen == null || Imagen.Length == 0)
                    return null;

                if (_image == null)
                    _image = (Image)new ImageConverter().ConvertFrom(Imagen);

                return _image;
            }
        }

        private MIMEAssistant.ContentType _contentType = new MIMEAssistant.ContentType();
        
        public MIMEAssistant.ContentType ContentType
        {
            get
            {
                return _contentType;
            }
        }

        //Nombre de la imagen
        [DataMember]
        public string Nombre { get; set; }

        private string _tipo;
        //Tipo MIME de la imagen
        [DataMember]
        public string Tipo
        {
            get { return _tipo; }
            set { if(_tipo != null) _contentType = new MIMEAssistant.ContentType(_tipo); }
        }

        [DataMember]
        public bool EsVideo
        {
            get
            {
                return ContentType.Type == "video";
            }
        }

        [DataMember]
        public bool EsImagen { get { return ContentType.Type == "image"; } }

        //Permite decidir si cargar solo la información sin imágenes.
        [DataMember]
        public bool CargarImagenes { get; set; }
    }
}
