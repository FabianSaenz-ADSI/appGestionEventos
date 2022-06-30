using appEventos2._0.Entidad;
using appEventos2._0.Logica;
using appEventos2._0.Presentacion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Web;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;

namespace appEventos2._0.Presentacion
{
    public partial class frmPersona : System.Web.UI.Page
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
            


            lblRut.Visible = false;
            pdf.Visible = false;


            //lleno el drowonlist manualmente
            if (!IsPostBack)
            {
                ListItem cedula = new ListItem("Cédula de ciudadanía", "1");
                ListItem extrangeria = new ListItem("Cédula de extrangería", "2");
                ListItem pasaporte = new ListItem("Pasaporte", "3");

                ddlTipoDocumento.Items.Add(cedula);
                ddlTipoDocumento.Items.Add(extrangeria);
                ddlTipoDocumento.Items.Add(pasaporte);

                ddlTipoDocumento.Items.Insert(0, "Seleccione...");

            }


            if (!IsPostBack)
            {
                ListItem Masculino = new ListItem("Masculino", "1");
                ListItem Femenino = new ListItem("Femenino", "2");
                ListItem Otros = new ListItem("Otro", "3");

                ddlGenero.Items.Add(Masculino);
                ddlGenero.Items.Add(Femenino);
                ddlGenero.Items.Add(Otros);

                ddlGenero.Items.Insert(0, "Seleccione...");
            }

        }

        protected void btnRegistrar_Click(object sender, EventArgs e)
        {
           
            

            if (ddlGenero.SelectedIndex == 0  || ddlTipoDocumento.SelectedIndex == 0 || txtConfirmacionEmail.Text == "" || txtConfirmacioContraseña.Text == "" || txtNombres.Text == "" || txtApellidos.Text == "" ||
               txtTelefono.Text == "" || txtDocumento.Text == "" || txtFecha.Text == "" || txtDireccion.Text == "" || txtPais.Text == "" || txtDepartamento.Text == "" || txtCiudad.Text == "" || txtEmail.Text == "" || txtContraseña.Text == "" || txtEdad.Text == "" || txtConfirmacioContraseña.Text == "")
            {


                ClientScript.RegisterStartupScript(this.GetType(), "mensaje", "<script>swal('Alerta!', 'Debe llenar o escoger todos los campos!', 'info')</script>");

            }
            else
            {

               


                clPersonaE objPersona = new clPersonaE();
                objPersona.nombres = txtNombres.Text;
                objPersona.apellidos = txtApellidos.Text;
                objPersona.genero = ddlGenero.SelectedItem.Text;
                objPersona.telefono = txtTelefono.Text;
                objPersona.tipoDocumento = ddlTipoDocumento.SelectedItem.Text;
                objPersona.documento = txtDocumento.Text;
                objPersona.fechaN = txtFecha.Text;
                objPersona.direccion = txtDireccion.Text;
                objPersona.pais = txtPais.Text;
                objPersona.departamento = txtDepartamento.Text;
                objPersona.ciudad = txtCiudad.Text;
                objPersona.emailPersona = txtEmail.Text;
                objPersona.clavePersona = txtContraseña.Text;
                objPersona.edad = txtEdad.Text;


                string nombrePdf = txtDocumento.Text;
                string extencion = System.IO.Path.GetExtension(pdf.FileName);


                if (pdf.HasFile)
                {
                    if (extencion == ".pdf" || extencion == ".PDF")
                    {

                        pdf.SaveAs(Server.MapPath("../carpetaPdf/" + pdf.FileName));
                        objPersona.rut = nombrePdf + extencion;

                    }
                    else
                    {


                        ClientScript.RegisterStartupScript(this.GetType(), "mensaje", "<script>swal('Alerta!', 'Adjunte su archivo pdf!', 'info')</script>");



                    }

                }

                clPersonaL objCliente = new clPersonaL();
                int resultado = objCliente.mtdRegistrar(objPersona);

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

                    ClientScript.RegisterStartupScript(this.GetType(), "mensaje", "<script>swal('Alerta!', 'Email o Documento ya estan!', 'info')</script>");

                }



            }
        }
        protected void limpiar()
        {
            txtNombres.Text = "";
            txtApellidos.Text = "";
            ddlGenero.SelectedIndex = 0;
            txtTelefono.Text = "";
            ddlTipoDocumento.SelectedIndex = 0;
            txtDocumento.Text = "";
            txtFecha.Text = "";
            txtDireccion.Text = "";
            txtPais.Text = "";
            txtDepartamento.Text = "";
            txtCiudad.Text = "";
            txtEmail.Text = "";
            txtContraseña.Text = "";
            txtEdad.Text = "";
            txtConfirmacionEmail.Text = "";

        }

        
    }
}