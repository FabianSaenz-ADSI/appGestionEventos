<%@ Page Title="" Language="C#" MasterPageFile="~/Presentacion/Site1.Master" AutoEventWireup="true" CodeBehind="frmInicio.aspx.cs" Inherits="appEventos2._0.Presentacion.frmInicio2" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div class="container-xxl pt-5 pb-3">
        <div class="container">
            <div class="text-center wow fadeInUp" data-wow-delay="0.1s">
                <h5 class="section-title ff-secondary text-center text-primary fw-normal">Bienvenido°°</h5>
                <h1 class="mb-5">Eventos Disponibles</h1>
            </div>
            <div class="row g-4">
                <asp:Repeater ID="rpEventos" runat="server">
                    <ItemTemplate>
                        <div class="col-lg-4 col-md-6 wow fadeInUp" data-wow-delay="0.1s">
                            <div class="team-item text-center rounded overflow-hidden">
                                <div class="rounded-circle overflow-hidden m-4">
                                    <img class="img-fluid" src="img/team-1.jpg" alt="">
                                </div>

                                <asp:Label ID="labelDato" Visible="False" runat="server" Text='<%#Eval("idEvento") %> '></asp:Label>

                                <h5 class="mb-0">Portada</h5>
                                <asp:Literal ID="Imagen" runat="server" /><img src="<%#Eval("imagenRepresentativa") %>" width="200" height="200" /><br>
                                <h5 class="mb-0">Evento</h5>
                                <small><%#Eval("nombreEvento") %></small>
                                <h5 class="mb-0">Lugar</h5>
                                <small><%#Eval("lugarEvento") %></small>
                                <h5 class="mb-0">Realizacion</h5>
                                <small><%#Eval("fechaInicioEvento") %></small>

                                <div class="d-flex justify-content-center mt-3">
                                    <asp:Button ID="btnDetalles" runat="server" Text="Detalles" class="btn btn-outline-warning mx-1" OnClick="btnDetalles_Click" />
                                    <asp:Button ID="btnReserva" runat="server" Text="Reserva" class="btn btn-outline-danger mx-1" OnClick="btnReserva_Click" />

                                </div>

                            </div>
                        </div>
                    </ItemTemplate>
                </asp:Repeater>
            </div>
        </div>
    </div>


</asp:Content>

