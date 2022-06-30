using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace appEventos2._0.Entidad
{
    public class clPersonaEventoE : clPersonaE
    {
        public int idPersonaEvento { get; set; }
        public string nombreEvento { get; set; }
        public string fechaInicioEvento { get; set; }
        public string fechaFinalEvento { get; set; }
        public string aperturaPuertas { get; set; }
        public string lugarEvento { get; set; }
        public string responsable { get; set; }
        public string ciudadEvento { get; set; }
        public int idEvento { get; set; }
        public string tipoRol { get; set; }
    }
}