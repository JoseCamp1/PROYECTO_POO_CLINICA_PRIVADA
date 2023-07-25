using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Capa01_Aplicacion_Web
{
    public partial class Frm_MenuPrincipal : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnClientes_Click(object sender, EventArgs e)
        {
            Response.Redirect("Frm_MenuPacientes.aspx");
        }
    }
}