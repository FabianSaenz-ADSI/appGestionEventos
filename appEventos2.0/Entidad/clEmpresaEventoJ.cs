using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace appEventos2._0.Entidad
{
    public class clEmpresaEventoJ : clEmpresaE
    {
        public int idEmpresaEvento { get; set; }
        public int idEvento { get; set; }
        public string tipoRolEmpresa { get; set; }
    }
}