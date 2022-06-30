using appEventos2._0.Entidad;
using appEventos2._0.Logica;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace appEventos2._0.Presentacion
{
    public partial class frmDetalles : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            if (!IsPostBack)
            {
                string valor = Convert.ToString(Request.QueryString["idE"]);
                labelDetalles.Attributes.Add("Style", "DISPLAY:none");
                labelDetalles.Text = valor;
                int idEvento = int.Parse(valor);


                clDetallesL objDetallesL = new clDetallesL();
                listadoGeneral.DataSource = objDetallesL.mtdListarDetallesL(idEvento);
                listadoGeneral.DataBind();
            }




        }
        protected void btnRegresar_Click(object sender, EventArgs e)
        {

            Response.Redirect("frmInicio.aspx");
        }

        protected void btnAsistir_Click(object sender, EventArgs e)
        {

            Button btn = (Button)sender;
            ListViewDataItem item = (ListViewDataItem)btn.NamingContainer;
            Label lbl = (Label)item.FindControl("labelDetalles");
            int idEventoCompra = int.Parse(labelDetalles.Text);
            Response.Redirect("frmCompraBoleta.aspx?idE=" + idEventoCompra);



        }

        protected void btnQr_Click(object sender, EventArgs e)
        {
            Response.Redirect("frmCompraQr.aspx");
        }
    }
}