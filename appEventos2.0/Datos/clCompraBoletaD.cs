using appEventos2._0.Entidad;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace appEventos2._0.Datos
{
    public class clCompraBoletaD
    {
        public clBoletasE mtdListarCompra(int idEvento)
        {
            string consulta = "SELECT evento.nombreEvento, tipoBoleta.tipoBoleta, tipoBoleta.precioBoleta fROM evento INNER JOIN tipoBoleta ON evento.idEvento = tipoBoleta.idEvento where tipoBoleta.idEvento = '" + idEvento + "'";
            clConexion objConexion = new clConexion();
            DataTable tblDatos = new DataTable();

            tblDatos = objConexion.mtdDesconectado(consulta);

            clBoletasE objDatos = new clBoletasE();

            if (tblDatos.Rows.Count > 0)
            {
                objDatos.nombreEvento = tblDatos.Rows[0]["nombreEvento"].ToString();
                objDatos.tipoBoleta = tblDatos.Rows[0]["tipoBoleta"].ToString();
                objDatos.precioBoleta = tblDatos.Rows[0]["precioBoleta"].ToString();

            }
            else
            {
                objDatos = null;

            }
            return objDatos;


        }
    }
}