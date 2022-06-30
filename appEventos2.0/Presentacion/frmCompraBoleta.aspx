<%@ Page Title="" Language="C#" MasterPageFile="~/Presentacion/Site1.Master" AutoEventWireup="true" CodeBehind="frmCompraBoleta.aspx.cs" Inherits="appEventos2._0.Presentacion.frmCompraBoleta" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">


    <div class="container-xxl py-5">
        <div class="container">
            <div class="text-center wow fadeInUp" data-wow-delay="0.1s">
                <h5 class="section-title ff-secondary text-center text-primary fw-normal">Boletas</h5>
                <h1 class="mb-5">Compra Tu Boleta</h1>
            </div>
            <div class="tab-class text-center wow fadeInUp" data-wow-delay="0.1s">

                <div class="tab-content">
                    <div id="tab-1" class="tab-pane fade show p-0 active">
                        <div class="row g-4">
                            <div class="col-lg-12">
                                <div class="d-flex align-items-center">
                                    <div class="w-100 d-flex flex-column text-start ps-4">
                                        <h5 class="d-flex justify-content-between border-bottom pb-2">
                                            <asp:Label ID="Label2" runat="server" Text="Nombre Boleta" CssClass="form-control"></asp:Label>
                                            <asp:Label ID="Label4" runat="server" Text="Tipo Boleta" CssClass="form-control"></asp:Label>
                                            <asp:Label ID="Label3" runat="server" Text="Precio " CssClass="form-control"></asp:Label>
                                            <asp:Label ID="Label5" runat="server" Text="Cantidad " CssClass="form-control"></asp:Label>
                                            <asp:Label ID="Label88" runat="server" Text="Total " CssClass="form-control"></asp:Label>
                                            <asp:Label ID="Label6" runat="server" Text=" " class="form-control"></asp:Label>

                                        </h5>

                                    </div>
                                </div>
                            </div>
                            <asp:Repeater ID="rpEventos" runat="server">

                                <asp:ListView ID="listadoCompra" runat="server">
                                    <itemtemplate>
                                        <div class="col-lg-12">
                                            <div class="d-flex align-items-center">
                                                <div class="w-100 d-flex flex-column text-start ps-4">

                                                    <h5 class=" ff-secondary text-start text-primary fw-normal">Evento:</h5>
                                                    <small><%#Eval("nombreEvento") %></small>

                                                    <h5 class=" ff-secondary text-start text-primary fw-normal">tipo:</h5>
                                                    <small><%#Eval("tipoBoleta") %></small>


                                                    <h5 class=" ff-secondary text-start text-primary fw-normal">precio:</h5>
                                                    <small><%#Eval("precioBoleta") %></small>

                                                    <%-- <asp:Label ID="lblNombre" runat="server" Text="" CssClass="form-control"></asp:Label>
                                                <asp:Label ID="lblTipo" runat="server" Text="" CssClass="form-control"></asp:Label>
                                                <asp:Label ID="lblPrecio" runat="server" Text=" " CssClass="form-control"></asp:Label>--%>


                                                    <asp:DropDownList ID="ddlCantidad" runat="server" CssClass="form-control"></asp:DropDownList>
                                                    <asp:Label ID="lblTotal" runat="server" Text="" CssClass="form-control"></asp:Label>
                                                    <asp:Button ID="Button1" runat="server" Text="Comprar" class="form-control" BackColor="Yellow" />


                                                </div>
                                            </div>
                                        </div>
                                    </itemtemplate>
                                </asp:ListView>
                            </asp:Repeater>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>


</asp:Content>
