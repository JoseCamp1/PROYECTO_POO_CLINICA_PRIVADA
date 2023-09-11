using System;
using System.Collections.Generic;
using System.Text;

namespace Capa_Entidades
{
    public class Entidad_UsuarioSistema
    {
        private int idUsuarioSistema;
        private int idFuncionario;
        private string correo;
        private string usuario;
        private string contrasena;
        private bool existe;

        public int IdUsuarioSistema { get => idUsuarioSistema; set => idUsuarioSistema = value; }
        public int IdFuncionario { get => idFuncionario; set => idFuncionario = value; }
        public string Correo { get => correo; set => correo = value; }
        public string Usuario { get => usuario; set => usuario = value; }
        public string Contrasena { get => contrasena; set => contrasena = value; }
        public bool Existe { get => existe; set => existe = value; }

        public Entidad_UsuarioSistema()
        {
            idUsuarioSistema = 0;
            idFuncionario = 0;
            correo = string.Empty;
            usuario = string.Empty;
            contrasena = string.Empty;
            existe = false;
        }

        public Entidad_UsuarioSistema(int idUsuarioSistema, int idFuncionario, string correo, string usuario, string contrasena,bool existe)
        {
            this.idUsuarioSistema = idUsuarioSistema;
            this.idFuncionario = idFuncionario;
            this.correo = correo;
            this.usuario = usuario;
            this.contrasena = contrasena;
            this.existe = existe;
        }

        public override string ToString()
        {
            return idUsuarioSistema.ToString();
        }
    }
}
