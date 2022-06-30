<%@ Page Title="" Language="C#" MasterPageFile="~/Presentacion/Site1.Master" AutoEventWireup="true" CodeBehind="frmEmpresa.aspx.cs" Inherits="appEventos2._0.Presentacion.frmEmpresa" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <!-- Reservation Start -->
    <div class="container-xxl py-5 px-0 wow fadeInUp" data-wow-delay="0.1s">
        <div class="row g-0">
            <div class="col-md-12 bg-dark d-flex align-items-center">
                <div class="p-5 wow fadeInUp" data-wow-delay="0.2s">
                    <h5 class="section-title ff-secondary text-start text-primary fw-normal">Registrar</h5>
                    <h1 class="text-white mb-4">Registra Tu Empresa</h1>
                    <form>
                        <div class="row g-3">
                            <div class="col-md-6">
                                <div class="form-floating date">
                                    <asp:Label ID="Label2" runat="server" Text="Nombre Empresa" ForeColor="White"></asp:Label>
                                    <asp:TextBox ID="txtNombreEmpresa" runat="server" class="form-control"></asp:TextBox>

                                </div>
                            </div>
                            <div class="col-md-6">
                                <div class="form-floating date">
                                    <asp:Label ID="Label3" runat="server" Text="Dirección" ForeColor="White"></asp:Label>
                                    <asp:TextBox ID="txtDireccion" runat="server" class="form-control"></asp:TextBox>

                                </div>
                            </div>
                            <div class="col-md-6">
                                <div class="form-floating date" id="date3" data-target-input="nearest">
                                    <asp:Label ID="Label4" runat="server" Text="Correo" ForeColor="White"></asp:Label>
                                    <asp:TextBox ID="txtEmail" runat="server" class="form-control" TextMode="Email"></asp:TextBox>

                                </div>
                            </div>
                            <div class="col-md-6">
                                <div class="form-floating date">
                                    <asp:Label ID="Label1" runat="server" Text="Confirmación Correo" ForeColor="White"></asp:Label>
                                    <asp:TextBox ID="txtConfirmarCorreo" runat="server" class="form-control" TextMode="Email"></asp:TextBox>
                                    <asp:CompareValidator ID="CompareValidator1" runat="server" ErrorMessage="Email no coincide" ControlToCompare="txtEmail" ControlToValidate="txtConfirmarCorreo" ForeColor="#3333FF"></asp:CompareValidator>

                                </div>
                            </div>
                            <div class="col-md-6">
                                <div class="form-floating date">
                                    <asp:Label ID="Label5" runat="server" Text="Teléfono" ForeColor="White"></asp:Label>
                                    <asp:TextBox ID="txtTelefono" runat="server" class="form-control" TextMode="Number"></asp:TextBox>

                                </div>
                            </div>
                            <div class="col-md-6">
                                <div class="form-floating date">
                                    <asp:Label ID="Label6" runat="server" Text="Nit" ForeColor="White"></asp:Label>
                                    <asp:TextBox ID="txtNit" runat="server" class="form-control"></asp:TextBox>

                                </div>

                            </div>
                            <div class="col-md-6">
                                <div class="form-floating date">
                                    <asp:Label ID="Label7" runat="server" Text="Contraseña" ForeColor="White"></asp:Label>
                                    <asp:TextBox ID="txtContraseña" runat="server" class="form-control" TextMode="Password"></asp:TextBox>

                                </div>

                            </div>
                            <div class="col-md-6">
                                <div class="form-floating date">
                                    <asp:Label ID="Label8" runat="server" Text="Confirmación Contraseña" ForeColor="White"></asp:Label>
                                    <asp:TextBox ID="txtConfirmacionContraseña" runat="server" class="form-control" TextMode="Password"></asp:TextBox>
                                    <asp:CompareValidator ID="CompareValidator2" runat="server" ErrorMessage="Contraseña no coincide" ControlToCompare="txtContraseña" ControlToValidate="txtConfirmacionContraseña" ForeColor="#3333FF"></asp:CompareValidator>
                                </div>
                            </div>

                           

                            <div class="col-md-6">
                                <asp:Label ID="Label10" runat="server" Text="Logo Empresa" ForeColor="White"></asp:Label>
                                <div class="form-floating">

                                    <asp:Image ID="img" runat="server" Width="150" Height="150" />
                                    <asp:FileUpload ID="flu" runat="server" onchange="mostrarImagen(this)" />

                                </div>
                            </div>
                            <div class="col-12">
                                <asp:Button ID="btnRegistrar" runat="server" Text="Registrar" class="btn btn-primary w-25 py-3" type="submit" OnClick="btnRegistrar_Click" />
                            </div>
                        </div>
                    </form>
                </div>
            </div>
        </div>
    </div>
</asp:Content>
