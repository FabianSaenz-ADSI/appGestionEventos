using appEventos2._0.Entidad;
using appEventos2._0.Logica;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace appEventos2._0.Presentacion
{
    public partial class frmCompraBoleta : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {


            btnComprar.Visible = false;



            if (!IsPostBack)
            {

                int valor = int.Parse(Request.QueryString["idE"]);



                clCompraBoletaL objlistadoEventosL = new clCompraBoletaL();
                clBoletasE comprar = new clBoletasE();
                comprar = objlistadoEventosL.mtdListarCompra(valor);


                if (comprar != null)
                {

                    txtNom.Text = comprar.nombreEvento;
                    txtEvento.Text = comprar.tipoBoleta;
                    txtPrecio.Text = comprar.precioBoleta;



                }
            }

        }




        protected void btnComprar_Click(object sender, EventArgs e)
        {

            

            if (Session["idUsuarioPersona"] != null)
            {
                string valor = Convert.ToString(Request.QueryString["idE"]);
                int idEventoCompra = int.Parse(valor);

                clCompraE objCom = new clCompraE();
                objCom.idPersona = int.Parse(Session["idUsuarioPersona"].ToString());
                objCom.idEvento = idEventoCompra;               
                objCom.PrecioTotal = txtTotal.Text;
                objCom.cantidadBoletas = txtCantidad.Text;
                clCompraBoletaL objCliente = new clCompraBoletaL();
                int resultado = objCliente.mtdRegistrarp(objCom);

                if (resultado > 0)
                {

                    Response.Redirect("frmConfirmarPago.aspx");


                }
            }
            if (Session["idUsuarioEmpresa"] != null)
            {

                string valor = Convert.ToString(Request.QueryString["idE"]);
                int idEventoCompra = int.Parse(valor);

                clCompraE objCom = new clCompraE();
                objCom.idEmpresa = int.Parse(Session["idUsuarioEmpresa"].ToString());
                objCom.idEvento = idEventoCompra;
                objCom.PrecioTotal = txtTotal.Text;
                objCom.cantidadBoletas = txtCantidad.Text;
                clCompraBoletaL objCliente = new clCompraBoletaL();
                int resultado = objCliente.mtdRegistrar(objCom);

                if (resultado > 0)
                {

                    Response.Redirect("frmConfirmarPago.aspx");


                }
             

            }


            



           
        }

        protected void btnTotal_Click(object sender, EventArgs e)
        {
            int precio = int.Parse(txtPrecio.Text);
            int cantidad = int.Parse(txtCantidad.Text);
            float resultado = precio * cantidad;

            txtTotal.Text = Convert.ToString(resultado);
            btnComprar.Visible = true;

        }
    }
}