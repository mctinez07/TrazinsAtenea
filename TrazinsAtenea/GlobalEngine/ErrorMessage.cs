using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrazinsAtenea.GlobalEngine
{
    //Clase para la gestión de errores. en caso de solicitar un log se realizaría desde aquí.
    public static class ErrorMessage
    {
        public static void ShowErrorMessage(string method, string err)
        {
            string errorMesage = string.Format("Error {0}: {1}", method, err);
            MessageBox.Show(errorMesage, "Trazins Atenea", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public static void ShowErrorMessage(string err)
        {
            string errorMesage = string.Format("Error:{0}", err);
            MessageBox.Show(errorMesage, "Trazins Atenea", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
