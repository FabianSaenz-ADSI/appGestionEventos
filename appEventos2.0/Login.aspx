<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="appEventos2._0.Login" %>

<!DOCTYPE html>

<html lang="en">

<head>

    <meta charset="utf-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1, shrink-to-fit=no">
    <meta name="description" content="">
    <meta name="author" content="">

    <title>Iniciar Sesión</title>

   <%-- <link href="Content/bootstrap.min.css" rel="stylesheet">--%>
    <link href="Presentacion/RecursosPlantilla/css/bootstrap.min.css" rel="stylesheet">
    

    


    <!-- sweetalert -->

    <script src="RecursosLogin/sweetalert-master/docs/assets/sweetalert/sweetalert.min.js"></script>

</head>

<body class="bg-dark">

    <div class="container">



        <!-- Outer Row -->
        <div class="row justify-content-center">

            <div class="col-xl-8 col-lg-12 col-md-9">

                <div class="card o-hidden border-0 shadow-lg my-5">
                    <div class="card-body p-0">
                        <!-- Nested Row within Card Body -->
                        <div class="row">

                            <div class="col-lg-6 col offset-3">
                                <div class="p-5">
                                    <div class="text-center">
                                        <h1 class="h4 text-gray-900 mb-4">Bienvenido!</h1>
                                    </div>
                                    <form runat="server">
                                        <div class="form-group m-3">

                                            <asp:TextBox ID="txtEmail" class="form-control border-primary w-100 py-3 ps-4 pe-5" runat="server"
                                                placeholder="Correo electronico..." aria-describedby="emailHelp"></asp:TextBox>
                                        </div>

                                        <div class="form-group m-3">
                                            <asp:TextBox ID="txtClave" class="form-control border-primary w-100 py-3 ps-4 pe-5" runat="server" TextMode="Password"
                                                placeholder="Clave..."></asp:TextBox>
                                        </div>

                                        <div class="form-group m-3">
                                            <asp:DropDownList ID="idTipoUsuario" runat="server" class="form-select border-primary  ps-4 ">
                                                <asp:ListItem Value="Tipo usuario"></asp:ListItem>
                                                <asp:ListItem Value="Persona"></asp:ListItem>
                                                <asp:ListItem Value="Empresa"></asp:ListItem>
                                            </asp:DropDownList>


                                        </div>

                                        <div class="form-group m-3 ">
                                            <asp:HyperLink ID="hplRecuperarContraseña" runat="server" NavigateUrl="Presentacion/frmRecuperarContraseña.aspx" ForeColor="Black">¿Has olvidado tu contraseña?</asp:HyperLink>
                                        </div>

                                        <div class="form-group  m-3 ">
                                            <asp:Button ID="btnIngresar" runat="server" Text="Ingresar" class="btn btn-primary btn-user btn-block col offset-3 " OnClick="btnIngresar_Click" />
                                            <asp:Label ID="lblMensaje" runat="server" Text=""></asp:Label>
                                        </div>

                                    </form>

                                </div>
                            </div>
                        </div>
                    </div>
                </div>

            </div>

        </div>
    </div>


</body>

</html>
