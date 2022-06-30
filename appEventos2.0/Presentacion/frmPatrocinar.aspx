<%@ Page Title="" Language="C#" MasterPageFile="~/Presentacion/Site1.Master" AutoEventWireup="true" CodeBehind="frmPatrocinar.aspx.cs" Inherits="appEventos2._0.Presentacion.frmPatrocinar" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
   
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container">
        <h2>Patrocinar Eventos</h2>
        <p>Estos son nuestros Eventos:</p>
            <asp:GridView ID="dgvPatrocinador" runat="server" class="table table-bordered table-striped" AutoGenerateColumns="False" OnRowCommand="dgvPatrocinador_RowCommand ">
                <Columns>
                    <asp:BoundField HeaderText="ID" DataField="idEvento" Visible="false" />
                    <asp:BoundField HeaderText="Ciudad" DataField="ciudadEvento" />
                    <asp:BoundField HeaderText="Lugar" DataField="lugarEvento" />
                    <asp:BoundField HeaderText="Edad Minima" DataField="edadMinima" />
                    <asp:BoundField HeaderText="Responsable" DataField="responsable" />
                    <asp:BoundField HeaderText="Dirección" DataField="direccion" />
                    <asp:BoundField HeaderText="Categoria" DataField="categoria" />
                    <asp:BoundField HeaderText="Aforo" DataField="aforo" />
                    <asp:BoundField HeaderText="Apertura Puertas" DataField="aperturaPuertas" />
                    <asp:BoundField HeaderText="Nombre Evento" DataField="nombreEvento" />
                    <asp:BoundField HeaderText="fecha Inicio" DataField="fechaInicioEvento" />
                    <asp:BoundField HeaderText="fecha Finalización" DataField="fechaFinalEvento" />
                    <asp:TemplateField HeaderText="Patrocinar">
                        <ItemTemplate>
                            <asp:LinkButton ID="btnEditar" runat="server" CssClass="btn btn-primary" CommandName="patrocinar" CommandArgument='<%# Eval("idEvento") %>' Text="P"></asp:LinkButton>
                        </ItemTemplate>
                    </asp:TemplateField>
                </Columns>

            </asp:GridView>
        </div>
   
     <script type="text/javascript">
         $(document).ready(function () {
             $('#<%=dgvPatrocinador.ClientID%>').DataTable();
        });

     </script>

</asp:Content>
