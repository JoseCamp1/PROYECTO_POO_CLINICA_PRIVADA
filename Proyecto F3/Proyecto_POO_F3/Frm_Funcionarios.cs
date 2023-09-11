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


        private void ListarDoctores(string condicion = "", string orden = "")
        {
            BL_Funcionario logica = new BL_Funcionario(Configuracion.getConnectionString);
            DataSet DSFuncionarios;
            try
            {
                DSFuncionarios = logica.ListarDoctores(condicion, orden);
                grdLista.DataSource = DSFuncionarios;
                grdLista.DataMember = DSFuncionarios.Tables["Funcionarios"].TableName;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ListarFuncionariosconEspecialidad(string condicion = "", string orden = "")
        {
            BL_Funcionario logica = new BL_Funcionario(Configuracion.getConnectionString);
            DataSet DSFuncionarios;
            try
            {
                DSFuncionarios = logica.ListarFuncionariosconEspecialidad(condicion, orden);
                grdLista.DataSource = DSFuncionarios;
                grdLista.DataMember = DSFuncionarios.Tables["Funcionarios"].TableName;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void cargarListaPuestosTrabajo(string condicion = "")
        {
            grdPuesto.Refresh();
            BL_PuestosTrabajo logica = new BL_PuestosTrabajo(Configuracion.getConnectionString);
            List<Entidad_PuestosTrabajo> puestosTrabajo;
            try
            {
                puestosTrabajo = logica.ListarPuestosTrabajo(condicion);
                if (puestosTrabajo.Count > 0)
                {
                    grdPuesto.DataSource = puestosTrabajo;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        public void cargarListaEspecialidades(string condicion = "")
        {
            grdEspecialidad.Refresh();
            BL_Especialidades logica = new BL_Especialidades(Configuracion.getConnectionString);
            List<Entidad_Especialidades> especialidades;
            try
            {
                especialidades = logica.ListarEspecialidades(condicion);
                if (especialidades.Count > 0)
                {
                    grdEspecialidad.DataSource = especialidades;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

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
            //funcionario.IdFuncionario = Convert.ToInt32(txtID_Funcionario.Text);
            funcionario.IdPuestoTrabajo = Convert.ToInt32(txt_ID_PUESTO_TRABAJO.Text);
            funcionario.IdEspecialidad = Convert.ToInt32(txtID_Especialidad.Text);
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
            txt_ID_PUESTO_TRABAJO.Text = string.Empty;
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
                    txt_ID_PUESTO_TRABAJO.Text = funcionario.IdPuestoTrabajo.ToString();
                    txtID_Especialidad.Text = funcionario.IdEspecialidad.ToString();
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
                if (!string.IsNullOrEmpty(txt_ID_PUESTO_TRABAJO.Text) && !string.IsNullOrEmpty(txtID_Especialidad.Text) && !string.IsNullOrEmpty(txtNombre.Text) && !string.IsNullOrEmpty(txtApellidos.Text) && !string.IsNullOrEmpty(txtCedula.Text) && !string.IsNullOrEmpty(txtTelefono.Text) && !string.IsNullOrEmpty(txtCorreo.Text) && !string.IsNullOrEmpty(txtDireccion.Text) && !string.IsNullOrEmpty(txtFechaNacimiento.Text))
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
                //verificarDoctor();
                cargarListaPuestosTrabajo();
                cargarListaFuncionarios();
                cargarListaEspecialidades();
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
                        MessageBox.Show("Eliminado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void grdEspecialidad_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // Asegurarse de que se haya hecho clic en una fila válida
            {
                DataGridViewRow row = grdEspecialidad.Rows[e.RowIndex];

                // Obtener el valor de la primera columna de la fila seleccionada
                string valor = row.Cells[0].Value.ToString();

                // Asignar el valor al TextBox
                txtID_Especialidad.Text = valor;
            }
        }

        private void grdPuesto_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // Asegurarse de que se haya hecho clic en una fila válida
            {
                DataGridViewRow row = grdPuesto.Rows[e.RowIndex];

                // Obtener el valor de la primera columna de la fila seleccionada
                string valor = row.Cells[0].Value.ToString();

                // Asignar el valor al TextBox
                txt_ID_PUESTO_TRABAJO.Text = valor;
            }
        }

        //private void verificarDoctor()
        //{
        //    if (txtID_Puesto.Text == "1")
        //    {
        //        grdEspecialidad.Enabled = false;
        //        cargarListaEspecialidades();
        //    }
        //    else
        //    {
        //        //txtID_Especialidad.Text = "1";
        //        grdEspecialidad.Enabled = true;
        //    }
        //}

        //private void txtID_Puesto_TextChanged(object sender, EventArgs e)
        //{
        //    //verificarDoctor();
        //}
    }
}
