using appEventos2._0.Entidad;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace appEventos2._0.Datos
{
    public class clDetallesD
    {
        public List<clEventosE> mtdListarDetalles(int idEvento)
        {
            string consulta = "SELECT * FROM evento where idEvento='" + idEvento + "'";
            clConexion objConexion = new clConexion();
            DataTable tblEventos = new DataTable();
            tblEventos = objConexion.mtdDesconectado(consulta);

            List<clEventosE> listaEventosInicio = new List<clEventosE>();

            for (int i = 0; i < tblEventos.Rows.Count; i++)
            {
                clEventosE objListaDetalles = new clEventosE();
                objListaDetalles.idEvento = int.Parse(tblEventos.Rows[i]["idEvento"].ToString());
                objListaDetalles.ciudadEvento = tblEventos.Rows[i]["ciudadEvento"].ToString();
                objListaDetalles.lugarEvento = tblEventos.Rows[i]["lugarEvento"].ToString();
                objListaDetalles.edadMinima = tblEventos.Rows[i]["edadMinima"].ToString();
                objListaDetalles.responsable = tblEventos.Rows[i]["responsable"].ToString();
                objListaDetalles.direccion = tblEventos.Rows[i]["direccion"].ToString();
                objListaDetalles.categoria = tblEventos.Rows[i]["categoria"].ToString();
                objListaDetalles.aforo = int.Parse(tblEventos.Rows[i]["aforo"].ToString());
                objListaDetalles.aperturaPuertas = tblEventos.Rows[i]["aperturaPuertas"].ToString();
                objListaDetalles.nit = int.Parse(tblEventos.Rows[i]["nit"].ToString());
                objListaDetalles.nombreEvento = tblEventos.Rows[i]["nombreEvento"].ToString();
                objListaDetalles.fechaInicioEvento = tblEventos.Rows[i]["fechaInicioEvento"].ToString();
                objListaDetalles.fechaFinalEvento = tblEventos.Rows[i]["fechaFinalEvento"].ToString();
                objListaDetalles.imagenRepresentativa = tblEventos.Rows[i]["imagenRepresentativa"].ToString();
                listaEventosInicio.Add(objListaDetalles);
            }
            return listaEventosInicio;
        }
    }
}