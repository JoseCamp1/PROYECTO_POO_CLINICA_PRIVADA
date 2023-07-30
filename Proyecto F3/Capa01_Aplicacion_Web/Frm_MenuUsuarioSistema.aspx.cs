using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Windows;
using System.Data;
using Capa02_LogicaNegocio;
using Capa_Entidades;

namespace Capa01_Aplicacion_Web
{
    public partial class Frm_MenuUsuarioSistema : System.Web.UI.Page
    {
        //CARGAR DATOS
        String mensajeScript;
        public void cargarListaUsuarios(string condicion = "")
        {
            BL_UsuarioSistema logica = new BL_UsuarioSistema(Cls_Configuracion.getConnectionString);
            List<Entidad_UsuarioSistema> usuario;
            try
            {
                usuario = logica.ListarUsuariosSistema(condicion);
                if (usuario.Count > 0)
                {
                    grdLista.DataSource = usuario;
                }
                grdLista.DataBind();//necesario para que visualicen los datos
            }
            catch (Exception)
            {
                throw;
            }
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                if (!IsPostBack)
                {
                    cargarListaUsuarios();
                }
            }
            catch (Exception)
            {
                //throw;
            }
        }

        protected void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                string condicion = string.Format("CORREO LIKE '%{0}%'", txtNombre.Text);
                cargarListaUsuarios(condicion);
            }
            catch (Exception ex)
            {
                mensajeScript = string.Format("javascript:mostrarMensaje('{0}')", ex.Message);
                ScriptManager.RegisterStartupScript(this, typeof(string), "MensajeRetorno", mensajeScript, true);
            }
        }

        protected void btnAgregar_Click(object sender, EventArgs e)
        {
            //eliminamos la variable de sesin, asi cuando el otro formulario pregunte si esta vacia
            //determinara que efectivamente esta vacia, lo cual significa que debamos
            //agregar un cliente nuevo
            Session.Remove("id_del_usuario");
            //redireccionamos al otro formulario
            Response.Redirect("Frm_NuevoUsuarioSistema.aspx");
        }

        protected void btnRegresar_Click(object sender, EventArgs e)
        {
            Response.Redirect("Frm_MenuPrincipal.aspx");
        }

        protected void grdLista_PageIndexChanging1(object sender, GridViewPageEventArgs e)
        {
            grdLista.PageIndex = e.NewPageIndex;
            cargarListaUsuarios();
        }

        protected void InkModificar_Command(object sender, CommandEventArgs e)
        {
            //aqui vamos a asignar el valor de SESION y redireccionar la pagina
            //en el valor de SESION colocamos el valor que contenga el Command
            //(el ID del cliente ) al cual se le dio click
            Session["id_del_usuario"] = e.CommandArgument.ToString();
            //redireccionamos al otro formulario(FrmClientes)
            Response.Redirect("Frm_NuevoUsuarioSistema.aspx");
        }

        protected void InkEliminar_Command(object sender, CommandEventArgs e)
        {
            int id = int.Parse(e.CommandArgument.ToString());
            BL_UsuarioSistema logica = new BL_UsuarioSistema(Cls_Configuracion.getConnectionString);
            Entidad_UsuarioSistema usuario;
            try
            {
                usuario = logica.ObtenerUsuarioSistema(id);
                if (usuario.Existe)
                {
                    if (logica.EliminarUsuarioSistema(usuario) > 0)
                    {
                        mensajeScript = string.Format("javascript:mostrarMensaje('Usuario eliminado con exito')");
                        ScriptManager.RegisterStartupScript(this, typeof(string), "MensajeRetorno", mensajeScript, true);
                        cargarListaUsuarios();
                        txtNombre.Text = "";
                    }
                    else
                    {
                        mensajeScript = string.Format("javascript:mostrarMensaje('{0}')", logica.Mensaje);
                        ScriptManager.RegisterStartupScript(this, typeof(string), "MensajeRetorno", mensajeScript, true);
                    }
                }
            }
            catch (Exception ex)
            {
                mensajeScript = string.Format("javascript:mostrarMensaje('{0}')", ex.Message);
                ScriptManager.RegisterStartupScript(this, typeof(string), "MensajeRetorno", mensajeScript, true);
            }
        }
    }
}