using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace appEventos2._0.Datos
{
    public class clConexion
    {

        SqlConnection conexion;
        public clConexion()
        {
            conexion = new SqlConnection("Data Source=.;Initial Catalog=dbEventos;Integrated Security=True");
            conexion.Open();

        }
        public DataTable mtdDesconectado(string consulta)
        {
            SqlDataAdapter adaptador = new SqlDataAdapter(consulta, conexion);
            DataTable tblDatos = new DataTable();
            adaptador.Fill(tblDatos);
            conexion.Close();
            return tblDatos;

        }

        public int mtdConectado(string consulta)
        {
            SqlCommand comando = new SqlCommand(consulta, conexion);
            int filasAfectadas = comando.ExecuteNonQuery();
            conexion.Close();
            return filasAfectadas;
        }
        public int mtdConectadoId(string consulta)
        {
            SqlCommand comando = new SqlCommand(consulta, conexion);
            int id = Convert.ToInt32(comando.ExecuteScalar());
            conexion.Close();
            return id;
        }
    }
}