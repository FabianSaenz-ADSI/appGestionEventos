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
    public partial class frmMedios : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            if (!IsPostBack)
            {
                mtdlistarRegistrados();
                Label lblUsuario = this.Master.FindControl("lblUsuario") as Label;
                Button btnIngresarLogin = this.Master.FindControl("btnIngresarLogin") as Button;
                HtmlAnchor crearCuenta = (HtmlAnchor)this.Master.FindControl("crearCuenta");
                HtmlAnchor crearEvento = (HtmlAnchor)this.Master.FindControl("crearEvento");
                btnIngresarLogin.Visible = false;
                crearCuenta.Visible = false;
                crearEvento.Visible = false;
            }
        }

        protected void btnRegistrarMedio_Click(object sender, EventArgs e)
        {
   

            if (txtMedio.Text == "" || txtTipoMedio.Text == "" || txtPublicidad.Text == "")
            {
                ClientScript.RegisterStartupScript(this.GetType(), "mensaje", "<script> swal('Error','Debe llenar todos los campos') </script>");
            }
            else if (true)
            {
                clMediosE objDatosMedios = new clMediosE();
                objDatosMedios.nombreMedio = txtMedio.Text;
                objDatosMedios.tipo = txtTipoMedio.Text;
                objDatosMedios.urlWeb = hplWeb.Text;
                objDatosMedios.redSocial = txtPublicidad.Text;
                objDatosMedios.idEvento = int.Parse(dpRegistradosMedios.SelectedValue);

                clMediosL objDatosL = new clMediosL();
                int resultado = objDatosL.mtdRegistrarM(objDatosMedios);

                if (resultado > 0)
                {
                    ClientScript.RegisterClientScriptBlock(this.GetType(), "Exito", "swal('Informacion Registrada Correctamente').then((value) => { window.location = 'frmInicio.aspx';});", true);
                }
                else
                {
                    ClientScript.RegisterStartupScript(this.GetType(), "mensaje", "<script> swal('Error','Error al Registrar') </script>");
                }
            }
        }

        protected void mtdlistarRegistrados()
        {
            clEventoL objRegistradosL = new clEventoL();
            dpRegistradosMedios.DataSource = objRegistradosL.mtdListarRegistrados();
            dpRegistradosMedios.DataTextField = "nombreEvento";
            dpRegistradosMedios.DataValueField = "idEvento";
            dpRegistradosMedios.DataBind();

            dpRegistradosMedios.Items.Insert(0, new ListItem("Seleccione el evento al que desea agregar los Medios", "0"));
        }
    }
}