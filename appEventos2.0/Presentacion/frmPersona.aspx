<%@ Page Title="" Language="C#" MasterPageFile="~/Presentacion/Site1.Master" AutoEventWireup="true" CodeBehind="frmPersona.aspx.cs" Inherits="appEventos2._0.Presentacion.frmPersona" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>


<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div class="container-xxl py-5 px-0 wow fadeInUp" data-wow-delay="0.1s">
        <div class="row g-0">
            <div class="col-md-12 bg-dark d-flex align-items-center">
                <div class="p-5 wow fadeInUp" data-wow-delay="0.2s">
                    <h5 class="section-title ff-secondary text-start text-primary fw-normal">Reservation</h5>
                    <h1 class="text-white mb-4">Registro Persona</h1>
                    <form>
                        <div class="row g-3">

                            <div class="col-md-6">
                                <asp:Label ID="Label2" runat="server" Text="Nombres" ForeColor="White"></asp:Label>
                                <div class="form-floating">
                                    <asp:TextBox ID="txtNombres" runat="server" type="text" CssClass="form-control" BorderColor="DarkSlateGray" ForeColor="DarkBlue"></asp:TextBox>
                                </div>
                            </div>
                            <div class="col-md-6">
                                <asp:Label ID="Label1" runat="server" Text="Apellidos" ForeColor="White"></asp:Label>
                                <div class="form-floating">
                                    <asp:TextBox ID="txtApellidos" runat="server" type="text" CssClass="form-control" ForeColor="DarkBlue"></asp:TextBox>
                                </div>
                            </div>



                            <div class="col-md-6">
                                <asp:Label ID="Label4" runat="server" Text="Numero De Telefono" ForeColor="White"></asp:Label>
                                <div class="form-floating">
                                    <asp:TextBox ID="txtTelefono" runat="server" type="text" CssClass="form-control" ForeColor="DarkBlue" MaxLength="10" TextMode="Number"></asp:TextBox>
                                </div>
                            </div>
                            <div class="col-md-6">
                                <asp:Label ID="Label5" runat="server" Text="Tipo De Documento" ForeColor="White"></asp:Label>
                                <div class="form-floating">
                                    <asp:DropDownList ID="ddlTipoDocumento" runat="server" CssClass="form-control"></asp:DropDownList>
                                </div>
                            </div>



                            <div class="col-md-6">
                                <asp:Label ID="Label6" runat="server" Text="Numero de documento" ForeColor="White"></asp:Label>
                                <div class="form-floating">
                                    <asp:TextBox ID="txtDocumento" runat="server" type="text" CssClass="form-control" ForeColor="DarkBlue" TextMode="Number"></asp:TextBox>
                                </div>
                            </div>
                            <div class="col-md-6">
                                <asp:Label ID="Label7" runat="server" Text="Genero" ForeColor="White"></asp:Label>
                                <div class="form-floating">
                                    <asp:DropDownList ID="ddlGenero" runat="server" CssClass="form-control"></asp:DropDownList>

                                </div>
                            </div>



                            <div class="col-md-6">
                                <asp:Label ID="Label8" runat="server" Text="Fecha De Nacimiento" ForeColor="White"></asp:Label>
                                <div class="form-floating">
                                    <asp:TextBox ID="txtFecha" runat="server" type="text" CssClass="form-control" ForeColor="DarkBlue" TextMode="Date"></asp:TextBox>
                                </div>
                            </div>
                            <div class="col-md-6">
                                <asp:Label ID="Label9" runat="server" Text="Edad" ForeColor="White"></asp:Label>
                                <div class="form-floating">
                                    <asp:TextBox ID="txtEdad" runat="server" type="text" CssClass="form-control" ForeColor="DarkBlue" TextMode="Number" MaxLength="2"></asp:TextBox>
                                </div>
                            </div>



                            <div class="col-md-6">
                                <asp:Label ID="Label10" runat="server" Text="Pais" ForeColor="White"></asp:Label>
                                <div class="form-floating">
                                    <asp:TextBox ID="txtPais" runat="server" type="text" CssClass="form-control" ForeColor="DarkBlue"></asp:TextBox>
                                </div>
                            </div>
                            <div class="col-md-6">
                                <asp:Label ID="Label11" runat="server" Text="Departamento" ForeColor="White"></asp:Label>
                                <div class="form-floating">
                                    <asp:TextBox ID="txtDepartamento" runat="server" type="text" CssClass="form-control" ForeColor="DarkBlue"></asp:TextBox>
                                </div>
                            </div>



                            <div class="col-md-6">
                                <asp:Label ID="Label12" runat="server" Text="Ciudad" ForeColor="White"></asp:Label>
                                <div class="form-floating">
                                    <asp:TextBox ID="txtCiudad" runat="server" type="text" CssClass="form-control" ForeColor="DarkBlue"></asp:TextBox>
                                </div>
                            </div>
                            <div class="col-md-6">
                                <asp:Label ID="Label13" runat="server" Text="Dirección" ForeColor="White"></asp:Label>
                                <div class="form-floating">
                                    <asp:TextBox ID="txtDireccion" runat="server" type="text" CssClass="form-control" ForeColor="DarkBlue"></asp:TextBox>
                                </div>
                            </div>




                            <div class="col-md-6">
                                <asp:Label ID="Label14" runat="server" Text="Email" ForeColor="White"></asp:Label>
                                <div class="form-floating">
                                    <asp:TextBox ID="txtEmail" runat="server" type="text" CssClass="form-control" ForeColor="DarkBlue" TextMode="Email"></asp:TextBox>
                                </div>
                            </div>
                            <div class="col-md-6">
                                <asp:Label ID="Label15" runat="server" Text="Confirmacion De Email" ForeColor="White"></asp:Label>
                                <div class="form-floating">
                                    <asp:TextBox ID="txtConfirmacionEmail" runat="server" type="text" CssClass="form-control" ForeColor="DarkBlue" TextMode="Email"></asp:TextBox>
                                    <asp:CompareValidator ID="cvEmail" runat="server" ErrorMessage="El email no coincide" ControlToValidate="txtEmail" ControlToCompare="txtConfirmacionEmail" Operator="Equal" CssClass="value" ForeColor="White"></asp:CompareValidator>
                                </div>
                            </div>



                            <div class="col-md-6">
                                <asp:Label ID="Label16" runat="server" Text="Contraseña" ForeColor="White"></asp:Label>
                                <div class="form-floating">
                                    <asp:TextBox ID="txtContraseña" runat="server" type="text" CssClass="form-control" ForeColor="DarkBlue" TextMode="Password"></asp:TextBox>
                                </div>
                            </div>
                            <div class="col-md-6">
                                <asp:Label ID="Label17" runat="server" Text="Confirmacion De Contraseña" ForeColor="White"></asp:Label>
                                <div class="form-floating">
                                    <asp:TextBox ID="txtConfirmacioContraseña" runat="server" type="text" CssClass="form-control" ForeColor="DarkBlue" TextMode="Password"></asp:TextBox>
                                    <asp:CompareValidator ID="cvContraseña" runat="server" ErrorMessage="La contraseña no coinside" ControlToCompare="txtContraseña" ControlToValidate="txtConfirmacioContraseña" CssClass="value" ForeColor="White"></asp:CompareValidator>
                                </div>
                            </div>


                            <div class="col offset-lg-2">
                                <asp:Label ID="lblRut" runat="server" Text="INGRESE SU RUT"></asp:Label>
                                <br />
                                <br />

                                <asp:FileUpload ID="pdf" runat="server" />
                                <br />
                                <br />
                            </div>



                            <div class="col-md-12">
                                <asp:Button ID="btnRegistrar" runat="server" Text="Registrar" CssClass="btn btn-primary w-100 py-3" OnClick="btnRegistrar_Click" />


                            </div>

                            
                        </div>
                    </form>
                </div>
            </div>
        </div>
    </div>


</asp:Content>
