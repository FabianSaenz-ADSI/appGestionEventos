using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using appEventos2._0.Entidad;
using appEventos2._0.Logica;
namespace appEventos2._0.Presentacion
{
    public partial class frmMisReservas : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                Label lblUsuario = this.Master.FindControl("lblUsuario") as Label;
                Button btnIngresarLogin = this.Master.FindControl("btnIngresarLogin") as Button;
                HtmlAnchor crearCuenta = (HtmlAnchor)this.Master.FindControl("crearCuenta");
                HtmlAnchor crearEvento = (HtmlAnchor)this.Master.FindControl("crearEvento");
                if (Session["usuarioPersona"] == null && Session["usuarioEmpresa"] == null)
                {
                    Response.Redirect("../Login.aspx");
                }
                else
                {
                    btnIngresarLogin.Visible = false;
                    crearCuenta.Visible = false;
                    crearEvento.Visible = false;
                    if (Session["usuarioPersona"] != null)
                    {
                        lblUsuario.Text = Session["usuarioPersona"].ToString();


                    }
                    else
                    {
                        lblUsuario.Text = Session["usuarioEmpresa"].ToString();


                    }
                }
            }



        }

        [WebMethod]
        public static List<clReservaE> mtdListarReservaBoleta()
        {
            clReservaE objDatos = new clReservaE();
            if (HttpContext.Current.Session["idUsuarioPersona"] != null)
            {
                objDatos.idPersona = int.Parse(HttpContext.Current.Session["idUsuarioPersona"].ToString());
            }
            else
            {
                objDatos.idEmpresa = int.Parse(HttpContext.Current.Session["idUsuarioEmpresa"].ToString());

            }

            List<clReservaE> listaRerva = new List<clReservaE>();
            listaRerva = clReservaBoletaL.mtdListarReservaBoleta(objDatos);
            return listaRerva;
        }

        [WebMethod]

        public static bool mtdCancelarReserva(clReservaE objDatos)
        {
            clReservaBoletaL objDatosReservaBoletaL = new clReservaBoletaL();
            int r = objDatosReservaBoletaL.mtdCancelarReserva(objDatos);
            bool respuesta;
            if (r > 0)
            {
                respuesta = true;

            }
            else
            {
                respuesta = false;
            }
            return respuesta;

        }


    }
}