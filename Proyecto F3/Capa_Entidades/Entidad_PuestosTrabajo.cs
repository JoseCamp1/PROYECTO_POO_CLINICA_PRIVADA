using System;
using System.Collections.Generic;
using System.Text;

namespace Capa_Entidades
{
    public class Entidad_PuestosTrabajo
    {
        private int idPuestoTrabajo;
        private string nombre;
        private string descripcion;
        private bool existe;

        public int IdPuestoTrabajo { get => idPuestoTrabajo; set => idPuestoTrabajo = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }
        public bool Existe { get => existe; set => existe = value; }

        public Entidad_PuestosTrabajo()
        {
            idPuestoTrabajo = 0;
            nombre = string.Empty;
            descripcion = string.Empty;
            existe = false;
        }

        public Entidad_PuestosTrabajo(int idPuestoTrabajo, string nombre, string descripcion, bool existe)
        {
            this.idPuestoTrabajo = idPuestoTrabajo;
            this.nombre = nombre;
            this.descripcion = descripcion;
            this.existe = existe;
        }

        public override string ToString()
        {
            return string.Format("{0} - {1}", idPuestoTrabajo, nombre);
        }
    }
}
