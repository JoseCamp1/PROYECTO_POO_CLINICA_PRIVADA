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

namespace Capa01_Aplicacion_Web
{
    public partial class Frm_NuevoPaciente : System.Web.UI.Page
    {
        string MensajeScript;

        public void Limpiar()
        {
            txtId.Text = "";
            txtNombre.Text = "";
            txtApellidos.Text = string.Empty;
            txtCedula.Text = string.Empty;
            txtTelefono.Text = string.Empty;
            txtCorreo.Text = string.Empty;
            txtDireccion.Text = "";
            txtFechaNacimiento.Text = string.Empty;            
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            Entidad_Paciente paciente;
            BL_Paciente logica = new BL_Paciente(Cls_Configuracion.getConnectionString);
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
                    if (Session["id_del_paciente"] != null)
                    {
                        identificacion = int.Parse(Session["id_del_paciente"].ToString());
                        paciente = logica.ObtenerPaciente(identificacion);
                        if (paciente.Existe)
                        {
                            txtId.Text = paciente.IdPaciente.ToString();
                            txtNombre.Text = paciente.Nombre;
                            txtApellidos.Text = paciente.Apellidos;
                            txtCedula.Text = paciente.Cedula;
                            txtTelefono.Text = paciente.Telefono;
                            txtCorreo.Text = paciente.Correo;
                            txtDireccion.Text = paciente.Direccion;
                            txtFechaNacimiento.Text = paciente.FechaNacimiento.ToString("yyyy-MM-dd");

                            lblid.Visible = true;
                            txtId.Visible = true;
                        }
                        else
                        {
                            MensajeScript = string.Format("javascript:mostrarMensaje" + "('Cliente no encontrado')");
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
                Response.Redirect("Frm_MenuPacientes.aspx");
            }
        }

        private Entidad_Paciente GenerarEntidadPaciente()
        {
            Entidad_Paciente paciente = new Entidad_Paciente();
            // si hay algo en la variable de sesion
            if (Session["id_del_paciente"] != null)
            {
                paciente.IdPaciente = int.Parse(Session["id_del_paciente"].ToString());
                paciente.Existe = true;
            }
            //si no hay nada en la variable de sesion, es un paciente nuevo
            else
            {
                paciente.IdPaciente = -1;
                paciente.Existe = false;
            }
            //los demas datos siempre se toman de los cuadros de texto
            paciente.Nombre = txtNombre.Text;
            paciente.Apellidos = txtApellidos.Text;
            paciente.Cedula = txtCedula.Text;
            paciente.Telefono = txtTelefono.Text;
            paciente.Correo = txtCorreo.Text;
            paciente.Direccion = txtDireccion.Text;
            paciente.FechaNacimiento = DateTime.Parse(txtFechaNacimiento.Text);
            return paciente;
        }

        protected void btnCancelar_Click(object sender, EventArgs e)
        {
            Response.Redirect("Frm_MenuPacientes.aspx");
        }

        protected void btnGuardar_Click(object sender, EventArgs e)
        {
            Entidad_Paciente paciente;
            BL_Paciente logica = new BL_Paciente(Cls_Configuracion.getConnectionString);
            int resultado;
            try
            {
                paciente = GenerarEntidadPaciente();
                //si el paciente ya existe , se modifica 
                if (paciente.Existe)
                {
                    resultado = logica.ModificarPaciente(paciente);
                }
                //si el paciente no existe se crea
                else
                {
                    if (!string.IsNullOrEmpty(txtNombre.Text))
                    {
                        resultado = logica.InsertarPaciente(paciente);
                    }
                    else
                    {
                        MensajeScript = string.Format("javascript:mostrarMensaje" + "('Debe agregar almenos el nombre del paciente')");
                        ScriptManager.RegisterStartupScript(this, typeof(string), "MensajeRetorno", MensajeScript, true);
                        resultado = -1;
                    }
                }
                if (resultado > 0)
                {
                    MensajeScript = string.Format("javascript:mostrarMensaje" + "('Operacion realizada satisfactoriamente')");
                    ScriptManager.RegisterStartupScript(this, typeof(string), "MensajeRetorno", MensajeScript, true);
                    Response.Redirect("Frm_MenuPacientes.aspx");
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
    }
}