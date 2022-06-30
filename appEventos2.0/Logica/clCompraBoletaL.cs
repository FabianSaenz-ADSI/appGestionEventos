using appEventos2._0.Datos;
using appEventos2._0.Entidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace appEventos2._0.Logica
{
    public class clCompraBoletaL
    {
        public clBoletasE mtdListarCompra(int idEvento)
        {
            clCompraBoletaD objEventoD = new clCompraBoletaD();
            clBoletasE objEvento = new clBoletasE();
            objEvento = objEventoD.mtdListarCompra(idEvento);
            return objEvento;


        }
    }
}