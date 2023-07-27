<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Frm_MenuEspecialidades.aspx.cs" Inherits="Capa01_Aplicacion_Web.Frm_Especialidades" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Especialidades</title>
<link href="Content/bootstrap.min.css" rel="stylesheet"/>
    <script src="Scripts/bootstrap.bundle.min.js"></script>
    
    <script type="text/javascript">
        function mostrarMensaje(mensaje) {
            alert(mensaje);
        }
    </script>

</head>
<body>
    <header class="bg-success text-light">
        <div class="container">
            <h1 class="p-3 text-center">Especialidades</h1>
        </div>
    </header>
    <form id="form1" runat="server" class="container text-center">
        <div class="form-inline mt-3">
            <asp:Label ID="Label2" runat="server" Text="Nombre de la Especialidad:" CssClass="mr-2"></asp:Label>
            <asp:TextBox ID="txtNombre" runat="server" CssClass="form-control mr-2"></asp:TextBox>
            <asp:Button ID="Button1" runat="server" Text="Buscar" OnClick="btnBuscar_Click" CssClass="btn btn-outline-success mr-2" />
            <asp:Button ID="btnAgregar" runat="server" Text="Agregar Nuevo" OnClick="btnAgregar_Click" CssClass="btn btn-outline-success" />
        </div>
        <div class="gridview mt-3">
            <asp:GridView ID="grdEspecialidades" runat="server" AllowPaging="True" AutoGenerateColumns="False" BackColor="White" BorderColor="#999999" BorderStyle="Solid" BorderWidth="1px" CellPadding="3" EmptyDataText="No existen registros para mostrar" ForeColor="Black" GridLines="Vertical" Width="100%" PageSize="8" OnPageIndexChanging="grdEspecialidades_PageIndexChanging">
                <AlternatingRowStyle BackColor="#CCCCCC" />
                <Columns>
                    <asp:TemplateField>
                        <ItemTemplate>
                            <asp:LinkButton ID="InkModificar" runat="server" CommandArgument='<%# Eval("IdEspecialidad").ToString() %>' CommandName="Modificar" OnCommand="InkModificar_Command">Modificar</asp:LinkButton>
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField>
                        <ItemTemplate>
                            <asp:LinkButton ID="InkEliminar" runat="server" CommandArgument='<%# Eval("IdEspecialidad").ToString() %>' CommandName="Eliminar" OnCommand="InkEliminar_Command">Eliminar</asp:LinkButton>
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:BoundField DataField="IdEspecialidad" HeaderText="ID" />
                    <asp:BoundField DataField="Nombre" HeaderText="Nombre" />
                    <asp:BoundField DataField="Descripcion" HeaderText="Descripcion" />                    
                    <asp:BoundField DataField="Existe" HeaderText="Existe" Visible="False" />
                </Columns>
                <FooterStyle BackColor="#CCCCCC" />
                <HeaderStyle BackColor="Black" Font-Bold="True" ForeColor="White" />
                <PagerStyle BackColor="#999999" ForeColor="Black" HorizontalAlign="Center" />
                <SelectedRowStyle BackColor="#000099" Font-Bold="True" ForeColor="White" />
                <SortedAscendingCellStyle BackColor="#F1F1F1" />
                <SortedAscendingHeaderStyle BackColor="Gray" />
                <SortedDescendingCellStyle BackColor="#CAC9C9" />
                <SortedDescendingHeaderStyle BackColor="#383838" />
            </asp:GridView>
            <br />
        </div>
        <div class="mt-3 d-flex justify-content-center">
            <asp:Button ID="btnRegresar" runat="server" Text="Regresar" OnClick="btnRegresar_Click" CssClass="btn btn-outline-success"/>            
        </div>        
    </form>
</body>
</html> 