using appEventos2._0.Datos;
using appEventos2._0.Entidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace appEventos2._0.Logica
{
    public class clMediosL
    {
        public int mtdRegistrarM(clMediosE objDatosMedios)
        {
            clMediosD objDatosMediosD = new clMediosD();
            int resultado = objDatosMediosD.mtdRegistrarMedio(objDatosMedios);
            return resultado;
        }

       

    }
}