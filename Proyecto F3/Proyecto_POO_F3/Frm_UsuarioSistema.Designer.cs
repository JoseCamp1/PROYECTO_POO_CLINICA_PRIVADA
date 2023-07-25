namespace Capa01_Presentacion
{
    partial class Frm_UsuarioSistema
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_UsuarioSistema));
            groupBox1 = new System.Windows.Forms.GroupBox();
            txtContrasena = new System.Windows.Forms.TextBox();
            txtUsuario = new System.Windows.Forms.TextBox();
            label7 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            txtID_Funcionario = new System.Windows.Forms.TextBox();
            txtCorreo = new System.Windows.Forms.TextBox();
            grdLista = new System.Windows.Forms.DataGridView();
            IdUsuarioSistema = new System.Windows.Forms.DataGridViewTextBoxColumn();
            IdFuncionario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Correo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Usuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Contrasena = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            btnLimpiar = new System.Windows.Forms.Button();
            btnSalir = new System.Windows.Forms.Button();
            btnEliminar = new System.Windows.Forms.Button();
            btnGuardar = new System.Windows.Forms.Button();
            btnBuscar = new System.Windows.Forms.Button();
            label5 = new System.Windows.Forms.Label();
            txtID_UsuarioSistema = new System.Windows.Forms.TextBox();
            label6 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            grdLista2 = new System.Windows.Forms.DataGridView();
            ID_FUNCIONARIO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ID_PuestodeTrabajo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Id_Especialidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            NOMBRE_PACIENTE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            APELLIDOS_PACIENTE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            CEDULA_PACIENTE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            TELEFONO_PACIENTE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            CORREO_PACIENTE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            DIRECCION_PACIENTE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            FECHA_NACIMIENTO_PACIENTE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Existe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            groupBox2 = new System.Windows.Forms.GroupBox();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)grdLista).BeginInit();
            ((System.ComponentModel.ISupportInitialize)grdLista2).BeginInit();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackColor = System.Drawing.Color.Transparent;
            groupBox1.Controls.Add(txtContrasena);
            groupBox1.Controls.Add(txtUsuario);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(txtID_Funcionario);
            groupBox1.Controls.Add(txtCorreo);
            groupBox1.Controls.Add(grdLista);
            groupBox1.Controls.Add(btnLimpiar);
            groupBox1.Controls.Add(btnSalir);
            groupBox1.Controls.Add(btnEliminar);
            groupBox1.Controls.Add(btnGuardar);
            groupBox1.Controls.Add(btnBuscar);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(txtID_UsuarioSistema);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label2);
            groupBox1.Location = new System.Drawing.Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new System.Drawing.Size(660, 366);
            groupBox1.TabIndex = 65;
            groupBox1.TabStop = false;
            groupBox1.Text = "Usuario";
            // 
            // txtContrasena
            // 
            txtContrasena.Location = new System.Drawing.Point(473, 36);
            txtContrasena.Name = "txtContrasena";
            txtContrasena.Size = new System.Drawing.Size(100, 23);
            txtContrasena.TabIndex = 73;
            // 
            // txtUsuario
            // 
            txtUsuario.Location = new System.Drawing.Point(367, 36);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new System.Drawing.Size(100, 23);
            txtUsuario.TabIndex = 72;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new System.Drawing.Point(476, 18);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(67, 15);
            label7.TabIndex = 71;
            label7.Text = "Contraseña";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(157, 16);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(84, 15);
            label4.TabIndex = 69;
            label4.Text = "ID Funcionario";
            // 
            // txtID_Funcionario
            // 
            txtID_Funcionario.BackColor = System.Drawing.SystemColors.Info;
            txtID_Funcionario.Enabled = false;
            txtID_Funcionario.Location = new System.Drawing.Point(157, 36);
            txtID_Funcionario.Name = "txtID_Funcionario";
            txtID_Funcionario.Size = new System.Drawing.Size(100, 23);
            txtID_Funcionario.TabIndex = 70;
            // 
            // txtCorreo
            // 
            txtCorreo.BackColor = System.Drawing.SystemColors.Info;
            txtCorreo.Enabled = false;
            txtCorreo.Location = new System.Drawing.Point(263, 36);
            txtCorreo.Name = "txtCorreo";
            txtCorreo.Size = new System.Drawing.Size(100, 23);
            txtCorreo.TabIndex = 65;
            // 
            // grdLista
            // 
            grdLista.BackgroundColor = System.Drawing.SystemColors.ActiveBorder;
            grdLista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grdLista.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { IdUsuarioSistema, IdFuncionario, Correo, Usuario, Contrasena, dataGridViewTextBoxColumn3 });
            grdLista.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            grdLista.GridColor = System.Drawing.SystemColors.ActiveBorder;
            grdLista.Location = new System.Drawing.Point(51, 63);
            grdLista.Name = "grdLista";
            grdLista.RowTemplate.Height = 25;
            grdLista.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            grdLista.Size = new System.Drawing.Size(557, 210);
            grdLista.TabIndex = 62;
            grdLista.DoubleClick += grdLista_DoubleClick;
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
            // btnLimpiar
            // 
            btnLimpiar.BackColor = System.Drawing.Color.Transparent;
            btnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            btnLimpiar.Image = Properties.Resources.broom_5182;
            btnLimpiar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            btnLimpiar.Location = new System.Drawing.Point(169, 281);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new System.Drawing.Size(75, 71);
            btnLimpiar.TabIndex = 61;
            btnLimpiar.Text = "&Limpiar";
            btnLimpiar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            btnLimpiar.UseVisualStyleBackColor = false;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // btnSalir
            // 
            btnSalir.BackColor = System.Drawing.Color.Transparent;
            btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            btnSalir.Image = Properties.Resources._4115235_exit_logout_sign_out_114030;
            btnSalir.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            btnSalir.Location = new System.Drawing.Point(533, 281);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new System.Drawing.Size(75, 71);
            btnSalir.TabIndex = 60;
            btnSalir.Text = "&Salir";
            btnSalir.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            btnSalir.UseVisualStyleBackColor = false;
            btnSalir.Click += btnSalir_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.BackColor = System.Drawing.Color.Transparent;
            btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            btnEliminar.Image = Properties.Resources.trash_bin_icon_icons_com_67981;
            btnEliminar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            btnEliminar.Location = new System.Drawing.Point(419, 281);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new System.Drawing.Size(75, 71);
            btnEliminar.TabIndex = 59;
            btnEliminar.Text = "&Eliminar";
            btnEliminar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            btnEliminar.UseVisualStyleBackColor = false;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnGuardar
            // 
            btnGuardar.BackColor = System.Drawing.Color.Transparent;
            btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            btnGuardar.Image = Properties.Resources._1490129329_rounded38_82203;
            btnGuardar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            btnGuardar.Location = new System.Drawing.Point(303, 279);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new System.Drawing.Size(75, 71);
            btnGuardar.TabIndex = 58;
            btnGuardar.Text = "&Guardar";
            btnGuardar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            btnGuardar.UseVisualStyleBackColor = false;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnBuscar
            // 
            btnBuscar.BackColor = System.Drawing.Color.Transparent;
            btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            btnBuscar.Image = Properties.Resources.seo_social_web_network_internet_340_icon_icons_com_61497;
            btnBuscar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            btnBuscar.Location = new System.Drawing.Point(51, 279);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new System.Drawing.Size(75, 71);
            btnBuscar.TabIndex = 57;
            btnBuscar.Text = "&Buscar";
            btnBuscar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            btnBuscar.UseVisualStyleBackColor = false;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new System.Drawing.Point(367, 18);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(47, 15);
            label5.TabIndex = 49;
            label5.Text = "Usuario";
            // 
            // txtID_UsuarioSistema
            // 
            txtID_UsuarioSistema.BackColor = System.Drawing.SystemColors.Info;
            txtID_UsuarioSistema.Enabled = false;
            txtID_UsuarioSistema.Location = new System.Drawing.Point(51, 36);
            txtID_UsuarioSistema.Name = "txtID_UsuarioSistema";
            txtID_UsuarioSistema.Size = new System.Drawing.Size(100, 23);
            txtID_UsuarioSistema.TabIndex = 54;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new System.Drawing.Point(51, 18);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(105, 15);
            label6.TabIndex = 53;
            label6.Text = "ID Usuario Sistema";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(263, 18);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(43, 15);
            label2.TabIndex = 47;
            label2.Text = "Correo";
            // 
            // grdLista2
            // 
            grdLista2.BackgroundColor = System.Drawing.SystemColors.ActiveBorder;
            grdLista2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grdLista2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { ID_FUNCIONARIO, ID_PuestodeTrabajo, Id_Especialidad, NOMBRE_PACIENTE, APELLIDOS_PACIENTE, CEDULA_PACIENTE, TELEFONO_PACIENTE, CORREO_PACIENTE, DIRECCION_PACIENTE, FECHA_NACIMIENTO_PACIENTE, Existe });
            grdLista2.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            grdLista2.GridColor = System.Drawing.SystemColors.ActiveBorder;
            grdLista2.Location = new System.Drawing.Point(6, 22);
            grdLista2.Name = "grdLista2";
            grdLista2.RowTemplate.Height = 25;
            grdLista2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            grdLista2.Size = new System.Drawing.Size(647, 179);
            grdLista2.TabIndex = 66;
            grdLista2.CellDoubleClick += grdLista2_CellDoubleClick;
            // 
            // ID_FUNCIONARIO
            // 
            ID_FUNCIONARIO.DataPropertyName = "IdFuncionario";
            ID_FUNCIONARIO.HeaderText = "Funcionario";
            ID_FUNCIONARIO.Name = "ID_FUNCIONARIO";
            // 
            // ID_PuestodeTrabajo
            // 
            ID_PuestodeTrabajo.DataPropertyName = "IdPuestoTrabajo";
            ID_PuestodeTrabajo.HeaderText = "Puesto de Trabajo";
            ID_PuestodeTrabajo.Name = "ID_PuestodeTrabajo";
            // 
            // Id_Especialidad
            // 
            Id_Especialidad.DataPropertyName = "IdEspecialidad";
            Id_Especialidad.HeaderText = "Especialidad";
            Id_Especialidad.Name = "Id_Especialidad";
            // 
            // NOMBRE_PACIENTE
            // 
            NOMBRE_PACIENTE.DataPropertyName = "Nombre";
            NOMBRE_PACIENTE.HeaderText = "Nombre";
            NOMBRE_PACIENTE.Name = "NOMBRE_PACIENTE";
            // 
            // APELLIDOS_PACIENTE
            // 
            APELLIDOS_PACIENTE.DataPropertyName = "Apellidos";
            APELLIDOS_PACIENTE.HeaderText = "Apellidos";
            APELLIDOS_PACIENTE.Name = "APELLIDOS_PACIENTE";
            // 
            // CEDULA_PACIENTE
            // 
            CEDULA_PACIENTE.DataPropertyName = "Cedula";
            CEDULA_PACIENTE.HeaderText = "Cedula";
            CEDULA_PACIENTE.Name = "CEDULA_PACIENTE";
            CEDULA_PACIENTE.Visible = false;
            // 
            // TELEFONO_PACIENTE
            // 
            TELEFONO_PACIENTE.DataPropertyName = "Telefono";
            TELEFONO_PACIENTE.HeaderText = "Telefono";
            TELEFONO_PACIENTE.Name = "TELEFONO_PACIENTE";
            TELEFONO_PACIENTE.Visible = false;
            // 
            // CORREO_PACIENTE
            // 
            CORREO_PACIENTE.DataPropertyName = "Correo";
            CORREO_PACIENTE.HeaderText = "Correo Electronico";
            CORREO_PACIENTE.Name = "CORREO_PACIENTE";
            // 
            // DIRECCION_PACIENTE
            // 
            DIRECCION_PACIENTE.DataPropertyName = "Direccion";
            DIRECCION_PACIENTE.HeaderText = "Direccion";
            DIRECCION_PACIENTE.Name = "DIRECCION_PACIENTE";
            DIRECCION_PACIENTE.Visible = false;
            DIRECCION_PACIENTE.Width = 150;
            // 
            // FECHA_NACIMIENTO_PACIENTE
            // 
            FECHA_NACIMIENTO_PACIENTE.DataPropertyName = "FechaNacimiento";
            FECHA_NACIMIENTO_PACIENTE.HeaderText = "Fecha de Nacimiento";
            FECHA_NACIMIENTO_PACIENTE.Name = "FECHA_NACIMIENTO_PACIENTE";
            FECHA_NACIMIENTO_PACIENTE.Visible = false;
            FECHA_NACIMIENTO_PACIENTE.Width = 150;
            // 
            // Existe
            // 
            Existe.DataPropertyName = "Existe";
            Existe.HeaderText = "Existe";
            Existe.Name = "Existe";
            Existe.Visible = false;
            // 
            // groupBox2
            // 
            groupBox2.BackColor = System.Drawing.Color.Transparent;
            groupBox2.Controls.Add(grdLista2);
            groupBox2.Location = new System.Drawing.Point(12, 393);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new System.Drawing.Size(661, 209);
            groupBox2.TabIndex = 67;
            groupBox2.TabStop = false;
            groupBox2.Text = "Funcionario";
            // 
            // Frm_UsuarioSistema
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            BackgroundImage = Properties.Resources.Screenshot_2023_06_10_171827;
            BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            ClientSize = new System.Drawing.Size(684, 613);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            DoubleBuffered = true;
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Frm_UsuarioSistema";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Usuario del Sistema";
            Load += Frm_UsuarioSistema_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)grdLista).EndInit();
            ((System.ComponentModel.ISupportInitialize)grdLista2).EndInit();
            groupBox2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtID_Funcionario;
        private System.Windows.Forms.TextBox txtCorreo;
        private System.Windows.Forms.DataGridView grdLista;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtID_UsuarioSistema;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtContrasena;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdUsuarioSistema;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdFuncionario;
        private System.Windows.Forms.DataGridViewTextBoxColumn Correo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Usuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn Contrasena;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridView grdLista2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_FUNCIONARIO;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_PuestodeTrabajo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id_Especialidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn NOMBRE_PACIENTE;
        private System.Windows.Forms.DataGridViewTextBoxColumn APELLIDOS_PACIENTE;
        private System.Windows.Forms.DataGridViewTextBoxColumn CEDULA_PACIENTE;
        private System.Windows.Forms.DataGridViewTextBoxColumn TELEFONO_PACIENTE;
        private System.Windows.Forms.DataGridViewTextBoxColumn CORREO_PACIENTE;
        private System.Windows.Forms.DataGridViewTextBoxColumn DIRECCION_PACIENTE;
        private System.Windows.Forms.DataGridViewTextBoxColumn FECHA_NACIMIENTO_PACIENTE;
        private System.Windows.Forms.DataGridViewTextBoxColumn Existe;
    }
}