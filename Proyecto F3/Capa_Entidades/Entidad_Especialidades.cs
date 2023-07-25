using System;
using System.Collections.Generic;
using System.Text;

namespace Capa_Entidades
{
    public class Entidad_Especialidades
    {
        private int idEspecialidad;
        private string nombre;
        private string descripcion;
        private bool existe;

        public int IdEspecialidad { get => idEspecialidad; set => idEspecialidad = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }
        public bool Existe { get => existe; set => existe = value; }

        public Entidad_Especialidades()
        {
            idEspecialidad = 0;
            nombre = string.Empty;
            descripcion = string.Empty;
            existe = false;
        }

        public Entidad_Especialidades(int idEspecialidad, string nombre, string descripcion, bool existe)
        {
            this.idEspecialidad = idEspecialidad;
            this.nombre = nombre;
            this.descripcion = descripcion;
            this.existe = existe;
        }

        public override string ToString()
        {
            return string.Format("{0} - {1}", idEspecialidad, nombre);
        }
    }
}
