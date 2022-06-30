using appEventos2._0.Entidad;
using appEventos2._0.Logica;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;

namespace appEventos2._0.Presentacion
{
    public partial class frmPerfilPersona : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
           
            Label lblUsuario = this.Master.FindControl("lblUsuario") as Label;
            HtmlAnchor crearCuenta = (HtmlAnchor)this.Master.FindControl("crearCuenta");
            Button btnIngresarLogin = this.Master.FindControl("btnIngresarLogin") as Button;
            HtmlAnchor tipoRol = (HtmlAnchor)this.Master.FindControl("tipoRol");

            lblUsuario.Visible = false;
            crearCuenta.Visible = false;
            tipoRol.Visible = false;
            btnIngresarLogin.Visible = false;

            if (!IsPostBack)
            {

                int idUsuarioPersona = int.Parse(Session["idUsuarioPersona"].ToString());

                clPersonaL objDatos = new clPersonaL();
                clPersonaE objDatosRecibeL = new clPersonaE();
                objDatosRecibeL = objDatos.mtdListarEmpresa(idUsuarioPersona);

                if (objDatosRecibeL != null)
                {

                    txtDocumento.Text = objDatosRecibeL.documento;
                    txtNom.Text = objDatosRecibeL.nombres;
                    txtApellidos.Text = objDatosRecibeL.apellidos;
                    //ddlGenero.Text = objDatosRecibeL.genero;
                    txtTelefono.Text = objDatosRecibeL.telefono;
                    txtDireccion.Text = objDatosRecibeL.direccion;
                    txtPais.Text = objDatosRecibeL.pais;
                    txtDepartamento.Text = objDatosRecibeL.departamento;
                    txtCiudad.Text = objDatosRecibeL.ciudad;
                    txtEmail.Text = objDatosRecibeL.emailPersona;
                    //ddlTipoDocumento.Text = objDatosRecibeL.tipoDocumento;
                    txtEdad.Text = objDatosRecibeL.edad;

                }

                //lleno el drowonlist manualmente
                if (!IsPostBack)
                {
                    ListItem cedula = new ListItem("Cédula de ciudadanía", "1");
                    ListItem extrangeria = new ListItem("Cédula de extrangería", "2");
                    ListItem pasaporte = new ListItem("Pasaporte", "3");

                    ddlTipoDocumento.Items.Add(cedula);
                    ddlTipoDocumento.Items.Add(extrangeria);
                    ddlTipoDocumento.Items.Add(pasaporte);



                }


                if (!IsPostBack)
                {
                    ListItem Masculino = new ListItem("Masculino", "1");
                    ListItem Femenino = new ListItem("Femenino", "2");
                    ListItem Otros = new ListItem("Otro", "3");

                    ddlGenero.Items.Add(Masculino);
                    ddlGenero.Items.Add(Femenino);
                    ddlGenero.Items.Add(Otros);


                }


            }




        }

        protected void btnEditar_Click(object sender, EventArgs e)
        {


            clPersonaE objDatos = new clPersonaE();
            objDatos.idPersona = int.Parse(Session["idUsuarioPersona"].ToString());
            objDatos.documento = txtDocumento.Text;
            objDatos.nombres = txtNom.Text;
            objDatos.apellidos = txtApellidos.Text;
            objDatos.telefono = txtTelefono.Text;
            objDatos.direccion = txtDireccion.Text;
            objDatos.pais = txtPais.Text;
            objDatos.departamento = txtDepartamento.Text;
            objDatos.ciudad = txtCiudad.Text;
            objDatos.emailPersona = txtEmail.Text;
            objDatos.edad = txtEdad.Text;





            clPersonaL objHabitacionL = new clPersonaL();
            int perfil = objHabitacionL.mtdEditar(objDatos);

            if (perfil > 0)
            {

                ClientScript.RegisterStartupScript(this.GetType(), "mensaje", "<script>swal('Alerta!', 'Se actualizo correctamente!', 'info')</script>");

            }
            else
            {
                ClientScript.RegisterStartupScript(this.GetType(), "mensaje", "<script>swal('Alerta!', 'Error!', 'info')</script>");
            }






        }

        protected void btnEliminar_Click(object sender, EventArgs e)
        {

            string seccion = Session["idUsuarioPersona"].ToString(); ;

            clPersonaE objHabitacionE = new clPersonaE();
            objHabitacionE.idPersona = int.Parse(seccion);

            clPersonaL objHabitacionL = new clPersonaL();
            int filas = objHabitacionL.mtdEliminar(objHabitacionE);

            if (filas > 0)
            {

                Session.RemoveAll();
                ClientScript.RegisterClientScriptBlock(this.GetType(), "alerta", "swal('Datos Eliminados').then((value) => { window.location = 'frmInicio.aspx';});", true);
            }

            else
            {
                ClientScript.RegisterClientScriptBlock(this.GetType(), "k", "swal('Habitación No Eliminada','Nuestros servidores están teniendo problemas','warning')", true);
            }
        }
    }
}