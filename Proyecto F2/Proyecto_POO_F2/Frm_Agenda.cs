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
    public partial class Frm_Agenda : Form
    {
        public Frm_Agenda()
        {
            InitializeComponent();
        }
        Frm_BuscarAgenda formularioBuscarAgenda;

        // Variable global, esto si el campo txtIdPuestoTrabajo.Text tiene algún idFuncionario, significa que el puesto de trabajo existe
        // No se debe insertar, se debe modificar
        Entidad_Agenda agendaRegistrada;

        public Entidad_Agenda GenerarEntidadAgenda()
        {
            Entidad_Agenda agenda;
            if (!string.IsNullOrEmpty(txtID_Agenda.Text))
            {
                agenda = agendaRegistrada;
            }
            else
            {
                agenda = new Entidad_Agenda();
            }
            agenda.IdFuncionario = Convert.ToInt32(txtID_Funcionario.Text);
            agenda.Fecha = dtp_Fecha.Value;
            agenda.HoraInicio = TimeSpan.Parse(txtHoraInicio.Text);
            agenda.HoraFin = TimeSpan.Parse(txtHoraFin.Text);
            return agenda;
        }

        private void Limpiar()
        {
            txtID_Agenda.Text = string.Empty;
            txtID_Funcionario.Text = string.Empty;
            dtp_Fecha.ResetText();
            txtHoraInicio.Text = string.Empty;
            txtHoraFin.Text = string.Empty;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Entidad_Agenda agenda = new Entidad_Agenda();
            BL_Agenda logica = new BL_Agenda(Configuracion.getConnectionString);
            int resultado;
            try
            {
                if (!string.IsNullOrEmpty(txtID_Funcionario.Text) && !string.IsNullOrEmpty(txtHoraInicio.Text) && !string.IsNullOrEmpty(txtHoraFin.Text))
                {
                    agenda = GenerarEntidadAgenda();
                    if (!agenda.Existe)
                    {
                        resultado = logica.InsertarAgenda(agenda);
                    }
                    else
                    {
                        resultado = logica.ModificarAgenda(agenda);
                    }
                    if (resultado > 0)
                    {
                        Limpiar();
                        MessageBox.Show("Operación realizada con éxito", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        cargarListaAgendas();
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

        public void cargarListaAgendas(string condicion = "")
        {
            grdLista.Refresh();
            BL_Agenda logica = new BL_Agenda(Configuracion.getConnectionString);
            List<Entidad_Agenda> agendas;
            try
            {
                agendas = logica.ListarAgendas(condicion);
                if (agendas.Count > 0)
                {
                    grdLista.DataSource = agendas;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            formularioBuscarAgenda = new Frm_BuscarAgenda();
            formularioBuscarAgenda.Aceptar += new EventHandler(Aceptar);
            formularioBuscarAgenda.ShowDialog();
        }

        private void Aceptar(object id, EventArgs e)
        {
            try
            {
                int idAgenda = (int)id;
                if (idAgenda != -1)
                {
                    CargarAgenda(idAgenda);
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

        private void CargarAgenda(int id)
        {
            Entidad_Agenda agenda = new Entidad_Agenda();
            BL_Agenda traerAgenda = new BL_Agenda(Configuracion.getConnectionString);
            try
            {
                agenda = traerAgenda.ObtenerAgenda(id);
                if (agenda != null)
                {
                    txtID_Agenda.Text = agenda.IdAgenda.ToString();
                    txtID_Funcionario.Text = agenda.IdFuncionario.ToString();
                    dtp_Fecha.Text = agenda.Fecha.ToString();
                    txtHoraInicio.Text = agenda.HoraInicio.ToString();
                    txtHoraFin.Text = agenda.HoraFin.ToString();
                    agendaRegistrada = agenda;
                }
                else
                {
                    MessageBox.Show("La agenda no se encuentra en la base de datos", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    cargarListaAgendas();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            Entidad_Agenda agenda;
            int resultado;
            BL_Agenda logica = new BL_Agenda(Configuracion.getConnectionString);
            try
            {
                if (!string.IsNullOrEmpty(txtID_Agenda.Text))
                {
                    agenda = logica.ObtenerAgenda(int.Parse(txtID_Agenda.Text));
                    if (agenda != null)
                    {
                        resultado = logica.EliminarAgenda(agenda);
                        MessageBox.Show("Eliminado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Limpiar();
                        cargarListaAgendas();
                    }
                    else
                    {
                        MessageBox.Show("La agenda no existe", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        Limpiar();
                        cargarListaAgendas();
                    }
                }
                else
                {
                    MessageBox.Show("Debe seleccionar una agenda antes de eliminar", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                CargarAgenda(id);
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

        private void Frm_Agenda_Load(object sender, EventArgs e)
        {
            try
            {
                cargarListaAgendas();
                ListarDoctores();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ListarDoctores(string condicion = "", string orden = "")
        {
            BL_Funcionario logica = new BL_Funcionario(Configuracion.getConnectionString);
            DataSet DSFuncionarios;
            try
            {
                DSFuncionarios = logica.ListarDoctores(condicion, orden);
                grdEspecialista.DataSource = DSFuncionarios;
                grdEspecialista.DataMember = DSFuncionarios.Tables["Funcionarios"].TableName;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void grdEspecialista_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0) // Asegurarse de que se haya hecho clic en una celda válida
            {
                DataGridViewCell cell = grdEspecialista.Rows[e.RowIndex].Cells[e.ColumnIndex];
                if (cell.Value != null) // Verificar si la celda tiene un valor
                {
                    string valor = cell.Value.ToString();
                    txtID_Funcionario.Text = valor;
                }
                else
                {
                    // La celda está vacía, puedes mostrar un mensaje de error o realizar otra acción apropiada.
                    MessageBox.Show("La celda seleccionada está vacía.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
