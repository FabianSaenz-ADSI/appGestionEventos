using appEventos2._0.Entidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace appEventos2._0.Datos
{
    public class clBoletasD
    {
        public int mtdRegistrarBoleta(clBoletasE objDatosBoleta)
        {
            string consulta = "INSERT INTO tipoBoleta(tipoBoleta,precioBoleta,ubicacion,numeroBoletas,idEvento)values('" + objDatosBoleta.tipoBoleta + "'," + objDatosBoleta.precioBoleta + ",'" + objDatosBoleta.ubicacion + "','"+objDatosBoleta.numeroBoletas+"',"+objDatosBoleta.idEvento+")";
            clConexion objConexion = new clConexion();
            int resultado = objConexion.mtdConectado(consulta);
            return resultado;

        }
    }
}