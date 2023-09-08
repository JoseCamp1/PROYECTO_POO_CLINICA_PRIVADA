namespace Capa01_Presentacion
{
    partial class Frm_BuscarUsuarioSistema
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_BuscarUsuarioSistema));
            groupBox1 = new System.Windows.Forms.GroupBox();
            grdLista = new System.Windows.Forms.DataGridView();
            IdUsuarioSistema = new System.Windows.Forms.DataGridViewTextBoxColumn();
            IdFuncionario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Correo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Usuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Contrasena = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            btnAceptar = new System.Windows.Forms.Button();
            btnBuscar = new System.Windows.Forms.Button();
            btnCancelar = new System.Windows.Forms.Button();
            label2 = new System.Windows.Forms.Label();
            txtUsuario = new System.Windows.Forms.TextBox();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)grdLista).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackColor = System.Drawing.Color.Transparent;
            groupBox1.Controls.Add(grdLista);
            groupBox1.Controls.Add(btnAceptar);
            groupBox1.Controls.Add(btnBuscar);
            groupBox1.Controls.Add(btnCancelar);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(txtUsuario);
            groupBox1.Location = new System.Drawing.Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new System.Drawing.Size(573, 320);
            groupBox1.TabIndex = 6;
            groupBox1.TabStop = false;
            groupBox1.Text = "Buscar ";
            // 
            // grdLista
            // 
            grdLista.BackgroundColor = System.Drawing.SystemColors.ActiveBorder;
            grdLista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grdLista.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { IdUsuarioSistema, IdFuncionario, Correo, Usuario, Contrasena, dataGridViewTextBoxColumn3 });
            grdLista.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            grdLista.GridColor = System.Drawing.SystemColors.ActiveBorder;
            grdLista.Location = new System.Drawing.Point(6, 99);
            grdLista.Name = "grdLista";
            grdLista.RowTemplate.Height = 25;
            grdLista.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            grdLista.Size = new System.Drawing.Size(557, 210);
            grdLista.TabIndex = 63;
            grdLista.Click += grdLista_DoubleClick_1;
            // 
            // IdUsuarioSistema
            // 
            IdUsuarioSistema.DataPropertyName = "IdUsuarioSistema";
            IdUsuarioSistema.HeaderText = "#UsuarioSistema";
            IdUsuarioSistema.Name = "IdUsuarioSistema";
            // 
            // IdFuncionario
            // 
            IdFuncionario.DataPropertyName = "IdFuncionario";
            IdFuncionario.HeaderText = "#Funcionario";
            IdFuncionario.Name = "IdFuncionario";
            // 
            // Correo
            // 
            Correo.DataPropertyName = "Correo";
            Correo.HeaderText = "Correo";
            Correo.Name = "Correo";
            // 
            // Usuario
            // 
            Usuario.DataPropertyName = "Usuario";
            Usuario.HeaderText = "Usuario";
            Usuario.Name = "Usuario";
            // 
            // Contrasena
            // 
            Contrasena.DataPropertyName = "Contrasena";
            Contrasena.HeaderText = "Contrasena ";
            Contrasena.Name = "Contrasena";
            // 
            // dataGridViewTextBoxColumn3
            // 
            dataGridViewTextBoxColumn3.DataPropertyName = "Existe";
            dataGridViewTextBoxColumn3.HeaderText = "Existe";
            dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            dataGridViewTextBoxColumn3.Visible = false;
            // 
            // btnAceptar
            // 
            btnAceptar.BackColor = System.Drawing.Color.Transparent;
            btnAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            btnAceptar.Image = Properties.Resources._4115228_accept_checklist_checkmark_yes_114037;
            btnAceptar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            btnAceptar.Location = new System.Drawing.Point(407, 22);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new System.Drawing.Size(75, 71);
            btnAceptar.TabIndex = 29;
            btnAceptar.Text = "&Aceptar";
            btnAceptar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            btnAceptar.UseVisualStyleBackColor = false;
            btnAceptar.Click += btnAceptar_Click;
            // 
            // btnBuscar
            // 
            btnBuscar.BackColor = System.Drawing.Color.Transparent;
            btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            btnBuscar.Image = Properties.Resources.seo_social_web_network_internet_340_icon_icons_com_61497;
            btnBuscar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            btnBuscar.Location = new System.Drawing.Point(326, 22);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new System.Drawing.Size(75, 71);
            btnBuscar.TabIndex = 28;
            btnBuscar.Text = "&Buscar";
            btnBuscar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            btnBuscar.UseVisualStyleBackColor = false;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = System.Drawing.Color.Transparent;
            btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            btnCancelar.Image = Properties.Resources._1487086345_cross_815771;
            btnCancelar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            btnCancelar.Location = new System.Drawing.Point(488, 22);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new System.Drawing.Size(75, 71);
            btnCancelar.TabIndex = 19;
            btnCancelar.Text = "&Cancelar";
            btnCancelar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(6, 23);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(100, 15);
            label2.TabIndex = 26;
            label2.Text = "Ingrese el Usuario";
            // 
            // txtUsuario
            // 
            txtUsuario.Location = new System.Drawing.Point(6, 41);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new System.Drawing.Size(284, 23);
            txtUsuario.TabIndex = 27;
            // 
            // Frm_BuscarUsuarioSistema
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            BackgroundImage = Properties.Resources.Screenshot_2023_06_10_171827;
            BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            ClientSize = new System.Drawing.Size(598, 340);
            Controls.Add(groupBox1);
            DoubleBuffered = true;
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Frm_BuscarUsuarioSistema";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Frm_BuscarUsuarioSistema";
            Load += Frm_BuscarUsuarioSistema_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)grdLista).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.DataGridView grdLista;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdUsuarioSistema;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdFuncionario;
        private System.Windows.Forms.DataGridViewTextBoxColumn Correo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Usuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn Contrasena;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
    }
}