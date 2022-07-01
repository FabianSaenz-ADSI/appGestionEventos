using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;

namespace appEventos2._0.Presentacion
{
    public partial class frmConfirmarPago : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Label lblUsuario = this.Master.FindControl("lblUsuario") as Label;
            HtmlAnchor crearCuenta = (HtmlAnchor)this.Master.FindControl("crearCuenta");
            Button btnIngresarLogin = this.Master.FindControl("btnIngresarLogin") as Button;
            HtmlAnchor tipoRol = (HtmlAnchor)this.Master.FindControl("tipoRol");

            lblUsuario.Visible = false;
            crearCuenta.Visible = false;
            tipoRol.Visible = false;
            btnIngresarLogin.Visible = false;


        }
    }
}