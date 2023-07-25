using Capa_Entidades;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Text;
using System.Linq;

namespace Capa03_AccesoDatos
{
    public class DA_Agenda
    {
        private string _cadenaConexion;
        private string _mensaje;

        public string Mensaje { get => _mensaje; }

        public DA_Agenda(string cadenaConexion)
        {
            _cadenaConexion = cadenaConexion;
            _mensaje = string.Empty;
        }

        public int InsertarAgenda(Entidad_Agenda agenda)
        {
            int id = 0;
            SqlConnection conexion = new SqlConnection(_cadenaConexion);
            SqlCommand comando = new SqlCommand();
            comando.Connection = conexion;
            string sentencia = "INSERT INTO AGENDA  (ID_FUNCIONARIO, FECHA, HORA_INICIO, HORA_FIN) VALUES (@ID_FUNCIONARIO, @FECHA, @HORA_INICIO, @HORA_FIN) SELECT @@IDENTITY";
            comando.Parameters.AddWithValue("@ID_FUNCIONARIO", agenda.IdFuncionario);
            comando.Parameters.AddWithValue("@FECHA", agenda.Fecha);
            comando.Parameters.AddWithValue("@HORA_INICIO", agenda.HoraInicio);
            comando.Parameters.AddWithValue("@HORA_FIN", agenda.HoraFin);
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

        public List<Entidad_Agenda> ListarAgendas(string condicion = "")
        {
            DataSet DS = new DataSet();
            SqlConnection connection = new SqlConnection(_cadenaConexion);
            SqlDataAdapter adapter;
            List<Entidad_Agenda> agendas;
            string sentencia = "SELECT ID_AGENDA, ID_FUNCIONARIO, FECHA, HORA_INICIO, HORA_FIN FROM AGENDA";
            if (!string.IsNullOrEmpty(condicion))
            {
                sentencia = string.Format("{0} WHERE {1}", sentencia, condicion);
            }
            try
            {
                adapter = new SqlDataAdapter(sentencia, connection);
                adapter.Fill(DS, "Agenda");
                agendas = (from DataRow unaFila in DS.Tables["Agenda"].Rows
                           select new Entidad_Agenda()
                           {
                               IdAgenda = (int)unaFila[0],
                               IdFuncionario = (int)unaFila[1],
                               Fecha = (DateTime)unaFila[2],
                               HoraInicio = (TimeSpan)unaFila[3],
                               HoraFin = (TimeSpan)unaFila[4],
                           }).ToList();
            }
            catch (Exception)
            {
                throw;
            }
            return agendas;
        }

        public Entidad_Agenda ObtenerAgenda(int id)
        {
            Entidad_Agenda agenda = null;
            SqlConnection conexion = new SqlConnection(_cadenaConexion);
            SqlCommand comando = new SqlCommand();
            SqlDataReader dataReader;
            string sentencia = string.Format("SELECT ID_AGENDA, ID_FUNCIONARIO, FECHA, HORA_INICIO, HORA_FIN FROM AGENDA WHERE ID_AGENDA = {0}", id);
            comando.Connection = conexion;
            comando.CommandText = sentencia;
            try
            {
                conexion.Open();
                dataReader = comando.ExecuteReader();
                if (dataReader.HasRows)
                {
                    agenda = new Entidad_Agenda();
                    dataReader.Read();
                    agenda.IdAgenda = dataReader.GetInt32(0);
                    agenda.IdFuncionario = dataReader.GetInt32(1);
                    agenda.Fecha = dataReader.GetDateTime(2);
                    agenda.HoraInicio = dataReader.GetTimeSpan(3);
                    agenda.HoraFin = dataReader.GetTimeSpan(4);
                    agenda.Existe = true;
                }
                conexion.Close();
            }
            catch (Exception)
            {
                throw;
            }
            return agenda;
        }

        public int EliminarAgenda(Entidad_Agenda agenda)
        {
            int afectado = -1;
            SqlConnection conexion = new SqlConnection(_cadenaConexion);
            SqlCommand comando = new SqlCommand();
            string sentencia = "DELETE FROM AGENDA";
            sentencia = string.Format("{0} WHERE ID_AGENDA = {1}", sentencia, agenda.IdAgenda);
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

        public int ModificarAgenda(Entidad_Agenda agenda)
        {
            int filasAfectadas = -1;
            SqlConnection conexion = new SqlConnection(_cadenaConexion);
            SqlCommand comando = new SqlCommand();
            string sentencia = "UPDATE AGENDA SET ID_FUNCIONARIO = @ID_FUNCIONARIO, FECHA = @FECHA, HORA_INICIO = @HORA_INICIO, HORA_FIN = @HORA_FIN WHERE ID_AGENDA = @ID_AGENDA";
            comando.CommandText = sentencia;
            comando.Connection = conexion;
            comando.Parameters.AddWithValue("@ID_AGENDA", agenda.IdAgenda);
            comando.Parameters.AddWithValue("@ID_FUNCIONARIO", agenda.IdFuncionario);
            comando.Parameters.AddWithValue("@FECHA", agenda.Fecha);
            comando.Parameters.AddWithValue("@HORA_INICIO", agenda.HoraInicio);
            comando.Parameters.AddWithValue("@HORA_FIN", agenda.HoraFin);
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
