using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using appEventos2._0.Logica;
using appEventos2._0.Entidad;


namespace appEventos2._0
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["usuarioPersona"] != null || Session["idUsuarioPersona"] != null || Session["usuarioEmpresa"] != null
                 || Session["idUsuarioEmpresa"] != null)
            {
                Response.Redirect("Presentacion/frmInicio.aspx");


            }

        }

        protected void btnIngresar_Click(object sender, EventArgs e)
        {
            if (txtEmail.Text == "" || txtClave.Text == "")
            {

                ClientScript.RegisterStartupScript(this.GetType(), "mensaje", "<script>swal('Alerta!', 'Campos incompletos!', 'info')</script>");

            }
            else if (idTipoUsuario.SelectedValue == "Tipo usuario")
            {

                ClientScript.RegisterStartupScript(this.GetType(), "mensaje", "<script>swal('Alerta!', 'Seleccione tipo de Usuario!', 'info')</script>");


            }
            else
            {
                clPersonaE objDatosPersonaE = new clPersonaE();
                clLoginL objLoginPersonaL = new clLoginL();
                clPersonaE objLoginLRecibePersona = new clPersonaE();
                objDatosPersonaE.emailPersona = txtEmail.Text;
                objDatosPersonaE.clavePersona = txtClave.Text;
                objLoginLRecibePersona = objLoginPersonaL.mtdLoginPersona(objDatosPersonaE);


                clEmpresaE objDatosEmpresaE = new clEmpresaE();
                clLoginL objLoginEmpresaL = new clLoginL();
                clEmpresaE objLoginLRecibeEmpresa = new clEmpresaE();
                objDatosEmpresaE.emailEmpresa = txtEmail.Text;
                objDatosEmpresaE.claveEmpresa = txtClave.Text;
                objLoginLRecibeEmpresa = objLoginEmpresaL.mtdLoginEmpresa(objDatosEmpresaE);


                if (idTipoUsuario.SelectedValue == "Persona")
                {
                    if (objLoginLRecibePersona == null && objLoginLRecibeEmpresa == null)
                    {
                        ClientScript.RegisterStartupScript(this.GetType(), "mensaje", "<script>swal('Alerta!', 'Usuario No registrado!', 'info')</script>");
                    }
                    else
                    {
                        if (objLoginLRecibePersona != null && objLoginLRecibeEmpresa == null)
                        {
                            if (objLoginLRecibePersona.clavePersona == txtClave.Text)
                            {
                                Session["usuarioPersona"] = " " + objLoginLRecibePersona.nombres;
                                Session["idUsuarioPersona"] = objLoginLRecibePersona.idPersona;
                                Response.Redirect("Presentacion/frmInicio.aspx");

                            }
                            else
                            {
                                ClientScript.RegisterStartupScript(this.GetType(), "mensaje", "<script>swal('Alerta!', 'Clave incorrecta!', 'info')</script>");
                            }

                        }
                        else
                        {
                            ClientScript.RegisterStartupScript(this.GetType(), "mensaje", "<script>swal('Alerta!', 'Usuario No encontrado como Persona!', 'info')</script>");

                        }

                    }





                }
                else
                {
                    if (objLoginLRecibePersona == null && objLoginLRecibeEmpresa == null)
                    {
                        ClientScript.RegisterStartupScript(this.GetType(), "mensaje", "<script>swal('Alerta!', 'Usuario No registrado!', 'info')</script>");
                    }
                    else
                    {
                        if (objLoginLRecibeEmpresa != null && objLoginLRecibePersona == null)
                        {
                            if (objLoginLRecibeEmpresa.claveEmpresa == txtClave.Text)
                            {
                                Session["usuarioEmpresa"] = " " + objLoginLRecibeEmpresa.nombreEmpresa;
                                Session["idUsuarioEmpresa"] = objLoginLRecibeEmpresa.idEmpresa;
                                Response.Redirect("Presentacion/frmInicio.aspx");
                            }
                            else
                            {
                                ClientScript.RegisterStartupScript(this.GetType(), "mensaje", "<script>swal('Alerta!', 'Clave incorrecta!', 'info')</script>");


                            }

                        }
                        else
                        {
                            ClientScript.RegisterStartupScript(this.GetType(), "mensaje", "<script>swal('Alerta!', 'Usuario No encontrado como Empresa!', 'info')</script>");
                        }
                    }

                }



            }
        }
    }
}