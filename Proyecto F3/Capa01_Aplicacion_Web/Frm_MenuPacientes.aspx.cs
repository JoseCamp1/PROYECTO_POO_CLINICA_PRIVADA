using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Windows;
using Capa02_LogicaNegocio;
using Capa_Entidades;


namespace Capa01_Aplicacion_Web
{
    public partial class Frm_MenuPacientes : System.Web.UI.Page
    {
        public void cargarListaPacientes(string condicion = "")
        {
            BL_Paciente logica = new BL_Paciente(Configuracion.getConnectionString);
            List<Entidad_Paciente> paciente;
            try
            {
                paciente = logica.ListarPacientes(condicion);
                if (paciente.Count > 0)
                {
                    grdLista.DataSource = paciente;
                }
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                if (!IsPostBack)
                {
                    //CargarListaClientes();
                }
            }
            catch (Exception)
            {
                //throw;
            }
        }

        protected void btnAgregar_Click(object sender, EventArgs e)
        {

        }

        protected void btnBuscar_Click(object sender, EventArgs e)
        {

        }

        protected void btnRegresar_Click(object sender, EventArgs e)
        {
            Response.Redirect("Frm_MenuPrincipal.aspx");
        }
    }
}