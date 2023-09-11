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
    public partial class Frm_NuevoPuestoTrabajo : System.Web.UI.Page
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
            Entidad_PuestosTrabajo puestoTrabajo;
            BL_PuestosTrabajo logica = new BL_PuestosTrabajo(Cls_Configuracion.getConnectionString);
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
                    if (Session["id_del_puestotrabajo"] != null)
                    {
                        identificacion = int.Parse(Session["id_del_puestotrabajo"].ToString());
                        puestoTrabajo = logica.ObtenerPuestosTrabajo(identificacion);
                        if (puestoTrabajo.Existe)
                        {
                            txtId.Text = puestoTrabajo.IdPuestoTrabajo.ToString();
                            txtNombre.Text = puestoTrabajo.Nombre;
                            txtDescripcion.Text = puestoTrabajo.Descripcion;                         

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

        private Entidad_PuestosTrabajo GenerarPuestoTrabajo()
        {
            Entidad_PuestosTrabajo puestoTrabajo = new Entidad_PuestosTrabajo();
            // si hay algo en la variable de sesion
            if (Session["id_del_puestotrabajo"] != null)
            {
                puestoTrabajo.IdPuestoTrabajo = int.Parse(Session["id_del_puestotrabajo"].ToString());
                puestoTrabajo.Existe = true;
            }
            //si no hay nada en la variable de sesion, es un puestoTrabajo nuevo
            else
            {
                puestoTrabajo.IdPuestoTrabajo = -1;
                puestoTrabajo.Existe = false;
            }
            //los demas datos siempre se toman de los cuadros de texto
            puestoTrabajo.Nombre = txtNombre.Text;
            puestoTrabajo.Descripcion = txtDescripcion.Text;            
            return puestoTrabajo;
        }

        protected void btnGuardar_Click(object sender, EventArgs e)
        {
            Entidad_PuestosTrabajo puestoTrabajo;
            BL_PuestosTrabajo logica = new BL_PuestosTrabajo(Cls_Configuracion.getConnectionString);
            int resultado;
            try
            {
                puestoTrabajo = GenerarPuestoTrabajo();
                //si el puestoTrabajo ya existe , se modifica 
                if (puestoTrabajo.Existe)
                {
                    resultado = logica.ModificarPuestosTrabajo(puestoTrabajo);
                }
                //si el puestoTrabajo no existe se crea
                else
                {
                    if (!string.IsNullOrEmpty(txtNombre.Text))
                    {
                        resultado = logica.InsertarPuestosTrabajo(puestoTrabajo);
                    }
                    else
                    {
                        MensajeScript = string.Format("javascript:mostrarMensaje" + "('Debe agregar almenos el nombre del puestoTrabajo')");
                        ScriptManager.RegisterStartupScript(this, typeof(string), "MensajeRetorno", MensajeScript, true);
                        resultado = -1;
                    }
                }
                if (resultado > 0)
                {
                    MensajeScript = string.Format("javascript:mostrarMensaje" + "('Operacion realizada satisfactoriamente')");
                    ScriptManager.RegisterStartupScript(this, typeof(string), "MensajeRetorno", MensajeScript, true);
                    Response.Redirect("Frm_MenuPuestosTrabajo.aspx");
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
            Response.Redirect("Frm_MenuPuestosTrabajo.aspx");
        }
    }
}