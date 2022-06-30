using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace appEventos2._0.Entidad
{
    public class clPersonaEventoJ : clPersonaE
    {
        public int idPersonaEvento { get; set; }
        public int idEvento { get; set; }
        public string tipoRolPersona { get; set; }
    }
}