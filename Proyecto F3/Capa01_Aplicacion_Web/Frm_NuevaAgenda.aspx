<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Frm_NuevaAgenda.aspx.cs" Inherits="Capa01_Aplicacion_Web.Frm_NuevaAgenda" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <link href="Content/bootstrap.min.css" rel="stylesheet"/>
    <script src="Scripts/bootstrap.bundle.min.js"></script>
    <script type="text/javascript">
        function mostrarMensaje(mensaje) {
            alert(mensaje);
        }
    </script>
</head>
<body>

    <header>
        <nav class="navbar navbar-expand-lg navbar-success bg-success navbar-light text-white">
          <div class="container-fluid">
            <a class="navbar-brand text-white" href="Frm_MenuPrincipal.aspx">Clinica El Buen Vivir</a>
            <button class="navbar-toggler" type="button" data-bs-toggle="collapse" data-bs-target="#navbarSupportedContent" aria-controls="navbarSupportedContent" aria-expanded="false" aria-label="Toggle navigation">
              <span class="navbar-toggler-icon"></span>
            </button>
            <div class="collapse navbar-collapse" id="navbarSupportedContent">
              <ul class="navbar-nav ms-auto mb-2 mb-lg-0">
                <li class="nav-item dropdown">
                  <a class="nav-link dropdown-toggle text-white" href="#" role="button" data-bs-toggle="dropdown" aria-expanded="false">
                    Menu Principal
                  </a>
                  <ul class="dropdown-menu">
                    <li><a class="dropdown-item " href="Frm_MenuPacientes.aspx">Pacientes</a></li>
                      <li><hr class="dropdown-divider"/></li>
                    <li><a class="dropdown-item " href="Frm_MenuFuncionarios.aspx">Funcionarios</a></li>
                    <li><hr class="dropdown-divider"/></li>
                    <li><a class="dropdown-item " href="Frm_MenuPuestosTrabajo.aspx">Puestos de Trabajo</a></li>
                    <li><hr class="dropdown-divider"/></li>
                    <li><a class="dropdown-item " href="Frm_MenuEspecialidades.aspx">Especialidades Medicas</a></li>
                    <li><hr class="dropdown-divider"/></li>
                    <li><a class="dropdown-item " href="Frm_MenuAgenda.aspx">Agenda Especialistas</a></li>
                    <li><hr class="dropdown-divider"/></li>
                    <li><a class="dropdown-item " href="Frm_MenuUsuarioSistema.aspx">Usuario de Sistema</a></li>  
                  </ul>
                </li>
                <li class="nav-item dropdown">
                  <a class="nav-link dropdown-toggle text-white" href="#" role="button" data-bs-toggle="dropdown" aria-expanded="false">
                    Servicios
                  </a>
                  <ul class="dropdown-menu">
                    <li><a class="dropdown-item " href="Frm_MenuCitas.aspx">Citas</a></li>
                      <li><hr class="dropdown-divider"/></li>
                    <li><a class="dropdown-item " href="Frm_EnDesarrollo.aspx">Facturas</a></li>
                    <li><hr class="dropdown-divider"/></li>
                    <li><a class="dropdown-item " href="Frm_EnDesarrollo.aspx">Otros</a></li>
                  </ul>
                </li>
                <li class="nav-item">
                  <a class="nav-link active text-white" aria-current="page" href="Frm_EnDesarrollo.aspx">Sucursales</a>
                </li>            
                <li class="nav-item">
                  <a class="nav-link text-white" href="Frm_EnDesarrollo.aspx">Contacto</a>
                </li>     
            </div>
          </div>
        </nav>
    </header>
    
    <form id="form1" runat="server" class="container">
        
        <div class="container text-center p-3">
            <h1>Nuevo/Modificar Agenda</h1>
            <h2>Medicos Especialistas</h2>
        </div>

        <div class="gridview mt-3">            
            <asp:GridView ID="grdLista" runat="server" AllowPaging="True" AutoGenerateColumns="False" BackColor="White" BorderColor="#999999" BorderStyle="Solid" BorderWidth="1px" CellPadding="3" EmptyDataText="No existen registros para mostrar" ForeColor="Black" GridLines="Vertical" Width="100%" PageSize="8" OnPageIndexChanging="grdLista_PageIndexChanging">
                <AlternatingRowStyle BackColor="#CCCCCC" />
                <Columns>
                    <asp:TemplateField>
                        <ItemTemplate>
                            <asp:LinkButton ID="InkIdFuncionario" runat="server" CommandArgument='<%# Eval("ID_FUNCIONARIO").ToString() %>' CommandName="Id Funcionario" OnCommand="InkIdFuncionario_Command">Id Funcionario</asp:LinkButton>
                        </ItemTemplate>
                    </asp:TemplateField>                    
                    <asp:BoundField DataField="NOMBRE_ESPECIALIDAD" HeaderText="Especialidad" />
                    <asp:BoundField DataField="ID_FUNCIONARIO" HeaderText="Id Funcionario" />
                    <asp:BoundField DataField="NOMBRE_FUNCIONARIO" HeaderText="Nombre" />
                    <asp:BoundField DataField="APELLIDOS_FUNCIONARIO" HeaderText="Apellidos" />                    
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
        <div class="container">            
            <div class="row">
                <div class="col-md-6 offset-md-3">
                    <div class="form-group">
                        <asp:Label ID="lblid" runat="server" Text="Id Agenda:"></asp:Label>
                        <asp:TextBox ID="txtId" runat="server" CssClass="form-control" ReadOnly="True"></asp:TextBox>
                    </div>
                    <div class="form-group">
                        <asp:Label ID="Label1" runat="server" Text="Id Funcionario:"></asp:Label>
                        <asp:TextBox ID="txtIdFuncionario" runat="server" CssClass="form-control" ReadOnly="True"></asp:TextBox>
                    </div>
                    <div class="form-group">
                        <asp:Label ID="lblFecha" runat="server" Text="Fecha:"></asp:Label>
                        <asp:TextBox ID="txtFecha" runat="server" CssClass="form-control" Width="100%"></asp:TextBox>
                    </div>
                    <div class="form-group">
                        <asp:Label ID="lblApellidos" runat="server" Text="Hora de Inicio:"></asp:Label>
                        <asp:TextBox ID="txtHoraInicio" runat="server" CssClass="form-control" Width="100%"></asp:TextBox>
                    </div>
                    <div class="form-group">
                        <asp:Label ID="lblCedula" runat="server" Text="Hora de Fin:"></asp:Label>
                        <asp:TextBox ID="txtHoraFin" runat="server" CssClass="form-control" Width="100%"></asp:TextBox>
                    </div>
                    
                    <div class="text-center">
                        <asp:Button ID="btnGuardar" runat="server" Text="Guardar" CssClass="btn btn-outline-success" OnClick="btnGuardar_Click" />
                        <asp:Button ID="btnCancelar" runat="server" Text="Cancelar" CssClass="btn btn-outline-success" OnClick="btnCancelar_Click" />
                    </div>
                </div>
            </div>
        </div>
    </form>

    <footer class="bg-dark p-1 text-white fixed-bottom">        
        <p class="m-0 text-center">
            Clinica El Buen Vivir©
        </p>
    </footer>

</body>
</html>

