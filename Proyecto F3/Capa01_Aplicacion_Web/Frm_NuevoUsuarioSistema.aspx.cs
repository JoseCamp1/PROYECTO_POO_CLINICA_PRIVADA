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
    public partial class Frm_NuevoUsuarioSistema : System.Web.UI.Page
    {
        //CARGAR DATOS
        string MensajeScript;

        public void Limpiar()
        {
            txtId.Text = "";
            txtIdFuncionario.Text = string.Empty;
            txtCorreo.Text = string.Empty;
            txtUsuario.Text = string.Empty;
            txtContrasena.Text = string.Empty;            
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            cargarListaFuncionarios();
            Entidad_UsuarioSistema usuario;
            BL_UsuarioSistema logica = new BL_UsuarioSistema(Cls_Configuracion.getConnectionString);
            int identificacion;
            try
            {
                if (!Page.IsPostBack)
                {
                    //EI ID es un dato que se genera en el otro formulario
                    //Se pueden enviar datos de un formulario a otro por QueryString o por SESION(existe muchas otras
                    //formas de enviar datos entre päginas Web)
                    //Lo enviaremos por sesiön, vamos a preguntar si lo que viene por sesiön trae algo

                    //Funcionamiento:
                    //EI formulario Default le enviarå por SESION un valor al formulario FrmClientes,
                    //esto permite que de un formulario enviemos valores hasta otro formulario.
                    //En este formulario(FrmClientes) estamos preguntando si en el valor de SESION existe algün valor
                    //llamado "id_del_cliente"
                    //Esto implica que desde el formulario Default(o cualquier otro formulario que invoque a FrmC1ientes)
                    //debemos crear una Variable de SESION y llamarla "id_del_cliente" asignåndole el ID que corresponda.
                    if (Session["id_del_usuario"] != null)
                    {
                        identificacion = int.Parse(Session["id_del_usuario"].ToString());
                        usuario = logica.ObtenerUsuarioSistema(identificacion);
                        if (usuario.Existe)
                        {
                            txtId.Text = usuario.IdUsuarioSistema.ToString();
                            txtIdFuncionario.Text = usuario.IdFuncionario.ToString();
                            txtCorreo.Text = usuario.Correo;
                            txtUsuario.Text = usuario.Usuario;
                            txtContrasena.Text = usuario.Contrasena;

                            lblid.Visible = true;
                            txtId.Visible = true;
                        }
                        else
                        {
                            MensajeScript = string.Format("javascript:mostrarMensaje" + "('Usuario no encontrado')");
                            ScriptManager.RegisterStartupScript(this, typeof(string), "MensajeRetorno", MensajeScript, true);
                        }
                    }
                    else
                    {
                        Limpiar();
                        txtId.Text = "-1";
                        lblid.Visible = false;
                        txtId.Visible = false;
                    }
                }
            }
            catch (Exception ex)
            {
                MensajeScript = string.Format("javascript:mostrarMensaje('{0}')", ex.Message);
                ScriptManager.RegisterStartupScript(this, typeof(string), "MensajeRetorno", MensajeScript, true);
                Response.Redirect("Frm_MenuUsuarioSistema.aspx");
            }
        }

        private Entidad_UsuarioSistema GenerarEntidadUsuario()
        {
            Entidad_UsuarioSistema usuario = new Entidad_UsuarioSistema();
            // si hay algo en la variable de sesion
            if (Session["id_del_usuario"] != null)
            {
                usuario.IdUsuarioSistema = int.Parse(Session["id_del_usuario"].ToString());
                usuario.Existe = true;
            }
            //si no hay nada en la variable de sesion, es un usuario nuevo
            else
            {
                usuario.IdUsuarioSistema = -1;
                usuario.Existe = false;
            }
            //los demas datos siempre se toman de los cuadros de texto
            usuario.IdFuncionario = int.Parse(txtIdFuncionario.Text);
            usuario.Correo = txtCorreo.Text;
            usuario.Usuario = txtUsuario.Text;
            usuario.Contrasena = txtContrasena.Text;
            return usuario;
        }

        protected void btnGuardar_Click(object sender, EventArgs e)
        {
            Entidad_UsuarioSistema usuario;
            BL_UsuarioSistema logica = new BL_UsuarioSistema(Cls_Configuracion.getConnectionString);
            int resultado;
            try
            {
                usuario = GenerarEntidadUsuario();
                //si el usuario ya existe , se modifica 
                if (usuario.Existe)
                {
                    resultado = logica.ModificarUsuarioSistema(usuario);
                }
                //si el usuario no existe se crea
                else
                {
                    if (!string.IsNullOrEmpty(txtIdFuncionario.Text))
                    {
                        resultado = logica.InsertarUsuarioSistema(usuario);
                    }
                    else
                    {
                        MensajeScript = string.Format("javascript:mostrarMensaje" + "('Debe agregar almenos el nombre id del funcionario')");
                        ScriptManager.RegisterStartupScript(this, typeof(string), "MensajeRetorno", MensajeScript, true);
                        resultado = -1;
                    }
                }
                if (resultado > 0)
                {
                    MensajeScript = string.Format("javascript:mostrarMensaje" + "('Operacion realizada satisfactoriamente')");
                    ScriptManager.RegisterStartupScript(this, typeof(string), "MensajeRetorno", MensajeScript, true);
                    Response.Redirect("Frm_MenuUsuarioSistema.aspx");
                }
                else
                {
                    MensajeScript = string.Format("javascript:mostrarMensaje" + "('No se pudo ejecutar la operacion')");
                    ScriptManager.RegisterStartupScript(this, typeof(string), "MensajeRetorno", MensajeScript, true);
                }
            }
            catch (Exception ex)
            {
                MensajeScript = string.Format("javascript:mostrarMensaje('{0}')", ex.Message);
                ScriptManager.RegisterStartupScript(this, typeof(string), "MensajeRetorno", MensajeScript, true);
            }
        }

        protected void btnCancelar_Click(object sender, EventArgs e)
        {
            Response.Redirect("Frm_MenuUsuarioSistema.aspx");
        }

        protected void InkIdFuncionario_Command(object sender, CommandEventArgs e)
        {
            if (e.CommandName == "IdFuncionario")
            {
                string[] datos = e.CommandArgument.ToString().Split(',');

                if (datos.Length == 2)
                {
                    string idFuncionario = datos[0];
                    string correo = datos[1];                  

                    
                    txtIdFuncionario.Text = idFuncionario;
                    txtCorreo.Text = correo;
                    
                }
            }            
        }

        protected void grdLista_PageIndexChanging1(object sender, GridViewPageEventArgs e)
        {
            grdLista.PageIndex = e.NewPageIndex;
            cargarListaFuncionarios();
        }

        public void cargarListaFuncionarios(string condicion = "")
        {
            BL_Funcionario logica = new BL_Funcionario(Cls_Configuracion.getConnectionString);
            List<Entidad_Funcionario> funcionarios;
            try
            {
                funcionarios = logica.ListarFuncionarios(condicion);
                if (funcionarios.Count > 0)
                {
                    grdLista.DataSource = funcionarios;
                }
                grdLista.DataBind();//necesario para que visualicen los datos
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}