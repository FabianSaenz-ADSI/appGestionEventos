using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace appEventos2._0.Entidad
{
    public class clMediosE
    {
        public int idMedio { get; set; }
        public string nombreMedio { get; set; }

        public string tipo { get; set; }

        public string urlWeb { get; set; }
        public string redSocial { get; set; }
        public int idEvento { get; set; }

    }
}