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
    public partial class Frm_NuevaEspecialidad : System.Web.UI.Page
    {
        //CARGAR DATOS
        string MensajeScript;
        public void Limpiar()
        {
            txtId.Text = "";
            txtNombre.Text = "";
            txtDescripcion.Text = string.Empty;
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            Entidad_Especialidades especialidad;
            BL_Especialidades logica = new BL_Especialidades(Cls_Configuracion.getConnectionString);
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
                    if (Session["id_del_especialidad"] != null)
                    {
                        identificacion = int.Parse(Session["id_del_especialidad"].ToString());
                        especialidad = logica.ObtenerEspecialidad(identificacion);
                        if (especialidad.Existe)
                        {
                            txtId.Text = especialidad.IdEspecialidad.ToString();
                            txtNombre.Text = especialidad.Nombre;
                            txtDescripcion.Text = especialidad.Descripcion;

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
                Response.Redirect("Frm_MenuPuestosTrabajo.aspx");
            }
        }

        private Entidad_Especialidades GenerarEspecialidad()
        {
            Entidad_Especialidades especialidad = new Entidad_Especialidades();
            // si hay algo en la variable de sesion
            if (Session["id_del_especialidad"] != null)
            {
                especialidad.IdEspecialidad = int.Parse(Session["id_del_especialidad"].ToString());
                especialidad.Existe = true;
            }
            //si no hay nada en la variable de sesion, es un especialidad nuevo
            else
            {
                especialidad.IdEspecialidad = -1;
                especialidad.Existe = false;
            }
            //los demas datos siempre se toman de los cuadros de texto
            especialidad.Nombre = txtNombre.Text;
            especialidad.Descripcion = txtDescripcion.Text;
            return especialidad;
        }

        protected void btnGuardar_Click(object sender, EventArgs e)
        {
            Entidad_Especialidades especialidad;
            BL_Especialidades logica = new BL_Especialidades(Cls_Configuracion.getConnectionString);
            int resultado;
            try
            {
                especialidad = GenerarEspecialidad();
                //si el especialidad ya existe , se modifica 
                if (especialidad.Existe)
                {
                    resultado = logica.ModificarEspecialidad(especialidad);
                }
                //si el especialidad no existe se crea
                else
                {
                    if (!string.IsNullOrEmpty(txtNombre.Text))
                    {
                        resultado = logica.InsertarEspecialidad(especialidad);
                    }
                    else
                    {
                        MensajeScript = string.Format("javascript:mostrarMensaje" + "('Debe agregar almenos el nombre del especialidad')");
                        ScriptManager.RegisterStartupScript(this, typeof(string), "MensajeRetorno", MensajeScript, true);
                        resultado = -1;
                    }
                }
                if (resultado > 0)
                {
                    MensajeScript = string.Format("javascript:mostrarMensaje" + "('Operacion realizada satisfactoriamente')");
                    ScriptManager.RegisterStartupScript(this, typeof(string), "MensajeRetorno", MensajeScript, true);
                    Response.Redirect("Frm_MenuEspecialidades.aspx");
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
            Response.Redirect("Frm_MenuEspecialidades.aspx");
        }
    }
}