<%@ Page Title="" Language="C#" MasterPageFile="~/Presentacion/Site1.Master" AutoEventWireup="true" CodeBehind="frmEventos.aspx.cs" Inherits="appEventos2._0.Presentacion.WebForm1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div class="container-xxl py-5 px-0 wow fadeInUp" data-wow-delay="0.1s">
        <div class="row g-0">
            <div class="col-md-12 bg-dark d-flex align-items-center">
                <div class="p-5 wow fadeInUp" data-wow-delay="0.2s">
                    <h5 class="section-title ff-secondary text-start text-primary fw-normal">Registrar</h5>
                    <h1 class="text-white mb-4">Registra Aqui tus Eventos</h1>
                    <form>

                        <div class="row g-3">

                            <div class="col-md-12">
                                <div class="form-floating date">
                                    <asp:Label ID="Label1" runat="server" Text="Tipo Evento" ForeColor="White"></asp:Label>
                                    <asp:DropDownList  ID="dpListaEventos" runat="server" placeholder="tipo Evento" CssClass="form-control" ForeColor="Black" AutoPostBack="True"></asp:DropDownList>
                                </div>
                            </div>

                            <div class="col-md-6">
                                <div class="form-floating date">
                                    <asp:Label for="txtNombreEvento" runat="server" Text="" ForeColor="White">Nombre Evento:</asp:Label>
                                    <asp:TextBox ID="txtNombreEvento" runat="server" placeholder="Nombre Evento" CssClass="form-control"></asp:TextBox>
                                </div>
                            </div>

                            <div class="col-md-6">
                                <div class="form-floating date" data-target-input="nearest">
                                    <asp:Label for="txtCiudad" runat="server" Text="" ForeColor="White">Ciudad de Realizacion:</asp:Label>
                                    <asp:TextBox ID="txtCiudad" runat="server" placeholder="Ciudad Realizacion" CssClass="form-control"></asp:TextBox>
                                </div>
                            </div>

                            <div class="col-md-6">
                                <div class="form-floating date">
                                    <asp:Label for="txtLugar" runat="server" Text="" ForeColor="White">Lugar Evento:</asp:Label>
                                    <asp:TextBox ID="txtLugar" runat="server" placeholder="Lugar Evento" CssClass="form-control" BorderColor="DarkBlue"></asp:TextBox>
                                </div>
                            </div>

                            <div class="col-md-6">
                                <div class="form-floating date">
                                    <asp:Label for="txtEdadMinima" runat="server" Text="" ForeColor="White">edad minima :</asp:Label>
                                    <asp:TextBox ID="txtEdadMinima" runat="server" placeholder="edad Minima ingreso" CssClass="form-control" BorderColor="DarkBlue"></asp:TextBox>
                                </div>
                            </div>

                            <div class="col-md-6">
                                <div class="form-floating date">
                                    <asp:Label for="txtResponsable" runat="server" Text="" ForeColor="White">Representante Evento:</asp:Label>
                                    <asp:TextBox ID="txtResponsable" runat="server" placeholder="Nombre Representante" CssClass="form-control" BorderColor="DarkBlue"></asp:TextBox>
                                </div>
                            </div>

                            <div class="col-md-6">
                                <div class="form-floating date">
                                    <asp:Label for="txtDireccion" runat="server" Text="" ForeColor="White">Direccion de Realizacion:</asp:Label>
                                    <asp:TextBox ID="txtDireccion" runat="server" placeholder="Ingrese la direccion" CssClass="form-control" BorderColor="DarkBlue"></asp:TextBox>
                                </div>
                            </div>

                            <div class="col-md-6">
                                <div class="form-floating date">
                                    <asp:Label for="txtCategoria" runat="server" Text="" ForeColor="White">Categoria Evento:</asp:Label>
                                    <asp:TextBox ID="txtCategoria" runat="server" placeholder="Ingrese Categoria" CssClass="form-control" BorderColor="DarkBlue"></asp:TextBox>
                                </div>
                            </div>

                            <div class="col-md-6">
                                <div class="form-floating date">
                                    <asp:Label for="txtAforo" runat="server" Text="" ForeColor="White">Aforo Permitido:</asp:Label>
                                    <asp:TextBox ID="txtAforo" runat="server" placeholder="Ingrese la Cantidad de Personas Permitidas" CssClass="form-control" BorderColor="DarkBlue"></asp:TextBox>
                                </div>
                            </div>

                            <div class="col-md-6">
                                <div class="form-floating date">
                                    <asp:Label for="txtApertura" runat="server" Text="" ForeColor="White">Apertura Puertas:</asp:Label>
                                    <asp:TextBox ID="txtApertura" runat="server" placeholder="Hora de la Apertura" CssClass="form-control" BorderColor="DarkBlue"></asp:TextBox>
                                </div>
                            </div>

                            <div class="col-md-6">
                                <div class="form-floating date">
                                    <asp:Label for="txtNit" runat="server" Text="" ForeColor="White">Nit:</asp:Label>
                                    <asp:TextBox ID="txtNit" runat="server" placeholder="Nit Empresarial o Personal" CssClass="form-control" BorderColor="DarkBlue"></asp:TextBox>
                                </div>
                            </div>

                            <div class="col-md-6">
                                <div class="form-floating date">
                                    <asp:Label for="txtFechaInicial" runat="server" Text="" ForeColor="White">Fecha Inicio:</asp:Label>
                                    <asp:TextBox ID="txtFechaInicial" runat="server" placeholder="Fecha Inicial evento" CssClass="form-control" BorderColor="DarkBlue"></asp:TextBox>
                                </div>
                            </div>

                            <div class="col-md-6">
                                <div class="form-floating date">
                                    <asp:Label for="txtFechaFinal" runat="server" Text="" ForeColor="White">Fecha Terminacion:</asp:Label>
                                    <asp:TextBox ID="txtFechaFinal" runat="server" placeholder="Fecha Terminacion" CssClass="form-control" BorderColor="DarkBlue"></asp:TextBox>
                                </div>
                            </div>

                            <div class="col-md-12 text-center alig-items-center justify-content-center">
                                <asp:Label ID="Label10" runat="server" Text="Imagen Representativa" ForeColor="White"></asp:Label>
                                <div class="form-floating">

                                    <asp:Image ImageUrl="https://idescargar.com/wp-content/uploads/2018/01/lucky-patcher-apk.png" ID="img" runat="server" Width="150" Height="150" />
                                    <asp:FileUpload ID="fluImagen" runat="server" onchange="mostrarImagen(this)" />

                                </div>
                            </div>

                            <div class="text-center alig-items-center justify-content-center">
                                <asp:Button ID="btnRegistrarEvento" runat="server" Text="Registrar Evento" class="btn btn-outline-success" OnClick="btnRegistrarEvento_Click" />
                            </div>



                        </div>
                </div>
            </div>
        </div>
    </div>



</asp:Content>
