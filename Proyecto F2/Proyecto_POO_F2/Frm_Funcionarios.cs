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
    public partial class Frm_Funcionarios : Form
    {
        public Frm_Funcionarios()
        {
            InitializeComponent();
        }
        Frm_BuscarFuncionario formularioBuscarFuncionario;

        // Variable global: si el campo txtIdFuncionario.Text tiene algún valor, significa que el funcionario existe y no se debe insertar sino modificar
        Entidad_Funcionario funcionarioRegistrado;

        public Entidad_Funcionario GenerarEntidadFuncionario()
        {
            Entidad_Funcionario funcionario;
            if (!string.IsNullOrEmpty(txtID_Funcionario.Text))
            {
                funcionario = funcionarioRegistrado;
            }
            else
            {
                funcionario = new Entidad_Funcionario();
            }
            funcionario.Nombre = txtNombre.Text;
            funcionario.Apellidos = txtApellidos.Text;
            funcionario.Cedula = txtCedula.Text;
            funcionario.Telefono = txtTelefono.Text;
            funcionario.Correo = txtCorreo.Text;
            funcionario.Direccion = txtDireccion.Text;
            funcionario.FechaNacimiento = DateTime.Parse(txtFechaNacimiento.Text);
            return funcionario;
        }

        private void Limpiar()
        {
            txtID_Funcionario.Text = string.Empty;
            txtNombre.Text = string.Empty;
            txtApellidos.Text = string.Empty;
            txtCedula.Text = string.Empty;
            txtTelefono.Text = string.Empty;
            txtCorreo.Text = string.Empty;
            txtDireccion.Text = string.Empty;
            txtFechaNacimiento.Text = string.Empty;
        }

        public void cargarListaFuncionarios(string condicion = "")
        {
            grdLista.Refresh();
            BL_Funcionario logica = new BL_Funcionario(Configuracion.getConnectionString);
            List<Entidad_Funcionario> funcionarios;
            try
            {
                funcionarios = logica.ListarFuncionarios(condicion);
                if (funcionarios.Count > 0)
                {
                    grdLista.DataSource = funcionarios;
                }
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
                int idFuncionario = (int)id;
                if (idFuncionario != -1)
                {
                    CargarFuncionario(idFuncionario);
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

        private void CargarFuncionario(int id)
        {
            Entidad_Funcionario funcionario = new Entidad_Funcionario();
            BL_Funcionario traerFuncionario = new BL_Funcionario(Configuracion.getConnectionString);
            try
            {
                funcionario = traerFuncionario.ObtenerFuncionario(id);
                if (funcionario != null)
                {
                    txtID_Funcionario.Text = funcionario.IdFuncionario.ToString();
                    txtNombre.Text = funcionario.Nombre;
                    txtApellidos.Text = funcionario.Apellidos;
                    txtCedula.Text = funcionario.Cedula;
                    txtTelefono.Text = funcionario.Telefono;
                    txtCorreo.Text = funcionario.Correo;
                    txtDireccion.Text = funcionario.Direccion;
                    txtFechaNacimiento.Text = funcionario.FechaNacimiento.ToString();
                    funcionarioRegistrado = funcionario;
                }
                else
                {
                    MessageBox.Show("El funcionario no se encuentra en la base de datos", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    cargarListaFuncionarios();
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

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Entidad_Funcionario funcionario = new Entidad_Funcionario();
            BL_Funcionario logica = new BL_Funcionario(Configuracion.getConnectionString);
            int resultado;
            try
            {
                if (!string.IsNullOrEmpty(txtNombre.Text) && !string.IsNullOrEmpty(txtApellidos.Text) && !string.IsNullOrEmpty(txtCedula.Text) && !string.IsNullOrEmpty(txtTelefono.Text) && !string.IsNullOrEmpty(txtCorreo.Text) && !string.IsNullOrEmpty(txtDireccion.Text) && !string.IsNullOrEmpty(txtFechaNacimiento.Text))
                {
                    funcionario = GenerarEntidadFuncionario();
                    if (!funcionario.Existe)
                    {
                        resultado = logica.InsertarFuncionario(funcionario);
                    }
                    else
                    {
                        resultado = logica.ModificarFuncionario(funcionario);
                    }
                    if (resultado > 0)
                    {
                        Limpiar();
                        MessageBox.Show("Operación realizada con éxito", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        cargarListaFuncionarios();
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

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            formularioBuscarFuncionario = new Frm_BuscarFuncionario();
            formularioBuscarFuncionario.Aceptar += new EventHandler(Aceptar);
            formularioBuscarFuncionario.ShowDialog();
        }

        private void Frm_Funcionarios_Load(object sender, EventArgs e)
        {
            try
            {
                cargarListaFuncionarios();
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
                id = (int)grdLista.SelectedRows[0].Cells[0].Value;
                CargarFuncionario(id);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            Entidad_Funcionario funcionario;
            int resultado;
            BL_Funcionario logica = new BL_Funcionario(Configuracion.getConnectionString);
            try
            {
                if (!string.IsNullOrEmpty(txtID_Funcionario.Text))
                {
                    funcionario = logica.ObtenerFuncionario(int.Parse(txtID_Funcionario.Text));
                    if (funcionario != null)
                    {
                        resultado = logica.EliminarFuncionario(funcionario);
                        MessageBox.Show("Eliminado","Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Limpiar();
                        cargarListaFuncionarios();
                    }
                    else
                    {
                        MessageBox.Show("El funcionario no existe", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        Limpiar();
                        cargarListaFuncionarios();
                    }
                }
                else
                {
                    MessageBox.Show("Debe seleccionar un funcionario antes de eliminar", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
