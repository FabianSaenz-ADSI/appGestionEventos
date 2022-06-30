using appEventos2._0.Entidad;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace appEventos2._0.Datos
{
    public class clEditarEventoD
    {
        public List<clEventosE> mtdMisEventosD()
        {
            string consulta = "Select * FROM evento";
            clConexion objConexion = new clConexion();
            DataTable tblMisEventos = new DataTable();
            tblMisEventos = objConexion.mtdDesconectado(consulta);

            List<clEventosE> listaMisEventos = new List<clEventosE>();

            for (int i = 0; i < tblMisEventos.Rows.Count; i++)
            {
                clEventosE objDatosMisEventos = new clEventosE();
                objDatosMisEventos.idEvento = int.Parse(tblMisEventos.Rows[i]["idEvento"].ToString());
                objDatosMisEventos.ciudadEvento = tblMisEventos.Rows[i]["ciudadEvento"].ToString();
                objDatosMisEventos.lugarEvento = tblMisEventos.Rows[i]["lugarEvento"].ToString();
                objDatosMisEventos.edadMinima = tblMisEventos.Rows[i]["edadMinima"].ToString();
                objDatosMisEventos.responsable = tblMisEventos.Rows[i]["responsable"].ToString();
                objDatosMisEventos.direccion = tblMisEventos.Rows[i]["direccion"].ToString();
                objDatosMisEventos.categoria = tblMisEventos.Rows[i]["categoria"].ToString();
                objDatosMisEventos.aforo = int.Parse(tblMisEventos.Rows[i]["aforo"].ToString());
                objDatosMisEventos.aperturaPuertas = tblMisEventos.Rows[i]["aperturaPuertas"].ToString();
                objDatosMisEventos.nit = int.Parse(tblMisEventos.Rows[i]["nit"].ToString());
                objDatosMisEventos.nombreEvento = tblMisEventos.Rows[i]["nombreEvento"].ToString();
                objDatosMisEventos.fechaInicioEvento = tblMisEventos.Rows[i]["fechaInicioEvento"].ToString();
                objDatosMisEventos.fechaFinalEvento = tblMisEventos.Rows[i]["fechaFinalEvento"].ToString();
                objDatosMisEventos.imagenRepresentativa = tblMisEventos.Rows[i]["imagenRepresentativa"].ToString();
                listaMisEventos.Add(objDatosMisEventos);
            }
            return listaMisEventos;
        }
    }
}