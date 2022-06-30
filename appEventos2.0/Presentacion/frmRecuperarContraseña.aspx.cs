using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using appEventos2._0.Logica;
using appEventos2._0.Entidad;
using System.Net.Mail;
using System.Net;

namespace appEventos2._0.Presentacion
{
    public partial class frmRecuperarContraseña : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }



        protected void btnEnviar_Click(object sender, EventArgs e)
        {
            if (txtEmail.Text == "")
            {
                ClientScript.RegisterStartupScript(this.GetType(), "mensaje", "<script>swal('Alerta!', 'Debe ingresar correo electronico!', 'info')</script>");
            }
            else
            {
                clLoginL objDatosPersonaL = new clLoginL();
                clPersonaE objDatosPersonaE = new clPersonaE();
                clPersonaE objDatosPersonaRecibeE = new clPersonaE();
                objDatosPersonaE.emailPersona = txtEmail.Text;
                objDatosPersonaRecibeE = objDatosPersonaL.mtdLoginPersona(objDatosPersonaE);

                clLoginL objDatosEmpresaL = new clLoginL();
                clEmpresaE objDatosEmpresaE = new clEmpresaE();
                clEmpresaE objDatosEmpresaRecibeE = new clEmpresaE();
                objDatosEmpresaE.emailEmpresa = txtEmail.Text;
                objDatosEmpresaRecibeE = objDatosEmpresaL.mtdLoginEmpresa(objDatosEmpresaE);

                if (objDatosPersonaRecibeE == null && objDatosEmpresaRecibeE == null)
                {
                    ClientScript.RegisterStartupScript(this.GetType(), "mensaje", "<script>swal('Alerta!', 'Correo no existente!', 'info')</script>");
                    txtEmail.Text = "";
                }
                else
                {
                    if (objDatosPersonaRecibeE != null)
                    {
                        MailMessage correo = new MailMessage();
                        correo.From = new MailAddress("fachavita2@misena.edu.co");
                        correo.To.Add(objDatosPersonaRecibeE.emailPersona);
                        correo.Subject = ("Recuperar Contraseña");
                        correo.Body = "Hola! usted solicito recuperar su contraseña: " + objDatosPersonaRecibeE.clavePersona;
                        correo.Priority = MailPriority.Normal;

                        SmtpClient servidorCorreo = new SmtpClient();
                        servidorCorreo.Credentials = new NetworkCredential("fachavita2@misena.edu.co", "fachavita4.0");
                        servidorCorreo.Host = "smtp.gmail.com";
                        servidorCorreo.Port = 587;
                        servidorCorreo.EnableSsl = true;

                        try
                        {
                            servidorCorreo.Send(correo);
                            Response.Redirect("../Login.aspx");
                        }
                        catch (Exception)
                        {


                        }


                    }
                    else
                    {
                        MailMessage correo = new MailMessage();
                        correo.From = new MailAddress("fachavita2@misena.edu.co");
                        correo.To.Add(objDatosEmpresaRecibeE.emailEmpresa);
                        correo.Subject = ("Recuperar Contraseña");
                        correo.Body = "Hola! usted solicito recuperar su contraseña: " + objDatosEmpresaRecibeE.claveEmpresa;
                        correo.Priority = MailPriority.Normal;

                        SmtpClient servidorCorreo = new SmtpClient();
                        servidorCorreo.Credentials = new NetworkCredential("fachavita2@misena.edu.co", "fachavita4.0");
                        servidorCorreo.Host = "smtp.gmail.com";
                        servidorCorreo.Port = 587;
                        servidorCorreo.EnableSsl = true;

                        try
                        {
                            servidorCorreo.Send(correo);
                            Response.Redirect("../Login.aspx");
                        }
                        catch (Exception)
                        {


                        }


                    }

                }


            }
        }
    }
}