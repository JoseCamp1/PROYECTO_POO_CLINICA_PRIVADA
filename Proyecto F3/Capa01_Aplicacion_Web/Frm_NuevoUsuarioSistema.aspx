<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Frm_NuevoUsuarioSistema.aspx.cs" Inherits="Capa01_Aplicacion_Web.Frm_NuevoUsuarioSistema" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Nuevo/Modificar Usuario</title>
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
                    <h1 class="p-3 text-center">Nuevo/Modificar Usuario</h1>
                </div>        
    </header>
    <form id="form1" runat="server">
        <div class="container">
            <div class="gridview mt-3">
            <asp:GridView ID="grdLista" runat="server" AllowPaging="True" AutoGenerateColumns="False" BackColor="White" BorderColor="#999999" BorderStyle="Solid" BorderWidth="1px" CellPadding="3" EmptyDataText="No existen registros para mostrar" ForeColor="Black" GridLines="Vertical" Width="100%" PageSize="8" OnPageIndexChanging="grdLista_PageIndexChanging1">
                <AlternatingRowStyle BackColor="#CCCCCC" />
                <Columns>
                    <asp:TemplateField>
                        <ItemTemplate>
                            <asp:LinkButton ID="InkIdFuncionario" runat="server" CommandArgument='<%# Eval("IdFuncionario") + "," + Eval("Correo") %>' CommandName="IdFuncionario" OnCommand="InkIdFuncionario_Command" >Agregar IdFuncionario</asp:LinkButton>
                        </ItemTemplate>
                    </asp:TemplateField>                    
                    <asp:BoundField DataField="IdFuncionario" HeaderText="ID Funcionario" />
                    <asp:BoundField DataField="IdPuestoTrabajo" HeaderText="ID Puesto de Trabajo" />
                    <asp:BoundField DataField="IdEspecialidad" HeaderText="ID Especialidad" />
                    <asp:BoundField DataField="Nombre" HeaderText="Nombre" />
                    <asp:BoundField DataField="Apellidos" HeaderText="Apellidos" />
                    <asp:BoundField DataField="Cedula" HeaderText="Cedula" />
                    <asp:BoundField DataField="Telefono" HeaderText="Telefono" />
                    <asp:BoundField DataField="Correo" HeaderText="Correo" />
                    <asp:BoundField DataField="Direccion" HeaderText="Direccion" />
                    <asp:BoundField DataField="FechaNacimiento" HeaderText="Fecha de Nacimiento" />
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
                                 
            
            <div class="row">
                <div class="col-md-6 offset-md-3">
                    <div class="form-group">
                        <asp:Label ID="lblid" runat="server" Text="Id Usuario:"></asp:Label>
                        <asp:TextBox ID="txtId" runat="server" CssClass="form-control" ReadOnly="True"></asp:TextBox>
                    </div>
                    <div class="form-group">
                        <asp:Label ID="lblNombre" runat="server" Text="Id Funcionario:"></asp:Label>
                        <asp:TextBox ID="txtIdFuncionario" runat="server" CssClass="form-control" Width="100%" ReadOnly="True"></asp:TextBox>
                    </div>
                    <div class="form-group">
                        <asp:Label ID="lblCorreo" runat="server" Text="Correo:"></asp:Label>
                        <asp:TextBox ID="txtCorreo" runat="server" CssClass="form-control" Width="100%" ReadOnly="True"></asp:TextBox>
                    </div>                    
                    <div class="form-group">
                        <asp:Label ID="lblCedula" runat="server" Text="Usuario:"></asp:Label>
                        <asp:TextBox ID="txtUsuario" runat="server" CssClass="form-control" Width="100%"></asp:TextBox>
                    </div>
                    <div class="form-group">
                        <asp:Label ID="lblTelefono" runat="server" Text="Contraseña:"></asp:Label>
                        <asp:TextBox ID="txtContrasena" runat="server" CssClass="form-control" Width="100%"></asp:TextBox>
                    </div>               
                    
                    <div class="text-center">
                        <asp:Button ID="btnGuardar" runat="server" Text="Guardar" CssClass="btn btn-outline-success" OnClick="btnGuardar_Click" />
                        <asp:Button ID="btnCancelar" runat="server" Text="Cancelar" CssClass="btn btn-outline-success" OnClick="btnCancelar_Click" />
                    </div>
                </div>
            </div>
        </div>
    </form>
</body>
</html>
