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
    public partial class Frm_PuestosdeTrabajo : Form
    {
        public Frm_PuestosdeTrabajo()
        {
            InitializeComponent();
        }

        Frm_BuscarPuestoTrabajo formularioBuscarPuestoTrabajo;

        // Variable global, esto si el campo txtIdPuestoTrabajo.Text tiene algún valor, significa que el puesto de trabajo existe
        // No se debe insertar, se debe modificar
        Entidad_PuestosTrabajo puestoTrabajoRegistrado;

        public Entidad_PuestosTrabajo GenerarEntidadPuestoTrabajo()
        {
            Entidad_PuestosTrabajo puestoTrabajo;
            if (!string.IsNullOrEmpty(txtID_PuestoTrabajo.Text))
            {
                puestoTrabajo = puestoTrabajoRegistrado;
            }
            else
            {
                puestoTrabajo = new Entidad_PuestosTrabajo();
            }
            puestoTrabajo.Nombre = txtNombrePuesto.Text;
            puestoTrabajo.Descripcion = txtDescripcionPuesto.Text;
            return puestoTrabajo;
        }

        private void Limpiar()
        {
            txtID_PuestoTrabajo.Text = string.Empty;
            txtNombrePuesto.Text = string.Empty;
            txtDescripcionPuesto.Text = string.Empty;
        }



        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Entidad_PuestosTrabajo puestoTrabajo = new Entidad_PuestosTrabajo();
            BL_PuestosTrabajo logica = new BL_PuestosTrabajo(Configuracion.getConnectionString);
            int resultado;
            try
            {
                if (!string.IsNullOrEmpty(txtNombrePuesto.Text) && !string.IsNullOrEmpty(txtDescripcionPuesto.Text))
                {
                    puestoTrabajo = GenerarEntidadPuestoTrabajo();
                    if (!puestoTrabajo.Existe)
                    {
                        resultado = logica.InsertarPuestosTrabajo(puestoTrabajo);
                    }
                    else
                    {
                        resultado = logica.ModificarPuestosTrabajo(puestoTrabajo);
                    }
                    if (resultado > 0)
                    {
                        Limpiar();
                        MessageBox.Show("Operación realizada con éxito", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        cargarListaPuestosTrabajo();
                    }
                    else
                    {
                        MessageBox.Show("No se realizaron cambios", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show("Los datos son obligatorios", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

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
            formularioBuscarPuestoTrabajo = new Frm_BuscarPuestoTrabajo();
            formularioBuscarPuestoTrabajo.Aceptar += new EventHandler(Aceptar);
            formularioBuscarPuestoTrabajo.ShowDialog();
        }

        private void Frm_PuestosTrabajo_Load(object sender, EventArgs e)
        {
            try
            {
                cargarListaPuestosTrabajo();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Aceptar(object id, EventArgs e)
        {
            try
            {
                int idPuestoTrabajo = (int)id;
                if (idPuestoTrabajo != -1)
                {
                    CargarPuestoTrabajo(idPuestoTrabajo);
                }
                else
                {
                    Limpiar();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CargarPuestoTrabajo(int id)
        {
            Entidad_PuestosTrabajo puestoTrabajo = new Entidad_PuestosTrabajo();
            BL_PuestosTrabajo traerPuestoTrabajo = new BL_PuestosTrabajo(Configuracion.getConnectionString);
            try
            {
                puestoTrabajo = traerPuestoTrabajo.ObtenerPuestosTrabajo(id);
                if (puestoTrabajo != null)
                {
                    txtID_PuestoTrabajo.Text = puestoTrabajo.IdPuestoTrabajo.ToString();
                    txtNombrePuesto.Text = puestoTrabajo.Nombre;
                    txtDescripcionPuesto.Text = puestoTrabajo.Descripcion;
                    puestoTrabajoRegistrado = puestoTrabajo;
                }
                else
                {
                    MessageBox.Show("El puesto de trabajo no se encuentra en la base de datos", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    cargarListaPuestosTrabajo();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        private void btnEliminar_Click(object sender, EventArgs e)
        {
            Entidad_PuestosTrabajo puestoTrabajo;
            int resultado;
            BL_PuestosTrabajo logica = new BL_PuestosTrabajo(Configuracion.getConnectionString);
            try
            {
                if (!string.IsNullOrEmpty(txtID_PuestoTrabajo.Text))
                {
                    puestoTrabajo = logica.ObtenerPuestosTrabajo(int.Parse(txtID_PuestoTrabajo.Text));
                    if (puestoTrabajo != null)
                    {
                        resultado = logica.EliminarPuestosTrabajo(puestoTrabajo);
                        MessageBox.Show("Eliminado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Limpiar();
                        cargarListaPuestosTrabajo();
                    }
                    else
                    {
                        MessageBox.Show("El puesto de trabajo no existe", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        Limpiar();
                        cargarListaPuestosTrabajo();
                    }
                }
                else
                {
                    MessageBox.Show("Debe seleccionar un puesto de trabajo antes de eliminar", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSalir_Click_1(object sender, EventArgs e)
        {
            Close();
        }

        private void grdLista_DoubleClick_1(object sender, EventArgs e)
        {
            int id = 0;
            try
            {
                id = (int)grdLista.SelectedRows[0].Cells[0].Value;
                CargarPuestoTrabajo(id);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }
    }
}
