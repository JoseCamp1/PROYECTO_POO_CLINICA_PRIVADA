using System;
using System.Collections.Generic;
using System.Text;

namespace Capa_Entidades
{
    public class Entidad_Paciente
    {
        private int idPaciente;
        private string nombre;
        private string apellidos;
        private string cedula;
        private string telefono;
        private string correo;
        private string direccion;
        private DateTime fechaNacimiento;
        private bool existe;


        public int IdPaciente { get => idPaciente; set => idPaciente = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellidos { get => apellidos; set => apellidos = value; }
        public string Cedula { get => cedula; set => cedula = value; }
        public string Telefono { get => telefono; set => telefono = value; }
        public string Correo { get => correo; set => correo = value; }
        public string Direccion { get => direccion; set => direccion = value; }
        public DateTime FechaNacimiento { get => fechaNacimiento; set => fechaNacimiento = value; }
        public bool Existe { get => existe; set => existe = value; }

        public Entidad_Paciente()
        {
            IdPaciente = 0;
            Nombre = string.Empty;
            Apellidos = string.Empty;
            Cedula = string.Empty;
            Telefono = string.Empty;
            Correo = string.Empty;
            Direccion = string.Empty;
            FechaNacimiento = DateTime.MinValue;
            Existe = false;
        }

        public Entidad_Paciente(int id, string nombre, string apellidos, string apellido2,
            string cedula, string telefono, string correo, string direccion,
            DateTime fechaNacimiento, bool existe)
        {

            this.IdPaciente = id;
            this.Nombre = nombre;
            this.Apellidos = apellidos;
            this.Cedula = cedula;
            this.Telefono = telefono;
            this.Correo = correo;
            this.Direccion = direccion;
            this.FechaNacimiento = fechaNacimiento;
            this.Existe = existe;
        }



        public override string ToString()
        {
            return string.Format("{0} - {1}", IdPaciente, Nombre);
        }
    }
    
        

}
