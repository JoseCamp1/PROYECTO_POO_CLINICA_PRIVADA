using Capa_Entidades;
using Capa02_LogicaNegocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Capa01_Presentacion
{
    public partial class Frm_BuscarAgenda : Form
    {
        public Frm_BuscarAgenda()
        {
            InitializeComponent();
        }

        public event EventHandler Aceptar;

        int vgn_id_agenda;

        private void Seleccionar()
        {
            if (grdLista.SelectedRows.Count > 0)
            {
                vgn_id_agenda = (int)grdLista.SelectedRows[0].Cells[0].Value;
                Aceptar(vgn_id_agenda, null);
                Close();
            }
        }

        public void CargarListaAgenda(string condicion = "")
        {
            grdLista.Refresh();
            BL_Agenda logica = new BL_Agenda(Configuracion.getConnectionString);
            List<Entidad_Agenda> agendas;
            try
            {
                agendas = logica.ListarAgendas(condicion);
                if (agendas.Count > 0)
                {
                    grdLista.DataSource = agendas;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string condicion = string.Empty;
            try
            {
                if (!string.IsNullOrEmpty(txtID_Funcionario.Text))
                {
                    condicion = string.Format("ID_FUNCIONARIO  LIKE '%{0}%'", txtID_Funcionario.Text.Trim());
                    CargarListaAgenda(condicion);
                }
                else
                {
                    MessageBox.Show("Debe escribir parte del nombre a buscar.", "Atención.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtID_Funcionario.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            Seleccionar();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Aceptar(-1, null);
            Close();
        }

        private void Frm_BuscarAgenda_Load(object sender, EventArgs e)
        {
            CargarListaAgenda();
        }

        private void grdLista_DoubleClick_1(object sender, EventArgs e)
        {
            Seleccionar();
        }
    }
}
