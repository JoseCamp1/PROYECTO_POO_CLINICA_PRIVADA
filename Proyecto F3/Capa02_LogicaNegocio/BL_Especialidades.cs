using Capa_Entidades;
using Capa03_AccesoDatos;
using System;
using System.Collections.Generic;
using System.Text;

namespace Capa02_LogicaNegocio
{
    public class BL_Especialidades
    {
        private string _cadenaConexion;
        private string _mensaje;

        public string Mensaje
        {
            get => _mensaje;
        }

        public BL_Especialidades(string cadenaConexion)
        {
            _cadenaConexion = cadenaConexion;
            _mensaje = string.Empty;
        }

        public int InsertarEspecialidad(Entidad_Especialidades especialidad)
        {
            int idEspecialidad = 0;
            DA_Especialidades accesoDatos = new DA_Especialidades(_cadenaConexion);
            try
            {
                idEspecialidad = accesoDatos.InsertarEspecialidad(especialidad);
            }
            catch (Exception)
            {
                throw;
            }
            return idEspecialidad;
        }

        public List<Entidad_Especialidades> ListarEspecialidades(string condicion = "")
        {
            List<Entidad_Especialidades> listaEspecialidades;
            DA_Especialidades accesoDatos = new DA_Especialidades(_cadenaConexion);
            try
            {
                listaEspecialidades = accesoDatos.ListarEspecialidades(condicion);
            }
            catch (Exception)
            {
                throw;
            }
            return listaEspecialidades;
        }

        public Entidad_Especialidades ObtenerEspecialidad(int id)
        {
            Entidad_Especialidades especialidad;
            DA_Especialidades accesoDatos = new DA_Especialidades(_cadenaConexion);
            try
            {
                especialidad = accesoDatos.ObtenerEspecialidad(id);
            }
            catch (Exception)
            {
                throw;
            }
            return especialidad;
        }

        public int EliminarEspecialidad(Entidad_Especialidades especialidad)
        {
            int resultado;
            DA_Especialidades accesoDatos = new DA_Especialidades(_cadenaConexion);
            try
            {
                resultado = accesoDatos.EliminarEspecialidad(especialidad);
                _mensaje = accesoDatos.Mensaje;
            }
            catch (Exception)
            {
                throw;
            }
            return resultado;
        }

        public int ModificarEspecialidad(Entidad_Especialidades especialidad)
        {
            int filasAfectadas = 0;
            DA_Especialidades accesoDatos = new DA_Especialidades(_cadenaConexion);
            try
            {
                filasAfectadas = accesoDatos.ModificarEspecialidad(especialidad);
            }
            catch (Exception)
            {
                throw;
            }
            return filasAfectadas;
        }

    }
}
