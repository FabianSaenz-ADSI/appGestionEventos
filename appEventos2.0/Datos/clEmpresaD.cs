using appEventos2._0.Entidad;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace appEventos2._0.Datos
{
    public class clEmpresaD
    {
        public clEmpresaE mtdNitEmailExistente(string nit, string email)
        {
            string consulta = "select * from Empresa where nit='" + nit + "' or emailEmpresa='" + email + "'";
            clConexion objConexion = new clConexion();
            DataTable tblDatos = new DataTable();
            tblDatos = objConexion.mtdDesconectado(consulta);

            clEmpresaE objDatos = new clEmpresaE();

            if (tblDatos.Rows.Count > 0)
            {

                objDatos.nit = tblDatos.Rows[0]["nit"].ToString();
                objDatos.emailEmpresa = tblDatos.Rows[0]["emailEmpresa"].ToString();


            }
            else
            {
                objDatos = null;

            }
            return objDatos;

        }


        public int mtdRegistrar(clEmpresaE objDatosEmpresa, string ruta2)
        {
            string consulta = "insert into Empresa(nombreEmpresa,direccionEmpresa,emailEmpresa," +
                "telefonoEmpresa,nit,logoEmpresa,claveEmpresa)values('" + objDatosEmpresa.nombreEmpresa + "','" + objDatosEmpresa.direccionEmpresa + "'," +
                "'" + objDatosEmpresa.emailEmpresa + "','" + objDatosEmpresa.telefonoEmpresa + "','" + objDatosEmpresa.nit + "','" + ruta2 + "'," +
                "'" + objDatosEmpresa.claveEmpresa + "')";

            clConexion objConexion = new clConexion();
            int resultado = objConexion.mtdConectado(consulta);
            return resultado;
        }
        public clEmpresaE mtdListarE(int idUsuarioEmpresa)
        {
            string consulta = "select nombreEmpresa,direccionEmpresa,emailEmpresa," +
                "telefonoEmpresa,nit,claveEmpresa from Empresa where idEmpresa=" + idUsuarioEmpresa + "";
            clConexion objConexion = new clConexion();
            DataTable tblDatos = new DataTable();

            tblDatos = objConexion.mtdDesconectado(consulta);

            clEmpresaE objDatos = new clEmpresaE();

            if (tblDatos.Rows.Count > 0)
            {
                objDatos.nombreEmpresa = tblDatos.Rows[0]["nombreEmpresa"].ToString();
                objDatos.direccionEmpresa = tblDatos.Rows[0]["direccionEmpresa"].ToString();
                objDatos.emailEmpresa = tblDatos.Rows[0]["emailEmpresa"].ToString();
                objDatos.telefonoEmpresa = tblDatos.Rows[0]["telefonoEmpresa"].ToString();
                objDatos.nit = tblDatos.Rows[0]["nit"].ToString();
                objDatos.claveEmpresa = tblDatos.Rows[0]["claveEmpresa"].ToString();




            }
            else
            {
                objDatos = null;

            }
            return objDatos;


        }

        public int mtdEditarE(clEmpresaE objDatosEmpresa, int idUsuarioEmpresa)
        {

            string consulta = "update Empresa set nombreEmpresa='" + objDatosEmpresa.nombreEmpresa + "', direccionEmpresa='" + objDatosEmpresa.direccionEmpresa + "'," +
                "emailEmpresa='" + objDatosEmpresa.emailEmpresa + "',telefonoEmpresa='" + objDatosEmpresa.telefonoEmpresa + "',nit='" + objDatosEmpresa.nit + "'," +
                "claveEmpresa='" + objDatosEmpresa.claveEmpresa + "'  where idEmpresa=" + idUsuarioEmpresa + "";

            clConexion objConexion = new clConexion();
            int resultado = objConexion.mtdConectado(consulta);
            return resultado;
        }

        public int mtdEliminarE(int idUsuarioEmpresa)
        {
            string consulta = "delete from Empresa where idEmpresa=" + idUsuarioEmpresa + "";

            clConexion objConexion = new clConexion();
            int resultado = objConexion.mtdConectado(consulta);
            return resultado;

        }
    }
}