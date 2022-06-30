using appEventos2._0.Entidad;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace appEventos2._0.Datos
{
    public class clPersonaD
    {
        public int registrar(clPersonaE objCliente)
        {

            string sqlConsulta = "select * from persona where emailPersona='" + objCliente.emailPersona + "' or documento='" + objCliente.documento + "' ";
            clConexion objConexionConsulta = new clConexion();
            DataTable tblBuscar = new DataTable();
            tblBuscar = objConexionConsulta.mtdDesconectado(sqlConsulta);


            if (tblBuscar.Rows.Count > 0)
            {
                return 0;

            }
            else
            {

                string consulta = "insert into persona (documento,nombres,apellidos,genero,telefono,direccion,pais,departamento,ciudad,emailpersona,clavePersona,tipoDocumento,edad,fechaN,rut) values ('" + objCliente.documento + "'," +
                    "'" + objCliente.nombres + "','" + objCliente.apellidos + "','" + objCliente.genero + "','" + objCliente.telefono + "','" + objCliente.direccion + "'," +
                    "'" + objCliente.pais + "','" + objCliente.departamento + "','" + objCliente.ciudad + "','" + objCliente.emailPersona + "','" + objCliente.clavePersona + "','" + objCliente.tipoDocumento + "','" + objCliente.edad + "','" + objCliente.fechaN + "','" + objCliente.rut + "')";
                clConexion objConexion = new clConexion();
                int resultado = objConexion.mtdConectado(consulta);
                return resultado;


            }

        }

        public clPersonaE mtdListarPersona(int idPersona)
        {
            string consulta = "select documento,nombres,apellidos,telefono,direccion,pais,departamento,ciudad,emailPersona,edad from persona where idPersona=" + idPersona + "";
            clConexion objConexion = new clConexion();
            DataTable tblDatos = new DataTable();

            tblDatos = objConexion.mtdDesconectado(consulta);

            clPersonaE objDatos = new clPersonaE();

            if (tblDatos.Rows.Count > 0)
            {
                objDatos.documento = tblDatos.Rows[0]["documento"].ToString();
                objDatos.nombres = tblDatos.Rows[0]["nombres"].ToString();
                objDatos.apellidos = tblDatos.Rows[0]["apellidos"].ToString();                
                objDatos.telefono = tblDatos.Rows[0]["telefono"].ToString();
                objDatos.direccion = tblDatos.Rows[0]["direccion"].ToString();
                objDatos.pais = tblDatos.Rows[0]["pais"].ToString();
                objDatos.departamento = tblDatos.Rows[0]["departamento"].ToString();
                objDatos.ciudad = tblDatos.Rows[0]["ciudad"].ToString();
                objDatos.emailPersona = tblDatos.Rows[0]["emailPersona"].ToString();
               
                objDatos.edad = tblDatos.Rows[0]["edad"].ToString();





            }
            else
            {
                objDatos = null;

            }
            return objDatos;


        }

        public int mtdEditar(clPersonaE objDatos)
        {
            string sql = "UPDATE persona SET documento='" + objDatos.documento + "',nombres='" + objDatos.nombres + "',apellidos='" + objDatos.apellidos + "',telefono='" + objDatos.telefono + "',direccion='" + objDatos.direccion + "',pais='" + objDatos.pais + "',departamento='" + objDatos.departamento + "',ciudad='" + objDatos.ciudad + "',emailPersona='" + objDatos.emailPersona + "',edad='" + objDatos.edad + "'  WHERE idPersona =" + objDatos.idPersona + "";




            clConexion objConexion = new clConexion();
            int resultado = objConexion.mtdConectado(sql);

            return resultado;
        }

        public int mtdEliminar(clPersonaE idPersona)
        {
            string consulta = "delete from persona where idPersona=" + idPersona.idPersona + " ";
            clConexion objConexion = new clConexion();
            int filasAfectadas = objConexion.mtdConectado(consulta);
            return filasAfectadas;


        }

        public int mtdRegistrarTipo(clPersonaEventoE objTipo)
        {
            string consulta = "INSERT INTO personaEvento(idPersona,idEvento,tipoRol)values('" + objTipo.idPersona + "'," + objTipo.idEvento + ",'" + objTipo.tipoRol + "')";
            clConexion objConexion = new clConexion();
            int resultado = objConexion.mtdConectado(consulta);
            return resultado;

        }

        public int mtdRegistrarTipoP(clPersonaEventoJ objTipo)
        {
            string consulta = "INSERT INTO personaEvento(idPersona,idEvento,tipoRolPersona)values('" + objTipo.idPersona + "'," + objTipo.idEvento + ",'" + objTipo.tipoRolPersona + "')";
            clConexion objConexion = new clConexion();
            int resultado = objConexion.mtdConectado(consulta);
            return resultado;

        }
    }
}