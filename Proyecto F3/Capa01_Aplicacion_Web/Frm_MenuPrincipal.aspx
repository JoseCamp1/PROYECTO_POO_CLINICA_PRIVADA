<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Frm_MenuPrincipal.aspx.cs" Inherits="Capa01_Aplicacion_Web.Frm_MenuPrincipal" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
        <title>Menu Principal</title>

    <link href="Content/bootstrap.min.css" rel="stylesheet"/>
    <script src="Scripts/bootstrap.bundle.min.js"></script>
</head>

<body>

    <header class="container">
        <h1 class="bg-success p-3 text-center">Menu Principal</h1>
    </header>

    <form id="form1" runat="server">

        <div class="container p-3 text-center">
            <asp:LinkButton ID="btnClientes" CssClass="btn btn-outline-success" runat="server" BorderStyle="None" OnClick="btnClientes_Click">Pacientes</asp:LinkButton>            
        </div>   

    </form>

</body>
</html>
