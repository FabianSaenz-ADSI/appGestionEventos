<%@ Page Title="" Language="C#" MasterPageFile="~/Presentacion/Site1.Master" AutoEventWireup="true" CodeBehind="frmCompraQr.aspx.cs" Inherits="appEventos2._0.Presentacion.frmCompraQr" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container-xxl py-5">
        <div class="container">
            <div class="text-center wow fadeInUp" data-wow-delay="0.1s">
                <h5 class="section-title ff-secondary text-center text-primary fw-normal">Food Menu</h5>
                <h1 class="mb-5">Most Popular Items</h1>
            </div>
            <div class="tab-class text-center wow fadeInUp" data-wow-delay="0.1s">

                <div class="tab-content">
                    <div id="tab-1" class="tab-pane fade show p-0 active">
                        <asp:TextBox ID="txtCode" runat="server"></asp:TextBox>
                        <asp:Button ID="btnGenerarQr" runat="server" Text="Generar" OnClick="btnGenerarQr_Click" />
                    </div>
                    <div>
                        <div>
                            <img runat="server" id="imgCtrl" />
                        </div>
                    </div>

                </div>
            </div>
        </div>
    </div>
    <!-- Menu End -->
</asp:Content>
