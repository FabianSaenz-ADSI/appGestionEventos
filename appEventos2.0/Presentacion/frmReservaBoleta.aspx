<%@ Page Title="" Language="C#" MasterPageFile="~/Presentacion/Site1.Master" AutoEventWireup="true" CodeBehind="frmReservaBoleta.aspx.cs" Inherits="appEventos2._0.Presentacion.frmReservaBoleta" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">


    <div class="container-xxl py-5 px-0 wow fadeInUp" data-wow-delay="0.1s">
        <div class="row g-0">

            <div class="col-md-5 d-grid align-items-center" >
                <asp:Image ID="imgEvento" Width="400" Height="400" CssClass="rounded-start col offset-2" runat="server" />

            </div>


            <div class="col-md-7 bg-dark d-flex align-items-center">
                <div class="p-5 wow fadeInUp" data-wow-delay="0.2s">

                    <h5 class="section-title ff-secondary text-start text-primary fw-normal">Reservación</h5>
                    <h1 class="text-white mb-4">Reserva tu boleta Online</h1>






                    <div class="row g-3">
                        <div class="col-md-6">
                            <div class="form-floating">

                                <asp:TextBox ID="txtNombreEvento" class="form-control" runat="server"></asp:TextBox>
                                <label for="name">Nombre del evento</label>

                            </div>
                        </div>
                        <div class="col-md-6">
                            <div class="form-floating">

                                <asp:TextBox ID="txtFechaInicio" class="form-control" runat="server"></asp:TextBox>
                                <label for="name">Fecha inicio</label>

                            </div>
                        </div>
                        <div class="col-md-6">
                            <div class="form-floating">

                                <asp:TextBox ID="txtFechaFinal" class="form-control" runat="server"></asp:TextBox>
                                <label for="name">Fecha final</label>

                            </div>
                        </div>
                        <div class="col-md-6">
                            <div class="form-floating">

                                <asp:TextBox ID="txtAperturaPuertas" class="form-control" runat="server"></asp:TextBox>
                                <label for="name">Apertura puertas</label>

                            </div>
                        </div>
                        <div class="col-md-6">
                            <div class="form-floating">

                                <asp:TextBox ID="txtLugarEvento" class="form-control" runat="server"></asp:TextBox>
                                <label for="name">Lugar del evento</label>

                            </div>
                        </div>

                        <div class="col-md-6">
                            <div class="form-floating">

                                <asp:TextBox ID="txtResponsable" class="form-control" runat="server"></asp:TextBox>
                                <label for="name">Responsable</label>

                            </div>
                        </div>

                        <div class="col-md-6">
                            <div class="form-floating">

                                <asp:TextBox ID="txtCiudadEvento" class="form-control" runat="server"></asp:TextBox>
                                <label for="name">Ciudad del evento</label>

                            </div>
                        </div>

                        <div class="col-md-6">
                            <div class="form-floating">

                                <asp:TextBox ID="txtDireccionEvento" class="form-control" runat="server"></asp:TextBox>
                                <label for="name">Dirección del  evento</label>

                            </div>
                        </div>

                        <div class="col-md-6">
                            <p1 class="text-white mb-4">Tipo de boleta</p1>
                            <div>
                                <asp:DropDownList ID="ddlListaTipoBoleta" class="form-select form-control" runat="server" AutoPostBack="True"></asp:DropDownList>
                            </div>
                        </div>

                        <div class="col-md-2">
                            <p1 class="text-white mb-4">Cantidad</p1>
                            <div>
                                <asp:TextBox ID="txtCantidadBoletas" class="form-control" runat="server" TextMode="Number">

                                </asp:TextBox>
                            </div>
                        </div>

                        <div class="col-md-2">
                            <p1 class="text-white mb-4">$ Total</p1>
                            <div>
                                <asp:TextBox ID="txtTotalReserva" class="form-control" runat="server"></asp:TextBox>
                            </div>
                        </div>
                        <div class="col-md-2">
                            <p1 class="text-white mb-4">Calcular</p1>
                            <div>
                                <asp:Button ID="btnCalcular" runat="server" class="btn btn-primary " type="submit" Text="Total" OnClick="btnCalcular_Click" />
                            </div>
                        </div>

                        <div class="col-12">
                            <asp:Button ID="btnReservar" runat="server" class="btn btn-primary w-100 py-3" type="submit" Text="Reservar" OnClick="btnReservar_Click" />
                        </div>
                    </div>

                </div>
            </div>
        </div>
    </div>



</asp:Content>
