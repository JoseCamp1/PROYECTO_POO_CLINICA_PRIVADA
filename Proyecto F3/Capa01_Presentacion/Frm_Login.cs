using Capa_Entidades;
using Capa02_LogicaNegocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Capa01_Presentacion
{
    public partial class Frm_Login : Form
    {
        public Frm_Login()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {

            bool loguear = ValidarCredenciales(txtUsuario.Text, mtxtConstrasena.Text);
            if (loguear)
            {
                //this.Hide();
                Frm_MenuPrincipal login = new Frm_MenuPrincipal();
                login.Show();
                //MessageBox.Show("Usuario Confirmado", "Atención.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtUsuario.Text=string.Empty;
                mtxtConstrasena.Text=string.Empty;
            }
            else
            {
                MessageBox.Show("El usuario o la contraseña no son validos!", "Atención.", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }       

        public List<Entidad_UsuarioSistema> ObtenerUsuariosSistemaparaLogin(string condicion = "")
        {
            BL_UsuarioSistema logica = new BL_UsuarioSistema(Configuracion.getConnectionString);
            List<Entidad_UsuarioSistema> usuariosSistema = new List<Entidad_UsuarioSistema>();
            try
            {
                usuariosSistema = logica.ListarUsuariosSistema(condicion);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        //otra forma de hacer la confirmacion del login
        //public bool VerificarCredenciales(string usuario, string contrasena)
        //{
        //    string connectionString = "Data Source=JOSEPC\\SQLEXPRESS;Initial Catalog=CLINICA_PRIVADA;Integrated Security=True"; // Reemplaza con la cadena de conexión correcta

        //    using (SqlConnection connection = new SqlConnection(connectionString))
        //    {
        //        connection.Open();

        //        string query = "SELECT COUNT(*) FROM USUARIOS_SISTEMA WHERE USUARIO = @USUARIO AND CONTRASENA = @CONTRASENA";

        //        using (SqlCommand command = new SqlCommand(query, connection))
        //        {
        //            command.Parameters.AddWithValue("@USUARIO", usuario);
        //            command.Parameters.AddWithValue("@CONTRASENA", contrasena);

        //            int count = (int)command.ExecuteScalar();

        //            return count > 0; // Retorna true si se encontró un usuario con las credenciales proporcionadas, de lo contrario retorna false
        //        }
        //    }
        //}

    }
}
