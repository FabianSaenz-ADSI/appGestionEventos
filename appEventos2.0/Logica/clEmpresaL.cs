using appEventos2._0.Datos;
using appEventos2._0.Entidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace appEventos2._0.Logica
{
    public class clEmpresaL
    {
        public int mtdRegistrarEmpresa(clEmpresaE objDatosEmpresa, string ruta2)
        {
            clEmpresaD objEmpresaD = new clEmpresaD();
            int resultado = objEmpresaD.mtdRegistrar(objDatosEmpresa, ruta2);
            return resultado;
        }


        public clEmpresaE mtdNitEmailExistente(string nit, string email)
        {
            clEmpresaD objClienteD = new clEmpresaD();
            clEmpresaE objClienteRecibeD = new clEmpresaE();
            objClienteRecibeD = objClienteD.mtdNitEmailExistente(nit, email);
            return objClienteRecibeD;

        }
        public clEmpresaE mtdListarEmpresa(int idUsuarioEmpresa)
        {
            clEmpresaD objEmpresaD = new clEmpresaD();
            clEmpresaE objEmpresaRecibe = new clEmpresaE();
            objEmpresaRecibe = objEmpresaD.mtdListarE(idUsuarioEmpresa);
            return objEmpresaRecibe;


        }
        public int mtdEditarEmpresa(clEmpresaE objDatosEmpresa, int idUsuarioEmpresa)
        {
            clEmpresaD objEmpresaD = new clEmpresaD();
            int resultado = objEmpresaD.mtdEditarE(objDatosEmpresa, idUsuarioEmpresa);
            return resultado;
        }

        public int mtdEliminarEmpresa(int idUsuarioEmpresa)
        {
            clEmpresaD objEmpresaD = new clEmpresaD();
            int resultado = objEmpresaD.mtdEliminarE(idUsuarioEmpresa);
            return resultado;
        }

        public List<clEventosE> mtdListarRegistrados()
        {
            clEmpresaD objListaR = new clEmpresaD();
            List<clEventosE> listaRegistradosL = new List<clEventosE>();
            listaRegistradosL = objListaR.mtdListarEventosRegistradosP();
            return listaRegistradosL;
        }
        public int mtdRompimientoE(clEmpresaEventoJ objTipo)
        {
            clEmpresaD objTipoRol = new clEmpresaD();
            int objTipos = objTipoRol.mtdRegistrarTipo(objTipo);
            return objTipos;

        }

    }
}