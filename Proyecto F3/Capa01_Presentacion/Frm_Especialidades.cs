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
    public partial class Frm_Especialidades : Form
    {
        public Frm_Especialidades()
        {
            InitializeComponent();
        }

        Frm_BuscarEspecialidades formularioBuscarEspecialidades;

        // Variable global, esto si el campo txtIdPuestoTrabajo.Text tiene algún valor, significa que el puesto de trabajo existe
        // No se debe insertar, se debe modificar
        Entidad_Especialidades especialidadesRegistradas;

        public Entidad_Especialidades GenerarEntidadEspecialidad()
        {
            Entidad_Especialidades especialidad;
            if (!string.IsNullOrEmpty(txtID_Especialidad.Text))
            {
                especialidad = especialidadesRegistradas;
            }
            else
            {
                especialidad = new Entidad_Especialidades();
            }
            especialidad.Nombre = txtNombre.Text;
            especialidad.Descripcion = txtDescripcion.Text;
            return especialidad;
        }

        private void Limpiar()
        {
            txtID_Especialidad.Text = string.Empty;
            txtNombre.Text = string.Empty;
            txtDescripcion.Text = string.Empty;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Entidad_Especialidades especialidad = new Entidad_Especialidades();
            BL_Especialidades logica = new BL_Especialidades(Configuracion.getConnectionString);
            int resultado;
            try
            {
                if (!string.IsNullOrEmpty(txtNombre.Text) && !string.IsNullOrEmpty(txtDescripcion.Text))
                {
                    especialidad = GenerarEntidadEspecialidad();
                    if (!especialidad.Existe)
                    {
                        resultado = logica.InsertarEspecialidad(especialidad);
                    }
                    else
                    {
                        resultado = logica.ModificarEspecialidad(especialidad);
                    }
                    if (resultado > 0)
                    {
                        Limpiar();
                        MessageBox.Show("Operación realizada con éxito", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        cargarListaEspecialidades();
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
            formularioBuscarEspecialidades = new Frm_BuscarEspecialidades();
            formularioBuscarEspecialidades.Aceptar += new EventHandler(Aceptar);
            formularioBuscarEspecialidades.ShowDialog();
        }

        private void Frm_Especialidades_Load(object sender, EventArgs e)
        {
            try
            {
                cargarListaEspecialidades();
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
                int idEspecialidad = (int)id;
                if (idEspecialidad != -1)
                {
                    CargarEspecialidad(idEspecialidad);
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

        private void CargarEspecialidad(int id)
        {
            Entidad_Especialidades especialidad = new Entidad_Especialidades();
            BL_Especialidades traerEspecialidad = new BL_Especialidades(Configuracion.getConnectionString);
            try
            {
                especialidad = traerEspecialidad.ObtenerEspecialidad(id);
                if (especialidad != null)
                {
                    txtID_Especialidad.Text = especialidad.IdEspecialidad.ToString();
                    txtNombre.Text = especialidad.Nombre;
                    txtDescripcion.Text = especialidad.Descripcion;
                    especialidadesRegistradas = especialidad;
                }
                else
                {
                    MessageBox.Show("La especialidad no se encuentra en la base de datos", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    cargarListaEspecialidades();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            Entidad_Especialidades especialidad;
            int resultado;
            BL_Especialidades logica = new BL_Especialidades(Configuracion.getConnectionString);
            try
            {
                if (!string.IsNullOrEmpty(txtID_Especialidad.Text))
                {
                    especialidad = logica.ObtenerEspecialidad(int.Parse(txtID_Especialidad.Text));
                    if (especialidad != null)
                    {
                        resultado = logica.EliminarEspecialidad(especialidad);
                        MessageBox.Show("Eliminado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Limpiar();
                        cargarListaEspecialidades();
                    }
                    else
                    {
                        MessageBox.Show("La especialidad no existe", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        Limpiar();
                        cargarListaEspecialidades();
                    }
                }
                else
                {
                    MessageBox.Show("Debe seleccionar una especialidad antes de eliminar", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void grdLista_DoubleClick(object sender, EventArgs e)
        {
            int id = 0;
            try
            {
                id = (int)grdLista.SelectedRows[0].Cells[0].Value;
                CargarEspecialidad(id);
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
