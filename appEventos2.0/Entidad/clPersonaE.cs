using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace appEventos2._0.Entidad
{
    public class clPersonaE : clEmpresaE
    {

        public int idPersona { get; set; }
        public string tipoDocumento { get; set; }

        public string documento { get; set; }
        public string nombres { get; set; }
        public string apellidos { get; set; }
        public string genero { get; set; }
        public string telefono { get; set; }
        public string fechaN { get; set; }
        public string direccion { get; set; }
        public string pais { get; set; }
        public string departamento { get; set; }
        public string ciudad { get; set; }
        public string emailPersona { get; set; }
        public string rut { get; set; }
        
        public string clavePersona { get; set; }
        public string edad { get; set; }


    }
}