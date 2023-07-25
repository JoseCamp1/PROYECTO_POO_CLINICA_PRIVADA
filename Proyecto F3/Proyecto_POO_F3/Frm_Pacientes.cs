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

        Frm_BuscarPaciente formularioBuscarPaciente;

        //variable global, esto si el campo txtIdcliente.text tiene algun valor, significa que el paciente existe
        //no se debe insertar se debe modificar
        Entidad_Paciente pacienteRegistrado;

        public Entidad_Paciente GenerarEntidadCliente()
        {
            Entidad_Paciente paciente;
            if (!string.IsNullOrEmpty(txtID_Paciente.Text))
            {
                paciente = pacienteRegistrado;
            }
            else
            {
                paciente = new Entidad_Paciente();
            }
            paciente.Nombre = txtNombre.Text;
            paciente.Apellidos = txtApellidos.Text;
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
            txtApellidos.Text = string.Empty;
            txtCedula.Text = string.Empty;
            txtTelefono.Text = string.Empty;
            txtCorreo.Text = string.Empty;
            txtDireccion.Text = string.Empty;
            txtFechaNacimiento.Text = string.Empty;
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
                if (!string.IsNullOrEmpty(txtNombre.Text) && !string.IsNullOrEmpty(txtApellidos.Text) && !string.IsNullOrEmpty(txtCedula.Text) && !string.IsNullOrEmpty(txtTelefono.Text) && !string.IsNullOrEmpty(txtCorreo.Text) && !string.IsNullOrEmpty(txtDireccion.Text) && !string.IsNullOrEmpty(txtFechaNacimiento.Text))
                {
                    paciente = GenerarEntidadCliente();
                    if (!paciente.Existe)
                    {
                        resultado = logica.InsertarPaciente(paciente);
                        //MessageBox.Show("No existe!");
                    }
                    else
                    {
                        resultado = logica.ModificarPaciente(paciente);
                        //MessageBox.Show("Existe!");
                    }
                    if (resultado > 0)
                    {
                        Limpiar();
                        MessageBox.Show("Operacion realizada con exito", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        cargarListaPacientes();
                    }
                    else
                    {
                        MessageBox.Show("No se Realizaron cambios", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show("Los datos son obligatorios", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }//fin guardar click

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
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            formularioBuscarPaciente = new Frm_BuscarPaciente();
            formularioBuscarPaciente.Aceptar += new EventHandler(Aceptar);
            formularioBuscarPaciente.ShowDialog();
        }

        private void Frm_Pacientes_Load(object sender, EventArgs e)
        {
            try
            {
                cargarListaPacientes();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Aceptar(object id, EventArgs e)
        {
            try
            {
                int idCliente = (int)id;
                if (idCliente != -1)
                {
                    //MessageBox.Show(idCliente.ToString());
                    CargarPaciente(idCliente);
                }
                else
                {
                    Limpiar();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CargarPaciente(int id)
        {
            Entidad_Paciente paciente = new Entidad_Paciente();
            BL_Paciente traerPaciente = new BL_Paciente(Configuracion.getConnectionString);
            try
            {
                paciente = traerPaciente.ObtenerPaciente(id);
                if (paciente != null)
                {
                    txtID_Paciente.Text = paciente.IdPaciente.ToString();
                    txtNombre.Text = paciente.Nombre;
                    txtApellidos.Text = paciente.Apellidos;
                    txtCedula.Text = paciente.Cedula;
                    txtTelefono.Text = paciente.Telefono;
                    txtCorreo.Text = paciente.Correo;
                    txtDireccion.Text = paciente.Direccion;
                    txtFechaNacimiento.Text = paciente.FechaNacimiento.ToString();
                    //se asigna la entidad paciente local a la variable global clienteRegistrado
                    pacienteRegistrado = paciente;
                }
                else
                {
                    MessageBox.Show("el paciente nose encuentra en la base de datos", "aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    cargarListaPacientes();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void grdLista_DoubleClick(object sender, EventArgs e)
        {
            int id = 0;
            try
            {
                //se recupero el id
                id = (int)grdLista.SelectedRows[0].Cells[0].Value;
                //ya con el id recuperado se puede llamar a la funcion que carga el paciente desde la base de datos en el formulario
                CargarPaciente(id);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            Entidad_Paciente paciente;
            int resultado;
            BL_Paciente logica = new BL_Paciente(Configuracion.getConnectionString);
            try
            {
                if (!string.IsNullOrEmpty(txtID_Paciente.Text))
                {
                    //busca primero el paciente antees de borrarlo para ver si existe
                    paciente = logica.ObtenerPaciente(int.Parse(txtID_Paciente.Text));
                    if (paciente != null)
                    {
                        //si el paciente no es nulo puede borrarlo
                        resultado = logica.EliminarPaciente(paciente);
                        MessageBox.Show("Eliminado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        //imprime el msj que el sp mando
                        Limpiar();
                        cargarListaPacientes();
                    }
                    else
                    {
                        MessageBox.Show("El paciente no existe", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        Limpiar();
                        cargarListaPacientes();
                    }
                }
                else
                {
                    MessageBox.Show("Debe seleccionar un paciente antes de eliminar", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
