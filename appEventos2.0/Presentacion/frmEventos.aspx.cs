using appEventos2._0.Entidad;
using appEventos2._0.Logica;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace appEventos2._0.Presentacion
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                mtdLLenarDropDown();
            }


        }

        protected void mtdLLenarDropDown()
        {
            clEventoL objDatosl = new clEventoL();
            dpListaEventos.DataSource = objDatosl.mtdListarT();
            dpListaEventos.DataTextField = "tipoEvento";
            dpListaEventos.DataValueField = "idTipoEvento";
            dpListaEventos.DataBind();

            dpListaEventos.Items.Insert(0, new ListItem("Seleccione tipo de evento", "0"));
        }
        protected void btnRegistrarEvento_Click(object sender, EventArgs e)
        {
            if (txtNombreEvento.Text == "" || txtCiudad.Text == "" || txtLugar.Text == "" || txtEdadMinima.Text == "" || txtResponsable.Text == ""
                || txtDireccion.Text == "" || txtCategoria.Text == "" || txtAforo.Text == "" || txtApertura.Text == "" || txtNit.Text == "" || txtFechaInicial.Text == "" || txtFechaFinal.Text == "" || dpListaEventos.SelectedValue == "")
            {
                ClientScript.RegisterStartupScript(this.GetType(), "mensaje", "<script> swal('Error','Debe llenar todos los campos') </script>");
            }
            else if (true)
            {
                clEventosE objDatosEvento = new clEventosE();
                objDatosEvento.nombreEvento = txtNombreEvento.Text;
                objDatosEvento.ciudadEvento = txtCiudad.Text;
                objDatosEvento.lugarEvento = txtLugar.Text;
                objDatosEvento.edadMinima = txtEdadMinima.Text;
                objDatosEvento.responsable = txtResponsable.Text;
                objDatosEvento.direccion = txtDireccion.Text;
                objDatosEvento.categoria = txtCategoria.Text;
                objDatosEvento.aforo = int.Parse(txtAforo.Text.ToString());
                objDatosEvento.aperturaPuertas = txtApertura.Text;
                objDatosEvento.nit = int.Parse(txtNit.Text.ToString());
                objDatosEvento.fechaInicioEvento = txtFechaInicial.Text.ToString();
                objDatosEvento.fechaFinalEvento = txtFechaFinal.Text.ToString();
                objDatosEvento.idTipoEvento = int.Parse(dpListaEventos.SelectedValue);

                string ext = Path.GetExtension(fluImagen.FileName);
                string ruta = Server.MapPath("logoEvento\\" + txtNombreEvento.Text + ext);
                if (ext != "")
                {
                    if (ext == ".jpg" || ext == ".png")
                    {
                        fluImagen.SaveAs(ruta);

                        objDatosEvento.imagenRepresentativa = txtNombreEvento.Text + ext;

                        clEventoL objDatosL = new clEventoL();
                        int resultado = objDatosL.mtdRegistarEventoL(objDatosEvento);

                        if (resultado > 0)
                        {
                            int idEventoR = resultado;

                            if (idEventoR > 0)
                            {
                                if (Session["idUsuarioEmpresa"] != null)
                                {

                                    clEmpresaEventoJ objDatosEmpresaEvento = new clEmpresaEventoJ();
                                    int idUsuarioEmpresa = int.Parse(Session["idUsuarioEmpresa"].ToString());
                                    string TipoRol = "Organizador";
                                    int idEmpresa = int.Parse(Session["idUsuarioEmpresa"].ToString());
                                    int idEvento = idEventoR;


                                    clEventoL objEmpresaEventoL = new clEventoL();
                                    int resultado2 = objEmpresaEventoL.mtdRompimientoEmpresaL(TipoRol, idEvento, idEmpresa);


                                }
                                else
                                {
                                    clPersonaEventoJ objDatosEmpresaEvento = new clPersonaEventoJ();
                                    string tipoRolPersona = "Organizador";
                                    int idPersona = int.Parse(Session["idUsuarioPersona"].ToString());
                                    int idEvento = idEventoR;

                                    clEventoL objDatosPersonaEventoL = new clEventoL();
                                    int resultado2 = objDatosPersonaEventoL.mtdRompimientoPersonaL(idPersona, idEvento, tipoRolPersona);
                                }

                                ClientScript.RegisterClientScriptBlock(this.GetType(), "Realizado", "swal('Evento Registrado Exitosamente').then((value) => { window.location = 'frmInicio.aspx';});", true);

                            }
                            else
                            {
                                ClientScript.RegisterStartupScript(this.GetType(), "mensaje", "<script> swal('Error' Error al Registrar','Danger') </script>");
                            }
                            limpiarCajasDeTexto();
                        }
                    }


                }   
            }


        }
        protected void limpiarCajasDeTexto()
        {
            txtNombreEvento.Text = "";
            txtCiudad.Text = "";
            txtLugar.Text = "";
            txtEdadMinima.Text = "";
            txtResponsable.Text = "";
            txtDireccion.Text = "";
            txtCategoria.Text = "";
            txtAforo.Text = "";
            txtApertura.Text = "";
            txtNit.Text = "";
            txtFechaInicial.Text = "";
            txtFechaFinal.Text = "";
        }
    }
}