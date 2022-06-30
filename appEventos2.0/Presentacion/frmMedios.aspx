<%@ Page Title="" Language="C#" MasterPageFile="~/Presentacion/Site1.Master" AutoEventWireup="true" CodeBehind="frmMedios.aspx.cs" Inherits="appEventos2._0.Presentacion.frmMedios" %>

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
                                    <asp:DropDownList ID="dpRegistradosMedios" runat="server" placeholder="Seleccione el evento" CssClass="form-control" ForeColor="Black"></asp:DropDownList>
                                </div>
                            </div>

                            <div class="col-md-12">
                                <div class="form-floating date">
                                    <asp:Label runat="server" ForeColor="White">Nombre del Medio:</asp:Label>
                                    <asp:TextBox ID="txtMedio" runat="server" placeholder="Desccripcion del medio" CssClass="form-control"></asp:TextBox>
                                </div>
                            </div>

                            <div class="col-md-12">
                                <div class="form-floating date">
                                    <asp:Label runat="server" ForeColor="White">Tipo Medio:</asp:Label>
                                    <asp:TextBox ID="txtTipoMedio" runat="server" placeholder="Especifique el tipo medio(Imagen-video-pagina-post)" CssClass="form-control"></asp:TextBox>
                                </div>
                            </div>

                            <div class="col-md-12">
                                <div class="form-floating date" id="date3" data-target-input="nearest">
                                    <asp:Label runat="server" ForeColor="White">Enlace Publicidad:</asp:Label>
                                    <asp:HyperLink ID="hplWeb" runat="server" ForeColor="White">Enlace Medio Promocional</asp:HyperLink>
                                    <asp:TextBox ID="txtPublicidad" runat="server" placeholder="Publicidad" CssClass="form-control"></asp:TextBox>

                                    <div class="redes-container">
                                        <ul>
                                            <li><a href="https://www.facebook.com/" class="facebook" ><i class="fab fa-facebook-f"></i></a></li>
                                            <li><a href="https://www.instagram.com/" class="instagram" ><i class="fab fa-instagram"></i></a></li>
                                            <li><a href="https://twitter.com/" class="Twitter" ><i class="fab fa-twitter"></i></a></li>
                                            <li><a href="https://co.pinterest.com/" class="pinterest" ><i class="fab fa-pinterest-p"></i></a></li>
                                            <li><a href="https://co.linkedin.com/" class="linkedin" ><i class="fab fa-linkedin-in"></i></a></li>
                                            <li><a href="https://www.youtube.com/" class="youtube" ><i class="fab fa-youtube"></i></a></li>
                                        </ul>
                                    </div>
                                </div>
                            </div>

                            <div class="text-center alig-items-center justify-content-center">
                                <asp:Button ID="btnRegistrarMedio" runat="server" Text="Registrar Medio" class="btn btn-outline-warning" OnClick="btnRegistrarMedio_Click" />
                            </div>

                        </div>
                </div>
            </div>
        </div>
    </div>

</asp:Content>
