﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Capa01_Aplicacion_Web.Frm_MenuLogin" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <link href="Content/bootstrap.min.css" rel="stylesheet"/>
    <script src="Scripts/bootstrap.bundle.min.js"></script>    

    <style>
        body {
            background-image: url('https://localhost:44369/img/2.png');
            background-repeat: no-repeat;
            background-size: cover;
        }

        .login-container {
            position: relative;
            background-color: rgba(255, 255, 255, 0.8); /* Fondo transparente */
            padding: 20px;
            border-radius: 10px;
            margin-top: 100px;
        }

        .login-image {
            position: absolute;
            top: 0;
            left: 0;
            width: 100%;
            height: 100%;
            z-index: -1; /* Para que la imagen quede detrás del formulario */
            opacity: 0.8;
        }
    </style>

    <script type="text/javascript">
        function mostrarMensaje(mensaje) {
            alert(mensaje);
        }
    </script>
</head>
<body>
    <form id="form1" runat="server">
        <div class="container">
            <div class="row justify-content-center">
                <div class="col-md-4 login-container">
                    <div class="card">
                        <div class="card-header bg-success text-white">
                            <h3 class="text-center">Iniciar sesión</h3>
                        </div>
                        <div class="card-body">
                            <div class="mb-3">
                                <asp:Label ID="lblUsername" runat="server" Text="Usuario:" AssociatedControlID="txtUsername" CssClass="form-label"></asp:Label>
                                <asp:TextBox ID="txtUsername" runat="server" CssClass="form-control"></asp:TextBox>
                            </div>
                            <div class="mb-3">
                                <asp:Label ID="lblPassword" runat="server" Text="Contraseña:" AssociatedControlID="txtPassword" CssClass="form-label"></asp:Label>
                                <asp:TextBox ID="txtPassword" runat="server" TextMode="Password" CssClass="form-control"></asp:TextBox>
                            </div>
                            <div class="text-center">
                                <asp:Button ID="btnLogin" runat="server" Text="Ingresar" CssClass="btn btn-outline-success" OnClick="btnLogin_Click" />
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
        <img src="~/img/2.png" class="login-image" />
    </form>
</body>
</html>


