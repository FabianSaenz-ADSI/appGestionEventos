using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using appEventos2._0.Entidad;
using appEventos2._0.Datos;


namespace appEventos2._0.Logica
{
    public class clLoginL
    {
        public clPersonaE mtdLoginPersona(clPersonaE objDatosE)
        {
            clLoginD objLoginD = new clLoginD();
            clPersonaE objLoginE = new clPersonaE();
            objLoginE = objLoginD.mtdLoginPersona(objDatosE);
            return objLoginE;
        }

        public clEmpresaE mtdLoginEmpresa(clEmpresaE objDatosE)
        {
            clLoginD objLoginD = new clLoginD();
            clEmpresaE objLoginE = new clEmpresaE();
            objLoginE = objLoginD.mtdLoginEmpresa(objDatosE);
            return objLoginE;
        }

    }
}