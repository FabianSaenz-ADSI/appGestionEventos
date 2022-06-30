<%@ Page Title="" Language="C#" MasterPageFile="~/Presentacion/Site1.Master" AutoEventWireup="true" CodeBehind="frmDetalleReserva.aspx.cs" Inherits="appEventos2._0.Presentacion.frmDetalleReserva" %>


<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">



    <div class="container mt-3 ">

        <h5 class="section-title ff-secondary text-start text-primary fw-normal">Reserva realizada</h5>
        <h1 class="mb-4">Detalles</h1>


        <div class="border-start border-5 border-primary px-3 ">
            <div>
                <table class="table table-hover" id="tblDetallesReserva">

                    <tr>
                        <td>Fecha de la Reserva: </td>
                        <td>
                            <asp:Label ID="lblFechaReserva" runat="server" Text=""></asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td>Cantidad de boletas reservadas: </td>
                        <td>
                            <asp:Label ID="lblCantidadBoletas" runat="server" Text=""></asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td>Nombre del Evento: </td>
                        <td>
                            <asp:Label ID="lblNombreEvento" runat="server" Text=""></asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td>Total a Pagar: </td>
                        <td>
                            <asp:Label ID="lblTotalReserva" runat="server" Text=""></asp:Label>
                        </td>
                    </tr>
                </table>
            </div>
        </div>





    </div>



</asp:Content>
