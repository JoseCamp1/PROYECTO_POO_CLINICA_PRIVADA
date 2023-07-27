<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Frm_NuevoFuncionario.aspx.cs" Inherits="Capa01_Aplicacion_Web.Frm_NuevoFuncionario" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Nuevo Funcionario</title>
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
                    <h1 class="p-3 text-center">Nuevo/Modificar Funcionario</h1>
                </div>        
    </header>
    <form id="form1" runat="server">
        <div class="container mt-3">
            <div class="row">
                <div class="col-md-6">
                    <h1>Puestos de trabajo</h1>
                    <div class="gridview mt-3">
                        <asp:GridView ID="grdPuestosT" runat="server" AllowPaging="True" AutoGenerateColumns="False" BackColor="White" BorderColor="#999999" BorderStyle="Solid" BorderWidth="1px" CellPadding="3" EmptyDataText="No existen registros para mostrar" ForeColor="Black" GridLines="Vertical" Width="100%" PageSize="8" OnPageIndexChanging="grdPuestosT_PageIndexChanging">
                            <AlternatingRowStyle BackColor="#CCCCCC" />
                            <Columns>
                                <asp:TemplateField>
                                    <ItemTemplate>
                                        <asp:LinkButton ID="InkPuesto" runat="server" CommandArgument='<%# Eval("IdPuestoTrabajo").ToString() %>' CommandName="Modificar" OnCommand="InkPuesto_Command">Agregar Puesto de Trabajo</asp:LinkButton>
                                    </ItemTemplate>
                                </asp:TemplateField>
                                <asp:BoundField DataField="IdPuestoTrabajo" HeaderText="ID" />
                                <asp:BoundField DataField="Nombre" HeaderText="Nombre" />
                                <asp:BoundField DataField="Descripcion" HeaderText="Descripcion" Visible="False" />                    
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
                    </div>
                </div>
                <div class="col-md-6">
                    <h1>Especialidades</h1>
                    <div class="gridview mt-3">
                        <asp:GridView ID="grdEspecialidades" runat="server" AllowPaging="True" AutoGenerateColumns="False" BackColor="White" BorderColor="#999999" BorderStyle="Solid" BorderWidth="1px" CellPadding="3" EmptyDataText="No existen registros para mostrar" ForeColor="Black" GridLines="Vertical" Width="100%" PageSize="8" OnPageIndexChanging="grdEspecialidades_PageIndexChanging">
                            <AlternatingRowStyle BackColor="#CCCCCC" />
                            <Columns>
                                <asp:TemplateField>
                                    <ItemTemplate>
                                        <asp:LinkButton ID="InkEspecialidad" runat="server" CommandArgument='<%# Eval("IdEspecialidad").ToString() %>' CommandName="Modificar" OnCommand="InkEspecialidad_Command">Agregar Especialidad</asp:LinkButton>
                                    </ItemTemplate>
                                </asp:TemplateField>
                                <asp:BoundField DataField="IdEspecialidad" HeaderText="ID" />
                                <asp:BoundField DataField="Nombre" HeaderText="Nombre" />
                                <asp:BoundField DataField="Descripcion" HeaderText="Descripcion" Visible="False" />                    
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
                    </div>
                </div>
            </div>
        </div>      

        <div class="container">           
            <div class="row">
                <div class="col-md-6 offset-md-3">
                    <div class="form-group">
                        <asp:Label ID="lblid" runat="server" Text="Id Funcionario:"></asp:Label>
                        <asp:TextBox ID="txtId" runat="server" CssClass="form-control" ReadOnly="True"></asp:TextBox>
                    </div>
                    <div class="form-group">
                        <asp:Label ID="Label1" runat="server" Text="Id Puesto de Trabajo:"></asp:Label>
                        <asp:TextBox ID="txtIdPuestoTrabajo" runat="server" CssClass="form-control" ReadOnly="True"></asp:TextBox>
                    </div>
                    <div class="form-group">
                        <asp:Label ID="Label2" runat="server" Text="Id Especialidad:"></asp:Label>
                        <asp:TextBox ID="txtIdEspecialidad" runat="server" CssClass="form-control" ReadOnly="True"></asp:TextBox>
                    </div>
                    <div class="form-group">
                        <asp:Label ID="lblNombre" runat="server" Text="Nombre:"></asp:Label>
                        <asp:TextBox ID="txtNombre" runat="server" CssClass="form-control" Width="100%"></asp:TextBox>
                    </div>
                    <div class="form-group">
                        <asp:Label ID="lblApellidos" runat="server" Text="Apellidos:"></asp:Label>
                        <asp:TextBox ID="txtApellidos" runat="server" CssClass="form-control" Width="100%"></asp:TextBox>
                    </div>
                    <div class="form-group">
                        <asp:Label ID="lblCedula" runat="server" Text="Cedula:"></asp:Label>
                        <asp:TextBox ID="txtCedula" runat="server" CssClass="form-control" Width="100%"></asp:TextBox>
                    </div>
                    <div class="form-group">
                        <asp:Label ID="lblTelefono" runat="server" Text="Telefono:"></asp:Label>
                        <asp:TextBox ID="txtTelefono" runat="server" CssClass="form-control" Width="100%"></asp:TextBox>
                    </div>
                    <div class="form-group">
                        <asp:Label ID="lblCorreo" runat="server" Text="Correo:"></asp:Label>
                        <asp:TextBox ID="txtCorreo" runat="server" CssClass="form-control" Width="100%"></asp:TextBox>
                    </div>
                    <div class="form-group">
                        <asp:Label ID="lblDireccion" runat="server" Text="Direccion:"></asp:Label>
                        <asp:TextBox ID="txtDireccion" runat="server" CssClass="form-control" Width="100%"></asp:TextBox>
                    </div>
                    <div class="form-group">
                        <asp:Label ID="lblFechaNacimiento" runat="server" Text="Fecha de Nacimiento:"></asp:Label>
                        <asp:TextBox ID="txtFechaNacimiento" runat="server" CssClass="form-control" Width="100%"></asp:TextBox>
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