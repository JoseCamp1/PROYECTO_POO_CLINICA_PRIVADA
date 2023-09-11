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
    public partial class Frm_BuscarUsuarioSistema : Form
    {
        public Frm_BuscarUsuarioSistema()
        {
            InitializeComponent();
        }

        public event EventHandler Aceptar;

        int vgn_id_usuario;

        private void Seleccionar()
        {
            if (grdLista.SelectedRows.Count > 0)
            {
                vgn_id_usuario = (int)grdLista.SelectedRows[0].Cells[0].Value;
                Aceptar(vgn_id_usuario, null);
                Close();
            }
        }

        public void cargarListaUsuariosSistema(string condicion = "")
        {
            grdLista.Refresh();
            BL_UsuarioSistema logica = new BL_UsuarioSistema(Configuracion.getConnectionString);
            List<Entidad_UsuarioSistema> usuarioSistema;
            try
            {
                usuarioSistema = logica.ListarUsuariosSistema(condicion);
                if (usuarioSistema.Count > 0)
                {
                    grdLista.DataSource = usuarioSistema;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string condicion = string.Empty;
            try
            {
                if (!string.IsNullOrEmpty(txtUsuario.Text))
                {
                    condicion = string.Format("USUARIO LIKE '%{0}%'", txtUsuario.Text.Trim());
                    cargarListaUsuariosSistema(condicion);
                }
                else
                {
                    MessageBox.Show("Debe escribir parte del nombre a buscar.", "Atención.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtUsuario.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            Seleccionar();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Aceptar(-1, null);
            Close();
        }

        private void grdLista_DoubleClick_1(object sender, EventArgs e)
        {
            Seleccionar();
        }

        private void Frm_BuscarUsuarioSistema_Load(object sender, EventArgs e)
        {
            cargarListaUsuariosSistema();
        }
    }
}
