<%@ Page Title="" Language="C#" MasterPageFile="~/Presentacion/Site1.Master" AutoEventWireup="true" CodeBehind="frmMisReservas.aspx.cs" Inherits="appEventos2._0.Presentacion.frmMisReservas" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container mt-5">
        <h2>Mis reservas</h2>
        <p>Lista de reservas realizadas</p>
        
        <br>
        <table id="tblDatosReserva" class="table table-striped table-bordered">
            <thead>
                <tr>
                    <th>#</th>
                    <th>Nombre Usuario</th>
                    <th>Fecha reserva</th>
                    <th>Nombre evento</th>
                    <th>N°Boletas</th>
                    <th>$Total</th>
                    <th>Cancelar</th>
                    <th>Comprar</th>


                </tr>
            </thead>
            <tbody id="myTable">
            </tbody>
        </table>

        <%--  <p>Note that we start the search in tbody, to prevent filtering the table headers.</p>--%>
    </div>
    <script src="https://code.jquery.com/jquery-3.5.1.js"></script>
    <script src="https://cdn.datatables.net/1.12.1/js/jquery.dataTables.min.js"></script>
    <script src="https://cdn.datatables.net/1.12.1/js/dataTables.bootstrap4.min.js"></script>



    <script src="script/reservas.js"></script>


</asp:Content>
