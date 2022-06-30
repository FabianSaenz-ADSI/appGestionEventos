using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace appEventos2._0.Entidad
{
    public class clCompraE
    {
        public int idCompra { get; set; }
        public int idEmpresa { get; set; }
        public int idEvento { get; set; }
        public int idPersona { get; set; }
        public string PrecioTotal { get; set; }
        public string cantidadBoletas { get; set; }

    }
}