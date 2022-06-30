using appEventos2._0.Datos;
using appEventos2._0.Entidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace appEventos2._0.Logica
{
    public class clDetallesL
    {
        public List<clEventosE> mtdListarDetallesL(int idEvento)
        {
            clDetallesD objListaDetallesD = new clDetallesD();
            List<clEventosE> listaDetallesL = new List<clEventosE>();
            listaDetallesL = objListaDetallesD.mtdListarDetalles(idEvento);
            return listaDetallesL;
        }
    }
}