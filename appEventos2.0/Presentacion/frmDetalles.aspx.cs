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
                List<clEventosE> listaDetallesL = new List<clEventosE>();
                listaDetallesL = objDetallesL.mtdListarDetallesL(idEvento);
                for (int i = 0; i < listaDetallesL.Count; i++)
                {
                    listaDetallesL[i].nombreEvento = listaDetallesL[i].nombreEvento;
                    listaDetallesL[i].ciudadEvento = listaDetallesL[i].ciudadEvento;
                    listaDetallesL[i].lugarEvento = listaDetallesL[i].lugarEvento;
                    listaDetallesL[i].edadMinima = listaDetallesL[i].edadMinima;
                    listaDetallesL[i].responsable = listaDetallesL[i].responsable;
                    listaDetallesL[i].direccion = listaDetallesL[i].direccion;
                    listaDetallesL[i].categoria = listaDetallesL[i].direccion;
                    listaDetallesL[i].aforo = listaDetallesL[i].aforo;
                    listaDetallesL[i].aperturaPuertas = listaDetallesL[i].aperturaPuertas;
                    listaDetallesL[i].nit = listaDetallesL[i].nit;
                    listaDetallesL[i].fechaInicioEvento = listaDetallesL[i].fechaInicioEvento;
                    listaDetallesL[i].fechaFinalEvento = listaDetallesL[i].fechaFinalEvento;
                    Image1.ImageUrl = "logoEvento\\" + listaDetallesL[i].imagenRepresentativa;
                    Image2.ImageUrl = "logoEvento\\" + listaDetallesL[i].imagenRepresentativa;
                    Image3.ImageUrl = "logoEvento\\" + listaDetallesL[i].imagenRepresentativa;
                    Image4.ImageUrl = "logoEvento\\" + listaDetallesL[i].imagenRepresentativa;
                }
                listadoGeneral.DataSource = listaDetallesL;
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