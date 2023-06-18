using System;
using System.Collections.Generic;
using System.Text;

namespace Capa_Entidades
{
    public class Entidad_Agenda
    {
        private int idAgenda;
        private int idFuncionario;
        private DateTime fecha;
        private TimeSpan horaInicio;
        private TimeSpan horaFin;
        private bool existe;

        public int IdAgenda { get => idAgenda; set => idAgenda = value; }
        public int IdFuncionario { get => idFuncionario; set => idFuncionario = value; }
        public DateTime Fecha { get => fecha; set => fecha = value; }
        public TimeSpan HoraInicio { get => horaInicio; set => horaInicio = value; }
        public TimeSpan HoraFin { get => horaFin; set => horaFin = value; }
        public bool Existe { get => existe; set => existe = value; }

        public Entidad_Agenda()
        {
            idAgenda = 0;
            idFuncionario = 0;
            fecha= Convert.ToDateTime("01/01/1900");
            horaInicio = TimeSpan.Zero;
            horaFin = TimeSpan.Zero;
            existe = false;
        }

        public Entidad_Agenda(int idAgenda, int idFuncionario, DateTime fecha, TimeSpan horaInicio, TimeSpan horaFin, bool existe)
        {
            this.idAgenda = idAgenda;
            this.idFuncionario = idFuncionario;
            this.fecha = fecha;
            this.horaInicio = horaInicio;
            this.horaFin = horaFin;
            this.existe = existe;            
        }

        public override string ToString()
        {
            return idAgenda.ToString();
        }
    }
}
