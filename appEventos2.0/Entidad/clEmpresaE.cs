using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace appEventos2._0.Entidad
{
    public class clEmpresaE : clEventosE
    {
        public int idEmpresa { get; set; }
        public string nombreEmpresa { get; set; }
        public string direccionEmpresa { get; set; }
        public string emailEmpresa { get; set; }
        public string telefonoEmpresa { get; set; }
        public string nit { get; set; }
        public string logoEmpresa { get; set; }
        public string claveEmpresa { get; set; }
        
    }
}