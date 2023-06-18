using Capa_Entidades;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Text;
using System.Linq;

namespace Capa03_AccesoDatos
{
    public class DA_Funcionario
    {
        //Atributos
        private string _cadenaConexion;
        private string _mensaje;

        //Propiedades
        public string Mensaje { get => _mensaje; }

        //Constructor
        public DA_Funcionario(string cadenaConexion)
        {
            _cadenaConexion = cadenaConexion;
            _mensaje = string.Empty;
        }

        //Metodos
        public int InsertarFuncionario(Entidad_Funcionario funcionario)
        {
            int id = 0;
            //Establecer el objeto conexion
            SqlConnection conexion = new SqlConnection(_cadenaConexion);
            //Establecer los comandos sQL
            SqlCommand comando = new SqlCommand();
            comando.Connection = conexion;
            string sentencia = "INSERT INTO FUNCIONARIOS (ID_PUESTO,ID_ESPECIALIDAD,NOMBRE_FUNCIONARIO,APELLIDOS_FUNCIONARIO,CEDULA_FUNCIONARIO,TELEFONO_FUNCIONARIO,CORREO_FUNCIONARIO,DIRECCION_FUNCIONARIO,FECHA_NACIMIENTO_FUNCIONARIO) VALUES (@ID_PUESTO,@ID_ESPECIALIDAD,@NOMBRE_FUNCIONARIO,@APELLIDOS_FUNCIONARIO,@CEDULA_FUNCIONARIO,@TELEFONO_FUNCIONARIO,@CORREO_FUNCIONARIO,@DIRECCION_FUNCIONARIO,@FECHA_NACIMIENTO_FUNCIONARIO) SELECT @@IDENTITY";
            comando.Parameters.AddWithValue("@ID_PUESTO", funcionario.IdFuncionario);
            comando.Parameters.AddWithValue("@ID_ESPECIALIDAD", funcionario.IdEspecialidad);
            comando.Parameters.AddWithValue("@NOMBRE_FUNCIONARIO", funcionario.Nombre);
            comando.Parameters.AddWithValue("@APELLIDOS_FUNCIONARIO", funcionario.Apellidos);
            comando.Parameters.AddWithValue("@CEDULA_FUNCIONARIO", funcionario.Cedula);
            comando.Parameters.AddWithValue("@TELEFONO_FUNCIONARIO", funcionario.Telefono);
            comando.Parameters.AddWithValue("@CORREO_FUNCIONARIO", funcionario.Correo);
            comando.Parameters.AddWithValue("@DIRECCION_FUNCIONARIO", funcionario.Direccion);
            comando.Parameters.AddWithValue("@FECHA_NACIMIENTO_FUNCIONARIO", funcionario.FechaNacimiento);
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

        


        public List<Entidad_Funcionario> ListarFuncionarios(string condicion = "")
        {
            DataSet DS = new DataSet();
            SqlConnection connection = new SqlConnection(_cadenaConexion);
            SqlDataAdapter adapter;
            List<Entidad_Funcionario> funcionario;
            string sentencia = "SELECT ID_FUNCIONARIO,ID_PUESTO,ID_ESPECIALIDAD,NOMBRE_FUNCIONARIO,APELLIDOS_FUNCIONARIO,CEDULA_FUNCIONARIO,TELEFONO_FUNCIONARIO,CORREO_FUNCIONARIO,DIRECCION_FUNCIONARIO,FECHA_NACIMIENTO_FUNCIONARIO FROM FUNCIONARIOS";
            if (!string.IsNullOrEmpty(condicion))
            {
                sentencia = string.Format("{0} WHERE {1}", sentencia, condicion);
            }
            try
            {
                adapter = new SqlDataAdapter(sentencia, connection);
                adapter.Fill(DS, "Funcionarios");
                funcionario = (from DataRow unaFila in DS.Tables["Funcionarios"].Rows
                               select new Entidad_Funcionario()
                               {
                                   IdFuncionario = (int)unaFila[0],
                                   IdPuestoTrabajo = (int)unaFila[1],
                                   IdEspecialidad = (int)unaFila[2],
                                   Nombre = unaFila[3].ToString(),
                                   Apellidos = unaFila[4].ToString(),
                                   Cedula = unaFila[5].ToString(),
                                   Telefono = unaFila[6].ToString(),
                                   Correo = unaFila[7].ToString(),
                                   Direccion = unaFila[8].ToString(),
                                   FechaNacimiento = DateTime.Parse(unaFila[9].ToString()),
                               }).ToList();
            }
            catch (Exception)
            {
                throw;
            }
            return funcionario;
        }

        public Entidad_Funcionario ObtenerFuncionario(int id)
        {
            Entidad_Funcionario funcionario = null;
            SqlConnection conexion = new SqlConnection(_cadenaConexion);
            SqlCommand comando = new SqlCommand();
            SqlDataReader dataReader;
            string sentencia = string.Format("SELECT ID_FUNCIONARIO,ID_PUESTO,ID_ESPECIALIDAD,NOMBRE_FUNCIONARIO,APELLIDOS_FUNCIONARIO,CEDULA_FUNCIONARIO,TELEFONO_FUNCIONARIO,CORREO_FUNCIONARIO,DIRECCION_FUNCIONARIO,FECHA_NACIMIENTO_FUNCIONARIO FROM FUNCIONARIOS WHERE ID_FUNCIONARIO ={0}", id);
            comando.Connection = conexion;
            comando.CommandText = sentencia;
            try
            {
                conexion.Open();
                dataReader = comando.ExecuteReader();
                if (dataReader.HasRows)
                {
                    funcionario = new Entidad_Funcionario();
                    dataReader.Read();
                    funcionario.IdFuncionario = dataReader.GetInt32(0);
                    funcionario.IdPuestoTrabajo = dataReader.GetInt32(1);
                    funcionario.IdEspecialidad = dataReader.GetInt32(2);
                    funcionario.Nombre = dataReader.GetString(3);
                    funcionario.Apellidos = dataReader.GetString(4);
                    funcionario.Cedula = dataReader.GetString(5);
                    funcionario.Telefono = dataReader.GetString(6);
                    funcionario.Correo = dataReader.GetString(7);
                    funcionario.Direccion = dataReader.GetString(8);
                    funcionario.FechaNacimiento = dataReader.GetDateTime(9);
                    funcionario.Existe = true;
                }
                conexion.Close();
            }
            catch (Exception) { throw; }
            return funcionario;
        }

        //este metodo sirve para eliminar un funcionario pero sin llamar a un SP
        public int EliminarRegistroFuncionario(Entidad_Funcionario funcionario)
        {
            int afectado = -1;
            SqlConnection conexion = new SqlConnection(_cadenaConexion);
            SqlCommand comando = new SqlCommand();
            string sentencia = "DELETE FROM FUNCIONARIOS";
            sentencia = string.Format("{0} WHERE ID_FUNCIONARIO ={1}", sentencia, funcionario.IdFuncionario);
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

        public int ModificarRegistroFuncionario(Entidad_Funcionario funcionario)
        {
            int filasAfectadas = -1;
            SqlConnection conexion = new SqlConnection(_cadenaConexion);
            SqlCommand comando = new SqlCommand();
            string sentencia = "UPDATE FUNCIONARIOS SET ID_PUESTO=@ID_PUESTO,ID_ESPECIALIDAD=@ID_ESPECIALIDAD,NOMBRE_FUNCIONARIO=@NOMBRE_FUNCIONARIO,APELLIDOS_FUNCIONARIO=@APELLIDOS_FUNCIONARIO,CEDULA_FUNCIONARIO=@CEDULA_FUNCIONARIO,TELEFONO_FUNCIONARIO=@TELEFONO_FUNCIONARIO,CORREO_FUNCIONARIO=@CORREO_FUNCIONARIO,DIRECCION_FUNCIONARIO=@DIRECCION_FUNCIONARIO,FECHA_NACIMIENTO_FUNCIONARIO=@FECHA_NACIMIENTO_FUNCIONARIO WHERE ID_FUNCIONARIO=@ID_FUNCIONARIO";
            comando.CommandText = sentencia;
            comando.Connection = conexion;
            comando.Parameters.AddWithValue("@ID_FUNCIONARIO", funcionario.IdFuncionario);
            comando.Parameters.AddWithValue("@ID_FUNCIONARIO", funcionario.IdPuestoTrabajo);
            comando.Parameters.AddWithValue("@ID_FUNCIONARIO", funcionario.IdEspecialidad);
            comando.Parameters.AddWithValue("@NOMBRE_FUNCIONARIO", funcionario.Nombre);
            comando.Parameters.AddWithValue("@APELLIDOS_FUNCIONARIO", funcionario.Apellidos);
            comando.Parameters.AddWithValue("@CEDULA_FUNCIONARIO", funcionario.Cedula);
            comando.Parameters.AddWithValue("@TELEFONO_FUNCIONARIO", funcionario.Telefono);
            comando.Parameters.AddWithValue("@CORREO_FUNCIONARIO", funcionario.Correo);
            comando.Parameters.AddWithValue("@DIRECCION_FUNCIONARIO", funcionario.Direccion);
            comando.Parameters.AddWithValue("@FECHA_NACIMIENTO_FUNCIONARIO", funcionario.FechaNacimiento);
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
