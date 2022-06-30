using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.SessionState;

namespace appEventos2._0
{
    public class Global : System.Web.HttpApplication
    {

        protected void Application_Start(object sender, EventArgs e)
        {

        }

        protected void Session_Start(object sender, EventArgs e)
        {
            Session["usuarioPersona"] = null;
            Session["usuarioEmpresa"] = null;
            Session["idUsuarioPersona"] = null;
            Session["idUsuarioEmpresa"] = null;
            Session["idEmpresaEvento"] = null;
            Session["idPersonaEvento"] = null;
            Session["idBoletaReserva"] = null;
            Session["totalReserva"] = 0;





            Session["idTipoRol"] = null;
            Session["idEvento"] = null;

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
            Session["usuarioPersona"] = null;
            Session["usuarioEmpresa"] = null;
            Session["idUsuarioPersona"] = null;
            Session["idUsuarioEmpresa"] = null;
            Session["idEmpresaEvento"] = null;
            Session["idPersonaEvento"] = null;
            Session["idBoletaReserva"] = null;
            Session["totalReserva"] = 0;



            Session["idTipoRol"] = null;
            Session["idEvento"] = null;

        }

        protected void Application_End(object sender, EventArgs e)
        {

        }
    }
}