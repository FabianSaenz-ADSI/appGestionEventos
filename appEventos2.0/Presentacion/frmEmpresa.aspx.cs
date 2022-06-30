using appEventos2._0.Entidad;
using appEventos2._0.Logica;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Web;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;

namespace appEventos2._0.Presentacion
{
    public partial class frmEmpresa : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            Label lblUsuario = this.Master.FindControl("lblUsuario") as Label;
            HtmlAnchor crearCuenta = (HtmlAnchor)this.Master.FindControl("crearCuenta");
            HtmlAnchor crearEvento = (HtmlAnchor)this.Master.FindControl("crearEvento");
            HtmlAnchor tipoRol = (HtmlAnchor)this.Master.FindControl("tipoRol");
            
             

            lblUsuario.Visible = false;
            crearCuenta.Visible = false;
            crearEvento.Visible = false;
            tipoRol.Visible = false;
            

        }

        private void limpiar()
        {

            txtNombreEmpresa.Text = "";
            txtDireccion.Text = "";
            txtEmail.Text = "";
            txtTelefono.Text = "";
            txtNit.Text = "";
            txtContraseña.Text = "";
            

        }

        protected void btnRegistrar_Click(object sender, EventArgs e)
        {
            if (txtNombreEmpresa.Text == "" || txtDireccion.Text == ""
              || txtEmail.Text == "" || txtTelefono.Text == "" || txtNit.Text == ""
              || txtContraseña.Text == "" )
            {
                ClientScript.RegisterStartupScript(this.GetType(), "mensaje", "<script> swal('¡ Error al Registrar! ', '...¡Falta ingresar valores en los campos! ') </script>");

            }
            else if (flu.HasFile)
            {
                string nit = txtNit.Text;
                string email = txtEmail.Text;


                clPersonaE objPersona = new clPersonaE();
                clPersonaL objCliente = new clPersonaL();
                int resu = objCliente.mtdRegistrar(objPersona);

                clEmpresaL objNitEmailExistente = new clEmpresaL();
                clEmpresaE objDatosRecibeL = new clEmpresaE();
                objDatosRecibeL = objNitEmailExistente.mtdNitEmailExistente(nit, email);

                if (objDatosRecibeL != null || resu > 0)
                {

                    ClientScript.RegisterStartupScript(this.GetType(), "mensaje", "<script> swal('Email o Nit Existente','info') </script>");
                }
                else 
                {

                    string extension = Path.GetExtension(flu.FileName);
                    string ruta = Server.MapPath("logoEmpresa\\" + txtNit.Text + extension);
                    flu.SaveAs(ruta);
                    clEmpresaE objDatosEmpresa = new clEmpresaE();
                    objDatosEmpresa.nombreEmpresa = txtNombreEmpresa.Text;
                    objDatosEmpresa.direccionEmpresa = txtDireccion.Text;
                    objDatosEmpresa.emailEmpresa = txtEmail.Text;
                    objDatosEmpresa.telefonoEmpresa = txtTelefono.Text;
                    objDatosEmpresa.nit = txtNit.Text;
                    string ruta2 = txtNit.Text + extension;
                    objDatosEmpresa.claveEmpresa = txtContraseña.Text;
                    

                    clEmpresaL objEmpresaL = new clEmpresaL();

                    int resultado = objEmpresaL.mtdRegistrarEmpresa(objDatosEmpresa, ruta2);

                    //Envio la confirmacion de registro al correo electronico

                    string body =
                        "<body>" +
                    "<h1>Bienvenido a nuestro grandioso sitio web</h1>" +
                    "<h4>Querido cliente,</h4>" +
                    "<br/>Su registro se a realizado con exito." +
                    "</body>";

                    string gmail = txtEmail.Text;
                    var fromAddress = new MailAddress("jahernandez0250@misena.edu.co", "Gestion de Eventos");
                    var toAddress = new MailAddress(gmail);
                    const string fromPassword = "123456andres";
                    const string subject = "Bienvenido";


                    var smtp = new SmtpClient
                    {
                        Host = "smtp.gmail.com",
                        Port = 587,
                        EnableSsl = true,
                        DeliveryMethod = SmtpDeliveryMethod.Network,
                        UseDefaultCredentials = false,
                        Credentials = new NetworkCredential(fromAddress.Address, fromPassword)

                    };
                    using (var message = new MailMessage(fromAddress, toAddress)
                    {
                        IsBodyHtml = true,
                        Subject = subject,
                        Body = body
                    })
                    {
                        smtp.Send(message);
                    }

                    if (resultado > 0)
                    {
                        ClientScript.RegisterClientScriptBlock(this.GetType(), "alerta", "swal('Datos Registrados').then((value) => { window.location = '../Login.aspx';});", true);

                        limpiar();

                    }
                    else
                    {
                        ClientScript.RegisterStartupScript(this.GetType(), "mensaje", "<script> swal('Alerta!', 'Error al registrar!','info') </script>");

                    }
                }

            }
            else
            {
                ClientScript.RegisterStartupScript(this.GetType(), "mensaje", "<script> swal('Alerta! ', 'Inserte Logo! ') </script>");

            }
        }
    }
    
}