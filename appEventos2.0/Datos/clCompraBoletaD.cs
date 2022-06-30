using appEventos2._0.Entidad;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace appEventos2._0.Datos
{
    public class clCompraBoletaD
    {
        public clBoletasE mtdListarComprar(int idEvento)
        {
            string consulta = "SELECT evento.nombreEvento, tipoBoleta.tipoBoleta, tipoBoleta.precioBoleta fROM evento INNER JOIN tipoBoleta ON evento.idEvento = tipoBoleta.idEvento where tipoBoleta.idEvento = '" + idEvento + "'";
            clConexion objConexion = new clConexion();
            DataTable tblDatos = new DataTable();

            tblDatos = objConexion.mtdDesconectado(consulta);

            clBoletasE comprar = new clBoletasE();
            if (tblDatos.Rows.Count > 0)
            {

                comprar.nombreEvento = tblDatos.Rows[0]["nombreEvento"].ToString();
                comprar.tipoBoleta = tblDatos.Rows[0]["tipoBoleta"].ToString();
                comprar.precioBoleta = tblDatos.Rows[0]["precioBoleta"].ToString();

            }
            else
            {
                comprar = null;

            }
            return comprar;

           



        }

        public int mtdRegistrar(clCompraE objCom) 
        {
           
                    string consulta = "INSERT INTO compra(idEmpresa,idEvento,precioTotal,cantidadBoletas) values (" + objCom.idEmpresa + "," + objCom.idEvento + ",'" + objCom.PrecioTotal + "','" + objCom.cantidadBoletas + "')";
                    clConexion objConexion = new clConexion(); 
                    int resultado = objConexion.mtdConectado(consulta);
                    return resultado;

        }
        public int mtdRegistrarp(clCompraE objCom)
        {

            string consulta = "INSERT INTO compra(idEvento,idPersona,precioTotal,cantidadBoletas) values (" + objCom.idEvento + "," + objCom.idPersona + ",'" + objCom.PrecioTotal + "','" + objCom.cantidadBoletas + "')";
            clConexion objConexion = new clConexion();
            int resultado = objConexion.mtdConectado(consulta);
            return resultado;


        }
    }
}