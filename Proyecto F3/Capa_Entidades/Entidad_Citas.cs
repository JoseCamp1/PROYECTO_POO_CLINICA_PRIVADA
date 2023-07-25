using System;
using System.Collections.Generic;
using System.Text;

namespace Capa_Entidades
{
    public class Entidad_Citas
    {
        private int idCita;
        private int idPaciente;
        private int idFuncionario;
        private string motivo;
        private DateTime fecha;
        private TimeSpan horaInicio;
        private TimeSpan horaFin;
        private string estado;
        private bool existe;

        public int IdCita { get => idCita; set => idCita = value; }
        public int IdPaciente { get => idPaciente; set => idPaciente = value; }
        public int IdFuncionario { get => idFuncionario; set => idFuncionario = value; }
        public string Motivo { get => motivo; set => motivo = value; }
        public DateTime Fecha { get => fecha; set => fecha = value; }
        public TimeSpan HoraInicio { get => horaInicio; set => horaInicio = value; }
        public TimeSpan HoraFin { get => horaFin; set => horaFin = value; }
        public string Estado { get => estado; set => estado = value; }
        public bool Existe { get => existe; set => existe = value; }

        public Entidad_Citas()
        {
            idCita = 0;
            idPaciente = 0;
            idFuncionario = 0;
            motivo = string.Empty;
            fecha = Convert.ToDateTime("01/01/1900");
            horaInicio = TimeSpan.Zero;
            horaFin = TimeSpan.Zero;
            estado = "ACT";
            existe = false;
        }

        public Entidad_Citas(int idCita, int idPaciente, int idFuncionario, string motivo, DateTime fecha, TimeSpan horaInicio, TimeSpan horaFin, string estado, bool existe)
        {
            this.idCita = idCita;
            this.idPaciente = idPaciente;
            this.idFuncionario = idFuncionario;
            this.motivo = motivo;
            this.fecha = fecha;
            this.horaInicio = horaInicio;
            this.horaFin = horaFin;
            this.estado = estado;
            this.existe = existe;
        }

        public override string ToString()
        {
            return idCita.ToString();
        }
    }


}
