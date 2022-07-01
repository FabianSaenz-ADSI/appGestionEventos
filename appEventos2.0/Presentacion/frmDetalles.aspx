<%@ Page Title="" Language="C#" MasterPageFile="~/Presentacion/Site1.Master" AutoEventWireup="true" CodeBehind="frmDetalles.aspx.cs" Inherits="appEventos2._0.Presentacion.frmDetalles" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div class="container-xxl py-5">
        <div class="container">
            <div class="row g-5 align-items-center">
                <div class="col-lg-4">
                    <div class="row g-3">
                        <div class="col-6 text-start">
                            <asp:Image ID="Image1" runat="server" ImageUrl='<%#Eval("imagenRepresentativa") %>' class="img-fluid rounded w-100 wow zoomIn" data-wow-delay="0.1s" /><br>
                        </div>
                        <div class="col-6 text-start">
                            <asp:Image ID="Image2" runat="server" class="img-fluid rounded w-75 wow zoomIn" data-wow-delay="0.3s" Style="margin-top: 25%;" /><br>
                        </div>
                        <div class="col-6 text-end">
                            <asp:Image ID="Image3" runat="server" class="img-fluid rounded w-75 wow zoomIn" data-wow-delay="0.5s" /><br>
                        </div>
                        <div class="col-6 text-end">
                            <asp:Image ID="Image4" runat="server" class="img-fluid rounded w-100 wow zoomIn" data-wow-delay="0.7s" /><br>
                        </div>
                    </div>
                </div>

                <div class="col-lg-8">
                    <h5 class="section-title ff-secondary text-start text-primary fw-normal">Bienvenido</h5>
                    <h1 class="mb-4">Informacion General</h1>
                    <asp:Label ID="labelDetalles" runat="server" Text="Label"></asp:Label>
                    <div class="row g-4 mb-4">
                        <div class="col-sm-6">
                            <div class="d-flex align-items-center border-start border-5 border-primary px-3">
                                <div class="ps-4">

                                    <asp:ListView ID="listadoGeneral" runat="server">
                                        <ItemTemplate>


                                            <h5 class=" ff-secondary text-start text-primary fw-normal">Evento:</h5>
                                            <small><%#Eval("nombreEvento") %></small>

                                            <h5 class=" ff-secondary text-start text-primary fw-normal">Ciudad:</h5>
                                            <small><%#Eval("ciudadEvento") %></small>

                                            <h5 class=" ff-secondary text-start text-primary fw-normal">Lugar:</h5>
                                            <small><%#Eval("lugarEvento") %></small>

                                            <h5 class=" ff-secondary text-start text-primary fw-normal">Edad Minima Ingreso:</h5>
                                            <small><%#Eval("edadMinima") %></small>

                                            <h5 class=" ff-secondary text-start text-primary fw-normal">Responsable:</h5>
                                            <small><%#Eval("responsable") %></small>

                                            <h5 class=" ff-secondary text-start text-primary fw-normal">Direccion:</h5>
                                            <small><%#Eval("direccion") %></small>

                                            <h5 class=" ff-secondary text-start text-primary fw-normal">Categoria:</h5>
                                            <small><%#Eval("categoria") %></small>

                                            <h5 class=" ff-secondary text-start text-primary fw-normal">Aforo Permitido:</h5>
                                            <small><%#Eval("aforo") %></small>

                                            <h5 class=" ff-secondary text-start text-primary fw-normal">Apertura Puertas:</h5>
                                            <small><%#Eval("aperturaPuertas") %></small>

                                            <h5 class=" ff-secondary text-start text-primary fw-normal">Nit:</h5>
                                            <small><%#Eval("nit") %></small>

                                            <h5 class=" ff-secondary text-start text-primary fw-normal">Fecha Inicio:</h5>
                                            <small><%#Eval("fechaInicioEvento") %></small>

                                            <h5 class=" ff-secondary text-start text-primary fw-normal">Fecha Finalizacion:</h5>
                                            <small><%#Eval("fechaFinalEvento") %></small>


                                        </ItemTemplate>


                                    </asp:ListView>

                                </div>
                            </div>
                        </div>
                    </div>

                </div>
                <div class="col offset-4">
                    <asp:Button ID="btnRegresar" runat="server" Text="Volver" OnClick="btnRegresar_Click" CssClass="btn btn-outline-warning mx-1" />
                    <asp:Button ID="btnAsistir" runat="server" Text="Comprar Boleta" class="btn btn-outline-success mx-1" OnClick="btnAsistir_Click" />
                    <asp:Button ID="btnQr" runat="server" Text="Generar Qr" class="btn btn-outline-success mx-2" OnClick="btnQr_Click" />

                </div>
            </div>
        </div>
    </div>

</asp:Content>
