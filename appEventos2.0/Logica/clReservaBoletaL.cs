using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using appEventos2._0.Datos;
using appEventos2._0.Entidad;

namespace appEventos2._0.Logica
{
    public class clReservaBoletaL
    {
        public clEmpresaEventoE mtdListarEmpresaEvento(clEventosE objDatosEvento, string tipoRolEmpresa)
        {
            clReservaBoletaD objDatosReservaBoletaD = new clReservaBoletaD();
            clEmpresaEventoE objDatosEmpresaEvento = new clEmpresaEventoE();
            objDatosEmpresaEvento = objDatosReservaBoletaD.mtdListarEmpresaEvento(objDatosEvento, tipoRolEmpresa);
            return objDatosEmpresaEvento;
        }


        public clPersonaEventoE mtdListarPersonaEvento(clEventosE objDatosEvento, string tipoRolPersona)
        {
            clReservaBoletaD objDatosReservaBoletaD = new clReservaBoletaD();
            clPersonaEventoE objDatosEmpresa = new clPersonaEventoE();
            objDatosEmpresa = objDatosReservaBoletaD.mtdListarPersonaEvento(objDatosEvento, tipoRolPersona);
            return objDatosEmpresa;
        }

        public int mtdInsertarReserva(clReservaE objDatosReservaE)
        {
            clReservaBoletaD objDatosReservaBoletaD = new clReservaBoletaD();
            int resultado = objDatosReservaBoletaD.mtdInsertarReserva(objDatosReservaE);
            return resultado;
        }

        public clBoleteriaE mtdListarDetalleReserva(int idBoletaReserva)
        {
            clReservaBoletaD objDatosReservaBoletaD = new clReservaBoletaD();
            clBoleteriaE objDatosBoleteriaE = new clBoleteriaE();
            objDatosBoleteriaE = objDatosReservaBoletaD.mtdListarDetalleReserva(idBoletaReserva);
            return objDatosBoleteriaE;

        }

        public List<clBoletasE> mtdListarTipoBoleta(clBoletasE objDatos)
        {
            clReservaBoletaD objDatosBoletaD = new clReservaBoletaD();

            List<clBoletasE> listaBoleta = new List<clBoletasE>();
            listaBoleta = objDatosBoletaD.mtdListarTipoBoleta(objDatos);
            return listaBoleta;

        }


        public List<clBoletasE> mtdListarTipoBoletaReserva(clBoletasE objDatos)
        {
            clReservaBoletaD objDatosBoletaD = new clReservaBoletaD();

            List<clBoletasE> listaBoleta = new List<clBoletasE>();
            listaBoleta = objDatosBoletaD.mtdListarTipoBoletaReserva(objDatos);
            return listaBoleta;

        }

        public static List<clReservaE> mtdListarReservaBoleta(clReservaE objDatos)
        {

            List<clReservaE> listaRerva = new List<clReservaE>();
            listaRerva = clReservaBoletaD.mtdListarReservaBoleta(objDatos);
            return listaRerva;
        }

        public int mtdCancelarReserva(clReservaE objDatos)
        {
            clReservaBoletaD objDatosReserva = new clReservaBoletaD();
            int r = objDatosReserva.mtdCancelarReserva(objDatos);
            return r;
        }

    }
}