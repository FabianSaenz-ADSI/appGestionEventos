<%@ Page Title="" Language="C#" MasterPageFile="~/Presentacion/Site1.Master" AutoEventWireup="true" CodeBehind="frmConfirmarPago.aspx.cs" Inherits="appEventos2._0.Presentacion.frmConfirmarPago" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div class="container-xxl py-5 px-0 wow fadeInUp" data-wow-delay="0.1s">
        <div class="row g-0">
            <div class="col-md-12 bg-dark d-flex align-items-center">
                <div class="p-5 wow fadeInUp" data-wow-delay="0.2s">

                    <h1 class="text-white mb-4 nav-link  fa fa-check me-3">&nbsp;&nbsp;&nbsp;&nbsp;Realizar Pago</h1>
                    <form>

                        <div class="col-md-12">

                            <%--boton paypal--%>
                            <div id="paypal-button-container"></div>
                            <script>

                                paypal.Buttons({
                                    style: {
                                        color: 'blue',
                                        shape: 'pill',
                                        label: 'pay'
                                    },
                                    craeteOrder: function (data, actions) {
                                        return actions.order.create({
                                            purchase_units: [{
                                                amount: {
                                                    value: 100
                                                }

                                            }]

                                        });
                                    },
                                    onApprove: function (data, actions) {
                                        actions.order.capture().then(function (detalles) {
                                            console.log(detalles);
                                            alert("El Pago Se Realizo Con Exito")
                                            window.location.href = "frmInicio.aspx";

                                        });

                                    },


                                    onCancel: function (data) {
                                        alert("Pago cancelado")
                                        console.log(data);
                                    }
                                }).render('#paypal-button-container');
    </script>
                            </center>
</section>
                        </div>







                    </form>
                </div>
            </div>
        </div>
    </div>


</asp:Content>
