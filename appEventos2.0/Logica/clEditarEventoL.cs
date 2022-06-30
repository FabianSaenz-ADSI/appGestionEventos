using appEventos2._0.Datos;
using appEventos2._0.Entidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace appEventos2._0.Logica
{
    public class clEditarEventoL
    {
        public List<clEventosE> mtdMisEventosL()
        {
            clEditarEventoD objDatosEventoD = new clEditarEventoD();
            List<clEventosE> listaMisEventosL = new List<clEventosE>();
            listaMisEventosL = objDatosEventoD.mtdMisEventosD();
            return listaMisEventosL;
        }
    }
}