using Capa_Entidades;
using Capa03_AccesoDatos;
using System;
using System.Collections.Generic;
using System.Text;

namespace Capa02_LogicaNegocio
{
    public class BL_Citas
    {
        private string _cadenaConexion;
        private string _mensaje;

        public string Mensaje
        {
            get => _mensaje;
        }

        public BL_Citas(string cadenaConexion)
        {
            _cadenaConexion = cadenaConexion;
            _mensaje = string.Empty;
        }

        public int InsertarCita(Entidad_Citas cita)
        {
            int idCita = 0;
            DA_Citas accesoDatos = new DA_Citas(_cadenaConexion);
            try
            {
                idCita = accesoDatos.InsertarCita(cita);
            }
            catch (Exception)
            {
                throw;
            }
            return idCita;
        }

        public List<Entidad_Citas> ListarCitas(string condicion = "")
        {
            List<Entidad_Citas> listaCitas;
            DA_Citas accesoDatos = new DA_Citas(_cadenaConexion);
            try
            {
                listaCitas = accesoDatos.ListarCitas(condicion);
            }
            catch (Exception)
            {
                throw;
            }
            return listaCitas;
        }

        public Entidad_Citas ObtenerCita(int id)
        {
            Entidad_Citas cita;
            DA_Citas accesoDatos = new DA_Citas(_cadenaConexion);
            try
            {
                cita = accesoDatos.ObtenerCita(id);
            }
            catch (Exception)
            {
                throw;
            }
            return cita;
        }

        public int EliminarCita(Entidad_Citas cita)
        {
            int resultado;
            DA_Citas accesoDatos = new DA_Citas(_cadenaConexion);
            try
            {
                resultado = accesoDatos.EliminarCita(cita);
                _mensaje = accesoDatos.Mensaje;
            }
            catch (Exception)
            {
                throw;
            }
            return resultado;
        }

        public int ModificarCita(Entidad_Citas cita)
        {
            int filasAfectadas = 0;
            DA_Citas accesoDatos = new DA_Citas(_cadenaConexion);
            try
            {
                filasAfectadas = accesoDatos.ModificarCita(cita);
            }
            catch (Exception)
            {
                throw;
            }
            return filasAfectadas;
        }
    }

}
