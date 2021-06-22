using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Xml.Serialization;
using Utils;
using System.ComponentModel;

namespace Models.Inventory
{
    [DataContract(Namespace = "http://WSTrazinsAtenea.com")]
    public class CajaImagen : BaseModel
    {
        private int? _id;
        [DataMember]
        public int? Id
        {
            get { return _id; }
            set
            {
                _id = value;
                InvokePropertyChanged(new PropertyChangedEventArgs("Id"));
            }
        }

        private string _cajaId;

        [DataMember]
        public string CajaId
        {
            get { return _cajaId; }
            set
            {
                _cajaId = value;
                InvokePropertyChanged(new PropertyChangedEventArgs("CajaId"));
            }
        }

        private byte[] _imagen;

        //Array de bits que contendrá la imagen
        [DataMember]
        public byte[] Imagen
        {
            get { return _imagen; }
            set
            {
                _imagen = value;
                InvokePropertyChanged(new PropertyChangedEventArgs("Imagen"));
            }
        }

        private Image _image;

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

        private string _nombre;
        //Nombre de la imagen
        [DataMember]
        public string Nombre
        {
            get { return _nombre; }
            set
            {
                _nombre = value;
                InvokePropertyChanged(new PropertyChangedEventArgs("Nombre"));
            }
        }

        private string _tipo;
        //Tipo MIME de la imagen
        [DataMember]
        public string Tipo
        {
            get { return _tipo; }
            set
            {
                _tipo = value;
                InvokePropertyChanged(new PropertyChangedEventArgs("Tipo"));
                if (_tipo != null)
                    _contentType = new MIMEAssistant.ContentType(_tipo);
            }
        }

        
        public bool EsVideo { get{ return ContentType.Type == "video"; } }

        public bool EsImagen
        {
            get
            {
                return ContentType.Type == "image";
            }
            set { }
        }

        private bool _cargarImagenes;
        //Permite decidir si cargar solo la información sin imágenes.
        [DataMember]
        public bool CargarImagenes
        {
            get { return _cargarImagenes; }
            set
            {
                _cargarImagenes = value;
                InvokePropertyChanged(new PropertyChangedEventArgs("CargarImagenes"));
            }
        }

        private bool? _principal;

       
        /// Verdadero si es la imagen principal de la caja
        /// Sólo una imagen puede ser la principal de una caja.        
        [Mapping]
        public bool? Principal
        {
            get { return _principal; }
            set
            {
                _principal = value;
                InvokePropertyChanged(new PropertyChangedEventArgs( "Principal"));
            }
        }
    }
}
