﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Capa01_Presentacion
{
    public partial class Frm_MenuPrincipal : Form
    {
        public Frm_MenuPrincipal()
        {
            InitializeComponent();
        }

        private void pacientesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Frm_Pacientes pacientes = new Frm_Pacientes();
            pacientes.MdiParent = this;
            pacientes.Show();
        }

        private void funcionariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_Funcionarios funcionario = new Frm_Funcionarios();
            funcionario.MdiParent = this;
            funcionario.Show();
        }

        private void puestosDeTrabajoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_PuestosdeTrabajo puestosTrabajo = new Frm_PuestosdeTrabajo();
            puestosTrabajo.MdiParent = this;
            puestosTrabajo.Show();
        }

        private void especialidadesMedicasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_Especialidades especialidades = new Frm_Especialidades();
            especialidades.MdiParent = this;
            especialidades.Show();
        }

        private void agendaEspecialistaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_Agenda agenda = new Frm_Agenda();
            agenda.MdiParent = this;
            agenda.Show();
        }

        private void citasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_Citas citas = new Frm_Citas();
            citas.MdiParent = this;
            citas.Show();
        }

        private void infoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string titulo = "Sobre Mi Programa";
            string mensaje = "¡Bienvenido a Mi Programa!\n\n" +
                             "Versión: 1.0\n" +
                             "Desarrollado por: Tu Nombre\n" +
                             "Contacto: tu@email.com";

            MessageBox.Show(mensaje, titulo, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
