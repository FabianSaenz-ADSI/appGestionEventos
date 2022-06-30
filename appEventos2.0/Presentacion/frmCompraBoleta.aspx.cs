using appEventos2._0.Logica;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace appEventos2._0.Presentacion
{
    public partial class frmCompraBoleta : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            if (!IsPostBack)
            {
                string valor = Convert.ToString(Request.QueryString["idE"]);
                int idEventoCompra = int.Parse(valor);


                clCompraBoletaL objlistadoEventosL = new clCompraBoletaL();
                listadoCompra.DataSource = objlistadoEventosL.mtdListarCompra(idEventoCompra);
                listadoCompra.DataBind();

            }
            





        }
    }
}