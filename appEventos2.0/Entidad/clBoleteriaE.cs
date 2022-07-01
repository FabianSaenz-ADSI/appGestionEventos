using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace appEventos2._0.Entidad
{
    public class clBoleteriaE
    {
        public string fechaReserva { get; set; }
        public string fechaCompra { get; set; }
        public string cantidadBoletas { get; set; }
        public string nombreEvento { get; set; } 
        public string totalCompra { get; set; } 
        public float totalReserva { get; set; }

        public int idEmpresa { get; set; }
        public int idEvento { get; set; }
        public int idPersona { get; set; }

    }
}