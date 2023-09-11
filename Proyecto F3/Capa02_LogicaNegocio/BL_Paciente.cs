using System;
using System.Collections.Generic;
using System.Text;
using Capa_Entidades;
using Capa03_AccesoDatos;


namespace Capa02_LogicaNegocio
{
    public class BL_Paciente
    {
        //atributos
        private string _cadenaConexion;
        private string _mensaje;

        //propiedades
        public string Mensaje
        {
            get => _mensaje;
        }

        // constructor
        public BL_Paciente(string cadenaConexion)
        {
            _cadenaConexion = cadenaConexion;
            _mensaje = string.Empty;
        }

        //metodo para llamar al metodo insertar de la capa3accesodatos
        public int InsertarPaciente(Entidad_Paciente paciente)
        {
            int id_paciente = 0;
            DA_Paciente accesoDatos = new DA_Paciente(_cadenaConexion);
            try
            {
                id_paciente = accesoDatos.InsertarPaciente(paciente);
            }
            catch (Exception)
            {
                throw;
            }
            return id_paciente;
        }// fin de la clase insertar

        public List<Entidad_Paciente> ListarPacientes(string condicion = "")
        {
            List<Entidad_Paciente> listaPacientes
                ;
            DA_Paciente accesoDatos = new DA_Paciente(_cadenaConexion);
            try
            {
                listaPacientes = accesoDatos.ListarPacientes(condicion);
            }
            catch (Exception)
            {
                throw;
            }
            return listaPacientes;
        }

        public Entidad_Paciente ObtenerPaciente(int id)
        {
            Entidad_Paciente cliente;
            DA_Paciente accesoDatos = new DA_Paciente(_cadenaConexion);
            try
            {
                cliente = accesoDatos.ObtenerPaciente(id);
            }
            catch (Exception)
            {
                throw;
            }
            return cliente;
        }

        public int EliminarPaciente(Entidad_Paciente paciente)
        {
            int resultado;
            DA_Paciente accesoDatos = new DA_Paciente(_cadenaConexion);
            try
            {
                //aqui antes de eliminar se podria verificar si es posible eliminar
                resultado = accesoDatos.EliminarRegistroPaciente(paciente);
                _mensaje = accesoDatos.Mensaje;
            }
            catch (Exception)
            {
                throw;
            }
            return resultado;
        }//eliminarfin

        public int ModificarPaciente(Entidad_Paciente paciente)
        {
            int filasAfectadas = 0;
            DA_Paciente accesoDatos = new DA_Paciente(_cadenaConexion);
            try
            {
                filasAfectadas = accesoDatos.ModificarRegistroPaciente(paciente);
            }
            catch (Exception)
            {
                throw;
            }
            return filasAfectadas;
        }//finmodificar
    }
}
