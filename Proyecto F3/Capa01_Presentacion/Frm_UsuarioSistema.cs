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
    public partial class Frm_UsuarioSistema : Form
    {
        public Frm_UsuarioSistema()
        {
            InitializeComponent();
        }

        //Variable global para ir al formulario buscar
        Frm_BuscarUsuarioSistema formularioBuscarUsuario;

        // Variable global, esto si el campo txtIdCita.Text tiene algún idFuncionario, significa que la usuarioSistema existe
        // No se debe insertar, se debe modificar
        Entidad_UsuarioSistema usuarioRegistrado;

        public void cargarListaFuncionarios(string condicion = "")
        {
            grdLista2.Refresh();
            BL_Funcionario logica = new BL_Funcionario(Configuracion.getConnectionString);
            List<Entidad_Funcionario> funcionarios;
            try
            {
                funcionarios = logica.ListarFuncionarios(condicion);
                if (funcionarios.Count > 0)
                {
                    grdLista2.DataSource = funcionarios;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public Entidad_UsuarioSistema GenerarEntidadUsuarioSistema()
        {
            Entidad_UsuarioSistema cita;
            if (!string.IsNullOrEmpty(txtID_UsuarioSistema.Text))
            {
                cita = usuarioRegistrado;
            }
            else
            {
                cita = new Entidad_UsuarioSistema();
            }
            cita.IdFuncionario = Convert.ToInt32(txtID_Funcionario.Text);
            cita.Correo = txtCorreo.Text;
            cita.Usuario = txtUsuario.Text;
            cita.Contrasena = txtContrasena.Text;
            return cita;
        }

        private void Limpiar()
        {
            txtID_UsuarioSistema.Text = string.Empty;
            txtID_Funcionario.Text = string.Empty;
            txtCorreo.Text = string.Empty;
            txtUsuario.Text = string.Empty;
            txtContrasena.Text = string.Empty;
        }

        public void cargarListaUsuariosSistema(string condicion = "")
        {
            grdLista.Refresh();
            BL_UsuarioSistema logica = new BL_UsuarioSistema(Configuracion.getConnectionString);
            List<Entidad_UsuarioSistema> usuarioSistema;
            try
            {
                usuarioSistema = logica.ListarUsuariosSistema(condicion);
                if (usuarioSistema.Count > 0)
                {
                    grdLista.DataSource = usuarioSistema;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Entidad_UsuarioSistema usuarioSistema = new Entidad_UsuarioSistema();
            BL_UsuarioSistema logica = new BL_UsuarioSistema(Configuracion.getConnectionString);
            int resultado;
            try
            {
                if (!string.IsNullOrEmpty(txtID_Funcionario.Text) && !string.IsNullOrEmpty(txtCorreo.Text) && !string.IsNullOrEmpty(txtUsuario.Text) && !string.IsNullOrEmpty(txtContrasena.Text))
                {
                    usuarioSistema = GenerarEntidadUsuarioSistema();
                    if (!usuarioSistema.Existe)
                    {
                        resultado = logica.InsertarUsuarioSistema(usuarioSistema);
                    }
                    else
                    {
                        resultado = logica.ModificarUsuarioSistema(usuarioSistema);
                    }
                    if (resultado > 0)
                    {
                        Limpiar();
                        MessageBox.Show("Operación realizada con éxito", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        cargarListaUsuariosSistema();
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
            formularioBuscarUsuario = new Frm_BuscarUsuarioSistema();
            formularioBuscarUsuario.Aceptar += new EventHandler(Aceptar);
            formularioBuscarUsuario.ShowDialog();
        }

        private void CargarUsuario(int id)
        {
            Entidad_UsuarioSistema cita = new Entidad_UsuarioSistema();
            BL_UsuarioSistema traerCita = new BL_UsuarioSistema(Configuracion.getConnectionString);
            try
            {
                cita = traerCita.ObtenerUsuarioSistema(id);
                if (cita != null)
                {
                    txtID_UsuarioSistema.Text = cita.IdUsuarioSistema.ToString();
                    txtID_Funcionario.Text = cita.IdFuncionario.ToString();
                    txtCorreo.Text = cita.Correo.ToString();
                    txtUsuario.Text = cita.Usuario.ToString();
                    txtContrasena.Text = cita.Contrasena.ToString();
                    usuarioRegistrado = cita;
                }
                else
                {
                    MessageBox.Show("La usuarioSistema no se encuentra en la base de datos", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    cargarListaUsuariosSistema();
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
                int idUsuarioSistema = (int)id;
                if (idUsuarioSistema != -1)
                {
                    CargarUsuario(idUsuarioSistema);
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

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            Entidad_UsuarioSistema usuarioSistema;
            int resultado;
            BL_UsuarioSistema logica = new BL_UsuarioSistema(Configuracion.getConnectionString);
            try
            {
                if (!string.IsNullOrEmpty(txtID_UsuarioSistema.Text))
                {
                    usuarioSistema = logica.ObtenerUsuarioSistema(int.Parse(txtID_UsuarioSistema.Text));
                    if (usuarioSistema != null)
                    {
                        resultado = logica.EliminarUsuarioSistema(usuarioSistema);
                        MessageBox.Show("Eliminado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Limpiar();
                        cargarListaUsuariosSistema();
                    }
                    else
                    {
                        MessageBox.Show("La usuarioSistema no existe", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        Limpiar();
                        cargarListaUsuariosSistema();
                    }
                }
                else
                {
                    MessageBox.Show("Debe seleccionar una usuarioSistema antes de eliminar", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                CargarUsuario(id);
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

        private void Frm_Citas_Load(object sender, EventArgs e)
        {

        }

        private void Frm_UsuarioSistema_Load(object sender, EventArgs e)
        {
            try
            {
                cargarListaUsuariosSistema();
                cargarListaFuncionarios();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void grdLista2_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // Asegurarse de que se haya hecho clic en una fila válida
            {
                DataGridViewRow row = grdLista2.Rows[e.RowIndex];

                // Obtener el id de la primera columna de la fila seleccionada
                string id = row.Cells[0].Value.ToString();
                string correo = row.Cells[7].Value.ToString();

                // Asignar el id al TextBox
                txtID_Funcionario.Text = id;
                txtCorreo.Text = correo;
            }
        }
    }
}
