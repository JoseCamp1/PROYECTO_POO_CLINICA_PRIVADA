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
    public partial class Frm_BuscarPuestoTrabajo : Form
    {
        public Frm_BuscarPuestoTrabajo()
        {
            InitializeComponent();
        }

        public event EventHandler Aceptar;

        int vgn_id_puestoTrabajo;

        private void Seleccionar()
        {
            if (grdLista.SelectedRows.Count > 0)
            {
                vgn_id_puestoTrabajo = (int)grdLista.SelectedRows[0].Cells[0].Value;
                Aceptar(vgn_id_puestoTrabajo, null);
                Close();
            }
        }//fin seleccionar

        public void cargarListaPuestosTrabajo(string condicion = "")
        {
            grdLista.Refresh();
            BL_PuestosTrabajo logica = new BL_PuestosTrabajo(Configuracion.getConnectionString);
            List<Entidad_PuestosTrabajo> puestosTrabajo;
            try
            {
                puestosTrabajo = logica.ListarPuestosTrabajo(condicion);
                if (puestosTrabajo.Count > 0)
                {
                    grdLista.DataSource = puestosTrabajo;
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
                    condicion = string.Format("NOMBRE_PUESTO  like '%{0}%'", txtNombre.Text.Trim());
                }
                else
                {
                    MessageBox.Show("Debe escribir parte del nombre a buscar.", "Atención.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtNombre.Focus();
                }
                cargarListaPuestosTrabajo(condicion);
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

        private void Frm_BuscarPuestoTrabajo_Load(object sender, EventArgs e)
        {
            cargarListaPuestosTrabajo();
        }
    }
}
