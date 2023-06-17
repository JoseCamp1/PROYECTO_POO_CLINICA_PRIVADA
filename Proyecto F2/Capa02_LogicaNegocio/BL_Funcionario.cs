using System;
using System.Collections.Generic;
using System.Text;
using Capa_Entidades;
using Capa03_AccesoDatos;

namespace Capa02_LogicaNegocio
{
    public class BL_Funcionario
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
        public BL_Funcionario(string cadenaConexion)
        {
            _cadenaConexion = cadenaConexion;
            _mensaje = string.Empty;
        }

        //metodo para llamar al metodo insertar de la capa3accesodatos
        public int InsertarFuncionario(Entidad_Funcionario funcionario)
        {
            int id_Funcionario = 0;
            DA_Funcionario accesoDatos = new DA_Funcionario(_cadenaConexion);
            try
            {
                id_Funcionario = accesoDatos.InsertarFuncionario(funcionario);
            }
            catch (Exception)
            {
                throw;
            }
            return id_Funcionario;
        }// fin de la clase insertar

        public List<Entidad_Funcionario> ListarFuncionarios(string condicion = "")
        {
            List<Entidad_Funcionario> listaFuncionarios;
            DA_Funcionario accesoDatos = new DA_Funcionario(_cadenaConexion);
            try
            {
                listaFuncionarios = accesoDatos.ListarFuncionarios(condicion);
            }
            catch (Exception)
            {
                throw;
            }
            return listaFuncionarios;
        }

        public Entidad_Funcionario ObtenerFuncionario(int id)
        {
            Entidad_Funcionario funcionario;
            DA_Funcionario accesoDatos = new DA_Funcionario(_cadenaConexion);
            try
            {
                funcionario = accesoDatos.ObtenerFuncionario(id);
            }
            catch (Exception)
            {
                throw;
            }
            return funcionario;
        }

        public int EliminarFuncionario(Entidad_Funcionario funcionario)
        {
            int resultado;
            DA_Funcionario accesoDatos = new DA_Funcionario(_cadenaConexion);
            try
            {
                //aqui antes de eliminar se podria verificar si es posible eliminar
                resultado = accesoDatos.EliminarRegistroFuncionario(funcionario);
                _mensaje = accesoDatos.Mensaje;
            }
            catch (Exception)
            {
                throw;
            }
            return resultado;
        }//eliminarfin

        public int ModificarFuncionario(Entidad_Funcionario funcionario)
        {
            int filasAfectadas = 0;
            DA_Funcionario accesoDatos = new DA_Funcionario(_cadenaConexion);
            try
            {
                filasAfectadas = accesoDatos.ModificarRegistroFuncionario(funcionario);
            }
            catch (Exception)
            {
                throw;
            }
            return filasAfectadas;
        }//finmodificar


    }
}
