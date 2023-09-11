using Capa_Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using System.Linq;

namespace Capa03_AccesoDatos
{
    public class DA_Paciente
    {
        //Atributos
        private string _cadenaConexion;
        private string _mensaje;

        //Propiedades
        public string Mensaje { get => _mensaje; }

        //Constructor
        public DA_Paciente(string cadenaConexion)
        {
            _cadenaConexion = cadenaConexion;
            _mensaje = string.Empty;
        }

        //Metodos
        public int InsertarPaciente(Entidad_Paciente paciente)
        {
            int id = 0;
            //Establecer el objeto conexion
            SqlConnection conexion = new SqlConnection(_cadenaConexion);
            //Establecer los comandos sQL
            SqlCommand comando = new SqlCommand();
            comando.Connection = conexion;
            string sentencia = "INSERT INTO PACIENTES (NOMBRE_PACIENTE,APELLIDOS_PACIENTE,CEDULA_PACIENTE,TELEFONO_PACIENTE,CORREO_PACIENTE,DIRECCION_PACIENTE,FECHA_NACIMIENTO_PACIENTE) VALUES (@NOMBRE_PACIENTE,@APELLIDOS_PACIENTE,@CEDULA_PACIENTE,@TELEFONO_PACIENTE,@CORREO_PACIENTE,@DIRECCION_PACIENTE,@FECHA_NACIMIENTO_PACIENTE) SELECT @@IDENTITY";
            comando.Parameters.AddWithValue("@NOMBRE_PACIENTE",paciente.Nombre);
            comando.Parameters.AddWithValue("@APELLIDOS_PACIENTE", paciente.Apellidos);            
            comando.Parameters.AddWithValue("@CEDULA_PACIENTE", paciente.Cedula);
            comando.Parameters.AddWithValue("@TELEFONO_PACIENTE", paciente.Telefono);
            comando.Parameters.AddWithValue("@CORREO_PACIENTE", paciente.Correo);
            comando.Parameters.AddWithValue("@DIRECCION_PACIENTE", paciente.Direccion);
            comando.Parameters.AddWithValue("@FECHA_NACIMIENTO_PACIENTE", paciente.FechaNacimiento);
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

        public List<Entidad_Paciente> ListarPacientes(string condicion = "")
        {
            DataSet DS = new DataSet();
            SqlConnection connection = new SqlConnection(_cadenaConexion);
            SqlDataAdapter adapter;
            List<Entidad_Paciente> clientes;
            string sentencia = "SELECT ID_PACIENTE,NOMBRE_PACIENTE,APELLIDOS_PACIENTE,CEDULA_PACIENTE,TELEFONO_PACIENTE,CORREO_PACIENTE,DIRECCION_PACIENTE,FECHA_NACIMIENTO_PACIENTE FROM PACIENTES";
            if (!string.IsNullOrEmpty(condicion))
            {
                sentencia = string.Format("{0} WHERE {1}", sentencia, condicion);
            }
            try
            {
                adapter = new SqlDataAdapter(sentencia, connection);
                adapter.Fill(DS, "Pacientes");
                clientes = (from DataRow unaFila in DS.Tables["Pacientes"].Rows
                            select new Entidad_Paciente()
                            {
                                IdPaciente = (int)unaFila[0],
                                Nombre = unaFila[1].ToString(),
                                Apellidos = unaFila[2].ToString(),                                
                                Cedula = unaFila[3].ToString(),
                                Telefono = unaFila[4].ToString(),
                                Correo = unaFila[5].ToString(),
                                Direccion = unaFila[6].ToString(),
                                FechaNacimiento = DateTime.Parse(unaFila[7].ToString()),                    
                                
                            }).ToList();
            }
            catch (Exception)
            {
                throw;
            }
            return clientes;
        }

        public Entidad_Paciente ObtenerPaciente(int id)
        {
            Entidad_Paciente paciente = null;
            SqlConnection conexion = new SqlConnection(_cadenaConexion);
            SqlCommand comando = new SqlCommand();
            SqlDataReader dataReader;
            string sentencia = string.Format("SELECT ID_PACIENTE,NOMBRE_PACIENTE,APELLIDOS_PACIENTE,CEDULA_PACIENTE,TELEFONO_PACIENTE,CORREO_PACIENTE,DIRECCION_PACIENTE,FECHA_NACIMIENTO_PACIENTE FROM PACIENTES WHERE ID_PACIENTE ={0}", id);
            comando.Connection = conexion;
            comando.CommandText = sentencia;
            try
            {
                conexion.Open();
                dataReader = comando.ExecuteReader();
                if (dataReader.HasRows)
                {
                    paciente = new Entidad_Paciente();
                    dataReader.Read();
                    paciente.IdPaciente = dataReader.GetInt32(0);
                    paciente.Nombre = dataReader.GetString(1);
                    paciente.Apellidos = dataReader.GetString(2);                    
                    paciente.Cedula = dataReader.GetString(3);
                    paciente.Telefono = dataReader.GetString(4);
                    paciente.Correo = dataReader.GetString(5);
                    paciente.Direccion = dataReader.GetString(6);
                    paciente.FechaNacimiento=dataReader.GetDateTime(7);
                    paciente.Existe = true;
                }
                conexion.Close();
            }
            catch (Exception) { throw; }
            return paciente;
        }

        //este metodo sirve para eliminar un paciente pero sin llamar a un SP
        public int EliminarRegistroPaciente(Entidad_Paciente paciente)
        {
            int afectado = -1;
            SqlConnection conexion = new SqlConnection(_cadenaConexion);
            SqlCommand comando = new SqlCommand();
            string sentencia = "DELETE FROM PACIENTES";
            sentencia = string.Format("{0} WHERE ID_PACIENTE ={1}", sentencia, paciente.IdPaciente);
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

        public int ModificarRegistroPaciente(Entidad_Paciente paciente)
        {
            int filasAfectadas = -1;
            SqlConnection conexion = new SqlConnection(_cadenaConexion);
            SqlCommand comando = new SqlCommand();
            string sentencia = "UPDATE PACIENTES SET NOMBRE_PACIENTE=@NOMBRE_PACIENTE,APELLIDOS_PACIENTE=@APELLIDOS_PACIENTE,CEDULA_PACIENTE=@CEDULA_PACIENTE,TELEFONO_PACIENTE=@TELEFONO_PACIENTE,CORREO_PACIENTE=@CORREO_PACIENTE,DIRECCION_PACIENTE=@DIRECCION_PACIENTE,FECHA_NACIMIENTO_PACIENTE=@FECHA_NACIMIENTO_PACIENTE WHERE ID_PACIENTE=@ID_PACIENTE";
            comando.CommandText = sentencia;
            comando.Connection = conexion;
            comando.Parameters.AddWithValue("@ID_PACIENTE", paciente.IdPaciente);
            comando.Parameters.AddWithValue("@NOMBRE_PACIENTE", paciente.Nombre);
            comando.Parameters.AddWithValue("@APELLIDOS_PACIENTE", paciente.Apellidos);
            comando.Parameters.AddWithValue("@CEDULA_PACIENTE", paciente.Cedula);
            comando.Parameters.AddWithValue("@TELEFONO_PACIENTE", paciente.Telefono);
            comando.Parameters.AddWithValue("@CORREO_PACIENTE", paciente.Correo);
            comando.Parameters.AddWithValue("@DIRECCION_PACIENTE", paciente.Direccion);
            comando.Parameters.AddWithValue("@FECHA_NACIMIENTO_PACIENTE", paciente.FechaNacimiento);
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
