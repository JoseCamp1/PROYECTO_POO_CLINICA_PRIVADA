<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Frm_NuevaCita.aspx.cs" Inherits="Capa01_Aplicacion_Web.Frm_NuevaCita" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title>Nuevo/Modificar Cita</title>
    <link href="Content/bootstrap.min.css" rel="stylesheet" />
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
            <h1 class="p-3 text-center">Nuevo/Modificar Cita</h1>
        </div>
    </header>
    <form id="form1" runat="server">
        <div class="container mt-3">
            <div class="gridview mt-3">
                <h1>Paciente</h1>
                <asp:GridView ID="grdPacientes" runat="server" AllowPaging="True" AutoGenerateColumns="False" BackColor="White" BorderColor="#999999" BorderStyle="Solid" BorderWidth="1px" CellPadding="3" EmptyDataText="No existen registros para mostrar" ForeColor="Black" GridLines="Vertical" Width="100%" PageSize="8" OnPageIndexChanging="grdPacientes_PageIndexChanging">
                    <AlternatingRowStyle BackColor="#CCCCCC" />
                    <Columns>
                        <asp:TemplateField>
                            <ItemTemplate>
                                <asp:LinkButton ID="InkIdPaciente" runat="server" CommandArgument='<%# Eval("IdPaciente").ToString() %>' CommandName="Modificar" OnCommand="InkIdPaciente_Command">Agregar Id Paciente</asp:LinkButton>
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:BoundField DataField="IdPaciente" HeaderText="ID" />
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
                
            </div>

            <div class="gridview mt-3">
                <h1>Especialista</h1>
                <asp:GridView ID="grdEspecialista" runat="server" AllowPaging="True" AutoGenerateColumns="False" BackColor="White" BorderColor="#999999" BorderStyle="Solid" BorderWidth="1px" CellPadding="3" EmptyDataText="No existen registros para mostrar" ForeColor="Black" GridLines="Vertical" Width="100%" PageSize="8" OnPageIndexChanging="grdEspecialista_PageIndexChanging">
                    <AlternatingRowStyle BackColor="#CCCCCC" />
                    <Columns>
                        <asp:TemplateField>
                            <ItemTemplate>
                                <asp:LinkButton ID="InkIdFuncionario" runat="server" CommandArgument='<%# Eval("ID_FUNCIONARIO").ToString() %>' CommandName="Modificar" OnCommand="InkIdFuncionario_Command">Agregar Id Funcionario</asp:LinkButton>
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:BoundField DataField="NOMBRE_ESPECIALIDAD" HeaderText="Especialidad" />
                        <asp:BoundField DataField="ID_FUNCIONARIO" HeaderText="Id Funcionario" />
                        <asp:BoundField DataField="NOMBRE_FUNCIONARIO" HeaderText="Nombre" />
                        <asp:BoundField DataField="APELLIDOS_FUNCIONARIO" HeaderText="Apellidos" />
                        <asp:BoundField DataField="FECHA" HeaderText="Fecha" />
                        <asp:BoundField DataField="HORA_INICIO" HeaderText="Inicio del Turno" />
                        <asp:BoundField DataField="HORA_FIN" HeaderText="Fin del Turno" />
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

            <div class="row">
                <div class="col-md-6 offset-md-3">
                        <div class="form-group">
                            <div class="form-group">
                            <asp:Label ID="lblid" runat="server" Text="Id Cita:"></asp:Label>
                            <asp:TextBox ID="txtId" runat="server" CssClass="form-control" ReadOnly="True"></asp:TextBox>
                        </div>
                        <div class="form-group">
                            <asp:Label ID="Label1" runat="server" Text="Id Paciente:"></asp:Label>
                            <asp:TextBox ID="txtIdPaciente" runat="server" CssClass="form-control" ReadOnly="True"></asp:TextBox>
                        </div>
                        <div class="form-group">
                            <asp:Label ID="Label2" runat="server" Text="Id Funcionario:"></asp:Label>
                            <asp:TextBox ID="txtIdFuncionario" runat="server" CssClass="form-control" ReadOnly="True"></asp:TextBox>
                        </div>
                        <div class="form-group">
                            <asp:Label ID="lblApellidos" runat="server" Text="Motivo:"></asp:Label>
                            <asp:TextBox ID="txtMotivo" runat="server" CssClass="form-control" Width="100%"></asp:TextBox>
                        </div>
                        <div class="form-group">
                            <asp:Label ID="lblCedula" runat="server" Text="Fecha:"></asp:Label>
                            <asp:TextBox ID="txtFecha" runat="server" CssClass="form-control" Width="100%" AutoPostBack="True" OnTextChanged="txtFecha_TextChanged"></asp:TextBox>
                        </div>
                        <div class="form-group">
                            <asp:Label ID="lblTelefono" runat="server" Text="Hora de Inicio:"></asp:Label>
                            <asp:TextBox ID="txtHoraInicio" runat="server" CssClass="form-control" Width="100%" OnTextChanged="txtHoraInicio_TextChanged" AutoPostBack="True"></asp:TextBox>
                        </div>
                        <div class="form-group">
                            <asp:Label ID="lblCorreo" runat="server" Text="Hora de Fin:"></asp:Label>
                            <asp:TextBox ID="txtHoraFin" runat="server" CssClass="form-control" Width="100%" ReadOnly="True"></asp:TextBox>
                        </div>
                        <div class="form-group">
                            <asp:Label ID="lblDireccion" runat="server" Text="Estado:"></asp:Label>
                            <asp:TextBox ID="txtEstado" runat="server" CssClass="form-control" Width="100%" ReadOnly="True"></asp:TextBox>
                        </div>
                        <div class="text-center">
                            <asp:Button ID="btnGuardar" runat="server" Text="Guardar" CssClass="btn btn-outline-success" OnClick="btnGuardar_Click" />
                            <asp:Button ID="btnCancelar" runat="server" Text="Cancelar" CssClass="btn btn-outline-success" OnClick="btnCancelar_Click" />
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </form>
</body>
</html>

