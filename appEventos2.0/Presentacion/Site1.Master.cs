using appEventos2._0.Entidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


namespace appEventos2._0.Presentacion
{
    public partial class Site1 : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnIngresarLogin_Click(object sender, EventArgs e)
        {
            Response.Redirect("../Login.aspx");
        }

        protected void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            Session.RemoveAll();
            Response.Redirect("frmInicio.aspx");
        }

        protected void btnParticipante_Click(object sender, EventArgs e)
        {


            lblRol.Text = " /Participante";
            Session["idTipoRol"] = "Participante";
            crearEvento.Visible = false;


        }

        protected void btnPatrocinador_Click(object sender, EventArgs e)
        {
            lblRol.Text = " /Patrocinador";
            Session["idTipoRol"] = "Patrocinador";
            crearEvento.Visible = false;
            Response.Redirect("frmPatrocinar.aspx");

        }

        protected void btnOrganizador_Click(object sender, EventArgs e)
        {

            lblRol.Text = " /Organizador";
            Session["idTipoRol"] = "Organizador";
            crearEvento.Visible = true;

           
            


        }

        protected void btnPerfil_Click(object sender, EventArgs e)
        {
            
           

            if (Session["idUsuarioPersona"] == null)
            {
                Response.Redirect("frmEditarEmpresa.aspx");
            }
            else
            {

                Response.Redirect("frmPerfilPersona.aspx");
            }
            
        }

        protected void btnReservas_Click(object sender, EventArgs e)
        {
            Response.Redirect("frmMisReservas.aspx");
        }
    }
}