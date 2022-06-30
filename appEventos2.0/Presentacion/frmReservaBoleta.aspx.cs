using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using appEventos2._0.Entidad;
using appEventos2._0.Logica;

namespace appEventos2._0.Presentacion
{
    public partial class frmReservaBoleta : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {



            if (!IsPostBack)
            {
                Label lblUsuario = this.Master.FindControl("lblUsuario") as Label;
                Button btnIngresarLogin = this.Master.FindControl("btnIngresarLogin") as Button;
                HtmlAnchor crearCuenta = (HtmlAnchor)this.Master.FindControl("crearCuenta");
                HtmlAnchor crearEvento = (HtmlAnchor)this.Master.FindControl("crearEvento");
                HtmlAnchor tipoRol = (HtmlAnchor)this.Master.FindControl("tipoRol");
                btnIngresarLogin.Visible = false;
                crearCuenta.Visible = false;
                crearEvento.Visible = false;
                btnReservar.Visible = false;
                txtNombreEvento.ReadOnly = true;
                txtFechaInicio.ReadOnly = true;
                txtFechaFinal.ReadOnly = true;
                txtAperturaPuertas.ReadOnly = true;
                txtLugarEvento.ReadOnly = true;
                txtResponsable.ReadOnly = true;
                txtCiudadEvento.ReadOnly = true;
                txtDireccionEvento.ReadOnly = true;
                txtTotalReserva.ReadOnly = true;


                if (Session["usuarioPersona"] == null && Session["usuarioEmpresa"] == null)
                {
                    Response.Redirect("../Login.aspx");
                }
                else
                {
                    if (Session["usuarioPersona"] != null)
                    {
                        lblUsuario.Text = Session["usuarioPersona"].ToString();


                    }
                    else
                    {
                        lblUsuario.Text = Session["usuarioEmpresa"].ToString();


                    }

                    clEventosE objDatosEventoEmpresa = new clEventosE();
                    clReservaBoletaL objDatosReservaL = new clReservaBoletaL();
                    objDatosEventoEmpresa.idEvento = int.Parse(Session["idEvento"].ToString());
                    clEmpresaEventoE objEmpresaEventoE = new clEmpresaEventoE();
                    string tipoRolEmpresa = "Organizador";

                    objEmpresaEventoE = objDatosReservaL.mtdListarEmpresaEvento(objDatosEventoEmpresa, tipoRolEmpresa);
                    ////////////////////////////////////////////////////////////////////////////////////////
                    clEventosE objDatosEventoPersona = new clEventosE();
                    clReservaBoletaL objDatosPersonaEventoL = new clReservaBoletaL();
                    objDatosEventoPersona.idEvento = int.Parse(Session["idEvento"].ToString());
                    clPersonaEventoE objDatosPersonaEventoE = new clPersonaEventoE();
                    string tipoRolPersona = "Organizador";
                    objDatosPersonaEventoE = objDatosPersonaEventoL.mtdListarPersonaEvento(objDatosEventoPersona, tipoRolPersona);

                    if (objEmpresaEventoE != null)
                    {
                        txtNombreEvento.Text = objEmpresaEventoE.nombreEvento;
                        txtFechaInicio.Text = objEmpresaEventoE.fechaInicioEvento.ToString();
                        txtFechaFinal.Text = objEmpresaEventoE.fechaFinalEvento.ToString();
                        txtAperturaPuertas.Text = objEmpresaEventoE.aperturaPuertas;

                        txtLugarEvento.Text = objEmpresaEventoE.lugarEvento;
                        txtResponsable.Text = objEmpresaEventoE.responsable;
                        txtCiudadEvento.Text = objEmpresaEventoE.ciudadEvento;
                        txtDireccionEvento.Text = objEmpresaEventoE.direccion;
                        imgEvento.ImageUrl = "logoEvento\\" + objEmpresaEventoE.imagenRepresentativa;
                        Session["idEmpresaEvento"] = objEmpresaEventoE.idEmpresaEvento;
                    }
                    else
                    {


                        txtNombreEvento.Text = objDatosPersonaEventoE.nombreEvento;
                        txtFechaInicio.Text = objDatosPersonaEventoE.fechaInicioEvento.ToString();
                        txtFechaFinal.Text = objDatosPersonaEventoE.fechaFinalEvento.ToString();
                        txtAperturaPuertas.Text = objDatosPersonaEventoE.aperturaPuertas;
                        txtLugarEvento.Text = objDatosPersonaEventoE.lugarEvento;
                        txtResponsable.Text = objDatosPersonaEventoE.responsable;
                        txtCiudadEvento.Text = objDatosPersonaEventoE.ciudadEvento;
                        txtDireccionEvento.Text = objDatosPersonaEventoE.direccion;
                        imgEvento.ImageUrl = "logoEvento\\" + objDatosPersonaEventoE.imagenRepresentativa;
                        Session["idPersonaEvento"] = objDatosPersonaEventoE.idPersonaEvento;

                    }





                }








                clReservaBoletaL objDatosReserva = new clReservaBoletaL();
                clBoletasE objDatos = new clBoletasE();
                objDatos.idEvento = int.Parse(Session["idEvento"].ToString());

                ddlListaTipoBoleta.DataSource = objDatosReserva.mtdListarTipoBoleta(objDatos);
                ddlListaTipoBoleta.DataValueField = "idTipoBoleta";
                ddlListaTipoBoleta.DataTextField = "TipoBoleta";
                ddlListaTipoBoleta.DataBind();
                ddlListaTipoBoleta.Items.Insert(0, "-- Seleccione tipo de Boleta --");
            }



        }


        protected void btnReservar_Click(object sender, EventArgs e)
        {
            clReservaE objDatosReservaBoletaE = new clReservaE();
            objDatosReservaBoletaE.idEmpresaEvento = 0;
            objDatosReservaBoletaE.idPersonaEvento = 0;
            objDatosReservaBoletaE.idPersona = 0;
            objDatosReservaBoletaE.idEmpresa = 0;


            objDatosReservaBoletaE.fechaReserva = DateTime.Now.ToString();
            objDatosReservaBoletaE.cantidadBoletas = txtCantidadBoletas.Text;
            objDatosReservaBoletaE.idEvento = int.Parse(Session["idEvento"].ToString());

            if (Session["idEmpresaEvento"] != null)
            {

                if (Session["idUsuarioPersona"] != null)
                {
                    objDatosReservaBoletaE.idEmpresaEvento = int.Parse(Session["idEmpresaEvento"].ToString());
                    objDatosReservaBoletaE.idPersona = int.Parse(Session["idUsuarioPersona"].ToString());
                    objDatosReservaBoletaE.totalReserva = float.Parse(Session["totalReserva"].ToString());

                    clReservaBoletaL objDatosReservaBoletaL = new clReservaBoletaL();
                    int resultado1 = objDatosReservaBoletaL.mtdInsertarReserva(objDatosReservaBoletaE);

                    if (resultado1 > 0)
                    {
                        Session["idBoletaReserva"] = resultado1;



                        ClientScript.RegisterClientScriptBlock(this.GetType(), "Mensaje", "swal('Alerta','Reserva realizada con Exito!','info').then((value) => { window.location = 'frmDetalleReserva.aspx';});", true);


                    }
                    else
                    {
                        ClientScript.RegisterStartupScript(this.GetType(), "mensaje", "<script>swal('Alerta!', 'Error al reservar!', 'info')</script>");

                    }

                }
                else
                {
                    objDatosReservaBoletaE.idEmpresaEvento = int.Parse(Session["idEmpresaEvento"].ToString());
                    objDatosReservaBoletaE.idEmpresa = int.Parse(Session["idUsuarioEmpresa"].ToString());
                    objDatosReservaBoletaE.totalReserva = float.Parse(Session["totalReserva"].ToString());
                    clReservaBoletaL objDatosReservaBoletaL = new clReservaBoletaL();
                    int resultado1 = objDatosReservaBoletaL.mtdInsertarReserva(objDatosReservaBoletaE);

                    if (resultado1 > 0)
                    {
                        Session["idBoletaReserva"] = resultado1;



                        ClientScript.RegisterClientScriptBlock(this.GetType(), "Mensaje", "swal('Alerta','Reserva realizada con Exito!','info').then((value) => { window.location = 'frmDetalleReserva.aspx';});", true);


                    }
                    else
                    {
                        ClientScript.RegisterStartupScript(this.GetType(), "mensaje", "<script>swal('Alerta!', 'Error al reservar!', 'info')</script>");

                    }

                }


            }
            else
            {
                if (Session["idUsuarioPersona"] != null)
                {
                    objDatosReservaBoletaE.idPersonaEvento = int.Parse(Session["idPersonaEvento"].ToString());
                    objDatosReservaBoletaE.idPersona = int.Parse(Session["idUsuarioPersona"].ToString());
                    objDatosReservaBoletaE.totalReserva = float.Parse(Session["totalReserva"].ToString());

                    clReservaBoletaL objDatosReservaBoletaL = new clReservaBoletaL();
                    int resultado2 = objDatosReservaBoletaL.mtdInsertarReserva(objDatosReservaBoletaE);

                    if (resultado2 > 0)
                    {
                        Session["idBoletaReserva"] = resultado2;

                        ClientScript.RegisterClientScriptBlock(this.GetType(), "Mensaje", "swal('Alerta','Reserva realizada con Exito!','info').then((value) => { window.location = 'frmDetalleReserva.aspx';});", true);



                    }
                    else
                    {
                        ClientScript.RegisterStartupScript(this.GetType(), "mensaje", "<script>swal('Alerta!', 'Error al reservar!', 'info')</script>");

                    }

                }
                else
                {
                    objDatosReservaBoletaE.idPersonaEvento = int.Parse(Session["idPersonaEvento"].ToString());
                    objDatosReservaBoletaE.idEmpresa = int.Parse(Session["idUsuarioEmpresa"].ToString());
                    objDatosReservaBoletaE.totalReserva = float.Parse(Session["totalReserva"].ToString());
                    clReservaBoletaL objDatosReservaBoletaL = new clReservaBoletaL();
                    int resultado2 = objDatosReservaBoletaL.mtdInsertarReserva(objDatosReservaBoletaE);

                    if (resultado2 > 0)
                    {
                        Session["idBoletaReserva"] = resultado2;

                        ClientScript.RegisterClientScriptBlock(this.GetType(), "Mensaje", "swal('Alerta','Reserva realizada con Exito!','info').then((value) => { window.location = 'frmDetalleReserva.aspx';});", true);



                    }
                    else
                    {
                        ClientScript.RegisterStartupScript(this.GetType(), "mensaje", "<script>swal('Alerta!', 'Error al reservar!', 'info')</script>");

                    }

                }

            }



        }



        protected void btnCalcular_Click(object sender, EventArgs e)
        {
            if (ddlListaTipoBoleta.SelectedValue == "-- Seleccione tipo de Boleta --")
            {
                ClientScript.RegisterStartupScript(this.GetType(), "mensaje", "<script>swal('Alerta!', 'Elija el tipo de boleta por favor!', 'info')</script>");
            }
            else if (txtCantidadBoletas.Text == "")
            {
                ClientScript.RegisterStartupScript(this.GetType(), "mensaje", "<script>swal('Alerta!', 'Proporcione la cantidad de boletas a reservar por favor!', 'info')</script>");
            }
            else
            {
                int idTipoBoleta = int.Parse(ddlListaTipoBoleta.SelectedValue.ToString());
                clReservaBoletaL objDatosReservaBoletaL = new clReservaBoletaL();
                List<clBoletasE> listaTipoBoletaReserva = new List<clBoletasE>();
                clBoletasE objDatos = new clBoletasE();
                objDatos.idTipoBoleta = idTipoBoleta;
                listaTipoBoletaReserva = objDatosReservaBoletaL.mtdListarTipoBoletaReserva(objDatos);

                if (listaTipoBoletaReserva[0].idTipoBoleta == idTipoBoleta)
                {
                    int cantidadReserva = int.Parse(txtCantidadBoletas.Text);
                    float precioBoleta = float.Parse(listaTipoBoletaReserva[0].precioBoleta);
                    float resultado = cantidadReserva * precioBoleta;
                    Session["totalReserva"] = resultado;
                    txtTotalReserva.Text = Convert.ToString(resultado);
                    btnReservar.Visible = true;

                }



            }

        }
    }
}