using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace appEventos2._0.Entidad
{
    public class clEventosE
    {
        public int idEvento { get; set; }
        public string nombreEvento { get; set; }
        public string ciudadEvento { get; set; }

        public string lugarEvento { get; set; }
        public string edadMinima { get; set; }
        public string responsable { get; set; }
        public string direccion { get; set; }

        public string categoria { get; set; }

        public int aforo { get; set; }
        public string aperturaPuertas { get; set; }

        public int nit { get; set; }
        public string fechaInicioEvento { get; set; }
        public string fechaFinalEvento { get; set; }

        public string imagenRepresentativa { get; set; }
        public int idTipoEvento { get; set; }
    }
}