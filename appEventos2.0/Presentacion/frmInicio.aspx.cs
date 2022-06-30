using appEventos2._0.Entidad;
using appEventos2._0.Logica;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;

namespace appEventos2._0.Presentacion
{
    public partial class frmInicio2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            if (!IsPostBack)
            {
                mtdListarEventosInicio();
            }


            Label lblUsuario = this.Master.FindControl("lblUsuario") as Label;
            Button btnIngresarLogin = this.Master.FindControl("btnIngresarLogin") as Button;
            HtmlAnchor crearCuenta = (HtmlAnchor)this.Master.FindControl("crearCuenta");
            HtmlAnchor crearEvento = (HtmlAnchor)this.Master.FindControl("crearEvento");
            HtmlAnchor tipoRol = (HtmlAnchor)this.Master.FindControl("tipoRol");



            crearEvento.Visible = false;
            tipoRol.Visible = false;

            if (Session["usuarioPersona"] == null && Session["idUsuarioPersona"] == null && Session["usuarioEmpresa"] == null
                && Session["idUsuarioEmpresa"] == null)
            {
                lblUsuario.Visible = false;


            }
            else
            {

                lblUsuario.Visible = true;
                tipoRol.Visible = true;
                btnIngresarLogin.Visible = false;


                if (Session["usuarioPersona"] == null)
                {
                    lblUsuario.Text = Session["usuarioEmpresa"].ToString();
                    crearCuenta.Visible = false;




                }
                else
                {
                    lblUsuario.Text = Session["usuarioPersona"].ToString();
                    crearCuenta.Visible = false;

                }

            }

        }

        protected void mtdListarEventosInicio()
        {
            clEventoL objlistadoEventosL = new clEventoL();
            rpEventos.DataSource = objlistadoEventosL.mtdListarEventosLogica();
            rpEventos.DataBind();

        }

        protected void btnDetalles_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            RepeaterItem item = (RepeaterItem)btn.NamingContainer;

            //Busca el Item de ese control
            Label lbl = (Label)item.FindControl("labelDato");
            int idEvento = int.Parse(lbl.Text);
            Response.Redirect("frmDetalles.aspx?idE=" + idEvento);


        }

        protected void btnReserva_Click(object sender, EventArgs e)
        {


            if (Session["idUsuarioPersona"] != null || Session["idUsuarioEmpresa"] != null)
            {

                Button btn = (Button)sender;
                RepeaterItem item = (RepeaterItem)btn.NamingContainer;

                //Busca el Item de ese control
                Label lbl = (Label)item.FindControl("labelDato");
                int idEvento = int.Parse(lbl.Text);
                Session["idEvento"] = idEvento;
                Response.Redirect("frmReservaBoleta.aspx");
            }
            else
            {
                Response.Redirect("../Login.aspx");
            }
        }
    }
}