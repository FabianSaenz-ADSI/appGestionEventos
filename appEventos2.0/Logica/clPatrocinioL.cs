using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using appEventos2._0.Datos;
using appEventos2._0.Entidad;

namespace appEventos2._0.Logica
{
    public class clPatrocinioL
    {
        public List<clEmpresaEventoE> mtdListarEmpresaEvento(clEmpresaE objEmpresaE)
        {
            clPatrocinioD objPatrocinio = new clPatrocinioD();
            List<clEmpresaEventoE> listaTipos = new List<clEmpresaEventoE>();
            listaTipos = objPatrocinio.mtdListarEmpresaEvento(objEmpresaE);
            return listaTipos;
        }

        public int mtdInsertarPatrocinio(string descripcion, int idEmpresaEvento)
        {
            clPatrocinioD objPatrocinio = new clPatrocinioD();
            int resultado = objPatrocinio.mtdInsertarPatrocinio(descripcion, idEmpresaEvento);
            return resultado;
        }

    }
}