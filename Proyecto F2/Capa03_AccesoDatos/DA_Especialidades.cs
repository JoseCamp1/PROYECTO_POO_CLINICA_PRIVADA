using System;
using System.Collections.Generic;
using System.Text;
using Capa_Entidades;
using System.Linq;
using System.Data.SqlClient;
using System.Data;

namespace Capa03_AccesoDatos
{
    public class DA_Especialidades
    {
        private string _cadenaConexion;
        private string _mensaje;

        public string Mensaje { get => _mensaje; }

        public DA_Especialidades(string cadenaConexion)
        {
            _cadenaConexion = cadenaConexion;
            _mensaje = string.Empty;
        }

        public int InsertarEspecialidad(Entidad_Especialidades especialidad)
        {
            int id = 0;
            SqlConnection conexion = new SqlConnection(_cadenaConexion);
            SqlCommand comando = new SqlCommand();
            comando.Connection = conexion;
            string sentencia = "INSERT INTO ESPECIALIDADES (NOMBRE_ESPECIALIDAD, DESCRIPCION_ESPECIALIDAD) VALUES (@NOMBRE_ESPECIALIDAD, @DESCRIPCION_ESPECIALIDAD) SELECT @@IDENTITY";
            comando.Parameters.AddWithValue("@NOMBRE_ESPECIALIDAD", especialidad.Nombre);
            comando.Parameters.AddWithValue("@DESCRIPCION_ESPECIALIDAD", especialidad.Descripcion);
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

        public List<Entidad_Especialidades> ListarEspecialidades(string condicion = "")
        {
            DataSet DS = new DataSet();
            SqlConnection connection = new SqlConnection(_cadenaConexion);
            SqlDataAdapter adapter;
            List<Entidad_Especialidades> especialidades;
            string sentencia = "SELECT ID_ESPECIALIDAD, NOMBRE_ESPECIALIDAD, DESCRIPCION_ESPECIALIDAD FROM ESPECIALIDADES";
            if (!string.IsNullOrEmpty(condicion))
            {
                sentencia = string.Format("{0} WHERE {1}", sentencia, condicion);
            }
            try
            {
                adapter = new SqlDataAdapter(sentencia, connection);
                adapter.Fill(DS, "Especialidades");
                especialidades = (from DataRow unaFila in DS.Tables["Especialidades"].Rows
                                  select new Entidad_Especialidades()
                                  {
                                      IdEspecialidad = (int)unaFila[0],
                                      Nombre = unaFila[1].ToString(),
                                      Descripcion = unaFila[2].ToString(),
                                  }).ToList();
            }
            catch (Exception)
            {
                throw;
            }
            return especialidades;
        }

        public Entidad_Especialidades ObtenerEspecialidad(int id)
        {
            Entidad_Especialidades especialidad = null;
            SqlConnection conexion = new SqlConnection(_cadenaConexion);
            SqlCommand comando = new SqlCommand();
            SqlDataReader dataReader;
            string sentencia = string.Format("SELECT ID_ESPECIALIDAD, NOMBRE_ESPECIALIDAD, DESCRIPCION_ESPECIALIDAD FROM ESPECIALIDADES WHERE ID_ESPECIALIDAD = {0}", id);
            comando.Connection = conexion;
            comando.CommandText = sentencia;
            try
            {
                conexion.Open();
                dataReader = comando.ExecuteReader();
                if (dataReader.HasRows)
                {
                    especialidad = new Entidad_Especialidades();
                    dataReader.Read();
                    especialidad.IdEspecialidad = dataReader.GetInt32(0);
                    especialidad.Nombre = dataReader.GetString(1);
                    especialidad.Descripcion = dataReader.GetString(2);
                    especialidad.Existe = true;
                }
                conexion.Close();
            }
            catch (Exception)
            {
                throw;
            }
            return especialidad;
        }

        public int EliminarEspecialidad(Entidad_Especialidades especialidad)
        {
            int afectado = -1;
            SqlConnection conexion = new SqlConnection(_cadenaConexion);
            SqlCommand comando = new SqlCommand();
            string sentencia = "DELETE FROM ESPECIALIDADES";
            sentencia = string.Format("{0} WHERE ID_ESPECIALIDAD = {1}", sentencia, especialidad.IdEspecialidad);
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

        public int ModificarEspecialidad(Entidad_Especialidades especialidad)
        {
            int filasAfectadas = -1;
            SqlConnection conexion = new SqlConnection(_cadenaConexion);
            SqlCommand comando = new SqlCommand();
            string sentencia = "UPDATE ESPECIALIDADES SET NOMBRE_ESPECIALIDAD = @NOMBRE_ESPECIALIDAD, DESCRIPCION_ESPECIALIDAD = @DESCRIPCION_ESPECIALIDAD WHERE ID_ESPECIALIDAD = @ID_ESPECIALIDAD";
            comando.CommandText = sentencia;
            comando.Connection = conexion;
            comando.Parameters.AddWithValue("@ID_ESPECIALIDAD", especialidad.IdEspecialidad);
            comando.Parameters.AddWithValue("@NOMBRE_ESPECIALIDAD", especialidad.Nombre);
            comando.Parameters.AddWithValue("@DESCRIPCION_ESPECIALIDAD", especialidad.Descripcion);
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
