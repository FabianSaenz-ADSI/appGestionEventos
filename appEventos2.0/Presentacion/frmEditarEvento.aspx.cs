using appEventos2._0.Logica;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace appEventos2._0.Presentacion
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            mtdEditarEvento();
        }

        protected void mtdEditarEvento()
        {
            clEditarEventoL objMisEventosL = new clEditarEventoL();
            rpEventos2.DataSource = objMisEventosL.mtdMisEventosL();
            rpEventos2.DataBind();
        }
    }
}