using System;
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
    }
}
