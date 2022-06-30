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
            objEvento = objEventoD.mtdListarComprar(idEvento);
            return objEvento;


        }
        public int mtdRegistrar(clCompraE objCom)
        {
            clCompraBoletaD objCliente = new clCompraBoletaD();
            int registro = objCliente.mtdRegistrar(objCom);
            return registro;

        }
        public int mtdRegistrarp (clCompraE objCom)
        {
            clCompraBoletaD objCliente = new clCompraBoletaD();
            int registro = objCliente.mtdRegistrarp (objCom);
            return registro;

        }




    }
}