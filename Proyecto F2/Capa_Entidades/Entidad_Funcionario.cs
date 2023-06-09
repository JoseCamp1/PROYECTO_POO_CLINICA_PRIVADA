﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Capa_Entidades
{
    public class Entidad_Funcionario
    {
        //atributos
        private int idFuncionario;
        private int idPuestoTrabajo;
        private int idEspecialidad;
        private string nombre;
        private string apellidos;
        private string cedula;
        private string telefono;
        private string correo;
        private string direccion;
        private DateTime fechaNacimiento;
        private bool existe;

        //metodos getter and setter
        public int IdFuncionario { get => idFuncionario; set => idFuncionario = value; }
        public int IdPuestoTrabajo { get => idPuestoTrabajo; set => idPuestoTrabajo = value; }
        public int IdEspecialidad { get => idEspecialidad; set => idEspecialidad = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellidos { get => apellidos; set => apellidos = value; }
        public string Cedula { get => cedula; set => cedula = value; }
        public string Telefono { get => telefono; set => telefono = value; }
        public string Correo { get => correo; set => correo = value; }
        public string Direccion { get => direccion; set => direccion = value; }
        public DateTime FechaNacimiento { get => fechaNacimiento; set => fechaNacimiento = value; }
        public bool Existe { get => existe; set => existe = value; }
        

        //constructores
        public Entidad_Funcionario()
        {
            IdFuncionario = 0;
            idPuestoTrabajo = 0;
            idEspecialidad = 0;            
            Nombre = string.Empty;
            Apellidos = string.Empty;
            Cedula = string.Empty;
            Telefono = string.Empty;
            Correo = string.Empty;
            Direccion = string.Empty;
            FechaNacimiento = Convert.ToDateTime("01/01/1900");
            Existe = false;
        }

        public Entidad_Funcionario(int id, int idPuestoTrabajo, int idEspecialidad, string nombre, string apellidos, string apellido2,
            string cedula, string telefono, string correo, string direccion,
            DateTime fechaNacimiento, bool existe)
        {

            this.IdFuncionario = id;            
            this.idPuestoTrabajo = idPuestoTrabajo;
            this.IdEspecialidad = idEspecialidad;
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
            return string.Format("{0} - {1}", IdFuncionario, Nombre);
        }

    }
}
