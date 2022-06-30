using appEventos2._0.Datos;
using appEventos2._0.Entidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace appEventos2._0.Logica
{
    public class clBoletasL
    {
        public int mtdRegistrarB(clBoletasE objDatosBoleta)
        {
            clBoletasD objBoletaD = new clBoletasD();
            int resultado = objBoletaD.mtdRegistrarBoleta(objDatosBoleta);
            return resultado;
        }
    }
}