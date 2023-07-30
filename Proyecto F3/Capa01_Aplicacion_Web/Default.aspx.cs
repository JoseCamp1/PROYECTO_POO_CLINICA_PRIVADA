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
    public partial class Frm_MenuLogin : System.Web.UI.Page
    {
        string mensajeScript;
        public List<Entidad_UsuarioSistema> ObtenerUsuariosSistemaparaLogin(string condicion = "")
        {
            BL_UsuarioSistema logica = new BL_UsuarioSistema(Cls_Configuracion.getConnectionString);
            List<Entidad_UsuarioSistema> usuariosSistema = new List<Entidad_UsuarioSistema>();
            try
            {
                usuariosSistema = logica.ListarUsuariosSistema(condicion);
            }
            catch (Exception)
            {
                throw;
            }
            return usuariosSistema;
        }

        public bool ValidarCredenciales(string usuario, string contrasena)
        {
            List<Entidad_UsuarioSistema> usuariosSistema = ObtenerUsuariosSistemaparaLogin();
            foreach (Entidad_UsuarioSistema usuarioSistema in usuariosSistema)//Recorro la lista de Entidades
            {
                if (usuarioSistema.Usuario == usuario && usuarioSistema.Contrasena == contrasena)//Busco si son iguales 
                {
                    return true; // Credenciales válidas
                }
            }
            return false; // Credenciales inválidas
        }
        

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            bool loguear = ValidarCredenciales(txtUsername.Text, txtPassword.Text);
            if (loguear)
            {
                // Redirigir a la página principal si las credenciales son válidas
                Response.Redirect("Frm_MenuPrincipal.aspx");
            }
            else
            {
                mensajeScript = string.Format("javascript:mostrarMensaje('El Usuario o la contrasena no son validos.')");
                ScriptManager.RegisterStartupScript(this, typeof(string), "MensajeRetorno", mensajeScript, true);
                Limpiar();
                
            }
        }

        public void Limpiar()
        {
            txtUsername.Text = string.Empty;
            txtPassword.Text = string.Empty;
        }

        protected void Page_Load(object sender, EventArgs e)
        {

        }
    }
}