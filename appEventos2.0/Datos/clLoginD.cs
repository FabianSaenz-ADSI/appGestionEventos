using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using appEventos2._0.Entidad;

namespace appEventos2._0.Datos
{
    public class clLoginD
    {
        public clPersonaE mtdLoginPersona(clPersonaE objDatosE)
        {

            string consulta = "select * from persona where emailPersona='" + objDatosE.emailPersona + "'";
            clConexion objConexion = new clConexion();
            DataTable tbDatos = new DataTable();
            tbDatos = objConexion.mtdDesconectado(consulta);

            clPersonaE objDatosUsuarioE = new clPersonaE();

            if (tbDatos.Rows.Count == 1)
            {
                objDatosUsuarioE.idPersona = int.Parse(tbDatos.Rows[0]["idPersona"].ToString());
                objDatosUsuarioE.tipoDocumento = tbDatos.Rows[0]["tipoDocumento"].ToString();
                objDatosUsuarioE.documento = tbDatos.Rows[0]["documento"].ToString();
                objDatosUsuarioE.nombres = tbDatos.Rows[0]["nombres"].ToString();
                objDatosUsuarioE.apellidos = tbDatos.Rows[0]["apellidos"].ToString();
                objDatosUsuarioE.genero = tbDatos.Rows[0]["genero"].ToString();
                objDatosUsuarioE.telefono = tbDatos.Rows[0]["telefono"].ToString();
                objDatosUsuarioE.fechaN = tbDatos.Rows[0]["fechaN"].ToString();
                objDatosUsuarioE.direccion = tbDatos.Rows[0]["direccion"].ToString();
                objDatosUsuarioE.pais = tbDatos.Rows[0]["pais"].ToString();
                objDatosUsuarioE.departamento = tbDatos.Rows[0]["departamento"].ToString();
                objDatosUsuarioE.ciudad = tbDatos.Rows[0]["ciudad"].ToString();
                objDatosUsuarioE.emailPersona = tbDatos.Rows[0]["emailPersona"].ToString();
                objDatosUsuarioE.rut = tbDatos.Rows[0]["rut"].ToString();
               
                objDatosUsuarioE.clavePersona = tbDatos.Rows[0]["clavePersona"].ToString();
                objDatosUsuarioE.edad = tbDatos.Rows[0]["edad"].ToString();

            }
            else
            {
                objDatosUsuarioE = null;

            }
            return objDatosUsuarioE;



        }

        public clEmpresaE mtdLoginEmpresa(clEmpresaE objDatosE)
        {
            string consulta = "select * from Empresa where emailEmpresa='" + objDatosE.emailEmpresa + "'";
            clConexion objConexion = new clConexion();
            DataTable tbDatos = new DataTable();
            tbDatos = objConexion.mtdDesconectado(consulta);


            clEmpresaE objDatosUsuarioE = new clEmpresaE();

            if (tbDatos.Rows.Count == 1)
            {
                objDatosUsuarioE.idEmpresa = int.Parse(tbDatos.Rows[0]["idEmpresa"].ToString());
                objDatosUsuarioE.nombreEmpresa = tbDatos.Rows[0]["nombreEmpresa"].ToString();
                objDatosUsuarioE.direccionEmpresa = tbDatos.Rows[0]["direccionEmpresa"].ToString();
                objDatosUsuarioE.emailEmpresa = tbDatos.Rows[0]["emailEmpresa"].ToString();
                objDatosUsuarioE.telefonoEmpresa = tbDatos.Rows[0]["telefonoEmpresa"].ToString();
                objDatosUsuarioE.nit = tbDatos.Rows[0]["nit"].ToString();
                objDatosUsuarioE.logoEmpresa = tbDatos.Rows[0]["logoEmpresa"].ToString();
                objDatosUsuarioE.claveEmpresa = tbDatos.Rows[0]["claveEmpresa"].ToString();
               

            }
            else
            {
                objDatosUsuarioE = null;

            }
            return objDatosUsuarioE;


        }

    }
}