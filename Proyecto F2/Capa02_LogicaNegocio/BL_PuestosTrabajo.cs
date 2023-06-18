using Capa_Entidades;
using Capa03_AccesoDatos;
using System;
using System.Collections.Generic;
using System.Text;

namespace Capa02_LogicaNegocio
{
    public class BL_PuestosTrabajo
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
        public BL_PuestosTrabajo(string cadenaConexion)
        {
            _cadenaConexion = cadenaConexion;
            _mensaje = string.Empty;
        }

        //metodo para llamar al metodo insertar de la capa3accesodatos
        public int InsertarPuestosTrabajo(Entidad_PuestosTrabajo puestosTrabajo)
        {
            int id_puestosTrabajo = 0;
            DA_PuestosTrabajo accesoDatos = new DA_PuestosTrabajo(_cadenaConexion);
            try
            {
                id_puestosTrabajo = accesoDatos.InsertarPuestosTrabajo(puestosTrabajo);
            }
            catch (Exception)
            {
                throw;
            }
            return id_puestosTrabajo;
        }// fin de la clase insertar

        public List<Entidad_PuestosTrabajo> ListarPuestosTrabajo(string condicion = "")
        {
            List<Entidad_PuestosTrabajo> listapuestosTrabajo;
            DA_PuestosTrabajo accesoDatos = new DA_PuestosTrabajo(_cadenaConexion);
            try
            {
                listapuestosTrabajo = accesoDatos.ListarPuestosTrabajo(condicion);
            }
            catch (Exception)
            {
                throw;
            }
            return listapuestosTrabajo;
        }

        public Entidad_PuestosTrabajo ObtenerPuestosTrabajo(int id)
        {
            Entidad_PuestosTrabajo puestosTrabajo;
            DA_PuestosTrabajo accesoDatos = new DA_PuestosTrabajo(_cadenaConexion);
            try
            {
                puestosTrabajo = accesoDatos.ObtenerPuestosTrabajo(id);
            }
            catch (Exception)
            {
                throw;
            }
            return puestosTrabajo;
        }

        public int EliminarPuestosTrabajo(Entidad_PuestosTrabajo puestosTrabajo)
        {
            int resultado;
            DA_PuestosTrabajo accesoDatos = new DA_PuestosTrabajo(_cadenaConexion);
            try
            {
                //aqui antes de eliminar se podria verificar si es posible eliminar
                resultado = accesoDatos.EliminarRegistroPuestosTrabajo(puestosTrabajo);
                _mensaje = accesoDatos.Mensaje;
            }
            catch (Exception)
            {
                throw;
            }
            return resultado;
        }//eliminarfin

        public int ModificarPuestosTrabajo(Entidad_PuestosTrabajo puestosTrabajo)
        {
            int filasAfectadas = 0;
            DA_PuestosTrabajo accesoDatos = new DA_PuestosTrabajo(_cadenaConexion);
            try
            {
                filasAfectadas = accesoDatos.ModificarRegistroPuestosTrabajo(puestosTrabajo);
            }
            catch (Exception)
            {
                throw;
            }
            return filasAfectadas;
        }//finmodificar
    }
}
