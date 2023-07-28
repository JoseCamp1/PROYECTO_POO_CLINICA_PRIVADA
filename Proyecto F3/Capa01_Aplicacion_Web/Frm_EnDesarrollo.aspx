<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Frm_EnDesarrollo.aspx.cs" Inherits="Capa01_Aplicacion_Web.Frm_EnDesarrollo" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title>Página en desarrollo</title>    
    <link href="Content/bootstrap.min.css" rel="stylesheet" />
    <script src="Scripts/bootstrap.bundle.min.js"></script>
</head>
<body>
    <form id="form1" runat="server">
        <div class="container mt-5">
            <div class="alert alert-warning alert-dismissible fade show" role="alert">
                <strong>¡Atención!</strong> Esta seccion de la página está en desarrollo y estará disponible próximamente. ¡Gracias por su comprensión! <br /> Atte:<strong> El Desarrollador.</strong>  
                <button type="button" class="btn-close" data-bs-dismiss="alert" aria-label="Close"></button>
            </div>
        </div>

        <div class="mt-3 d-flex justify-content-center">
            <asp:Button ID="btnRegresar" runat="server" Text="Regresar" OnClick="btnRegresar_Click" CssClass="btn btn-outline-success"/>            
        </div> 

    </form>
    
</body>
</html>

