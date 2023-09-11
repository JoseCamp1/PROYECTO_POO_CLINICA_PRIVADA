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
    public partial class Frm_Citas : System.Web.UI.Page
    {
        //CARGAR DATOS
        String mensajeScript;
        public void cargarListaCitas(string condicion = "")
        {
            BL_Citas logica = new BL_Citas(Cls_Configuracion.getConnectionString);
            List<Entidad_Citas> citas;
            try
            {
                citas = logica.ListarCitas(condicion);
                if (citas.Count > 0)
                {
                    grdLista.DataSource = citas;
                }
                grdLista.DataBind();//necesario para que visualicen los datos
            }
            catch (Exception)
            {
                throw;
            }
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                if (!IsPostBack)
                {
                    cargarListaCitas();
                }
            }
            catch (Exception)
            {
                //throw;
            }
        }

        protected void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                string condicion = string.Format("ID_PACIENTE LIKE '%{0}%'", txtNombre.Text);
                cargarListaCitas(condicion);
            }
            catch (Exception ex)
            {
                mensajeScript = string.Format("javascript:mostrarMensaje('{0}')", ex.Message);
                ScriptManager.RegisterStartupScript(this, typeof(string), "MensajeRetorno", mensajeScript, true);
            }
        }

        protected void btnAgregar_Click(object sender, EventArgs e)
        {
            //eliminamos la variable de sesin, asi cuando el otro formulario pregunte si esta vacia
            //determinara que efectivamente esta vacia, lo cual significa que debamos
            //agregar un cliente nuevo
            Session.Remove("id_del_cita");
            //redireccionamos al otro formulario
            Response.Redirect("Frm_NuevaCita.aspx");
        }

        protected void btnRegresar_Click(object sender, EventArgs e)
        {
            Response.Redirect("Frm_MenuPrincipal.aspx");
        }

        protected void grdLista_PageIndexChanging1(object sender, GridViewPageEventArgs e)
        {
            grdLista.PageIndex = e.NewPageIndex;
            cargarListaCitas();
        }

        protected void InkModificar_Command(object sender, CommandEventArgs e)
        {
            //aqui vamos a asignar el valor de SESION y redireccionar la pagina
            //en el valor de SESION colocamos el valor que contenga el Command
            //(el ID del cliente ) al cual se le dio click
            Session["id_del_cita"] = e.CommandArgument.ToString();
            //redireccionamos al otro formulario(FrmClientes)
            Response.Redirect("Frm_NuevaCita.aspx");
        }

        protected void InkEliminar_Command(object sender, CommandEventArgs e)
        {
            int id = int.Parse(e.CommandArgument.ToString());
            BL_Citas logica = new BL_Citas(Cls_Configuracion.getConnectionString);
            Entidad_Citas cita;
            try
            {
                cita = logica.ObtenerCita(id);
                if (cita.Existe)
                {
                    if (logica.EliminarCita(cita) > 0)
                    {
                        mensajeScript = string.Format("javascript:mostrarMensaje('Cita eliminada con exito')");
                        ScriptManager.RegisterStartupScript(this, typeof(string), "MensajeRetorno", mensajeScript, true);
                        cargarListaCitas();
                        txtNombre.Text = "";
                    }
                    else
                    {
                        mensajeScript = string.Format("javascript:mostrarMensaje('{0}')", logica.Mensaje);
                        ScriptManager.RegisterStartupScript(this, typeof(string), "MensajeRetorno", mensajeScript, true);
                    }
                }
            }
            catch (Exception ex)
            {
                mensajeScript = string.Format("javascript:mostrarMensaje('{0}')", ex.Message);
                ScriptManager.RegisterStartupScript(this, typeof(string), "MensajeRetorno", mensajeScript, true);
            }
        }
    }
}