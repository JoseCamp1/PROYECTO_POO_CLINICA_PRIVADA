using Capa_Entidades;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Text;
using System.Linq;

namespace Capa03_AccesoDatos
{
    public class DA_UsuarioSistema
    {
        private string _cadenaConexion;
        private string _mensaje;

        public string Mensaje { get => _mensaje; }

        public DA_UsuarioSistema(string cadenaConexion)
        {
            _cadenaConexion = cadenaConexion;
            _mensaje = string.Empty;
        }

        public int InsertarUsuarioSistema(Entidad_UsuarioSistema usuarioSistema)
        {
            int id = 0;
            SqlConnection conexion = new SqlConnection(_cadenaConexion);
            SqlCommand comando = new SqlCommand();
            comando.Connection = conexion;
            string sentencia = "INSERT INTO USUARIOS_SISTEMA (ID_FUNCIONARIO, CORREO, USUARIO, CONTRASENA)" +
                               "VALUES (@ID_FUNCIONARIO, @CORREO, @USUARIO, @CONTRASENA)" +
                               "SELECT @@IDENTITY";
            comando.Parameters.AddWithValue("@ID_FUNCIONARIO", usuarioSistema.IdFuncionario);
            comando.Parameters.AddWithValue("@CORREO", usuarioSistema.Correo);
            comando.Parameters.AddWithValue("@USUARIO", usuarioSistema.Usuario);
            comando.Parameters.AddWithValue("@CONTRASENA", usuarioSistema.Contrasena);
            comando.CommandText = sentencia;
            try
            {
                conexion.Open();
                id = Convert.ToInt32(comando.ExecuteScalar());
                conexion.Close();
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                conexion.Dispose();
                comando.Dispose();
            }
            return id;
        }

        public List<Entidad_UsuarioSistema> ListarUsuariosSistema(string condicion = "")
        {
            DataSet DS = new DataSet();
            SqlConnection connection = new SqlConnection(_cadenaConexion);
            SqlDataAdapter adapter;
            List<Entidad_UsuarioSistema> usuariosSistema;
            string sentencia = "SELECT ID_USUARIO_SISTEMA, ID_FUNCIONARIO, CORREO, USUARIO, CONTRASENA FROM USUARIOS_SISTEMA";
            if (!string.IsNullOrEmpty(condicion))
            {
                sentencia = string.Format("{0} WHERE {1}", sentencia, condicion);
            }
            try
            {
                adapter = new SqlDataAdapter(sentencia, connection);
                adapter.Fill(DS, "UsuariosSistema");
                usuariosSistema = (from DataRow unaFila in DS.Tables["UsuariosSistema"].Rows
                                   select new Entidad_UsuarioSistema()
                                   {
                                       IdUsuarioSistema = (int)unaFila[0],
                                       IdFuncionario = (int)unaFila[1],
                                       Correo = (string)unaFila[2],
                                       Usuario = (string)unaFila[3],
                                       Contrasena = (string)unaFila[4]
                                   }).ToList();
            }
            catch (Exception)
            {
                throw;
            }
            return usuariosSistema;
        }

        public Entidad_UsuarioSistema ObtenerUsuarioSistema(int id)
        {
            Entidad_UsuarioSistema usuarioSistema = null;
            SqlConnection conexion = new SqlConnection(_cadenaConexion);
            SqlCommand comando = new SqlCommand();
            SqlDataReader dataReader;
            string sentencia = string.Format("SELECT ID_USUARIO_SISTEMA, ID_FUNCIONARIO, CORREO, USUARIO, CONTRASENA FROM USUARIOS_SISTEMA WHERE ID_USUARIO_SISTEMA = {0}", id);
            comando.Connection = conexion;
            comando.CommandText = sentencia;
            try
            {
                conexion.Open();
                dataReader = comando.ExecuteReader();
                if (dataReader.HasRows)
                {
                    usuarioSistema = new Entidad_UsuarioSistema();
                    dataReader.Read();
                    usuarioSistema.IdUsuarioSistema = dataReader.GetInt32(0);
                    usuarioSistema.IdFuncionario = dataReader.GetInt32(1);
                    usuarioSistema.Correo = dataReader.GetString(2);
                    usuarioSistema.Usuario = dataReader.GetString(3);
                    usuarioSistema.Contrasena = dataReader.GetString(4);
                    usuarioSistema.Existe = true;
                }
                conexion.Close();
            }
            catch (Exception)
            {
                throw;
            }
            return usuarioSistema;
        }

        public int EliminarUsuarioSistema(Entidad_UsuarioSistema usuarioSistema)
        {
            int afectado = -1;
            SqlConnection conexion = new SqlConnection(_cadenaConexion);
            SqlCommand comando = new SqlCommand();
            string sentencia = "DELETE FROM USUARIOS_SISTEMA";
            sentencia = string.Format("{0} WHERE ID_USUARIO_SISTEMA = {1}", sentencia, usuarioSistema.IdUsuarioSistema);
            comando.CommandText = sentencia;
            comando.Connection = conexion;
            try
            {
                conexion.Open();
                afectado = comando.ExecuteNonQuery();
                conexion.Close();
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                conexion.Dispose();
                comando.Dispose();
            }
            return afectado;
        }

        public int ModificarUsuarioSistema(Entidad_UsuarioSistema usuarioSistema)
        {
            int filasAfectadas = -1;
            SqlConnection conexion = new SqlConnection(_cadenaConexion);
            SqlCommand comando = new SqlCommand();
            string sentencia = "UPDATE USUARIOS_SISTEMA SET ID_FUNCIONARIO = @ID_FUNCIONARIO, CORREO = @CORREO, USUARIO = @USUARIO, CONTRASENA = @CONTRASENA WHERE ID_USUARIO_SISTEMA = @ID_USUARIO_SISTEMA";
            comando.CommandText = sentencia;
            comando.Connection = conexion;
            comando.Parameters.AddWithValue("@ID_USUARIO_SISTEMA", usuarioSistema.IdUsuarioSistema);
            comando.Parameters.AddWithValue("@ID_FUNCIONARIO", usuarioSistema.IdFuncionario);
            comando.Parameters.AddWithValue("@CORREO", usuarioSistema.Correo);
            comando.Parameters.AddWithValue("@USUARIO", usuarioSistema.Usuario);
            comando.Parameters.AddWithValue("@CONTRASENA", usuarioSistema.Contrasena);
            try
            {
                conexion.Open();
                filasAfectadas = comando.ExecuteNonQuery();
                conexion.Close();
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                conexion.Dispose();
                comando.Dispose();
            }
            return filasAfectadas;
        }
    }

}
