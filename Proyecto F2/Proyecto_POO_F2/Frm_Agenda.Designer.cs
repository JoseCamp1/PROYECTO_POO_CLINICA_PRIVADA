namespace Capa01_Presentacion
{
    partial class Frm_Agenda
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Agenda));
            txtID_Agenda = new System.Windows.Forms.TextBox();
            label6 = new System.Windows.Forms.Label();
            txtID_Funcionario = new System.Windows.Forms.TextBox();
            label2 = new System.Windows.Forms.Label();
            label10 = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            groupBox1 = new System.Windows.Forms.GroupBox();
            label3 = new System.Windows.Forms.Label();
            grdFuncionario = new System.Windows.Forms.DataGridView();
            dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            txtHoraFin = new System.Windows.Forms.TextBox();
            txtHoraInicio = new System.Windows.Forms.TextBox();
            dtp_Fecha = new System.Windows.Forms.DateTimePicker();
            label1 = new System.Windows.Forms.Label();
            grdLista = new System.Windows.Forms.DataGridView();
            IDAGENDA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ID_Funcionario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            HoraInicio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            HoraFin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            btnLimpiar = new System.Windows.Forms.Button();
            btnSalir = new System.Windows.Forms.Button();
            btnEliminar = new System.Windows.Forms.Button();
            btnGuardar = new System.Windows.Forms.Button();
            btnBuscar = new System.Windows.Forms.Button();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)grdFuncionario).BeginInit();
            ((System.ComponentModel.ISupportInitialize)grdLista).BeginInit();
            SuspendLayout();
            // 
            // txtID_Agenda
            // 
            txtID_Agenda.BackColor = System.Drawing.SystemColors.Info;
            txtID_Agenda.Enabled = false;
            txtID_Agenda.Location = new System.Drawing.Point(318, 39);
            txtID_Agenda.Name = "txtID_Agenda";
            txtID_Agenda.Size = new System.Drawing.Size(100, 23);
            txtID_Agenda.TabIndex = 54;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new System.Drawing.Point(318, 21);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(62, 15);
            label6.TabIndex = 53;
            label6.Text = "ID Agenda";
            // 
            // txtID_Funcionario
            // 
            txtID_Funcionario.BackColor = System.Drawing.SystemColors.Info;
            txtID_Funcionario.Enabled = false;
            txtID_Funcionario.Location = new System.Drawing.Point(424, 39);
            txtID_Funcionario.Name = "txtID_Funcionario";
            txtID_Funcionario.Size = new System.Drawing.Size(100, 23);
            txtID_Funcionario.TabIndex = 52;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(706, 21);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(65, 15);
            label2.TabIndex = 47;
            label2.Text = "Hora Inicio";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new System.Drawing.Point(424, 21);
            label10.Name = "label10";
            label10.Size = new System.Drawing.Size(84, 15);
            label10.TabIndex = 51;
            label10.Text = "ID Funcionario";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new System.Drawing.Point(810, 21);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(52, 15);
            label5.TabIndex = 49;
            label5.Text = "Hora Fin";
            // 
            // groupBox1
            // 
            groupBox1.BackColor = System.Drawing.Color.Transparent;
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(grdFuncionario);
            groupBox1.Controls.Add(txtHoraFin);
            groupBox1.Controls.Add(txtHoraInicio);
            groupBox1.Controls.Add(dtp_Fecha);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(grdLista);
            groupBox1.Controls.Add(btnLimpiar);
            groupBox1.Controls.Add(btnSalir);
            groupBox1.Controls.Add(btnEliminar);
            groupBox1.Controls.Add(btnGuardar);
            groupBox1.Controls.Add(btnBuscar);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(txtID_Agenda);
            groupBox1.Controls.Add(label10);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(txtID_Funcionario);
            groupBox1.Location = new System.Drawing.Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new System.Drawing.Size(1256, 561);
            groupBox1.TabIndex = 57;
            groupBox1.TabStop = false;
            groupBox1.Text = "Agenda del Especialista";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(385, 86);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(525, 15);
            label3.TabIndex = 68;
            label3.Text = "*Doble click para agregar el ID Funcionario del Especialista del que desea crear o editar una agenda";
            // 
            // grdFuncionario
            // 
            grdFuncionario.BackgroundColor = System.Drawing.SystemColors.ActiveBorder;
            grdFuncionario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grdFuncionario.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { dataGridViewTextBoxColumn1, ID_PuestodeTrabajo, Id_Especialidad, NOMBRE_PACIENTE, APELLIDOS_PACIENTE, CEDULA_PACIENTE, TELEFONO_PACIENTE, CORREO_PACIENTE, DIRECCION_PACIENTE, FECHA_NACIMIENTO_PACIENTE, Existe });
            grdFuncionario.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            grdFuncionario.GridColor = System.Drawing.SystemColors.ActiveBorder;
            grdFuncionario.Location = new System.Drawing.Point(6, 113);
            grdFuncionario.Name = "grdFuncionario";
            grdFuncionario.RowTemplate.Height = 25;
            grdFuncionario.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            grdFuncionario.Size = new System.Drawing.Size(1245, 193);
            grdFuncionario.TabIndex = 67;
            grdFuncionario.CellDoubleClick += grdFuncionario_CellDoubleClick;
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.DataPropertyName = "IdFuncionario";
            dataGridViewTextBoxColumn1.HeaderText = "Funcionario";
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
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
            APELLIDOS_PACIENTE.Width = 150;
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
            CORREO_PACIENTE.Width = 150;
            // 
            // DIRECCION_PACIENTE
            // 
            DIRECCION_PACIENTE.DataPropertyName = "Direccion";
            DIRECCION_PACIENTE.HeaderText = "Direccion";
            DIRECCION_PACIENTE.Name = "DIRECCION_PACIENTE";
            DIRECCION_PACIENTE.Width = 150;
            // 
            // FECHA_NACIMIENTO_PACIENTE
            // 
            FECHA_NACIMIENTO_PACIENTE.DataPropertyName = "FechaNacimiento";
            FECHA_NACIMIENTO_PACIENTE.HeaderText = "Fecha de Nacimiento";
            FECHA_NACIMIENTO_PACIENTE.Name = "FECHA_NACIMIENTO_PACIENTE";
            FECHA_NACIMIENTO_PACIENTE.Width = 150;
            // 
            // Existe
            // 
            Existe.DataPropertyName = "Existe";
            Existe.HeaderText = "Existe";
            Existe.Name = "Existe";
            Existe.Visible = false;
            // 
            // txtHoraFin
            // 
            txtHoraFin.Location = new System.Drawing.Point(810, 39);
            txtHoraFin.Name = "txtHoraFin";
            txtHoraFin.Size = new System.Drawing.Size(100, 23);
            txtHoraFin.TabIndex = 66;
            // 
            // txtHoraInicio
            // 
            txtHoraInicio.Location = new System.Drawing.Point(706, 39);
            txtHoraInicio.Name = "txtHoraInicio";
            txtHoraInicio.Size = new System.Drawing.Size(100, 23);
            txtHoraInicio.TabIndex = 65;
            // 
            // dtp_Fecha
            // 
            dtp_Fecha.Location = new System.Drawing.Point(530, 39);
            dtp_Fecha.Name = "dtp_Fecha";
            dtp_Fecha.Size = new System.Drawing.Size(170, 23);
            dtp_Fecha.TabIndex = 64;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(528, 21);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(38, 15);
            label1.TabIndex = 63;
            label1.Text = "Fecha";
            // 
            // grdLista
            // 
            grdLista.BackgroundColor = System.Drawing.SystemColors.ActiveBorder;
            grdLista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grdLista.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { IDAGENDA, ID_Funcionario, Fecha, HoraInicio, HoraFin, dataGridViewTextBoxColumn3 });
            grdLista.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            grdLista.GridColor = System.Drawing.SystemColors.ActiveBorder;
            grdLista.Location = new System.Drawing.Point(333, 312);
            grdLista.Name = "grdLista";
            grdLista.RowTemplate.Height = 25;
            grdLista.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            grdLista.Size = new System.Drawing.Size(549, 164);
            grdLista.TabIndex = 62;
            grdLista.DoubleClick += grdLista_DoubleClick;
            // 
            // IDAGENDA
            // 
            IDAGENDA.DataPropertyName = "IdAgenda";
            IDAGENDA.HeaderText = "ID Agenda ";
            IDAGENDA.Name = "IDAGENDA";
            // 
            // ID_Funcionario
            // 
            ID_Funcionario.DataPropertyName = "IdFuncionario";
            ID_Funcionario.HeaderText = "ID Funcionario ";
            ID_Funcionario.Name = "ID_Funcionario";
            // 
            // Fecha
            // 
            Fecha.DataPropertyName = "Fecha";
            Fecha.HeaderText = "Fecha ";
            Fecha.Name = "Fecha";
            // 
            // HoraInicio
            // 
            HoraInicio.DataPropertyName = "HoraInicio";
            HoraInicio.HeaderText = "Hora Inicio ";
            HoraInicio.Name = "HoraInicio";
            // 
            // HoraFin
            // 
            HoraFin.DataPropertyName = "HoraFin";
            HoraFin.HeaderText = "Hora Fin ";
            HoraFin.Name = "HoraFin";
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
            btnLimpiar.BackColor = System.Drawing.SystemColors.Window;
            btnLimpiar.Image = Properties.Resources.broom_5182;
            btnLimpiar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            btnLimpiar.Location = new System.Drawing.Point(472, 484);
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
            btnSalir.BackColor = System.Drawing.SystemColors.Window;
            btnSalir.Image = Properties.Resources._4115235_exit_logout_sign_out_114030;
            btnSalir.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            btnSalir.Location = new System.Drawing.Point(776, 484);
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
            btnEliminar.BackColor = System.Drawing.SystemColors.Window;
            btnEliminar.Image = Properties.Resources.trash_bin_icon_icons_com_67981;
            btnEliminar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            btnEliminar.Location = new System.Drawing.Point(685, 484);
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
            btnGuardar.BackColor = System.Drawing.SystemColors.Window;
            btnGuardar.Image = Properties.Resources._1490129329_rounded38_82203;
            btnGuardar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            btnGuardar.Location = new System.Drawing.Point(575, 482);
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
            btnBuscar.BackColor = System.Drawing.SystemColors.Window;
            btnBuscar.Image = Properties.Resources.seo_social_web_network_internet_340_icon_icons_com_61497;
            btnBuscar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            btnBuscar.Location = new System.Drawing.Point(377, 482);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new System.Drawing.Size(75, 71);
            btnBuscar.TabIndex = 57;
            btnBuscar.Text = "&Buscar";
            btnBuscar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            btnBuscar.UseVisualStyleBackColor = false;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // Frm_Agenda
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            BackColor = System.Drawing.SystemColors.Window;
            BackgroundImage = Properties.Resources.Screenshot_2023_06_10_171827;
            BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            ClientSize = new System.Drawing.Size(1278, 585);
            Controls.Add(groupBox1);
            DoubleBuffered = true;
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Frm_Agenda";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Agenda";
            Load += Frm_Agenda_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)grdFuncionario).EndInit();
            ((System.ComponentModel.ISupportInitialize)grdLista).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private System.Windows.Forms.TextBox txtID_Agenda;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtID_Funcionario;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.DataGridView grdLista;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtp_Fecha;
        private System.Windows.Forms.TextBox txtHoraFin;
        private System.Windows.Forms.TextBox txtHoraInicio;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDAGENDA;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_Funcionario;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn HoraInicio;
        private System.Windows.Forms.DataGridViewTextBoxColumn HoraFin;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridView grdFuncionario;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
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
        private System.Windows.Forms.Label label3;
    }
}