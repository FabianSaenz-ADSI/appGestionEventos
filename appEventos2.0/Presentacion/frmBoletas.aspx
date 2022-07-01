<%@ Page Title="" Language="C#" MasterPageFile="~/Presentacion/Site1.Master" AutoEventWireup="true" CodeBehind="frmBoletas.aspx.cs" Inherits="appEventos2._0.Presentacion.frmBoletas" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <%--formulario registro boleteria--%>

    <div class="container-xxl py-5 px-0 wow fadeInUp" data-wow-delay="0.1s">
        <div class="row g-0">
            <div class="col-md-12 bg-dark d-flex align-items-center">
                <div class="p-5 wow fadeInUp" data-wow-delay="0.2s">
                    <h5 class="section-title ff-secondary text-start text-primary fw-normal">Registrar</h5>
                    <h1 class="text-white mb-4">Registra Tus Boletas</h1>
                    <form>

                        <div class="row g-3">

                            <div class="col-md-12">
                                <div class="form-floating date">
                                    <asp:Label runat="server" Text="Eventos Registrados" ForeColor="White"></asp:Label>
                                    <asp:DropDownList ID="dpEventosRegistrados" runat="server" placeholder="Seleccione el evento" CssClass="form-control" ForeColor="Black"></asp:DropDownList>
                                </div>
                            </div>

                            <div class="col-md-12">
                                <div class="form-floating date">
                                    <asp:Label runat="server" ForeColor="White">Tipo de Boleta:</asp:Label>
                                    <asp:TextBox ID="txtTipoBoleta" runat="server" placeholder="Ejemplo(vip-platea-premium)" CssClass="form-control"></asp:TextBox>
                                </div>
                            </div>

                            <div class="col-md-12">
                                <div class="form-floating date">
                                    <asp:Label runat="server" ForeColor="White">Precio Boleta:</asp:Label>
                                    <asp:TextBox ID="txtPrecioBoleta" runat="server" placeholder="" CssClass="form-control"></asp:TextBox>
                                </div>
                            </div>

                            <div class="col-md-12">
                                <div class="form-floating date" id="date3" data-target-input="nearest">
                                    <asp:Label runat="server" Text="" ForeColor="White">Ubicacion:</asp:Label>
                                    <asp:TextBox ID="txtUbicacion" runat="server" placeholder="Ejemplo(palco-graderia-gramilla)" CssClass="form-control"></asp:TextBox>
                                </div>
                            </div>



                            <div class="text-center alig-items-center justify-content-center">
                                <asp:Button ID="btnRegistrarBoleta" runat="server" Text="Registrar Boleta" class="btn btn-outline-warning" OnClick="btnRegistrarBoleta_Click" />
                            </div>

                        </div>
                </div>
            </div>
        </div>
    </div>
</asp:Content>
