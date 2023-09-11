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
    public partial class Frm_BuscarCitas : Form
    {
        public Frm_BuscarCitas()
        {
            InitializeComponent();
        }

        public event EventHandler Aceptar;

        int vgn_id_cita;

        private void Seleccionar()
        {
            if (grdLista.SelectedRows.Count > 0)
            {
                vgn_id_cita = (int)grdLista.SelectedRows[0].Cells[0].Value;
                Aceptar(vgn_id_cita, null);
                Close();
            }
        }

        public void CargarListaCitas(string condicion = "")
        {
            grdLista.Refresh();
            BL_Citas logica = new BL_Citas(Configuracion.getConnectionString);
            List<Entidad_Citas> citas;
            try
            {
                citas = logica.ListarCitas(condicion);
                if (citas.Count > 0)
                {
                    grdLista.DataSource = citas;
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
                if (!string.IsNullOrEmpty(txtID_Paciente.Text))
                {
                    condicion = string.Format("ID_PACIENTE LIKE '%{0}%'", txtID_Paciente.Text.Trim());
                    CargarListaCitas(condicion);
                }
                else
                {
                    MessageBox.Show("Debe escribir parte del nombre a buscar.", "Atención.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtID_Paciente.Focus();
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

        private void Frm_BuscarCita_Load(object sender, EventArgs e)
        {
            CargarListaCitas();
        }


        private void grdLista_DoubleClick_1(object sender, EventArgs e)
        {
            Seleccionar();
        }
    }
}
