using appEventos2._0.Entidad;
using appEventos2._0.Logica;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;

namespace appEventos2._0.Presentacion
{
    public partial class frmPatrocinar : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            mtdPatrocinador();

            HtmlAnchor crearCuenta = (HtmlAnchor)this.Master.FindControl("crearCuenta");
            HtmlAnchor crearEvento = (HtmlAnchor)this.Master.FindControl("crearEvento");
            HtmlAnchor tipoRol = (HtmlAnchor)this.Master.FindControl("tipoRol");
            Button ingresar = this.Master.FindControl("btnIngresarLogin") as Button;

            crearCuenta.Visible = false;
            crearEvento.Visible = false;
            tipoRol.Visible = false;
            ingresar.Visible = false;
        }
        protected void mtdPatrocinador()
        {
            clEmpresaL objPatrocinador = new clEmpresaL();
            List<clEventosE> listaPatrocinador = new List<clEventosE>();
            DataTable dtpat = new DataTable();
            listaPatrocinador = objPatrocinador.mtdListarRegistrados();
            dtpat.Columns.Add(new DataColumn("idEvento", typeof(int)));
            dtpat.Columns.Add(new DataColumn("ciudadEvento", typeof(string)));
            dtpat.Columns.Add(new DataColumn("lugarEvento", typeof(string)));
            dtpat.Columns.Add(new DataColumn("edadMinima", typeof(string)));
            dtpat.Columns.Add(new DataColumn("responsable", typeof(string)));
            dtpat.Columns.Add(new DataColumn("direccion", typeof(string)));
            dtpat.Columns.Add(new DataColumn("categoria", typeof(string)));
            dtpat.Columns.Add(new DataColumn("aforo", typeof(int)));
            dtpat.Columns.Add(new DataColumn("aperturaPuertas", typeof(string)));
            dtpat.Columns.Add(new DataColumn("nombreEvento", typeof(string)));
            dtpat.Columns.Add(new DataColumn("fechaInicioEvento", typeof(string)));
            dtpat.Columns.Add(new DataColumn("fechaFinalEvento", typeof(string)));

            for (int i = 0; i < listaPatrocinador.Count; i++)
            {
                int idEvento = listaPatrocinador[i].idEvento;
                string ciudad = listaPatrocinador[i].ciudadEvento;
                string lugar = listaPatrocinador[i].lugarEvento;
                string edad = listaPatrocinador[i].edadMinima;
                string responsable = listaPatrocinador[i].responsable;
                string direccion = listaPatrocinador[i].direccion;
                string categoria = listaPatrocinador[i].categoria;
                int aforo = listaPatrocinador[i].aforo;
                string apertura = listaPatrocinador[i].aperturaPuertas;
                string nombreEvento = listaPatrocinador[i].nombreEvento;
                string fechainicio = listaPatrocinador[i].fechaInicioEvento;
                string fechafinal = listaPatrocinador[i].fechaFinalEvento;

                DataRow row = dtpat.NewRow();
                row["idEvento"] = idEvento;
                row["ciudadEvento"] = ciudad;
                row["lugarEvento"] = lugar;
                row["edadMinima"] = edad;
                row["responsable"] = responsable;
                row["direccion"] = direccion;
                row["categoria"] = categoria;
                row["aforo"] = aforo;
                row["aperturaPuertas"] = apertura;
                row["nombreEvento"] = nombreEvento;
                row["fechaInicioEvento"] = fechainicio;
                row["fechaFinalEvento"] = fechafinal;

                dtpat.Rows.Add(row);
            }

            dgvPatrocinador.DataSource = dtpat;
            dgvPatrocinador.DataBind();
            dgvPatrocinador.UseAccessibleHeader = true;
            dgvPatrocinador.HeaderRow.TableSection = TableRowSection.TableHeader;
        }

        protected void dgvPatrocinador_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if (IsPostBack)
            {
                if (e.CommandName == "patrocinar")
                {
                    string rol = "Patrocinador";
                    int lista = Convert.ToInt32(e.CommandArgument);
                    //GridViewRow row = dgvPatrocinador.Rows[lista];
                    //string valor = dgvPatrocinador.Rows[lista].Cells[0].Text;
                    int idVen = lista;
                    if (idVen >= 0)
                    {
                        if (Session["idUsuarioEmpresa"] != null)
                        {
                            clEmpresaEventoJ objEmpresaEvento = new clEmpresaEventoJ();
                            objEmpresaEvento.idEmpresa = int.Parse(Session["idUsuarioEmpresa"].ToString());
                            objEmpresaEvento.idEvento = idVen;
                            objEmpresaEvento.tipoRolEmpresa = rol;

                            clEmpresaL objDatos = new clEmpresaL();
                            int resultado = objDatos.mtdRompimientoE(objEmpresaEvento);

                            if (resultado > 0)
                            {

                                ClientScript.RegisterClientScriptBlock(this.GetType(), "Mensaje", "swal('Alerta','Desea Patrocinar Este Evento?!','info').then((value) => { window.location = 'frmInicio.aspx';});", true);

                            }
                            else
                            {
                                ClientScript.RegisterStartupScript(this.GetType(), "mensaje", "<script>swal('Alerta!', 'Error!', 'info')</script>");
                            }


                        }
                        if (Session["idUsuarioPersona"] != null)
                        {
                            clPersonaEventoJ objPersonaEvento = new clPersonaEventoJ();
                            objPersonaEvento.idPersona = int.Parse(Session["idUsuarioPersona"].ToString());
                            objPersonaEvento.idEvento = idVen;
                            objPersonaEvento.tipoRolPersona = rol;

                            clPersonaL objDatosP = new clPersonaL();
                            int resultado = objDatosP.mtdRompimientoP(objPersonaEvento);

                            if (resultado > 0)
                            {

                                ClientScript.RegisterClientScriptBlock(this.GetType(), "Mensaje", "swal('Alerta','Desea Patrocinar Este Evento?!','info').then((value) => { window.location = 'frmInicio.aspx';});", true);

                            }
                            else
                            {
                                ClientScript.RegisterStartupScript(this.GetType(), "mensaje", "<script>swal('Alerta!', 'Error!', 'info')</script>");
                            }
                        }
                    }
                }
            }
        }
    }
}