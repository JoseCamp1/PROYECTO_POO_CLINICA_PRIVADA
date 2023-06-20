using Capa_Entidades;
using Capa02_LogicaNegocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Text;
using System.Windows.Forms;

namespace Capa01_Presentacion
{
    public partial class Frm_Citas : Form
    {
        public Frm_Citas()
        {
            InitializeComponent();
        }
        Frm_BuscarCitas formularioBuscarCita;

        // Variable global, esto si el campo txtIdCita.Text tiene algún idFuncionario, significa que la cita existe
        // No se debe insertar, se debe modificar
        Entidad_Citas citaRegistrada;

        private void ListarFuncionariosconEspecialidad(string condicion = "", string orden = "")
        {
            BL_Funcionario logica = new BL_Funcionario(Configuracion.getConnectionString);
            DataSet DSFuncionarios;
            try
            {
                DSFuncionarios = logica.ListarFuncionariosconEspecialidad(condicion, orden);
                grdEspecialista.DataSource = DSFuncionarios;
                grdEspecialista.DataMember = DSFuncionarios.Tables["Funcionarios"].TableName;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public Entidad_Citas GenerarEntidadCitas()
        {
            Entidad_Citas cita;
            if (!string.IsNullOrEmpty(txtID_Cita.Text))
            {
                cita = citaRegistrada;
            }
            else
            {
                cita = new Entidad_Citas();
            }
            cita.IdPaciente= Convert.ToInt32(txtID_Paciente.Text);
            cita.IdFuncionario = Convert.ToInt32(txtID_Funcionario.Text);
            cita.Motivo=txtMotivo.Text;
            cita.Fecha = dtp_Fecha.Value;
            cita.HoraInicio = TimeSpan.Parse(txtHoraInicio.Text);
            cita.HoraFin = TimeSpan.Parse(txtHoraFin.Text);
            return cita;
        }

        private void Limpiar()
        {
            txtID_Cita.Text = string.Empty;
            txtID_Funcionario.Text = string.Empty;
            dtp_Fecha.ResetText();
            txtHoraInicio.Text = string.Empty;
            txtHoraFin.Text = string.Empty;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Entidad_Citas cita = new Entidad_Citas();
            BL_Citas logica = new BL_Citas(Configuracion.getConnectionString);
            int resultado;
            try
            {
                if (!string.IsNullOrEmpty(txtID_Paciente.Text) && !string.IsNullOrEmpty(txtID_Funcionario.Text) && !string.IsNullOrEmpty(txtMotivo.Text) && !string.IsNullOrEmpty(txtHoraInicio.Text) && !string.IsNullOrEmpty(txtHoraFin.Text))
                {
                    cita = GenerarEntidadCitas();
                    if (!cita.Existe)
                    {
                        resultado = logica.InsertarCita(cita);
                    }
                    else
                    {
                        resultado = logica.ModificarCita(cita);
                    }
                    if (resultado > 0)
                    {
                        Limpiar();
                        MessageBox.Show("Operación realizada con éxito", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        cargarListaCitas();
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

        public void cargarListaCitas(string condicion = "")
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
            formularioBuscarCita = new Frm_BuscarCitas();
            formularioBuscarCita.Aceptar += new EventHandler(Aceptar);
            formularioBuscarCita.ShowDialog();
        }

        private void Aceptar(object id, EventArgs e)
        {
            try
            {
                int idCita = (int)id;
                if (idCita != -1)
                {
                    CargarCita(idCita);
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

        private void CargarCita(int id)
        {
            Entidad_Citas cita = new Entidad_Citas();
            BL_Citas traerCita = new BL_Citas(Configuracion.getConnectionString);
            try
            {
                cita = traerCita.ObtenerCita(id);
                if (cita != null)
                {
                    txtID_Cita.Text = cita.IdCita.ToString();
                    txtID_Paciente.Text = cita.IdPaciente.ToString();
                    txtID_Funcionario.Text = cita.IdFuncionario.ToString();
                    txtMotivo.Text = cita.Motivo.ToString();
                    dtp_Fecha.Text = cita.Fecha.ToString();
                    txtHoraInicio.Text = cita.HoraInicio.ToString();
                    txtHoraFin.Text = cita.HoraFin.ToString();
                    txtEstado.Text = cita.Estado.ToString();
                    citaRegistrada = cita;
                }
                else
                {
                    MessageBox.Show("La cita no se encuentra en la base de datos", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    cargarListaCitas();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            Entidad_Citas cita;
            int resultado;
            BL_Citas logica = new BL_Citas(Configuracion.getConnectionString);
            try
            {
                if (!string.IsNullOrEmpty(txtID_Cita.Text))
                {
                    cita = logica.ObtenerCita(int.Parse(txtID_Cita.Text));
                    if (cita != null)
                    {
                        resultado = logica.EliminarCita(cita);
                        MessageBox.Show("Eliminado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Limpiar();
                        cargarListaCitas();
                    }
                    else
                    {
                        MessageBox.Show("La cita no existe", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        Limpiar();
                        cargarListaCitas();
                    }
                }
                else
                {
                    MessageBox.Show("Debe seleccionar una cita antes de eliminar", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                CargarCita(id);
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
            try
            {
                cargarListaCitas();
                ListarFuncionariosconEspecialidad();
                cargarListaPacientes();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void cargarListaPacientes(string condicion = "")
        {
            grdPaciente.Refresh();
            BL_Paciente logica = new BL_Paciente(Configuracion.getConnectionString);
            List<Entidad_Paciente> paciente;
            try
            {
                paciente = logica.ListarPacientes(condicion);
                if (paciente.Count > 0)
                {
                    grdPaciente.DataSource = paciente;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void gdrPaciente_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // Asegurarse de que se haya hecho clic en una fila válida
            {
                DataGridViewRow row = grdPaciente.Rows[e.RowIndex];

                // Obtener el valor de la primera columna de la fila seleccionada
                string valor = row.Cells[0].Value.ToString();

                // Asignar el valor al TextBox
                txtID_Paciente.Text = valor;

            }
        }

        private void grdEspecialista_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // Asegurarse de que se haya hecho clic en una fila válida
            {
                DataGridViewRow row = grdEspecialista.Rows[e.RowIndex];

                // Obtener el valor de la primera columna de la fila seleccionada
                string valor = row.Cells[1].Value.ToString();
                DateTime valor1 = (DateTime)row.Cells[4].Value;
                string valor2 = row.Cells[5].Value.ToString();

                // Asignar el valor al TextBox
                txtID_Funcionario.Text = valor;
                dtp_Fecha.Value = valor1;
                txtHoraInicio.Text = valor2;
            }
        }

        private void txtHoraInicio_TextChanged(object sender, EventArgs e)
        {
            // Verificar si el texto en txtHoraInicio es válido
            if (!string.IsNullOrWhiteSpace(txtHoraInicio.Text))
            {
                // Intentar convertir el texto en un objeto DateTime
                if (DateTime.TryParseExact(txtHoraInicio.Text, "HH:mm:ss", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime horaInicio))
                {
                    // Sumar 30 minutos a la hora de inicio
                    DateTime horaFin = horaInicio.AddMinutes(30);
                    txtHoraFin.Text = horaFin.ToString("HH:mm:ss");
                }
                else
                {
                    // El formato de la hora de inicio no es válido
                    // Aquí puedes mostrar un mensaje de error o tomar alguna acción adecuada
                    // Por ejemplo, borrar el contenido de txtHoraFin si el formato es incorrecto
                    txtHoraFin.Text = string.Empty;
                }
            }
            else
            {
                // El campo de hora de inicio está vacío
                // Puedes tomar alguna acción si es necesario, como borrar el contenido de txtHoraFin
                txtHoraFin.Text = string.Empty;
            }
        }

        private void txtEstado_TextChanged(object sender, EventArgs e)
        {
            string estado = txtEstado.Text.Trim();

            if (estado.Length >= 3)
            {
                if (estado != "ACT" && estado != "INA" && estado != "PEN")
                {
                    MessageBox.Show("El estado ingresado no es válido. Debe ser 'ACT', 'INA' o 'PEN'.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtEstado.Text = string.Empty;
                }
            }
        }
    }
}
