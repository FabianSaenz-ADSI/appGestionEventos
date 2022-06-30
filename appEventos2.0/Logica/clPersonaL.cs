using appEventos2._0.Datos;
using appEventos2._0.Entidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace appEventos2._0.Logica
{
    public class clPersonaL
    {

        public int mtdRegistrar(clPersonaE objDatos)
        {
            clPersonaD objCliente = new clPersonaD();
            int registro = objCliente.registrar(objDatos);
            return registro;

        }


        public clPersonaE mtdListarEmpresa(int idPersona)
        {
            clPersonaD objperfilD = new clPersonaD();
            clPersonaE objPersona = new clPersonaE();
            objPersona = objperfilD.mtdListarPersona(idPersona);
            return objPersona;


        }

        public int mtdEditar(clPersonaE objDatos)
        {
            clPersonaD objDatosPerfilD = new clPersonaD();
            int resultado = objDatosPerfilD.mtdEditar(objDatos);
            return resultado;
        }
        public int mtdEliminar(clPersonaE idPersona)
        {
            clPersonaD objUsuarioD = new clPersonaD();
            int fa = objUsuarioD.mtdEliminar(idPersona);
            return fa;
        }



        public int mtdRompimiento(clPersonaEventoE objTipo)
        {
            clPersonaD objTipoRol = new clPersonaD();
            int objTipos = objTipoRol.mtdRegistrarTipo(objTipo);
            return objTipos;

        }

        public int mtdRompimientoP(clPersonaEventoJ objTipo)
        {
            clPersonaD objTipoRol = new clPersonaD();
            int objTipos = objTipoRol.mtdRegistrarTipoP(objTipo);
            return objTipos;

        }
    }
}