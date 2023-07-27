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
    public partial class Frm_NuevoFuncionario : System.Web.UI.Page
    {
        public void cargarListaEspecialidades(string condicion = "")
        {
            BL_Especialidades logica = new BL_Especialidades(Cls_Configuracion.getConnectionString);
            List<Entidad_Especialidades> puestoTrabajo;
            try
            {
                puestoTrabajo = logica.ListarEspecialidades(condicion);
                if (puestoTrabajo.Count > 0)
                {
                    grdEspecialidades.DataSource = puestoTrabajo;
                }
                grdEspecialidades.DataBind();//necesario para que visualicen los datos
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void cargarListaPuestosTrabajo(string condicion = "")
        {
            BL_PuestosTrabajo logica = new BL_PuestosTrabajo(Cls_Configuracion.getConnectionString);
            List<Entidad_PuestosTrabajo> puestoTrabajo;
            try
            {
                puestoTrabajo = logica.ListarPuestosTrabajo(condicion);
                if (puestoTrabajo.Count > 0)
                {
                    grdPuestosT.DataSource = puestoTrabajo;
                }
                grdPuestosT.DataBind();//necesario para que visualicen los datos
            }
            catch (Exception)
            {
                throw;
            }
        }
        //CARGAR DATOS
        string MensajeScript;

        public void Limpiar()
        {
            txtId.Text = "";
            txtIdPuestoTrabajo.Text = string.Empty;
            txtIdEspecialidad.Text = string.Empty;
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
            cargarListaEspecialidades();
            cargarListaPuestosTrabajo();
            Entidad_Funcionario funcionario;
            BL_Funcionario logica = new BL_Funcionario(Cls_Configuracion.getConnectionString);
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
                    if (Session["id_del_funcionario"] != null)
                    {
                        identificacion = int.Parse(Session["id_del_funcionario"].ToString());
                        funcionario = logica.ObtenerFuncionario(identificacion);
                        if (funcionario.Existe)
                        {
                            txtId.Text = funcionario.IdFuncionario.ToString();
                            txtIdPuestoTrabajo.Text = funcionario.IdPuestoTrabajo.ToString();
                            txtIdEspecialidad.Text = funcionario.IdEspecialidad.ToString();
                            txtNombre.Text = funcionario.Nombre;
                            txtApellidos.Text = funcionario.Apellidos;
                            txtCedula.Text = funcionario.Cedula;
                            txtTelefono.Text = funcionario.Telefono;
                            txtCorreo.Text = funcionario.Correo;
                            txtDireccion.Text = funcionario.Direccion;
                            txtFechaNacimiento.Text = funcionario.FechaNacimiento.ToString("yyyy-MM-dd");

                            lblid.Visible = true;
                            txtId.Visible = true;
                        }
                        else
                        {
                            MensajeScript = string.Format("javascript:mostrarMensaje" + "('Funcionario no encontrado')");
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
                Response.Redirect("Frm_MenuFuncionarios.aspx");
            }
        }

        private Entidad_Funcionario GenerarEntidadFuncionario()
        {
            Entidad_Funcionario funcionario = new Entidad_Funcionario();
            // si hay algo en la variable de sesion
            if (Session["id_del_funcionario"] != null)
            {
                funcionario.IdFuncionario = int.Parse(Session["id_del_funcionario"].ToString());
                funcionario.Existe = true;
            }
            //si no hay nada en la variable de sesion, es un funcionario nuevo
            else
            {
                funcionario.IdFuncionario = -1;
                funcionario.Existe = false;
            }
            //los demas datos siempre se toman de los cuadros de texto
            funcionario.IdPuestoTrabajo = int.Parse(txtIdPuestoTrabajo.Text);
            funcionario.IdEspecialidad = int.Parse(txtIdEspecialidad.Text);
            funcionario.Nombre = txtNombre.Text;
            funcionario.Apellidos = txtApellidos.Text;
            funcionario.Cedula = txtCedula.Text;
            funcionario.Telefono = txtTelefono.Text;
            funcionario.Correo = txtCorreo.Text;
            funcionario.Direccion = txtDireccion.Text;
            funcionario.FechaNacimiento = DateTime.Parse(txtFechaNacimiento.Text);
            return funcionario;
        }

        protected void btnGuardar_Click(object sender, EventArgs e)
        {
            Entidad_Funcionario funcionario;
            BL_Funcionario logica = new BL_Funcionario(Cls_Configuracion.getConnectionString);
            int resultado;
            try
            {
                funcionario = GenerarEntidadFuncionario();
                //si el funcionario ya existe , se modifica 
                if (funcionario.Existe)
                {
                    resultado = logica.ModificarFuncionario(funcionario);
                }
                //si el funcionario no existe se crea
                else
                {
                    if (!string.IsNullOrEmpty(txtNombre.Text))
                    {
                        resultado = logica.InsertarFuncionario(funcionario);
                    }
                    else
                    {
                        MensajeScript = string.Format("javascript:mostrarMensaje" + "('Debe agregar almenos el nombre del funcionario')");
                        ScriptManager.RegisterStartupScript(this, typeof(string), "MensajeRetorno", MensajeScript, true);
                        resultado = -1;
                    }
                }
                if (resultado > 0)
                {
                    MensajeScript = string.Format("javascript:mostrarMensaje" + "('Operacion realizada satisfactoriamente')");
                    ScriptManager.RegisterStartupScript(this, typeof(string), "MensajeRetorno", MensajeScript, true);
                    Response.Redirect("Frm_MenuFuncionarios.aspx");
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
            Response.Redirect("Frm_MenuFuncionarios.aspx");
        }

        protected void grdPuestosT_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            grdPuestosT.PageIndex = e.NewPageIndex;
            cargarListaPuestosTrabajo();
        }

        protected void grdEspecialidades_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            grdEspecialidades.PageIndex = e.NewPageIndex;
            cargarListaEspecialidades();
        }

        protected void InkPuesto_Command(object sender, CommandEventArgs e)
        {
            txtIdPuestoTrabajo.Text = e.CommandArgument.ToString();
        }

        protected void InkEspecialidad_Command(object sender, CommandEventArgs e)
        {
            txtIdEspecialidad.Text = e.CommandArgument.ToString();
        }
    }
}