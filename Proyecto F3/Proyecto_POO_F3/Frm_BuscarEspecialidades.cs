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
    public partial class Frm_BuscarEspecialidades : Form
    {
        public Frm_BuscarEspecialidades()
        {
            InitializeComponent();
        }

        public event EventHandler Aceptar;

        int vgn_id_especialidad;

        private void Seleccionar()
        {
            if (grdLista.SelectedRows.Count > 0)
            {
                vgn_id_especialidad = (int)grdLista.SelectedRows[0].Cells[0].Value;
                Aceptar(vgn_id_especialidad, null);
                Close();
            }
        }

        public void cargarListaEspecialidades(string condicion = "")
        {
            grdLista.Refresh();
            BL_Especialidades logica = new BL_Especialidades(Configuracion.getConnectionString);
            List<Entidad_Especialidades> especialidades;
            try
            {
                especialidades = logica.ListarEspecialidades(condicion);
                if (especialidades.Count > 0)
                {
                    grdLista.DataSource = especialidades;
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
                if (!string.IsNullOrEmpty(txtNombre.Text))
                {
                    condicion = string.Format("NOMBRE_ESPECIALIDAD LIKE '%{0}%'", txtNombre.Text.Trim());
                    cargarListaEspecialidades(condicion);
                }
                else
                {
                    MessageBox.Show("Debe escribir parte del nombre a buscar.", "Atención.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtNombre.Focus();
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

        private void grdLista_DoubleClick(object sender, EventArgs e)
        {
            Seleccionar();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Aceptar(-1, null);
            Close();
        }

        private void Frm_BuscarEspecialidades_Load(object sender, EventArgs e)
        {
            cargarListaEspecialidades();
        }

    }
}
