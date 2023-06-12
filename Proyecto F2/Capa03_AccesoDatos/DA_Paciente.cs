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
        public int Insertar(Entidad_Paciente paciente)
        {
            int id = 0;
            //Establecer el objeto conexion
            SqlConnection conexion = new SqlConnection(_cadenaConexion);
            //Establecer los comandos sQL
            SqlCommand comando = new SqlCommand();
            comando.Connection = conexion;
            string sentencia = "INSERT INTO PACIENTES (NOMBRE_PACIENTE,APELLIDO1_PACIENTE,APELLIDO2_PACIENTE,CEDULA_PACIENTE,TELEFONO_PACIENTE,CORREO_PACIENTE,DIRECCION_PACIENTE,FECHA_NACIMIENTO_PACIENTE) VALUES (@NOMBRE_PACIENTE,@APELLIDO1_PACIENTE,@APELLIDO2_PACIENTE,@CEDULA_PACIENTE,@TELEFONO_PACIENTE,@CORREO_PACIENTE,@DIRECCION_PACIENTE,@FECHA_NACIMIENTO_PACIENTE) SELECT @@IDENTITY";
            comando.Parameters.AddWithValue("@NOMBRE_PACIENTE",paciente.Nombre);
            comando.Parameters.AddWithValue("@APELLIDO1_PACIENTE", paciente.Apellido1);
            comando.Parameters.AddWithValue("@APELLIDO2_PACIENTE", paciente.Apellido2);
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
            string sentencia = "SELECT ID_PACIENTE,NOMBRE_PACIENTE,APELLIDO1_PACIENTE,APELLIDO2_PACIENTE,CEDULA_PACIENTE,TELEFONO_PACIENTE,CORREO_PACIENTE,DIRECCION_PACIENTE,FECHA_NACIMIENTO_PACIENTE,ESTADO_PACIENTE,BORRADO_PACIENTE FROM PACIENTES";
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
                                Apellido1 = unaFila[2].ToString(),
                                Apellido2 = unaFila[3].ToString(),
                                Cedula = unaFila[4].ToString(),
                                Telefono = unaFila[5].ToString(),
                                Correo = unaFila[6].ToString(),
                                Direccion = unaFila[7].ToString(),
                                FechaNacimiento = DateTime.Parse(unaFila[8].ToString()),
                                Estado = unaFila[9].ToString(),
                                Borrado = (bool)unaFila[10],
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
            string sentencia = string.Format("SELECT ID_PACIENTE,NOMBRE_PACIENTE,APELLIDO1_PACIENTE,APELLIDO2_PACIENTE,CEDULA_PACIENTE,TELEFONO_PACIENTE,CORREO_PACIENTE,DIRECCION_PACIENTE,FECHA_NACIMIENTO_PACIENTE,ESTADO_PACIENTE,BORRADO_PACIENTE FROM CLIENTES WHERE ID_CLIENTE ={0}", id);
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
                    paciente.Apellido1 = dataReader.GetString(2);
                    paciente.Apellido2 = dataReader.GetString(3);
                    paciente.Cedula = dataReader.GetString(4);
                    paciente.Telefono = dataReader.GetString(5);
                    paciente.Correo = dataReader.GetString(6);
                    paciente.Direccion = dataReader.GetString(7);
                    paciente.FechaNacimiento=dataReader.GetDateTime(8);
                    paciente.Estado=dataReader.GetString(9);
                    paciente.Borrado=dataReader.GetBoolean(10);                    
                }
                conexion.Close();
            }
            catch (Exception) { throw; }
            return paciente;
        }



    }
}
