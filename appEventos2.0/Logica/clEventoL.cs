using appEventos2._0.Datos;
using appEventos2._0.Entidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace appEventos2._0.Logica
{
    public class clEventoL
    {
        public List<clTipoEventoE> mtdListarT()
        {
            clEventosD objDatosD = new clEventosD();
            List<clTipoEventoE> listaDatosT = new List<clTipoEventoE>();
            listaDatosT = objDatosD.mtdListarTipos();
            return listaDatosT;
        }

        public int mtdRegistarEventoL(clEventosE objDatosEvento)
        {
            clEventosD objDatosD = new clEventosD();
            int resultado = objDatosD.mtdRegistrarEvento(objDatosEvento);
            return resultado;
        }

        public List<clEventosE> mtdListarRegistrados()
        {
            clEventosD objListaR = new clEventosD();
            List<clEventosE> listaRegistradosL = new List<clEventosE>();
            listaRegistradosL = objListaR.mtdListarEventosRegistrados();
            return listaRegistradosL;
        }

        public List<clEventosE> mtdListarEventosLogica()
        {
            clEventosD objlistaEventosD = new clEventosD();
            List<clEventosE> listadoeventosI = new List<clEventosE>();
            listadoeventosI = objlistaEventosD.mtdListarEventosInicio();
            return listadoeventosI;
        }
    }
}