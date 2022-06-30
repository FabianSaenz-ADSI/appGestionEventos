using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace appEventos2._0.Entidad
{
    public class clBoletasE : clEventosE
    {
        public int idTipoBoleta { get; set; }
        public string tipoBoleta { get; set; }
        public string precioBoleta { get; set; }
        public string ubicacion { get; set; }
        public int numeroBoletas { get; set; }
        public int idEventos { get; set; } 
    }
}