using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Windows;
using System.Data;
using Capa02_LogicaNegocio;
using Capa_Entidades;


using System.ComponentModel;

using System.Drawing;
using System.Globalization;
using System.Text;


namespace Capa01_Aplicacion_Web
{
    public partial class Frm_NuevaCita : System.Web.UI.Page
    {
        //CARGAR DATOS
        string MensajeScript;

        public void Limpiar()
        {
            txtId.Text = "";
            txtIdPaciente.Text = string.Empty;
            txtIdFuncionario.Text = string.Empty;
            txtMotivo.Text = string.Empty;
            txtFecha.Text = string.Empty;
            txtHoraInicio.Text = string.Empty;
            txtHoraFin.Text = string.Empty;
            txtEstado.Text = string.Empty;

        }
        protected void Page_Load(object sender, EventArgs e)
        {
            ListarFuncionariosconEspecialidad();
            cargarListaPacientes();
            Entidad_Citas cita;
            BL_Citas logica = new BL_Citas(Cls_Configuracion.getConnectionString);
            int identificacion;
            try
            {
                if (!Page.IsPostBack)
                {
                    //EI ID es un dato que se genera en el otro formulario
                    //Se pueden enviar datos de un formulario a otro por QueryString o por SESION(existe muchas otras
                    //formas de enviar datos entre päginas Web)
                    //Lo enviaremos por sesiön, vamos a preguntar si lo que viene por sesiön trae algo

                    //Funcionamiento:
                    //EI formulario Default le enviarå por SESION un valor al formulario FrmClientes,
                    //esto permite que de un formulario enviemos valores hasta otro formulario.
                    //En este formulario(FrmClientes) estamos preguntando si en el valor de SESION existe algün valor
                    //llamado "id_del_cliente"
                    //Esto implica que desde el formulario Default(o cualquier otro formulario que invoque a FrmC1ientes)
                    //debemos crear una Variable de SESION y llamarla "id_del_cliente" asignåndole el ID que corresponda.
                    if (Session["id_del_cita"] != null)
                    {
                        identificacion = int.Parse(Session["id_del_cita"].ToString());
                        cita = logica.ObtenerCita(identificacion);
                        if (cita.Existe)
                        {
                            txtId.Text = cita.IdCita.ToString();
                            txtIdPaciente.Text = cita.IdPaciente.ToString();
                            txtIdFuncionario.Text = cita.IdFuncionario.ToString();
                            txtMotivo.Text = cita.Motivo;
                            txtFecha.Text = cita.Fecha.ToString();
                            txtHoraInicio.Text = cita.HoraInicio.ToString();
                            txtHoraFin.Text = cita.HoraFin.ToString();
                            txtEstado.Text = cita.Estado;                            

                            lblid.Visible = true;
                            txtId.Visible = true;
                        }
                        else
                        {
                            MensajeScript = string.Format("javascript:mostrarMensaje" + "('Cita no encontrada')");
                            ScriptManager.RegisterStartupScript(this, typeof(string), "MensajeRetorno", MensajeScript, true);
                        }
                    }
                    else
                    {
                        Limpiar();
                        txtId.Text = "-1";
                        lblid.Visible = false;
                        txtId.Visible = false;
                    }
                }
            }
            catch (Exception ex)
            {
                MensajeScript = string.Format("javascript:mostrarMensaje('{0}')", ex.Message);
                ScriptManager.RegisterStartupScript(this, typeof(string), "MensajeRetorno", MensajeScript, true);
                Response.Redirect("Frm_MenuCitas.aspx");
            }
        }

        private Entidad_Citas GenerarEntidadCita()
        {
            Entidad_Citas cita = new Entidad_Citas();
            // si hay algo en la variable de sesion
            if (Session["id_del_cita"] != null)
            {
                cita.IdCita = int.Parse(Session["id_del_cita"].ToString());
                cita.Existe = true;
            }
            //si no hay nada en la variable de sesion, es un cita nuevo
            else
            {
                cita.IdCita = -1;
                cita.Existe = false;
            }
            //los demas datos siempre se toman de los cuadros de texto
            cita.IdPaciente = int.Parse(txtIdPaciente.Text);
            cita.IdFuncionario = int.Parse(txtIdFuncionario.Text);
            cita.Motivo = txtMotivo.Text;
            cita.Fecha = DateTime.Parse(txtFecha.Text);
            cita.HoraInicio= TimeSpan.Parse(txtHoraInicio.Text);
            cita.HoraFin = TimeSpan.Parse(txtHoraFin.Text);
            cita.Estado = txtEstado.Text;            
            return cita;
        }

        protected void btnGuardar_Click(object sender, EventArgs e)
        {
            Entidad_Citas cita;
            BL_Citas logica = new BL_Citas(Cls_Configuracion.getConnectionString);
            int resultado;
            try
            {
                cita = GenerarEntidadCita();
                //si el cita ya existe , se modifica 
                if (cita.Existe)
                {
                    resultado = logica.ModificarCita(cita);
                }
                //si el cita no existe se crea
                else
                {
                    if (!string.IsNullOrEmpty(txtIdPaciente.Text))
                    {
                        resultado = logica.InsertarCita(cita);
                    }
                    else
                    {
                        MensajeScript = string.Format("javascript:mostrarMensaje" + "('Debe agregar almenos id del paciente')");
                        ScriptManager.RegisterStartupScript(this, typeof(string), "MensajeRetorno", MensajeScript, true);
                        resultado = -1;
                    }
                }
                if (resultado > 0)
                {
                    MensajeScript = string.Format("javascript:mostrarMensaje" + "('Operacion realizada satisfactoriamente')");
                    ScriptManager.RegisterStartupScript(this, typeof(string), "MensajeRetorno", MensajeScript, true);
                    Response.Redirect("Frm_MenuCitas.aspx");
                }
                else
                {
                    MensajeScript = string.Format("javascript:mostrarMensaje" + "('No se pudo ejecutar la operacion')");
                    ScriptManager.RegisterStartupScript(this, typeof(string), "MensajeRetorno", MensajeScript, true);
                }
            }
            catch (Exception ex)
            {
                MensajeScript = string.Format("javascript:mostrarMensaje('{0}')", ex.Message);
                ScriptManager.RegisterStartupScript(this, typeof(string), "MensajeRetorno", MensajeScript, true);
            }
        }

        protected void btnCancelar_Click(object sender, EventArgs e)
        {
            Response.Redirect("Frm_MenuCitas.aspx");
        }

        private void ListarFuncionariosconEspecialidad(string condicion = "", string orden = "")
        {
            BL_Funcionario logica = new BL_Funcionario(Cls_Configuracion.getConnectionString);
            DataSet DSFuncionarios;
            try
            {
                DSFuncionarios = logica.ListarFuncionariosconEspecialidad(condicion, orden);
                grdEspecialista.DataSource = DSFuncionarios;
                grdEspecialista.DataMember = DSFuncionarios.Tables[0].TableName;
                grdEspecialista.DataBind();//necesario para que visualicen los datos
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void cargarListaPacientes(string condicion = "")
        {
            BL_Paciente logica = new BL_Paciente(Cls_Configuracion.getConnectionString);
            List<Entidad_Paciente> paciente;
            try
            {
                paciente = logica.ListarPacientes(condicion);
                if (paciente.Count > 0)
                {
                    grdPacientes.DataSource = paciente;
                }
                grdPacientes.DataBind();//necesario para que visualicen los datos
            }
            catch (Exception)
            {
                throw;
            }
        }

        protected void InkIdFuncionario_Command(object sender, CommandEventArgs e)
        {
            txtIdFuncionario.Text = e.CommandArgument.ToString();
        }

        protected void InkIdPaciente_Command(object sender, CommandEventArgs e)
        {
            txtIdPaciente.Text = e.CommandArgument.ToString();
        }

        protected void grdEspecialista_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            grdEspecialista.PageIndex = e.NewPageIndex;
            ListarFuncionariosconEspecialidad();
        }

        protected void grdPacientes_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            grdPacientes.PageIndex = e.NewPageIndex;
            cargarListaPacientes();
        }

        protected void txtHoraInicio_TextChanged(object sender, EventArgs e)
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

        protected void txtFecha_TextChanged(object sender, EventArgs e)
        {
            DateTime fechaSeleccionada = DateTime.Parse(txtFecha.Text); // Obtener solo la fecha, sin la hora

            // Obtener la fecha actual sin la hora
            DateTime fechaActual = DateTime.Now.Date;

            // Comparar la fecha seleccionada con la fecha actual
            if (fechaSeleccionada < fechaActual)
            {
                txtEstado.Text = "INA"; // La fecha ya pasó
            }
            else if (fechaSeleccionada > fechaActual)
            {
                txtEstado.Text = "ACT"; // La fecha está en el futuro
            }
            else
            {
                //txtEstado.Text = "PEN"; // La fecha es hoy
                txtEstado.Text = "ACT";
            }
        }
    }
}