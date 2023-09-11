using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Capa_Entidades;
using Capa02_LogicaNegocio;

namespace Capa01_Presentacion
{
    public partial class Frm_BuscarPaciente : Form
    {
        public Frm_BuscarPaciente()
        {
            InitializeComponent();
        }

        public event EventHandler Aceptar;

        int vgn_id_Paciente;

        private void Seleccionar()
        {
            if (grdLista.SelectedRows.Count > 0)
            {
                vgn_id_Paciente = (int)grdLista.SelectedRows[0].Cells[0].Value;
                Aceptar(vgn_id_Paciente, null);
                Close();
            }
        }//fin seleccionar

        public void cargarListaPacientes(string condicion = "")
        {
            grdLista.Refresh();
            BL_Paciente logica = new BL_Paciente(Configuracion.getConnectionString);
            List<Entidad_Paciente> paciente;
            try
            {
                paciente = logica.ListarPacientes(condicion);
                if (paciente.Count > 0)
                {
                    grdLista.DataSource = paciente;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }//fin cargar

        private void Frm_BuscarPaciente_Load(object sender, EventArgs e)
        {
            cargarListaPacientes();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string condicion = string.Empty;
            try
            {
                if (!string.IsNullOrEmpty(txtNombre.Text))
                {
                    condicion = string.Format("NOMBRE_PACIENTE like '%{0}%'", txtNombre.Text.Trim());
                }
                else
                {
                    MessageBox.Show("Debe escribir parte del nombre a buscar.", "Atención.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtNombre.Focus();
                }
                cargarListaPacientes(condicion);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }//fin buscar

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            Seleccionar();
        }

        private void grdLista_DoubleClick(object sender, EventArgs e)
        {
            Seleccionar();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Aceptar(-1, null);
            Close();
        }
    }
}
