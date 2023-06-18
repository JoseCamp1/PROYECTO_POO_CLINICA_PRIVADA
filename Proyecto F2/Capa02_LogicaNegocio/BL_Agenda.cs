using Capa_Entidades;
using Capa03_AccesoDatos;
using System;
using System.Collections.Generic;
using System.Text;

namespace Capa02_LogicaNegocio
{
    public class BL_Agenda
    {
        private string _cadenaConexion;
        private string _mensaje;

        public string Mensaje
        {
            get => _mensaje;
        }

        public BL_Agenda(string cadenaConexion)
        {
            _cadenaConexion = cadenaConexion;
            _mensaje = string.Empty;
        }

        public int InsertarAgenda(Entidad_Agenda agenda)
        {
            int idAgenda = 0;
            DA_Agenda accesoDatos = new DA_Agenda(_cadenaConexion);
            try
            {
                idAgenda = accesoDatos.InsertarAgenda(agenda);
            }
            catch (Exception)
            {
                throw;
            }
            return idAgenda;
        }

        public List<Entidad_Agenda> ListarAgendas(string condicion = "")
        {
            List<Entidad_Agenda> listaAgendas;
            DA_Agenda accesoDatos = new DA_Agenda(_cadenaConexion);
            try
            {
                listaAgendas = accesoDatos.ListarAgendas(condicion);
            }
            catch (Exception)
            {
                throw;
            }
            return listaAgendas;
        }

        public Entidad_Agenda ObtenerAgenda(int id)
        {
            Entidad_Agenda agenda;
            DA_Agenda accesoDatos = new DA_Agenda(_cadenaConexion);
            try
            {
                agenda = accesoDatos.ObtenerAgenda(id);
            }
            catch (Exception)
            {
                throw;
            }
            return agenda;
        }

        public int EliminarAgenda(Entidad_Agenda agenda)
        {
            int resultado;
            DA_Agenda accesoDatos = new DA_Agenda(_cadenaConexion);
            try
            {
                resultado = accesoDatos.EliminarAgenda(agenda);
                _mensaje = accesoDatos.Mensaje;
            }
            catch (Exception)
            {
                throw;
            }
            return resultado;
        }

        public int ModificarAgenda(Entidad_Agenda agenda)
        {
            int filasAfectadas = 0;
            DA_Agenda accesoDatos = new DA_Agenda(_cadenaConexion);
            try
            {
                filasAfectadas = accesoDatos.ModificarAgenda(agenda);
            }
            catch (Exception)
            {
                throw;
            }
            return filasAfectadas;
        }
    }

}
