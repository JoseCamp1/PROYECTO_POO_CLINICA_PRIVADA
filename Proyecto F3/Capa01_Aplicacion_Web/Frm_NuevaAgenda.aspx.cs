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
    public partial class Frm_NuevaAgenda : System.Web.UI.Page
    {
        //CARGAR DATOS
        string MensajeScript;

        public void Limpiar()
        {
            txtId.Text = "";
            txtIdFuncionario.Text = string.Empty;
            txtFecha.Text = string.Empty;
            txtHoraInicio.Text = string.Empty;
            txtHoraFin.Text = string.Empty;
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            ListarDoctores();
            Entidad_Agenda agenda;
            BL_Agenda logica = new BL_Agenda(Cls_Configuracion.getConnectionString);
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
                    if (Session["id_del_agenda"] != null)
                    {
                        identificacion = int.Parse(Session["id_del_agenda"].ToString());
                        agenda = logica.ObtenerAgenda(identificacion);
                        if (agenda.Existe)
                        {
                            txtId.Text = agenda.IdAgenda.ToString();
                            txtIdFuncionario.Text = agenda.IdFuncionario.ToString();
                            txtFecha.Text = agenda.Fecha.ToString();
                            txtHoraInicio.Text = agenda.HoraInicio.ToString();
                            txtHoraFin.Text = agenda.HoraFin.ToString();                            

                            lblid.Visible = true;
                            txtId.Visible = true;
                        }
                        else
                        {
                            MensajeScript = string.Format("javascript:mostrarMensaje" + "('Agenda no encontrada')");
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
                Response.Redirect("Frm_MenuAgenda.aspx");
            }
        }

        private Entidad_Agenda GenerarEntidadAgenda()
        {
            Entidad_Agenda agenda = new Entidad_Agenda();
            // si hay algo en la variable de sesion
            if (Session["id_del_agenda"] != null)
            {
                agenda.IdAgenda = int.Parse(Session["id_del_agenda"].ToString());
                agenda.Existe = true;
            }
            //si no hay nada en la variable de sesion, es un agenda nuevo
            else
            {
                agenda.IdAgenda = -1;
                agenda.Existe = false;
            }
            //los demas datos siempre se toman de los cuadros de texto
            agenda.IdFuncionario = int.Parse(txtIdFuncionario.Text);
            agenda.Fecha = DateTime.Parse(txtFecha.Text);            
            agenda.HoraInicio = TimeSpan.Parse(txtHoraInicio.Text);
            agenda.HoraFin = TimeSpan.Parse(txtHoraFin.Text);            
            return agenda;
        }

        protected void btnGuardar_Click(object sender, EventArgs e)
        {
            Entidad_Agenda agenda;
            BL_Agenda logica = new BL_Agenda(Cls_Configuracion.getConnectionString);
            int resultado;
            try
            {
                agenda = GenerarEntidadAgenda();
                //si el agenda ya existe , se modifica 
                if (agenda.Existe)
                {
                    resultado = logica.ModificarAgenda(agenda);
                }
                //si el agenda no existe se crea
                else
                {
                    if (!string.IsNullOrEmpty(txtIdFuncionario.Text))
                    {
                        resultado = logica.InsertarAgenda(agenda);
                    }
                    else
                    {
                        MensajeScript = string.Format("javascript:mostrarMensaje" + "('Debe agregar almenos el id del funcionario')");
                        ScriptManager.RegisterStartupScript(this, typeof(string), "MensajeRetorno", MensajeScript, true);
                        resultado = -1;
                    }
                }
                if (resultado > 0)
                {
                    MensajeScript = string.Format("javascript:mostrarMensaje" + "('Operacion realizada satisfactoriamente')");
                    ScriptManager.RegisterStartupScript(this, typeof(string), "MensajeRetorno", MensajeScript, true);
                    Response.Redirect("Frm_MenuAgenda.aspx");
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
            Response.Redirect("Frm_MenuAgenda.aspx");
        }

        

        private void ListarDoctores(string condicion = "", string orden = "")
        {
            BL_Funcionario logica = new BL_Funcionario(Cls_Configuracion.getConnectionString);
            DataSet DSFuncionarios;
            try
            {
                DSFuncionarios = logica.ListarDoctores(condicion, orden);
                grdLista.DataSource = DSFuncionarios;
                grdLista.DataMember = DSFuncionarios.Tables[0].TableName;
                grdLista.DataBind();//necesario para que visualicen los datos
            }
            catch (Exception)
            {
                throw;
            }
        }

        protected void grdLista_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            grdLista.PageIndex = e.NewPageIndex;
            ListarDoctores();
        }

        protected void InkIdFuncionario_Command(object sender, CommandEventArgs e)
        {
            txtIdFuncionario.Text = e.CommandArgument.ToString();
        }
    }
}