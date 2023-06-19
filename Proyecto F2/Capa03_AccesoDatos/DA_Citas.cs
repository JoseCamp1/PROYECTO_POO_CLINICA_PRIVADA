using Capa_Entidades;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Text;
using System.Linq;

namespace Capa03_AccesoDatos
{
    public class DA_Citas
    {
        private string _cadenaConexion;
        private string _mensaje;

        public string Mensaje { get => _mensaje; }

        public DA_Citas(string cadenaConexion)
        {
            _cadenaConexion = cadenaConexion;
            _mensaje = string.Empty;
        }

        public int InsertarCita(Entidad_Citas cita)
        {
            int id = 0;
            SqlConnection conexion = new SqlConnection(_cadenaConexion);
            SqlCommand comando = new SqlCommand();
            comando.Connection = conexion;
            string sentencia = "INSERT INTO CITAS (ID_PACIENTE, ID_FUNCIONARIO, MOTIVO, FECHA, HORA_INICIO, HORA_FIN, ESTADO) VALUES (@ID_PACIENTE, @ID_FUNCIONARIO, @MOTIVO, @FECHA, @HORA_INICIO, @HORA_FIN, @ESTADO) SELECT @@IDENTITY";
            comando.Parameters.AddWithValue("@ID_PACIENTE", cita.IdPaciente);
            comando.Parameters.AddWithValue("@ID_FUNCIONARIO", cita.IdFuncionario);
            comando.Parameters.AddWithValue("@MOTIVO", cita.Motivo);
            comando.Parameters.AddWithValue("@FECHA", cita.Fecha);
            comando.Parameters.AddWithValue("@HORA_INICIO", cita.HoraInicio);
            comando.Parameters.AddWithValue("@HORA_FIN", cita.HoraFin);
            comando.Parameters.AddWithValue("@ESTADO", cita.Estado);
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

        public List<Entidad_Citas> ListarCitas(string condicion = "")
        {
            DataSet DS = new DataSet();
            SqlConnection connection = new SqlConnection(_cadenaConexion);
            SqlDataAdapter adapter;
            List<Entidad_Citas> citas;
            string sentencia = "SELECT ID_CITA, ID_PACIENTE, ID_FUNCIONARIO, MOTIVO, FECHA, HORA_INICIO, HORA_FIN, ESTADO FROM CITAS";
            if (!string.IsNullOrEmpty(condicion))
            {
                sentencia = string.Format("{0} WHERE {1}", sentencia, condicion);
            }
            try
            {
                adapter = new SqlDataAdapter(sentencia, connection);
                adapter.Fill(DS, "Citas");
                citas = (from DataRow unaFila in DS.Tables["Citas"].Rows
                         select new Entidad_Citas()
                         {
                             IdCita = (int)unaFila[0],
                             IdPaciente = (int)unaFila[1],
                             IdFuncionario = (int)unaFila[2],
                             Motivo = (string)unaFila[3],
                             Fecha = (DateTime)unaFila[4],
                             HoraInicio = (TimeSpan)unaFila[5],
                             HoraFin = (TimeSpan)unaFila[6],
                             Estado = (string)unaFila[7],
                         }).ToList();
            }
            catch (Exception)
            {
                throw;
            }
            return citas;
        }

        public Entidad_Citas ObtenerCita(int id)
        {
            Entidad_Citas cita = null;
            SqlConnection conexion = new SqlConnection(_cadenaConexion);
            SqlCommand comando = new SqlCommand();
            SqlDataReader dataReader;
            string sentencia = string.Format("SELECT ID_CITA, ID_PACIENTE, ID_FUNCIONARIO, MOTIVO, FECHA, HORA_INICIO, HORA_FIN, ESTADO FROM CITAS WHERE ID_CITA = {0}", id);
            comando.Connection = conexion;
            comando.CommandText = sentencia;
            try
            {
                conexion.Open();
                dataReader = comando.ExecuteReader();
                if (dataReader.HasRows)
                {
                    cita = new Entidad_Citas();
                    dataReader.Read();
                    cita.IdCita = dataReader.GetInt32(0);
                    cita.IdPaciente = dataReader.GetInt32(1);
                    cita.IdFuncionario = dataReader.GetInt32(2);
                    cita.Motivo = dataReader.GetString(3);
                    cita.Fecha = dataReader.GetDateTime(4);
                    cita.HoraInicio = dataReader.GetTimeSpan(5);
                    cita.HoraFin = dataReader.GetTimeSpan(6);
                    cita.Estado = dataReader.GetString(7);
                    cita.Existe = true;
                }
                conexion.Close();
            }
            catch (Exception)
            {
                throw;
            }
            return cita;
        }

        public int EliminarCita(Entidad_Citas cita)
        {
            int afectado = -1;
            SqlConnection conexion = new SqlConnection(_cadenaConexion);
            SqlCommand comando = new SqlCommand();
            string sentencia = "DELETE FROM CITAS";
            sentencia = string.Format("{0} WHERE ID_CITA = {1}", sentencia, cita.IdCita);
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

        public int ModificarCita(Entidad_Citas cita)
        {
            int filasAfectadas = -1;
            SqlConnection conexion = new SqlConnection(_cadenaConexion);
            SqlCommand comando = new SqlCommand();
            string sentencia = "UPDATE CITAS SET MOTIVO = @MOTIVO, FECHA = @FECHA, HORA_INICIO = @HORA_INICIO, HORA_FIN = @HORA_FIN, ESTADO = @ESTADO WHERE ID_CITA = @ID_CITA";
            comando.CommandText = sentencia;
            comando.Connection = conexion;
            comando.Parameters.AddWithValue("@ID_CITA", cita.IdCita);
            //comando.Parameters.AddWithValue("@ID_PACIENTE", cita.IdPaciente);
            //comando.Parameters.AddWithValue("@ID_FUNCIONARIO", cita.IdFuncionario);
            comando.Parameters.AddWithValue("@MOTIVO", cita.Motivo);
            comando.Parameters.AddWithValue("@FECHA", cita.Fecha);
            comando.Parameters.AddWithValue("@HORA_INICIO", cita.HoraInicio);
            comando.Parameters.AddWithValue("@HORA_FIN", cita.HoraFin);
            comando.Parameters.AddWithValue("@ESTADO", cita.Estado);
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
