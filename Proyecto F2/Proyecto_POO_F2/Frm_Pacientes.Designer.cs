namespace Capa01_Presentacion
{
    partial class Frm_Pacientes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Pacientes));
            txtDireccion = new System.Windows.Forms.TextBox();
            txtTelefono = new System.Windows.Forms.TextBox();
            txtNombre = new System.Windows.Forms.TextBox();
            label4 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            btnNuevo = new System.Windows.Forms.Button();
            btnSalir = new System.Windows.Forms.Button();
            btnEliminar = new System.Windows.Forms.Button();
            btnGuardar = new System.Windows.Forms.Button();
            btnBuscar = new System.Windows.Forms.Button();
            grdClientes = new System.Windows.Forms.DataGridView();
            ID_PACIENTE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            NOMBRE_PACIENTE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            APELLIDO1_PACIENTE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            APELLIDO2_PACIENTE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            CEDULA_PACIENTE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            TELEFONO_PACIENTE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            CORREO_PACIENTE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            DIRECCION_PACIENTE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            FECHA_NACIMIENTO_PACIENTE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ESTADO_PACIENTE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            BORRADO_PACIENTE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            txtApellido1 = new System.Windows.Forms.TextBox();
            label5 = new System.Windows.Forms.Label();
            txtApellido2 = new System.Windows.Forms.TextBox();
            label6 = new System.Windows.Forms.Label();
            txtCedula = new System.Windows.Forms.TextBox();
            label7 = new System.Windows.Forms.Label();
            txtFechaNacimiento = new System.Windows.Forms.TextBox();
            label8 = new System.Windows.Forms.Label();
            txtCorreo = new System.Windows.Forms.TextBox();
            label1 = new System.Windows.Forms.Label();
            txtBuscarNombre = new System.Windows.Forms.TextBox();
            label9 = new System.Windows.Forms.Label();
            btnCargarLista = new System.Windows.Forms.Button();
            txtID_Paciente = new System.Windows.Forms.TextBox();
            label10 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)grdClientes).BeginInit();
            SuspendLayout();
            // 
            // txtDireccion
            // 
            txtDireccion.Location = new System.Drawing.Point(805, 67);
            txtDireccion.Name = "txtDireccion";
            txtDireccion.Size = new System.Drawing.Size(100, 23);
            txtDireccion.TabIndex = 27;
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new System.Drawing.Point(595, 67);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new System.Drawing.Size(100, 23);
            txtTelefono.TabIndex = 26;
            // 
            // txtNombre
            // 
            txtNombre.Location = new System.Drawing.Point(170, 67);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new System.Drawing.Size(100, 23);
            txtNombre.TabIndex = 25;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(805, 49);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(57, 15);
            label4.TabIndex = 23;
            label4.Text = "Direccion";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(595, 49);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(52, 15);
            label3.TabIndex = 22;
            label3.Text = "Telefono";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(170, 49);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(51, 15);
            label2.TabIndex = 21;
            label2.Text = "Nombre";
            // 
            // btnNuevo
            // 
            btnNuevo.Image = Properties.Resources._1490129329_rounded38_82203;
            btnNuevo.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            btnNuevo.Location = new System.Drawing.Point(526, 577);
            btnNuevo.Name = "btnNuevo";
            btnNuevo.Size = new System.Drawing.Size(75, 71);
            btnNuevo.TabIndex = 19;
            btnNuevo.Text = "&Nuevo";
            btnNuevo.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            btnNuevo.UseVisualStyleBackColor = true;
            btnNuevo.Click += btnNuevo_Click;
            // 
            // btnSalir
            // 
            btnSalir.Image = Properties.Resources._4115235_exit_logout_sign_out_114030;
            btnSalir.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            btnSalir.Location = new System.Drawing.Point(830, 577);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new System.Drawing.Size(75, 71);
            btnSalir.TabIndex = 18;
            btnSalir.Text = "&Salir";
            btnSalir.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Image = Properties.Resources.trash_bin_icon_icons_com_67981;
            btnEliminar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            btnEliminar.Location = new System.Drawing.Point(735, 577);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new System.Drawing.Size(75, 71);
            btnEliminar.TabIndex = 17;
            btnEliminar.Text = "&Eliminar";
            btnEliminar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            btnEliminar.UseVisualStyleBackColor = true;
            // 
            // btnGuardar
            // 
            btnGuardar.Image = Properties.Resources._1904659_arrow_backup_down_download_save_storage_transfer_122509;
            btnGuardar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            btnGuardar.Location = new System.Drawing.Point(629, 575);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new System.Drawing.Size(75, 71);
            btnGuardar.TabIndex = 16;
            btnGuardar.Text = "&Guardar";
            btnGuardar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnBuscar
            // 
            btnBuscar.Image = Properties.Resources.seo_social_web_network_internet_340_icon_icons_com_61497;
            btnBuscar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            btnBuscar.Location = new System.Drawing.Point(323, 575);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new System.Drawing.Size(75, 71);
            btnBuscar.TabIndex = 15;
            btnBuscar.Text = "&Buscar";
            btnBuscar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // grdClientes
            // 
            grdClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grdClientes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { ID_PACIENTE, NOMBRE_PACIENTE, APELLIDO1_PACIENTE, APELLIDO2_PACIENTE, CEDULA_PACIENTE, TELEFONO_PACIENTE, CORREO_PACIENTE, DIRECCION_PACIENTE, FECHA_NACIMIENTO_PACIENTE, ESTADO_PACIENTE, BORRADO_PACIENTE });
            grdClientes.Location = new System.Drawing.Point(3, 110);
            grdClientes.Name = "grdClientes";
            grdClientes.RowTemplate.Height = 25;
            grdClientes.Size = new System.Drawing.Size(1149, 448);
            grdClientes.TabIndex = 14;
            // 
            // ID_PACIENTE
            // 
            ID_PACIENTE.DataPropertyName = "IdPaciente";
            ID_PACIENTE.HeaderText = "ID Paciente";
            ID_PACIENTE.Name = "ID_PACIENTE";
            // 
            // NOMBRE_PACIENTE
            // 
            NOMBRE_PACIENTE.DataPropertyName = "Nombre";
            NOMBRE_PACIENTE.HeaderText = "Nombre";
            NOMBRE_PACIENTE.Name = "NOMBRE_PACIENTE";
            // 
            // APELLIDO1_PACIENTE
            // 
            APELLIDO1_PACIENTE.DataPropertyName = "Apellido1";
            APELLIDO1_PACIENTE.HeaderText = "1er Apellido";
            APELLIDO1_PACIENTE.Name = "APELLIDO1_PACIENTE";
            // 
            // APELLIDO2_PACIENTE
            // 
            APELLIDO2_PACIENTE.DataPropertyName = "Apellido2";
            APELLIDO2_PACIENTE.HeaderText = "2do Apellido";
            APELLIDO2_PACIENTE.Name = "APELLIDO2_PACIENTE";
            // 
            // CEDULA_PACIENTE
            // 
            CEDULA_PACIENTE.DataPropertyName = "Cedula";
            CEDULA_PACIENTE.HeaderText = "Cedula";
            CEDULA_PACIENTE.Name = "CEDULA_PACIENTE";
            // 
            // TELEFONO_PACIENTE
            // 
            TELEFONO_PACIENTE.DataPropertyName = "Telefono";
            TELEFONO_PACIENTE.HeaderText = "Telefono";
            TELEFONO_PACIENTE.Name = "TELEFONO_PACIENTE";
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
            // 
            // FECHA_NACIMIENTO_PACIENTE
            // 
            FECHA_NACIMIENTO_PACIENTE.DataPropertyName = "FechaNacimiento";
            FECHA_NACIMIENTO_PACIENTE.HeaderText = "Fecha de Nacimiento";
            FECHA_NACIMIENTO_PACIENTE.Name = "FECHA_NACIMIENTO_PACIENTE";
            // 
            // ESTADO_PACIENTE
            // 
            ESTADO_PACIENTE.DataPropertyName = "Estado";
            ESTADO_PACIENTE.HeaderText = "Estado";
            ESTADO_PACIENTE.Name = "ESTADO_PACIENTE";
            // 
            // BORRADO_PACIENTE
            // 
            BORRADO_PACIENTE.DataPropertyName = "Borrado";
            BORRADO_PACIENTE.HeaderText = "Borrado";
            BORRADO_PACIENTE.Name = "BORRADO_PACIENTE";
            // 
            // txtApellido1
            // 
            txtApellido1.Location = new System.Drawing.Point(276, 67);
            txtApellido1.Name = "txtApellido1";
            txtApellido1.Size = new System.Drawing.Size(100, 23);
            txtApellido1.TabIndex = 29;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new System.Drawing.Point(276, 49);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(70, 15);
            label5.TabIndex = 28;
            label5.Text = "1er Apellido";
            // 
            // txtApellido2
            // 
            txtApellido2.Location = new System.Drawing.Point(382, 67);
            txtApellido2.Name = "txtApellido2";
            txtApellido2.Size = new System.Drawing.Size(100, 23);
            txtApellido2.TabIndex = 31;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new System.Drawing.Point(382, 49);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(74, 15);
            label6.TabIndex = 30;
            label6.Text = "2do Apellido";
            // 
            // txtCedula
            // 
            txtCedula.Location = new System.Drawing.Point(488, 67);
            txtCedula.Name = "txtCedula";
            txtCedula.Size = new System.Drawing.Size(100, 23);
            txtCedula.TabIndex = 33;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new System.Drawing.Point(488, 49);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(44, 15);
            label7.TabIndex = 32;
            label7.Text = "Cedula";
            // 
            // txtFechaNacimiento
            // 
            txtFechaNacimiento.Location = new System.Drawing.Point(911, 67);
            txtFechaNacimiento.Name = "txtFechaNacimiento";
            txtFechaNacimiento.Size = new System.Drawing.Size(100, 23);
            txtFechaNacimiento.TabIndex = 35;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new System.Drawing.Point(911, 49);
            label8.Name = "label8";
            label8.Size = new System.Drawing.Size(119, 15);
            label8.TabIndex = 34;
            label8.Text = "Fecha de Nacimiento";
            // 
            // txtCorreo
            // 
            txtCorreo.Location = new System.Drawing.Point(699, 67);
            txtCorreo.Name = "txtCorreo";
            txtCorreo.Size = new System.Drawing.Size(100, 23);
            txtCorreo.TabIndex = 37;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(699, 49);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(43, 15);
            label1.TabIndex = 36;
            label1.Text = "Correo";
            // 
            // txtBuscarNombre
            // 
            txtBuscarNombre.Location = new System.Drawing.Point(134, 624);
            txtBuscarNombre.Name = "txtBuscarNombre";
            txtBuscarNombre.Size = new System.Drawing.Size(150, 23);
            txtBuscarNombre.TabIndex = 39;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new System.Drawing.Point(134, 606);
            label9.Name = "label9";
            label9.Size = new System.Drawing.Size(110, 15);
            label9.TabIndex = 38;
            label9.Text = "Buscar por Nombre";
            // 
            // btnCargarLista
            // 
            btnCargarLista.Image = Properties.Resources._1492790910_94list_84237;
            btnCargarLista.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            btnCargarLista.Location = new System.Drawing.Point(423, 575);
            btnCargarLista.Name = "btnCargarLista";
            btnCargarLista.Size = new System.Drawing.Size(75, 71);
            btnCargarLista.TabIndex = 40;
            btnCargarLista.Text = "&Cargar";
            btnCargarLista.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            btnCargarLista.UseVisualStyleBackColor = true;
            btnCargarLista.Click += btnCargarLista_Click;
            // 
            // txtID_Paciente
            // 
            txtID_Paciente.BackColor = System.Drawing.SystemColors.Info;
            txtID_Paciente.Enabled = false;
            txtID_Paciente.Location = new System.Drawing.Point(64, 67);
            txtID_Paciente.Name = "txtID_Paciente";
            txtID_Paciente.Size = new System.Drawing.Size(100, 23);
            txtID_Paciente.TabIndex = 42;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new System.Drawing.Point(64, 49);
            label10.Name = "label10";
            label10.Size = new System.Drawing.Size(66, 15);
            label10.TabIndex = 41;
            label10.Text = "ID Paciente";
            // 
            // Frm_Pacientes
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Screenshot_2023_06_10_171827;
            BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            ClientSize = new System.Drawing.Size(1156, 660);
            Controls.Add(txtID_Paciente);
            Controls.Add(label10);
            Controls.Add(btnCargarLista);
            Controls.Add(txtBuscarNombre);
            Controls.Add(label9);
            Controls.Add(txtCorreo);
            Controls.Add(label1);
            Controls.Add(txtFechaNacimiento);
            Controls.Add(label8);
            Controls.Add(txtCedula);
            Controls.Add(label7);
            Controls.Add(txtApellido2);
            Controls.Add(label6);
            Controls.Add(txtApellido1);
            Controls.Add(label5);
            Controls.Add(txtDireccion);
            Controls.Add(txtTelefono);
            Controls.Add(txtNombre);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(btnNuevo);
            Controls.Add(btnSalir);
            Controls.Add(btnEliminar);
            Controls.Add(btnGuardar);
            Controls.Add(btnBuscar);
            Controls.Add(grdClientes);
            DoubleBuffered = true;
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Frm_Pacientes";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Frm_Pacientes";
            ((System.ComponentModel.ISupportInitialize)grdClientes).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.DataGridView grdClientes;
        private System.Windows.Forms.TextBox txtApellido1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtApellido2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtCedula;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtFechaNacimiento;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtCorreo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBuscarNombre;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnCargarLista;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_PACIENTE;
        private System.Windows.Forms.DataGridViewTextBoxColumn NOMBRE_PACIENTE;
        private System.Windows.Forms.DataGridViewTextBoxColumn APELLIDO1_PACIENTE;
        private System.Windows.Forms.DataGridViewTextBoxColumn APELLIDO2_PACIENTE;
        private System.Windows.Forms.DataGridViewTextBoxColumn CEDULA_PACIENTE;
        private System.Windows.Forms.DataGridViewTextBoxColumn TELEFONO_PACIENTE;
        private System.Windows.Forms.DataGridViewTextBoxColumn CORREO_PACIENTE;
        private System.Windows.Forms.DataGridViewTextBoxColumn DIRECCION_PACIENTE;
        private System.Windows.Forms.DataGridViewTextBoxColumn FECHA_NACIMIENTO_PACIENTE;
        private System.Windows.Forms.DataGridViewTextBoxColumn ESTADO_PACIENTE;
        private System.Windows.Forms.DataGridViewTextBoxColumn BORRADO_PACIENTE;
        private System.Windows.Forms.TextBox txtID_Paciente;
        private System.Windows.Forms.Label label10;
    }
}