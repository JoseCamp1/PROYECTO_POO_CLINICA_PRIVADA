using Capa_Entidades;
using Capa03_AccesoDatos;
using System;
using System.Collections.Generic;
using System.Text;

namespace Capa02_LogicaNegocio
{
    public class BL_UsuarioSistema
    {
        private string _cadenaConexion;
        private string _mensaje;

        public string Mensaje
        {
            get => _mensaje;
        }

        public BL_UsuarioSistema(string cadenaConexion)
        {
            _cadenaConexion = cadenaConexion;
            _mensaje = string.Empty;
        }

        public int InsertarUsuarioSistema(Entidad_UsuarioSistema usuarioSistema)
        {
            int idUsuarioSistema = 0;
            DA_UsuarioSistema accesoDatos = new DA_UsuarioSistema(_cadenaConexion);
            try
            {
                idUsuarioSistema = accesoDatos.InsertarUsuarioSistema(usuarioSistema);
            }
            catch (Exception)
            {
                throw;
            }
            return idUsuarioSistema;
        }

        public List<Entidad_UsuarioSistema> ListarUsuariosSistema(string condicion = "")
        {
            List<Entidad_UsuarioSistema> listaUsuariosSistema;
            DA_UsuarioSistema accesoDatos = new DA_UsuarioSistema(_cadenaConexion);
            try
            {
                listaUsuariosSistema = accesoDatos.ListarUsuariosSistema(condicion);
            }
            catch (Exception)
            {
                throw;
            }
            return listaUsuariosSistema;
        }

        public Entidad_UsuarioSistema ObtenerUsuarioSistema(int id)
        {
            Entidad_UsuarioSistema usuarioSistema;
            DA_UsuarioSistema accesoDatos = new DA_UsuarioSistema(_cadenaConexion);
            try
            {
                usuarioSistema = accesoDatos.ObtenerUsuarioSistema(id);
            }
            catch (Exception)
            {
                throw;
            }
            return usuarioSistema;
        }

        public int EliminarUsuarioSistema(Entidad_UsuarioSistema usuarioSistema)
        {
            int resultado;
            DA_UsuarioSistema accesoDatos = new DA_UsuarioSistema(_cadenaConexion);
            try
            {
                resultado = accesoDatos.EliminarUsuarioSistema(usuarioSistema);
                _mensaje = accesoDatos.Mensaje;
            }
            catch (Exception)
            {
                throw;
            }
            return resultado;
        }

        public int ModificarUsuarioSistema(Entidad_UsuarioSistema usuarioSistema)
        {
            int filasAfectadas = 0;
            DA_UsuarioSistema accesoDatos = new DA_UsuarioSistema(_cadenaConexion);
            try
            {
                filasAfectadas = accesoDatos.ModificarUsuarioSistema(usuarioSistema);
            }
            catch (Exception)
            {
                throw;
            }
            return filasAfectadas;
        }
    }

}
