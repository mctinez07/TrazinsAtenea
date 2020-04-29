using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.SessionState;

namespace WSTrazinsAtenea
{
    public class Global : System.Web.HttpApplication
    {
        //Generamos la cadena de conexión al iniciar desde IIS la aplicación.
        protected void Application_Start(object sender, EventArgs e)
        {
            if (!ClassInitConnections.InitConnections())
                throw new InvalidOperationException("No se pudo inicializar el acceso a datos");
        }

        protected void Session_Start(object sender, EventArgs e)
        {

        }

        protected void Application_BeginRequest(object sender, EventArgs e)
        {

        }

        protected void Application_AuthenticateRequest(object sender, EventArgs e)
        {

        }

        protected void Application_Error(object sender, EventArgs e)
        {

        }

        protected void Session_End(object sender, EventArgs e)
        {

        }

        protected void Application_End(object sender, EventArgs e)
        {

        }
    }
}