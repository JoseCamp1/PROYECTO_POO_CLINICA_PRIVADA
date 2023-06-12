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
    public partial class Frm_Pacientes : Form
    {
        public Frm_Pacientes()
        {
            InitializeComponent();
        }

        public Entidad_Paciente GenerarEntidadCliente()
        {
            Entidad_Paciente paciente = new Entidad_Paciente();
            paciente.Nombre = txtNombre.Text;
            paciente.Apellido1 = txtApellido1.Text;
            paciente.Apellido2 = txtApellido2.Text;
            paciente.Cedula = txtCedula.Text;
            paciente.Telefono = txtTelefono.Text;
            paciente.Correo = txtCorreo.Text;
            paciente.Direccion = txtDireccion.Text;
            paciente.FechaNacimiento = DateTime.Parse(txtFechaNacimiento.Text); ;
            return paciente;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Limpiar()
        {
            txtID_Paciente.Text = string.Empty;
            txtNombre.Text = string.Empty;
            txtApellido1.Text = string.Empty;
            txtApellido2.Text = string.Empty;
            txtCedula.Text = string.Empty;
            txtTelefono.Text = string.Empty;
            txtCorreo.Text = string.Empty;
            txtDireccion.Text = string.Empty;
            txtFechaNacimiento.Text = string.Empty;
            txtBuscarNombre.Text = string.Empty;                       
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Entidad_Paciente paciente = new Entidad_Paciente();
            BL_Paciente logica = new BL_Paciente(Configuracion.getConnectionString);
            int resultado;
            try
            {
                if (string.IsNullOrEmpty(txtNombre.Text) | string.IsNullOrEmpty(txtTelefono.Text) | string.IsNullOrEmpty(txtDireccion.Text))
                {
                    MessageBox.Show("Faltan datos. Favor complete los datos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    paciente = GenerarEntidadCliente();
                    resultado = logica.Insertar(paciente);
                    Limpiar();
                    MessageBox.Show("Operación realizada con éxito", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void cargarLista(string condicion = "")
        {
            grdClientes.Refresh();
            BL_Paciente logica = new BL_Paciente(Configuracion.getConnectionString);
            List<Entidad_Paciente> paciente;
            try
            {
                paciente = logica.ListarPacientes(condicion);
                if (paciente.Count > 0)
                {
                    grdClientes.DataSource = paciente;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCargarLista_Click(object sender, EventArgs e)
        {
            cargarLista();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string condicion = "";
            try
            {
                if (!string.IsNullOrEmpty(txtBuscarNombre.Text))
                {
                    condicion = string.Format("NOMBRE_PACIENTE LIKE '%{0}%'", txtBuscarNombre.Text.Trim());
                }
                else
                {
                    MessageBox.Show("Debe escribir algo antes de buscar", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtBuscarNombre.Focus();
                }
                cargarLista(condicion);
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            Limpiar();
        }
    }
}
