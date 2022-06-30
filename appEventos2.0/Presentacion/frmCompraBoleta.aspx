<%@ Page Title="" Language="C#" MasterPageFile="~/Presentacion/Site1.Master" AutoEventWireup="true" CodeBehind="frmCompraBoleta.aspx.cs" Inherits="appEventos2._0.Presentacion.frmCompraBoleta" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">

    <script src="https://www.paypal.com/sdk/js?client-id=AVVYE_HyMVI-R3bz3j_zo1tEV8B-3ZdlpPrDLAe9YAdfaNbBE30hgcD1Ne1cpXPjeorT3t6o8h5vaksN"></script>

</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container-xxl py-5 px-0 wow fadeInUp" data-wow-delay="0.1s">
        <div class="row g-0">
            <div class="col-md-12 bg-dark d-flex align-items-center">
                <div class="p-5 wow fadeInUp" data-wow-delay="0.2s">

                    <h1 class="text-white mb-4 nav-link  fa fa-check me-3">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Realizar Comprar</h1>
                    <form>
                        <div class="row g-3">



                            <div class="col-md-12">
                                <asp:Label ID="Label2" runat="server" Text="Nombre Evento" ForeColor="White"></asp:Label>
                                <div class="form-floating">
                                    <asp:TextBox ID="txtNom" runat="server" type="text" CssClass="form-control" BorderColor="DarkSlateGray" ForeColor="DarkBlue"></asp:TextBox>
                                </div>
                            </div>
                            <div class="col-md-12">
                                <asp:Label ID="Label1" runat="server" Text="Tipo de Evento" ForeColor="White"></asp:Label>
                                <div class="form-floating">
                                    <asp:TextBox ID="txtEvento" runat="server" type="text" CssClass="form-control" ForeColor="DarkBlue"></asp:TextBox>
                                </div>
                            </div>



                            <div class="col-md-12">
                                <asp:Label ID="Label4" runat="server" Text="Precio" ForeColor="White"></asp:Label>
                                <div class="form-floating">
                                    <asp:TextBox ID="txtPrecio" runat="server" type="text" CssClass="form-control" ForeColor="DarkBlue"></asp:TextBox>
                                </div>
                            </div>


                            <div class="col-md-12">
                                <asp:Label ID="Label3" runat="server" Text="Cantidad" ForeColor="White"></asp:Label>
                                <div class="form-floating">
                                    <asp:TextBox ID="txtCantidad" runat="server" type="text" CssClass="form-control" ForeColor="DarkBlue" MaxLength="10" TextMode="Number"></asp:TextBox>
                                </div>
                            </div>

                            <div class="col-md-12">
                                <asp:Label ID="lbl" runat="server" Text="Precio Total" ForeColor="White"></asp:Label>
                                <div class="form-floating">
                                    <asp:TextBox ID="txtTotal" runat="server" type="text" CssClass="form-control" ForeColor="DarkBlue"></asp:TextBox>
                                </div>
                            </div>



                            <div class="col-md-6">
                                <asp:Button runat="server" Text="Precio Total" ID="btnTotal" CssClass="btn btn-primary w-100 py-3" OnClick="btnTotal_Click" />

                            </div>

                            <div class="col-md-6">


                               <asp:Button runat="server" Text="Comprar" ID="btnComprar" CssClass="btn btn-primary w-100 py-3" OnClick="btnComprar_Click" />

                            </div>

                            <center>
                        </div>
                    </form>
                </div>
            </div>
        </div>
    </div>


    <%-- <div class="container mt-3 ">

        <h5 class="section-title ff-secondary text-start text-primary fw-normal">Reserva realizada</h5>
        <h1 class="mb-4">Detalles</h1>


        <div class="border-start border-5 border-primary px-3 ">
            <div>
                <asp:ListView ID="ListView1" runat="server">
                    <ItemTemplate>
                        <tr>
                            <h5 class=" ff-secondary text-start text-primary fw-normal">Evento:</h5>
                            
                             <small><%#Eval("nombreEvento") %> </small>
                        </tr>
                        <br />

                        <tr>
                            <td>tipo: </td>
                            <td>
                                <small><%#Eval("tipoBoleta") %></small>
                            </td>
                        </tr>
                        <br />
                        <tr>
                            <td>precio: </td>
                            <td>
                                <small><%#Eval("precioBoleta") %></small>
                            </td>
                        </tr>

                        <tr>
                            <td>cantidad: </td>
                            <td>
                               <asp:DropDownList ID="ddlCantidad" runat="server" CssClass="form-control">
                                                            <asp:ListItem>1</asp:ListItem>
                                                            <asp:ListItem>2</asp:ListItem>
                                                            <asp:ListItem>3</asp:ListItem>
                                                            <asp:ListItem>4</asp:ListItem>
                                                            <asp:ListItem>5</asp:ListItem>
                                                            <asp:ListItem>6</asp:ListItem>
                                                            <asp:ListItem>7</asp:ListItem>
                                                        </asp:DropDownList>
                            </td>
                        </tr>

                        <div class="justify-content-center text-align-item-center">

                            <asp:Button ID="btnAsistir" runat="server" Text="Comprar Boleta" class="btn btn-outline-success mx-1" />

                        </div>

                    </ItemTemplate>
                </asp:ListView>
            </div>
        </div>





    </div>--%>
</asp:Content>
