using System;
using System.Collections.Generic;
using System.Text;

namespace Capa_Entidades
{
    internal class Entidad_Funcionario
    {
        private int _idFuncionario;
        private string _nombre;
        private string _apellido1;
        private string _apellido2;
        private string _cedula;
        private string _telefono;
        private string _correo;
        private string _direccion;
        private DateTime _fechaNacimiento;
        private string _puestoTrabajo;
        private string _estado;
        private bool _borrado;

        public int GetIdFuncionario()
        {
            return _idFuncionario;
        }

        public void SetIdFuncionario(int idFuncionario)
        {
            _idFuncionario = idFuncionario;
        }

        public string GetNombre()
        {
            return _nombre;
        }

        public void SetNombre(string nombre)
        {
            _nombre = nombre;
        }

        public string GetApellido1()
        {
            return _apellido1;
        }

        public void SetApellido1(string apellido1)
        {
            _apellido1 = apellido1;
        }

        public string GetApellido2()
        {
            return _apellido2;
        }

        public void SetApellido2(string apellido2)
        {
            _apellido2 = apellido2;
        }

        public string GetCedula()
        {
            return _cedula;
        }

        public void SetCedula(string cedula)
        {
            _cedula = cedula;
        }

        public string GetTelefono()
        {
            return _telefono;
        }

        public void SetTelefono(string telefono)
        {
            _telefono = telefono;
        }

        public string GetCorreo()
        {
            return _correo;
        }

        public void SetCorreo(string correo)
        {
            _correo = correo;
        }

        public string GetDireccion()
        {
            return _direccion;
        }

        public void SetDireccion(string direccion)
        {
            _direccion = direccion;
        }

        public DateTime GetFechaNacimiento()
        {
            return _fechaNacimiento;
        }

        public void SetFechaNacimiento(DateTime fechaNacimiento)
        {
            _fechaNacimiento = fechaNacimiento;
        }

        public string GetPuestoTrabajo()
        {
            return _puestoTrabajo;
        }

        public void SetPuestoTrabajo(string puestoTrabajo)
        {
            _puestoTrabajo = puestoTrabajo;
        }

        public string GetEstado()
        {
            return _estado;
        }

        public void SetEstado(string estado)
        {
            _estado = estado;
        }

        public bool GetBorrado()
        {
            return _borrado;
        }

        public void SetBorrado(bool borrado)
        {
            _borrado = borrado;
        }

        public Entidad_Funcionario()
        {
            _idFuncionario = 0;
            _nombre = string.Empty;
            _apellido1 = string.Empty;
            _apellido2 = string.Empty;
            _cedula = string.Empty;
            _telefono = string.Empty;
            _correo = string.Empty;
            _direccion = string.Empty;
            _fechaNacimiento = DateTime.MinValue;
            _puestoTrabajo = string.Empty;
            _estado = string.Empty;
            _borrado = false;
        }

        public Entidad_Funcionario(int idFuncionario, string nombre, string apellido1, string apellido2,
            string cedula, string telefono, string correo, string direccion,
            DateTime fechaNacimiento, string puestoTrabajo, string estado, bool borrado)
        {
            _idFuncionario = idFuncionario;
            _nombre = nombre;
            _apellido1 = apellido1;
            _apellido2 = apellido2;
            _cedula = cedula;
            _telefono = telefono;
            _correo = correo;
            _direccion = direccion;
            _fechaNacimiento = fechaNacimiento;
            _puestoTrabajo = puestoTrabajo;
            _estado = estado;
            _borrado = borrado;
        }
    }

}
