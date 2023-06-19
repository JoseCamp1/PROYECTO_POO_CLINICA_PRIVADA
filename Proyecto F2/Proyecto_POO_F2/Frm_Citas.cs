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

        //public void cargarListaFuncionarios(string condicion = "")
        //{
        //    grdFuncionario.Refresh();
        //    BL_Funcionario logica = new BL_Funcionario(Configuracion.getConnectionString);
        //    List<Entidad_Funcionario> funcionarios;
        //    try
        //    {
        //        funcionarios = logica.ListarFuncionarios(condicion);
        //        if (funcionarios.Count > 0)
        //        {
        //            grdFuncionario.DataSource = funcionarios;
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //    }
        //}

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
            cita.IdFuncionario = Convert.ToInt32(txtID_Funcionario.Text);
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
                if (!string.IsNullOrEmpty(txtID_Funcionario.Text) && !string.IsNullOrEmpty(txtHoraInicio.Text) && !string.IsNullOrEmpty(txtHoraFin.Text))
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
                //cargarListaFuncionarios();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //private void grdFuncionario_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        //{
        //    if (e.RowIndex >= 0) // Asegurarse de que se haya hecho clic en una fila válida
        //    {
        //        DataGridViewRow row = grdFuncionario.Rows[e.RowIndex];

        //        string puestoTrabajo = row.Cells[9].Value.ToString(); // Valor de la columna 9 (Puesto de trabajo)
        //        string idEspecialidad = row.Cells[10].Value.ToString(); // Valor de la columna 10 (ID Especialidad)
        //        string valor = row.Cells[0].Value.ToString(); // Valor de la columna 0 (idfuncionario)

        //        if (puestoTrabajo == "1")
        //        {
        //            MessageBox.Show("Es médico");
        //            if (idEspecialidad != "1")
        //            {
        //                MessageBox.Show("Tiene una especialidad");
        //                txtID_Funcionario.Text = valor;
        //            }
        //            else
        //            {
        //                MessageBox.Show("No tiene una especialidad");
        //            }
        //        }
        //        else
        //        {
        //            MessageBox.Show("No es médico");
        //        }
        //    }
        //}
    }
}
