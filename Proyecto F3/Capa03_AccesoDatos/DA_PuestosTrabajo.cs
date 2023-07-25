using Capa_Entidades;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Text;
using System.Linq;

namespace Capa03_AccesoDatos
{
    public class DA_PuestosTrabajo
    {
        //Atributos
        private string _cadenaConexion;
        private string _mensaje;

        //Propiedades
        public string Mensaje { get => _mensaje; }

        //Constructor
        public DA_PuestosTrabajo(string cadenaConexion)
        {
            _cadenaConexion = cadenaConexion;
            _mensaje = string.Empty;
        }

        public int InsertarPuestosTrabajo(Entidad_PuestosTrabajo paciente)
        {
            int id = 0;
            //Establecer el objeto conexion
            SqlConnection conexion = new SqlConnection(_cadenaConexion);
            //Establecer los comandos sQL
            SqlCommand comando = new SqlCommand();
            comando.Connection = conexion;
            string sentencia = "INSERT INTO PUESTOS_DE_TRABAJO  (NOMBRE_PUESTO,DESCRIPCION_PUESTO) VALUES (@NOMBRE_PUESTO,@DESCRIPCION_PUESTO) SELECT @@IDENTITY";
            comando.Parameters.AddWithValue("@NOMBRE_PUESTO", paciente.Nombre);
            comando.Parameters.AddWithValue("@DESCRIPCION_PUESTO", paciente.Descripcion);            
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

        public List<Entidad_PuestosTrabajo> ListarPuestosTrabajo(string condicion = "")
        {
            DataSet DS = new DataSet();
            SqlConnection connection = new SqlConnection(_cadenaConexion);
            SqlDataAdapter adapter;
            List<Entidad_PuestosTrabajo> PuestosTrabajo;
            string sentencia = "SELECT ID_PUESTO ,NOMBRE_PUESTO ,DESCRIPCION_PUESTO FROM PUESTOS_DE_TRABAJO ";
            if (!string.IsNullOrEmpty(condicion))
            {
                sentencia = string.Format("{0} WHERE {1}", sentencia, condicion);
            }
            try
            {
                adapter = new SqlDataAdapter(sentencia, connection);
                adapter.Fill(DS, "PuestosTrabajo");
                PuestosTrabajo = (from DataRow unaFila in DS.Tables["PuestosTrabajo"].Rows
                            select new Entidad_PuestosTrabajo()
                            {
                                IdPuestoTrabajo = (int)unaFila[0],
                                Nombre = unaFila[1].ToString(),
                                Descripcion = unaFila[2].ToString(),
                            }).ToList();
            }
            catch (Exception)
            {
                throw;
            }
            return PuestosTrabajo;
        }

        public Entidad_PuestosTrabajo ObtenerPuestosTrabajo(int id)
        {
            Entidad_PuestosTrabajo PuestosTrabajo = null;
            SqlConnection conexion = new SqlConnection(_cadenaConexion);
            SqlCommand comando = new SqlCommand();
            SqlDataReader dataReader;
            string sentencia = string.Format("SELECT ID_PUESTO ,NOMBRE_PUESTO ,DESCRIPCION_PUESTO FROM PUESTOS_DE_TRABAJO  WHERE ID_PUESTO ={0}", id);
            comando.Connection = conexion;
            comando.CommandText = sentencia;
            try
            {
                conexion.Open();
                dataReader = comando.ExecuteReader();
                if (dataReader.HasRows)
                {
                    PuestosTrabajo = new Entidad_PuestosTrabajo();
                    dataReader.Read();
                    PuestosTrabajo.IdPuestoTrabajo = dataReader.GetInt32(0);
                    PuestosTrabajo.Nombre = dataReader.GetString(1);
                    PuestosTrabajo.Descripcion = dataReader.GetString(2);                    
                    PuestosTrabajo.Existe = true;
                }
                conexion.Close();
            }
            catch (Exception) { throw; }
            return PuestosTrabajo;
        }

        //este metodo sirve para eliminar un PuestosTrabajo pero sin llamar a un SP
        public int EliminarRegistroPuestosTrabajo(Entidad_PuestosTrabajo PuestosTrabajo)
        {
            int afectado = -1;
            SqlConnection conexion = new SqlConnection(_cadenaConexion);
            SqlCommand comando = new SqlCommand();
            string sentencia = "DELETE FROM PUESTOS_DE_TRABAJO ";
            sentencia = string.Format("{0} WHERE ID_PUESTO ={1}", sentencia, PuestosTrabajo.IdPuestoTrabajo);
            comando.CommandText = sentencia;
            comando.Connection = conexion;
            try
            {
                conexion.Open();
                afectado = comando.ExecuteNonQuery();
                conexion.Close();
            }
            catch (Exception) { throw; }
            finally
            {
                conexion.Dispose();
                comando.Dispose();
            }
            return afectado;
        }

        public int ModificarRegistroPuestosTrabajo(Entidad_PuestosTrabajo PuestosTrabajo)
        {
            int filasAfectadas = -1;
            SqlConnection conexion = new SqlConnection(_cadenaConexion);
            SqlCommand comando = new SqlCommand();
            string sentencia = "UPDATE PUESTOS_DE_TRABAJO  SET NOMBRE_PUESTO=@NOMBRE_PUESTO ,DESCRIPCION_PUESTO=@DESCRIPCION_PUESTO WHERE ID_PUESTO=@ID_PUESTO";
            comando.CommandText = sentencia;
            comando.Connection = conexion;
            comando.Parameters.AddWithValue("@ID_PUESTO", PuestosTrabajo.IdPuestoTrabajo);
            comando.Parameters.AddWithValue("@NOMBRE_PUESTO", PuestosTrabajo.Nombre);
            comando.Parameters.AddWithValue("@DESCRIPCION_PUESTO", PuestosTrabajo.Descripcion);            
            try
            {
                conexion.Open();
                filasAfectadas = comando.ExecuteNonQuery();
                conexion.Close();
            }
            catch (Exception) { throw; }
            finally
            {
                conexion.Dispose();
                comando.Dispose();
            }
            return filasAfectadas;
        }//fin modificar
    }
}
