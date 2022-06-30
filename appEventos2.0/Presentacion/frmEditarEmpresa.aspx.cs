using appEventos2._0.Entidad;
using appEventos2._0.Logica;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;

namespace appEventos2._0.Presentacion
{
    public partial class frmEditarEmpresa : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            HtmlAnchor crearCuenta = (HtmlAnchor)this.Master.FindControl("crearCuenta");
            HtmlAnchor crearEvento = (HtmlAnchor)this.Master.FindControl("crearEvento");
            HtmlAnchor tipoRol = (HtmlAnchor)this.Master.FindControl("tipoRol");
            Button ingresar = this.Master.FindControl("btnIngresarLogin") as Button;

            crearCuenta.Visible = false;
            crearEvento.Visible = false;
            tipoRol.Visible = false;
            ingresar.Visible = false;


            if (!IsPostBack)
            {
                int idUsuarioEmpresa = int.Parse(Session["idUsuarioEmpresa"].ToString());

                clEmpresaL objDatos = new clEmpresaL();
                clEmpresaE objDatosRecibeL = new clEmpresaE();
                objDatosRecibeL = objDatos.mtdListarEmpresa(idUsuarioEmpresa);

                if (objDatosRecibeL != null)
                {

                    txtNombreEditar.Text = objDatosRecibeL.nombreEmpresa;
                    txtDireccionEditar.Text = objDatosRecibeL.direccionEmpresa;
                    txtCorreoEditar.Text = objDatosRecibeL.emailEmpresa;
                    txtTelefonoEditar.Text = objDatosRecibeL.telefonoEmpresa;
                    txtNitEditar.Text = objDatosRecibeL.nit;
                    txtContraseñaEditar.Text = objDatosRecibeL.claveEmpresa;
                }

            }
        }
        private void limpiar()
        {

            txtNombreEditar.Text = "";
            txtDireccionEditar.Text = "";
            txtCorreoEditar.Text = "";
            txtTelefonoEditar.Text = "";
            txtNitEditar.Text = "";
            txtContraseñaEditar.Text = "";


        }

        protected void btnActualizar_Click(object sender, EventArgs e)
        {

            clEmpresaE objDatosEmpresa = new clEmpresaE();
            int idUsuarioEmpresa = int.Parse(Session["idUsuarioEmpresa"].ToString());
            objDatosEmpresa.nombreEmpresa = txtNombreEditar.Text;
            objDatosEmpresa.direccionEmpresa = txtDireccionEditar.Text;
            objDatosEmpresa.emailEmpresa = txtCorreoEditar.Text;
            objDatosEmpresa.telefonoEmpresa = txtTelefonoEditar.Text;
            objDatosEmpresa.nit = txtNitEditar.Text;
            objDatosEmpresa.claveEmpresa = txtContraseñaEditar.Text;

            clEmpresaL objDatosEmpresaL = new clEmpresaL();
            int resultado = objDatosEmpresaL.mtdEditarEmpresa(objDatosEmpresa, idUsuarioEmpresa);

            if (resultado > 0)
            {
                ClientScript.RegisterStartupScript(this.GetType(), "mensaje", "<script> swal('Exito!', 'Datos Actualizados Correctamente!','info') </script>");

            }
            else
            {
                ClientScript.RegisterStartupScript(this.GetType(), "mensaje", "<script> swal('Alerta!', 'Error al Actualizar!','info') </script>");

            }

        }

        protected void btnEliminar_Click(object sender, EventArgs e)
        {
            int idUsuarioEmpresa = int.Parse(Session["idUsuarioEmpresa"].ToString());
            clEmpresaL objDatosEmpresa = new clEmpresaL();
            int resultado = objDatosEmpresa.mtdEliminarEmpresa(idUsuarioEmpresa);
            if (resultado > 0)
            {
                Session.RemoveAll();
                ClientScript.RegisterClientScriptBlock(this.GetType(), "alerta", "swal('Usuario Eliminado').then((value) => { window.location = 'frmInicio.aspx';});", true);

                limpiar();

            }
            else
            {
                ClientScript.RegisterStartupScript(this.GetType(), "mensaje", "<script> swal('Alerta!', 'Error al Eliminar!','info') </script>");

            }
        }
    }
    
}