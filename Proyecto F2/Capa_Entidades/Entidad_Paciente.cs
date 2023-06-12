using System;
using System.Collections.Generic;
using System.Text;

namespace Capa_Entidades
{
    public class Entidad_Paciente
    {
        private int idPaciente;
        private string nombre;
        private string apellido1;
        private string apellido2;
        private string cedula;
        private string telefono;
        private string correo;
        private string direccion;
        private DateTime fechaNacimiento;
        private string estado;
        private bool borrado;

        public int IdPaciente { get => idPaciente; set => idPaciente = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido1 { get => apellido1; set => apellido1 = value; }
        public string Apellido2 { get => apellido2; set => apellido2 = value; }
        public string Cedula { get => cedula; set => cedula = value; }
        public string Telefono { get => telefono; set => telefono = value; }
        public string Correo { get => correo; set => correo = value; }
        public string Direccion { get => direccion; set => direccion = value; }
        public DateTime FechaNacimiento { get => fechaNacimiento; set => fechaNacimiento = value; }
        public string Estado { get => estado; set => estado = value; }
        public bool Borrado { get => borrado; set => borrado = value; }

        public Entidad_Paciente()
        {
            IdPaciente = 0;
            Nombre = string.Empty;
            Apellido1 = string.Empty;
            Apellido2 = string.Empty;
            Cedula = string.Empty;
            Telefono = string.Empty;
            Correo = string.Empty;
            Direccion = string.Empty;
            FechaNacimiento = DateTime.MinValue;
            Estado = string.Empty;
            Borrado = false;
        }

        public Entidad_Paciente(int id, string nombre, string apellido1, string apellido2,
            string cedula, string telefono, string correo, string direccion,
            DateTime fechaNacimiento, string estado, bool borrado)
        {
            
            this.IdPaciente = id;
            this.Nombre = nombre;
            this.Apellido1 = apellido1;
            this.Apellido2  = apellido2;
            this.Cedula = cedula;
            this.Telefono = telefono;
            this.Correo = correo;
            this.Direccion = direccion;
            this.FechaNacimiento = fechaNacimiento;            
        }

        

        public override string ToString()
        {
            return string.Format("{0} - {1}", IdPaciente, Nombre);
        }

    }

}
