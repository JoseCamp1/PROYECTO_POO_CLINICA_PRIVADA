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
            grdEspecialista = new System.Windows.Forms.DataGridView();
            label3 = new System.Windows.Forms.Label();
            txtHoraFin = new System.Windows.Forms.TextBox();
            txtHoraInicio = new System.Windows.Forms.TextBox();
            dtp_Fecha = new System.Windows.Forms.DateTimePicker();
            label1 = new System.Windows.Forms.Label();
            grdLista = new System.Windows.Forms.DataGridView();
            btnLimpiar = new System.Windows.Forms.Button();
            btnSalir = new System.Windows.Forms.Button();
            btnEliminar = new System.Windows.Forms.Button();
            btnGuardar = new System.Windows.Forms.Button();
            btnBuscar = new System.Windows.Forms.Button();
            groupBox2 = new System.Windows.Forms.GroupBox();
            NOMBRE_ESPECIALIDAD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            NOMBRE_FUNCIONARIO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            APELLIDOS_FUNCIONARIO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            FECHA_CITA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            HORA_INICIO_CITA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            HORA_FIN_CITA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            IDAGENDA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ID_Funcionario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            HoraInicio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            HoraFin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            groupBox3 = new System.Windows.Forms.GroupBox();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)grdEspecialista).BeginInit();
            ((System.ComponentModel.ISupportInitialize)grdLista).BeginInit();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // txtID_Agenda
            // 
            txtID_Agenda.BackColor = System.Drawing.SystemColors.Info;
            txtID_Agenda.Enabled = false;
            txtID_Agenda.Location = new System.Drawing.Point(14, 51);
            txtID_Agenda.Name = "txtID_Agenda";
            txtID_Agenda.Size = new System.Drawing.Size(100, 23);
            txtID_Agenda.TabIndex = 54;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new System.Drawing.Point(14, 33);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(62, 15);
            label6.TabIndex = 53;
            label6.Text = "ID Agenda";
            // 
            // txtID_Funcionario
            // 
            txtID_Funcionario.BackColor = System.Drawing.SystemColors.Info;
            txtID_Funcionario.Enabled = false;
            txtID_Funcionario.Location = new System.Drawing.Point(120, 51);
            txtID_Funcionario.Name = "txtID_Funcionario";
            txtID_Funcionario.Size = new System.Drawing.Size(100, 23);
            txtID_Funcionario.TabIndex = 52;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(402, 33);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(65, 15);
            label2.TabIndex = 47;
            label2.Text = "Hora Inicio";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new System.Drawing.Point(120, 33);
            label10.Name = "label10";
            label10.Size = new System.Drawing.Size(84, 15);
            label10.TabIndex = 51;
            label10.Text = "ID Funcionario";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new System.Drawing.Point(506, 33);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(52, 15);
            label5.TabIndex = 49;
            label5.Text = "Hora Fin";
            // 
            // groupBox1
            // 
            groupBox1.BackColor = System.Drawing.Color.Transparent;
            groupBox1.Controls.Add(groupBox3);
            groupBox1.Controls.Add(groupBox2);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(txtHoraFin);
            groupBox1.Controls.Add(txtHoraInicio);
            groupBox1.Controls.Add(dtp_Fecha);
            groupBox1.Controls.Add(label1);
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
            groupBox1.Size = new System.Drawing.Size(625, 657);
            groupBox1.TabIndex = 57;
            groupBox1.TabStop = false;
            groupBox1.Text = "Agenda del Especialista";
            // 
            // grdEspecialista
            // 
            grdEspecialista.BackgroundColor = System.Drawing.SystemColors.ActiveBorder;
            grdEspecialista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grdEspecialista.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { NOMBRE_ESPECIALIDAD, dataGridViewTextBoxColumn1, NOMBRE_FUNCIONARIO, APELLIDOS_FUNCIONARIO, FECHA_CITA, HORA_INICIO_CITA, HORA_FIN_CITA });
            grdEspecialista.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            grdEspecialista.GridColor = System.Drawing.SystemColors.ActiveBorder;
            grdEspecialista.Location = new System.Drawing.Point(6, 22);
            grdEspecialista.Name = "grdEspecialista";
            grdEspecialista.RowTemplate.Height = 25;
            grdEspecialista.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            grdEspecialista.Size = new System.Drawing.Size(568, 212);
            grdEspecialista.TabIndex = 69;
            grdEspecialista.CellDoubleClick += grdEspecialista_CellDoubleClick;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(44, 100);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(525, 15);
            label3.TabIndex = 68;
            label3.Text = "*Doble click para agregar el ID Funcionario del Especialista del que desea crear o editar una agenda";
            // 
            // txtHoraFin
            // 
            txtHoraFin.Location = new System.Drawing.Point(506, 51);
            txtHoraFin.Name = "txtHoraFin";
            txtHoraFin.Size = new System.Drawing.Size(100, 23);
            txtHoraFin.TabIndex = 66;
            // 
            // txtHoraInicio
            // 
            txtHoraInicio.Location = new System.Drawing.Point(402, 51);
            txtHoraInicio.Name = "txtHoraInicio";
            txtHoraInicio.Size = new System.Drawing.Size(100, 23);
            txtHoraInicio.TabIndex = 65;
            // 
            // dtp_Fecha
            // 
            dtp_Fecha.Location = new System.Drawing.Point(226, 51);
            dtp_Fecha.Name = "dtp_Fecha";
            dtp_Fecha.Size = new System.Drawing.Size(170, 23);
            dtp_Fecha.TabIndex = 64;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(224, 33);
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
            grdLista.Location = new System.Drawing.Point(7, 20);
            grdLista.Name = "grdLista";
            grdLista.RowTemplate.Height = 25;
            grdLista.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            grdLista.Size = new System.Drawing.Size(568, 178);
            grdLista.TabIndex = 62;
            grdLista.DoubleClick += grdLista_DoubleClick;
            // 
            // btnLimpiar
            // 
            btnLimpiar.BackColor = System.Drawing.SystemColors.Window;
            btnLimpiar.Image = Properties.Resources.broom_5182;
            btnLimpiar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            btnLimpiar.Location = new System.Drawing.Point(162, 580);
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
            btnSalir.Location = new System.Drawing.Point(461, 580);
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
            btnEliminar.Location = new System.Drawing.Point(363, 580);
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
            btnGuardar.Location = new System.Drawing.Point(265, 578);
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
            btnBuscar.Location = new System.Drawing.Point(67, 578);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new System.Drawing.Size(75, 71);
            btnBuscar.TabIndex = 57;
            btnBuscar.Text = "&Buscar";
            btnBuscar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            btnBuscar.UseVisualStyleBackColor = false;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(grdEspecialista);
            groupBox2.Location = new System.Drawing.Point(14, 118);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new System.Drawing.Size(581, 240);
            groupBox2.TabIndex = 70;
            groupBox2.TabStop = false;
            groupBox2.Text = "Especialistas";
            // 
            // NOMBRE_ESPECIALIDAD
            // 
            NOMBRE_ESPECIALIDAD.DataPropertyName = "NOMBRE_ESPECIALIDAD";
            NOMBRE_ESPECIALIDAD.HeaderText = "Especialidad";
            NOMBRE_ESPECIALIDAD.Name = "NOMBRE_ESPECIALIDAD";
            NOMBRE_ESPECIALIDAD.Width = 110;
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.DataPropertyName = "ID_FUNCIONARIO";
            dataGridViewTextBoxColumn1.HeaderText = "ID Funcionario";
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            dataGridViewTextBoxColumn1.Width = 150;
            // 
            // NOMBRE_FUNCIONARIO
            // 
            NOMBRE_FUNCIONARIO.DataPropertyName = "NOMBRE_FUNCIONARIO";
            NOMBRE_FUNCIONARIO.HeaderText = "Nombre";
            NOMBRE_FUNCIONARIO.Name = "NOMBRE_FUNCIONARIO";
            // 
            // APELLIDOS_FUNCIONARIO
            // 
            APELLIDOS_FUNCIONARIO.DataPropertyName = "APELLIDOS_FUNCIONARIO";
            APELLIDOS_FUNCIONARIO.HeaderText = "Apellidos";
            APELLIDOS_FUNCIONARIO.Name = "APELLIDOS_FUNCIONARIO";
            // 
            // FECHA_CITA
            // 
            FECHA_CITA.DataPropertyName = "FECHA";
            FECHA_CITA.HeaderText = "Dia";
            FECHA_CITA.Name = "FECHA_CITA";
            FECHA_CITA.Visible = false;
            // 
            // HORA_INICIO_CITA
            // 
            HORA_INICIO_CITA.DataPropertyName = "HORA_INICIO";
            HORA_INICIO_CITA.HeaderText = "Inicio del  Turno";
            HORA_INICIO_CITA.Name = "HORA_INICIO_CITA";
            HORA_INICIO_CITA.Visible = false;
            HORA_INICIO_CITA.Width = 150;
            // 
            // HORA_FIN_CITA
            // 
            HORA_FIN_CITA.DataPropertyName = "HORA_FIN";
            HORA_FIN_CITA.HeaderText = "Fin del Turno";
            HORA_FIN_CITA.Name = "HORA_FIN_CITA";
            HORA_FIN_CITA.Visible = false;
            HORA_FIN_CITA.Width = 150;
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
            ID_Funcionario.Width = 120;
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
            // groupBox3
            // 
            groupBox3.Controls.Add(grdLista);
            groupBox3.Location = new System.Drawing.Point(14, 364);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new System.Drawing.Size(581, 204);
            groupBox3.TabIndex = 71;
            groupBox3.TabStop = false;
            groupBox3.Text = "Agendas";
            // 
            // Frm_Agenda
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            BackColor = System.Drawing.SystemColors.Window;
            BackgroundImage = Properties.Resources.Screenshot_2023_06_10_171827;
            BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            ClientSize = new System.Drawing.Size(647, 681);
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
            ((System.ComponentModel.ISupportInitialize)grdEspecialista).EndInit();
            ((System.ComponentModel.ISupportInitialize)grdLista).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
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
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView grdEspecialista;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDAGENDA;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_Funcionario;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn HoraInicio;
        private System.Windows.Forms.DataGridViewTextBoxColumn HoraFin;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn NOMBRE_ESPECIALIDAD;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn NOMBRE_FUNCIONARIO;
        private System.Windows.Forms.DataGridViewTextBoxColumn APELLIDOS_FUNCIONARIO;
        private System.Windows.Forms.DataGridViewTextBoxColumn FECHA_CITA;
        private System.Windows.Forms.DataGridViewTextBoxColumn HORA_INICIO_CITA;
        private System.Windows.Forms.DataGridViewTextBoxColumn HORA_FIN_CITA;
    }
}