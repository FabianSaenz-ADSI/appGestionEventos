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
    public partial class frmBoletas : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                Label lblUsuario = this.Master.FindControl("lblUsuario") as Label;
                Button btnIngresarLogin = this.Master.FindControl("btnIngresarLogin") as Button;
                HtmlAnchor crearCuenta = (HtmlAnchor)this.Master.FindControl("crearCuenta");
                HtmlAnchor crearEvento = (HtmlAnchor)this.Master.FindControl("crearEvento");
                btnIngresarLogin.Visible = false;
                crearCuenta.Visible = false;
                crearEvento.Visible = false;
                mtdlistarRegistrados();

            }


        }

        protected void mtdlistarRegistrados()
        {
            clEventoL objRegistradosL = new clEventoL();
            dpEventosRegistrados.DataSource = objRegistradosL.mtdListarRegistrados();
            dpEventosRegistrados.DataTextField = "nombreEvento";
            dpEventosRegistrados.DataValueField = "idEvento";
            dpEventosRegistrados.DataBind();

            dpEventosRegistrados.Items.Insert(0, new ListItem("Seleccione el evento al que desea agregar la boleta", "0"));
        }

        protected void btnRegistrarBoleta_Click(object sender, EventArgs e)
        {
            if (txtTipoBoleta.Text == "" || txtUbicacion.Text == "" || txtUbicacion.Text == "")
            {
                ClientScript.RegisterStartupScript(this.GetType(), "mensaje", "<script> swal('Error','Debe llenar todos los campos') </script>");
            }
            else if (true)
            {
                clBoletasE objDatosBoleta = new clBoletasE();
                objDatosBoleta.tipoBoleta = txtTipoBoleta.Text;
                objDatosBoleta.precioBoleta = txtPrecioBoleta.Text.ToString();
                objDatosBoleta.ubicacion = txtUbicacion.Text;
                objDatosBoleta.idEvento = int.Parse(dpEventosRegistrados.SelectedValue);


                clBoletasL objDatosL = new clBoletasL();
                int result = objDatosL.mtdRegistrarB(objDatosBoleta);
                if (result > 0)
                {
                    ClientScript.RegisterClientScriptBlock(this.GetType(), "Realizado", "swal('Boletas Agregadas Exitosamente').then((value) => { window.location = 'frmInicio.aspx';});", true);
                }
                else
                {
                    ClientScript.RegisterStartupScript(this.GetType(), "mensaje", "<script> swal('Advertencia','Error, Intente de Nuevo'   ) </script>");
                }
                mtdLimpiarDatosBoletas();
            }
        }

        protected void mtdLimpiarDatosBoletas()
        {
            txtTipoBoleta.Text = "";
            txtPrecioBoleta.Text = "";
            txtUbicacion.Text = "";

        }
    }
}