using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using appEventos2._0.Entidad;
using appEventos2._0.Logica;

namespace appEventos2._0.Presentacion
{
    public partial class frmDetalleReserva : System.Web.UI.Page
    {




        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                Label lblUsuario = this.Master.FindControl("lblUsuario") as Label;
                Button btnIngresarLogin = this.Master.FindControl("btnIngresarLogin") as Button;
                HtmlAnchor crearCuenta = (HtmlAnchor)this.Master.FindControl("crearCuenta");
                HtmlAnchor crearEvento = (HtmlAnchor)this.Master.FindControl("crearEvento");
                HtmlAnchor tipoRol = (HtmlAnchor)this.Master.FindControl("tipoRol");

                btnIngresarLogin.Visible = false;
                crearCuenta.Visible = false;
                crearEvento.Visible = false;

                if (Session["usuarioPersona"] == null)
                {
                    lblUsuario.Text = Session["usuarioEmpresa"].ToString();





                }
                else
                {
                    lblUsuario.Text = Session["usuarioPersona"].ToString();


                }




                int idBoletaReserva = int.Parse(Session["idBoletaReserva"].ToString());

                clReservaBoletaL objDatosReservaBoletaL = new clReservaBoletaL();
                clBoleteriaE objDatosBoleteria = new clBoleteriaE();
                objDatosBoleteria = objDatosReservaBoletaL.mtdListarDetalleReserva(idBoletaReserva);

                if (objDatosBoleteria != null)
                {
                    lblFechaReserva.Text = objDatosBoleteria.fechaReserva;
                    lblCantidadBoletas.Text = objDatosBoleteria.cantidadBoletas;
                    lblNombreEvento.Text = objDatosBoleteria.nombreEvento;
                    lblTotalReserva.Text = Convert.ToString(objDatosBoleteria.totalReserva);
                }
            }



        }
    }
}