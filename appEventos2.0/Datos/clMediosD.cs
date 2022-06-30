using appEventos2._0.Entidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace appEventos2._0.Datos
{
    public class clMediosD
    {
        public int mtdRegistrarMedio(clMediosE objDatosMedios)
        {
            string consulta = "INSERT INTO medios(nombreMedio,tipo,urlWeb,redSocial,idEvento)values('" + objDatosMedios.nombreMedio + "','" + objDatosMedios.tipo + "','" + objDatosMedios.urlWeb + "','" + objDatosMedios.redSocial + "','"+objDatosMedios.idEvento+"')";
            clConexion objConexion = new clConexion();
            int resultado = objConexion.mtdConectado(consulta);
            return resultado;
        }
    }
}