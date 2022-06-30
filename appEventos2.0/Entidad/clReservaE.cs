using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace appEventos2._0.Entidad
{
    public class clReservaE :clPersonaE
    {
        public int idBoleteria { get; set; }
        public string fechaReserva { get; set; }
        public string fechaCompra { get; set; }
        public string cantidadBoletas { get; set; }
        public string fechaDevolucion { get; set; }
        public string cantidadDevolucion { get; set; }
        public int idEmpresaEvento { get; set; }
        public int idPersonaEvento  { get; set; }
        public int idEvento { get; set; }
        public string estado { get; set; }
        public int idPersona { get; set; }
        public int idEmpresa { get; set; }
        public float totalReserva { get; set; }
        public float totalcompra { get; set; }



    }
}