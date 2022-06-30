using appEventos2._0.Entidad;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace appEventos2._0.Datos
{
    public class clEventosD
    {
        public List<clTipoEventoE> mtdListarTipos()
        {
            string consulta = "SELECT * FROM tipoEvento";
            clConexion objConexion = new clConexion();
            DataTable tblTipos = new DataTable();
            tblTipos = objConexion.mtdDesconectado(consulta);

            List<clTipoEventoE> listaTipos = new List<clTipoEventoE>();

            for (int i = 0; i < tblTipos.Rows.Count; i++)
            {
                clTipoEventoE objDatosTipos = new clTipoEventoE();
                objDatosTipos.idTipoEvento = int.Parse(tblTipos.Rows[i]["idTipoEvento"].ToString());
                objDatosTipos.tipoEvento = tblTipos.Rows[i]["tipoEvento"].ToString();
                listaTipos.Add(objDatosTipos);
            }
            return listaTipos;
        }

        public int mtdRegistrarEvento(clEventosE objDatosEvento)
        {
            string consulta = "INSERT  INTO evento(nombreEvento,ciudadEvento,lugarEvento,edadMinima,responsable,direccion,categoria,aforo,aperturaPuertas,nit,fechaInicioEvento,fechaFinalEvento,imagenRepresentativa,idTipoEvento)values('" + objDatosEvento.nombreEvento + "','" + objDatosEvento.ciudadEvento + "','" + objDatosEvento.lugarEvento + "','" + objDatosEvento.edadMinima + "','" + objDatosEvento.responsable + "','" + objDatosEvento.direccion + "','" + objDatosEvento.categoria + "'," + objDatosEvento.aforo + ",'" + objDatosEvento.aperturaPuertas + "'," + objDatosEvento.nit + ",'" + objDatosEvento.fechaInicioEvento + "','" + objDatosEvento.fechaFinalEvento + "','" + objDatosEvento.imagenRepresentativa + "','" + objDatosEvento.idTipoEvento + "')";
            clConexion objConexion = new clConexion();
            int resultado = objConexion.mtdConectado(consulta);
            return resultado;
        }

        public List<clEventosE> mtdListarEventosRegistrados()
        {
            string consulta = "SELECT * FROM evento";
            clConexion objConexion = new clConexion();
            DataTable tblRegistrados = new DataTable();
            tblRegistrados = objConexion.mtdDesconectado(consulta);

            List<clEventosE> listaRegistrados = new List<clEventosE>();

            for (int i = 0; i < tblRegistrados.Rows.Count; i++)
            {
                clEventosE objEventosRegistrados = new clEventosE();
                objEventosRegistrados.idEvento = int.Parse(tblRegistrados.Rows[i]["idEvento"].ToString());
                objEventosRegistrados.nombreEvento = tblRegistrados.Rows[i]["nombreEvento"].ToString();
                objEventosRegistrados.lugarEvento = tblRegistrados.Rows[i]["lugarEvento"].ToString();
                objEventosRegistrados.edadMinima = tblRegistrados.Rows[i]["edadMinima"].ToString();
                objEventosRegistrados.responsable = tblRegistrados.Rows[i]["responsable"].ToString();
                objEventosRegistrados.direccion = tblRegistrados.Rows[i]["direccion"].ToString();
                objEventosRegistrados.categoria = tblRegistrados.Rows[i]["categoria"].ToString();
                objEventosRegistrados.aforo = int.Parse(tblRegistrados.Rows[i]["aforo"].ToString());
                objEventosRegistrados.aperturaPuertas = tblRegistrados.Rows[i]["aperturaPuertas"].ToString();
                objEventosRegistrados.nit = int.Parse(tblRegistrados.Rows[i]["nit"].ToString());
                objEventosRegistrados.fechaInicioEvento = tblRegistrados.Rows[i]["fechaInicioEvento"].ToString();
                objEventosRegistrados.fechaFinalEvento = tblRegistrados.Rows[i]["fechaFinalEvento"].ToString();
                objEventosRegistrados.imagenRepresentativa = tblRegistrados.Rows[i]["imagenRepresentativa"].ToString();
                listaRegistrados.Add(objEventosRegistrados);
            }
            return listaRegistrados;
        }

        public List<clEventosE> mtdListarEventosInicio()
        {
            string consulta = "SELECT * FROM evento";
            clConexion objConexion = new clConexion();
            DataTable tblEventos = new DataTable();
            tblEventos = objConexion.mtdDesconectado(consulta);

            List<clEventosE> listaEventosInicio = new List<clEventosE>();

            for (int i = 0; i < tblEventos.Rows.Count; i++)
            {
                clEventosE objListadoEventos = new clEventosE();
                objListadoEventos.idEvento = int.Parse(tblEventos.Rows[i]["idEvento"].ToString());
                objListadoEventos.nombreEvento = tblEventos.Rows[i]["nombreEvento"].ToString();
                objListadoEventos.lugarEvento = tblEventos.Rows[i]["lugarEvento"].ToString();
                objListadoEventos.fechaInicioEvento = tblEventos.Rows[i]["fechaInicioEvento"].ToString();
                objListadoEventos.imagenRepresentativa = tblEventos.Rows[i]["imagenRepresentativa"].ToString();
                listaEventosInicio.Add(objListadoEventos);
            }
            return listaEventosInicio;
        }

    }
}