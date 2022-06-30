<%@ Page Title="" Language="C#" MasterPageFile="~/Presentacion/Site1.Master" AutoEventWireup="true" CodeBehind="frmEditarEvento.aspx.cs" Inherits="appEventos2._0.Presentacion.WebForm2" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container-xxl py-5">
        <div class="container">
            <div class="text-center wow fadeInUp" data-wow-delay="0.1s">
                <h5 class="section-title ff-secondary text-center text-primary fw-normal">Bienvenido!!!</h5>
                <h1 class="mb-5">Eventos Disponibles</h1>
            </div>
            <div class="row g-4">
                <asp:Repeater ID="rpEventos2" runat="server">
                    <itemtemplate>
                        <div class="col-lg-3 col-sm-6 wow fadeInUp" data-wow-delay="0.1s">
                            <div class="service-item rounded pt-3">
                                <div class="p-4">

                                    <h5 class="mb-0">Portada</h5>
                                    <small><%#Eval("imagenRepresentativa") %></small>
                                    <h5 class="mb-0">Eventos</h5>
                                    <small><%#Eval("nombreEvento") %></small>
                                    <h5 class="mb-0">Lugar</h5>
                                    <small><%#Eval("lugarEvento") %></small>
                                    <h5 class="mb-0">Realizacion</h5>
                                    <small><%#Eval("fechaInicioEvento") %></small>

                                    <div class="d-flex justify-content-center mt-3">
                                        <asp:Button ID="btnEditarEventos" runat="server" Text="Editar" class="btn btn-warning mx-1" />
                                        <asp:Button ID="btnEliminarEvento" runat="server" Text="Eliminar" class="btn btn-warning mx-1" />
                                    </div>
                                </div>
                            </div>
                        </div>

                    </itemtemplate>
                </asp:Repeater>


            </div>
        </div>
    </div>
</asp:Content>
