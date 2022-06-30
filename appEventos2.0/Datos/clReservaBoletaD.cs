using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using appEventos2._0.Entidad;

namespace appEventos2._0.Datos
{
    public class clReservaBoletaD
    {

        public clEmpresaEventoE mtdListarEmpresaEvento(clEventosE objDatosEvento, string tipoRolEmpresa)
        {
            string consulta = "select  empresaEvento.idEmpresaEvento,evento.nombreEvento,evento.fechaInicioEvento,evento.fechaFinalEvento, evento.aperturaPuertas, evento.lugarEvento, evento.responsable,evento.ciudadEvento,evento.direccion, evento.imagenRepresentativa" +
            " from Empresa  inner join empresaEvento " +
            " on empresaEvento.idEmpresa = Empresa.idEmpresa " +
            "inner join evento on empresaEvento.idEvento=evento.idEvento where evento.idEvento=" + objDatosEvento.idEvento + " and tipoRolEmpresa='" + tipoRolEmpresa + "'";

            clConexion objConexion = new clConexion();
            DataTable tbDatos = new DataTable();
            tbDatos = objConexion.mtdDesconectado(consulta);

            clEmpresaEventoE objDatosEmpresaEvento = new clEmpresaEventoE();

            if (tbDatos.Rows.Count > 0)
            {

                objDatosEmpresaEvento.idEmpresaEvento = int.Parse(tbDatos.Rows[0]["idEmpresaEvento"].ToString());
                objDatosEmpresaEvento.nombreEvento = tbDatos.Rows[0]["nombreEvento"].ToString();
                objDatosEmpresaEvento.fechaInicioEvento = tbDatos.Rows[0]["fechaInicioEvento"].ToString();
                objDatosEmpresaEvento.fechaFinalEvento = tbDatos.Rows[0]["fechaFinalEvento"].ToString();
                objDatosEmpresaEvento.aperturaPuertas = tbDatos.Rows[0]["aperturaPuertas"].ToString();
                objDatosEmpresaEvento.lugarEvento = tbDatos.Rows[0]["lugarEvento"].ToString();
                objDatosEmpresaEvento.responsable = tbDatos.Rows[0]["responsable"].ToString();
                objDatosEmpresaEvento.ciudadEvento = tbDatos.Rows[0]["ciudadEvento"].ToString();
                objDatosEmpresaEvento.direccion = tbDatos.Rows[0]["direccion"].ToString();
                objDatosEmpresaEvento.imagenRepresentativa = tbDatos.Rows[0]["imagenRepresentativa"].ToString();


            }
            else
            {
                objDatosEmpresaEvento = null;

            }
            return objDatosEmpresaEvento;



        }

        public clPersonaEventoE mtdListarPersonaEvento(clEventosE objDatosEvento, string tipoRolPersona)
        {
            string consulta = "select  personaEvento.idPersonaEvento,evento.nombreEvento,evento.fechaInicioEvento,evento.fechaFinalEvento, evento.aperturaPuertas, evento.lugarEvento, evento.responsable,evento.ciudadEvento,evento.direccion, evento.imagenRepresentativa" +
            " from persona  inner join personaEvento " +
            " on personaEvento.idPersona = persona.idPersona " +
            "inner join evento on personaEvento.idEvento = evento.idEvento where evento.idEvento=" + objDatosEvento.idEvento + " and tipoRolPersona='" + tipoRolPersona + "'";

            clConexion objConexion = new clConexion();
            DataTable tbDatos = new DataTable();
            tbDatos = objConexion.mtdDesconectado(consulta);

            clPersonaEventoE objDatosPersonaEvento = new clPersonaEventoE();

            if (tbDatos.Rows.Count > 0)
            {
                objDatosPersonaEvento.idPersonaEvento = int.Parse(tbDatos.Rows[0]["idPersonaEvento"].ToString());
                objDatosPersonaEvento.nombreEvento = tbDatos.Rows[0]["nombreEvento"].ToString();
                objDatosPersonaEvento.fechaInicioEvento = tbDatos.Rows[0]["fechaInicioEvento"].ToString();
                objDatosPersonaEvento.fechaFinalEvento = tbDatos.Rows[0]["fechaFinalEvento"].ToString();
                objDatosPersonaEvento.aperturaPuertas = tbDatos.Rows[0]["aperturaPuertas"].ToString();
                objDatosPersonaEvento.lugarEvento = tbDatos.Rows[0]["lugarEvento"].ToString();
                objDatosPersonaEvento.responsable = tbDatos.Rows[0]["responsable"].ToString();
                objDatosPersonaEvento.ciudadEvento = tbDatos.Rows[0]["ciudadEvento"].ToString();
                objDatosPersonaEvento.direccion = tbDatos.Rows[0]["direccion"].ToString();
                objDatosPersonaEvento.imagenRepresentativa = tbDatos.Rows[0]["imagenRepresentativa"].ToString();

            }
            else
            {
                objDatosPersonaEvento = null;
            }

            return objDatosPersonaEvento;



        }



        public int mtdInsertarReserva(clReservaE objDatosReservaE)
        {
            if (objDatosReservaE.idEmpresaEvento != 0)
            {
                if (objDatosReservaE.idPersona != 0)
                {
                    string consulta1 = "insert into boleteria (fechaReserva, cantidadBoletas, idEmpresaEvento, idEvento, idPersona, totalReserva) values('" + objDatosReservaE.fechaReserva + "'," +
                    "'" + objDatosReservaE.cantidadBoletas + "'," + objDatosReservaE.idEmpresaEvento + "," + objDatosReservaE.idEvento + "," + objDatosReservaE.idPersona + "," + objDatosReservaE.totalReserva + ");SELECT SCOPE_IDENTITY()";

                    clConexion objConexion = new clConexion();
                    int resultado1 = objConexion.mtdConectadoId(consulta1);
                    return resultado1;

                }
                else
                {
                    string consulta1 = "insert into boleteria (fechaReserva, cantidadBoletas, idEmpresaEvento, idEvento, idEmpresa, totalReserva) values('" + objDatosReservaE.fechaReserva + "'," +
                    "'" + objDatosReservaE.cantidadBoletas + "'," + objDatosReservaE.idEmpresaEvento + "," + objDatosReservaE.idEvento + "," + objDatosReservaE.idEmpresa + "," + objDatosReservaE.totalReserva + ");SELECT SCOPE_IDENTITY()";

                    clConexion objConexion = new clConexion();
                    int resultado1 = objConexion.mtdConectadoId(consulta1);
                    return resultado1;

                }



            }
            else
            {
                if (objDatosReservaE.idPersona != 0)
                {
                    string consulta2 = "insert into boleteria (fechaReserva, cantidadBoletas, idPersonaEvento, idEvento, idPersona, totalReserva) values('" + objDatosReservaE.fechaReserva + "'," +
                    "'" + objDatosReservaE.cantidadBoletas + "'," + objDatosReservaE.idPersonaEvento + "," + objDatosReservaE.idEvento + "," + objDatosReservaE.idPersona + "," + objDatosReservaE.totalReserva + ");SELECT SCOPE_IDENTITY()";

                    clConexion objConexion = new clConexion();
                    int resultado2 = objConexion.mtdConectadoId(consulta2);
                    return resultado2;

                }
                else
                {
                    string consulta2 = "insert into boleteria (fechaReserva, cantidadBoletas, idPersonaEvento, idEvento, idEmpresa, totalReserva) values('" + objDatosReservaE.fechaReserva + "'," +
                   "'" + objDatosReservaE.cantidadBoletas + "'," + objDatosReservaE.idPersonaEvento + "," + objDatosReservaE.idEvento + "," + objDatosReservaE.idEmpresa + "," + objDatosReservaE.totalReserva + ");SELECT SCOPE_IDENTITY()";

                    clConexion objConexion = new clConexion();
                    int resultado2 = objConexion.mtdConectadoId(consulta2);
                    return resultado2;

                }

            }



        }

        public clBoleteriaE mtdListarDetalleReserva(int idBoletaReserva)
        {
            string consulta = "select boleteria.fechaReserva, boleteria.cantidadBoletas, boleteria.totalReserva, evento.nombreEvento from" +
                " boleteria inner join evento on boleteria.idEvento = evento.idEvento" +
                " where boleteria.idBoleteria ='" + idBoletaReserva + "'";
            clConexion objConexion = new clConexion();
            DataTable tbDatos = new DataTable();
            tbDatos = objConexion.mtdDesconectado(consulta);

            clBoleteriaE objDatosBoleteriaE = new clBoleteriaE();

            if (tbDatos.Rows.Count > 0)
            {

                objDatosBoleteriaE.fechaReserva = tbDatos.Rows[0]["fechaReserva"].ToString();
                objDatosBoleteriaE.cantidadBoletas = tbDatos.Rows[0]["cantidadBoletas"].ToString();
                objDatosBoleteriaE.nombreEvento = tbDatos.Rows[0]["nombreEvento"].ToString();
                objDatosBoleteriaE.totalReserva = float.Parse(tbDatos.Rows[0]["totalReserva"].ToString());

            }
            else
            {
                objDatosBoleteriaE = null;
            }

            return objDatosBoleteriaE;


        }


        public List<clBoletasE> mtdListarTipoBoleta(clBoletasE objDatos)
        {
            string consulta = "select tipoBoleta.idTipoBoleta,tipoBoleta.tipoBoleta+' | '+tipoBoleta.precioBoleta as TipoBoleta from tipoBoleta where tipoBoleta.idEvento ='" + objDatos.idEvento + "'";
            clConexion objConexion = new clConexion();
            DataTable tblDatosBoleta = new DataTable();
            tblDatosBoleta = objConexion.mtdDesconectado(consulta);
            List<clBoletasE> listaBoleta = new List<clBoletasE>();

            for (int i = 0; i < tblDatosBoleta.Rows.Count; i++)
            {
                clBoletasE objDatosBoletaE = new clBoletasE();
                objDatosBoletaE.idTipoBoleta = int.Parse(tblDatosBoleta.Rows[i]["idTipoBoleta"].ToString());
                objDatosBoletaE.tipoBoleta = tblDatosBoleta.Rows[i]["tipoBoleta"].ToString();
                objDatosBoletaE.precioBoleta = tblDatosBoleta.Rows[i]["TipoBoleta"].ToString();

                listaBoleta.Add(objDatosBoletaE);

            }
            return listaBoleta;

        }

        public List<clBoletasE> mtdListarTipoBoletaReserva(clBoletasE objDatos)
        {
            string consulta = "select * from tipoBoleta where idTipoBoleta ='" + objDatos.idTipoBoleta + "'";
            clConexion objConexion = new clConexion();
            DataTable tblDatosBoleta = new DataTable();
            tblDatosBoleta = objConexion.mtdDesconectado(consulta);
            List<clBoletasE> listaBoleta = new List<clBoletasE>();

            for (int i = 0; i < tblDatosBoleta.Rows.Count; i++)
            {
                clBoletasE objDatosBoletaE = new clBoletasE();
                objDatosBoletaE.idTipoBoleta = int.Parse(tblDatosBoleta.Rows[i]["idTipoBoleta"].ToString());
                objDatosBoletaE.precioBoleta = tblDatosBoleta.Rows[i]["precioBoleta"].ToString();

                listaBoleta.Add(objDatosBoletaE);

            }
            return listaBoleta;

        }

        public static List<clReservaE> mtdListarReservaBoleta(clReservaE objDatos)
        {
            string consulta;

            if (objDatos.idPersona != 0)
            {
                consulta = "select boleteria.idBoleteria, persona.nombres,boleteria.fechaReserva,evento.nombreEvento,boleteria.cantidadBoletas,boleteria.TotalReserva from boleteria" +
                    " inner join persona on boleteria.idPersona = persona.idPersona inner join evento" +
                    " on boleteria.idEvento = evento.idEvento where persona.idPersona='" + objDatos.idPersona + "' ";

            }
            else
            {
                consulta = "select boleteria.idBoleteria, Empresa.nombreEmpresa,boleteria.fechaReserva,evento.nombreEvento,boleteria.cantidadBoletas,boleteria.TotalReserva from boleteria" +
                    " inner join Empresa on boleteria.idEmpresa = Empresa.idEmpresa inner join evento" +
                    " on boleteria.idEvento = evento.idEvento where Empresa.idEmpresa='" + objDatos.idEmpresa + "' ";
            }

            clConexion objConexion = new clConexion();
            DataTable tblDatosRerva = new DataTable();
            tblDatosRerva = objConexion.mtdDesconectado(consulta);
            List<clReservaE> listaRerva = new List<clReservaE>();

            for (int i = 0; i < tblDatosRerva.Rows.Count; i++)
            {
                clReservaE objDatosReservaE = new clReservaE();
                objDatosReservaE.idBoleteria = int.Parse(tblDatosRerva.Rows[i]["idBoleteria"].ToString());

                if (objDatos.idPersona != 0)
                {

                    objDatosReservaE.nombres = tblDatosRerva.Rows[i]["nombres"].ToString();
                }
                else
                {
                    objDatosReservaE.nombreEmpresa = tblDatosRerva.Rows[i]["nombreEmpresa"].ToString();


                }
                objDatosReservaE.fechaReserva = tblDatosRerva.Rows[i]["fechaReserva"].ToString();
                objDatosReservaE.nombreEvento = tblDatosRerva.Rows[i]["nombreEvento"].ToString();
                objDatosReservaE.cantidadBoletas = tblDatosRerva.Rows[i]["cantidadBoletas"].ToString();
                objDatosReservaE.totalReserva = float.Parse(tblDatosRerva.Rows[i]["totalReserva"].ToString());


                listaRerva.Add(objDatosReservaE);
            }

            return listaRerva;

        }

        public int mtdCancelarReserva(clReservaE objDatos)
        {
            string consulta = "delete from boleteria where idBoleteria='" + objDatos.idBoleteria + "'";
            clConexion objConexion = new clConexion();
            int r = objConexion.mtdConectado(consulta);
            return r;
        }


    }
}