namespace Capa01_Presentacion
{
    partial class Frm_Citas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Citas));
            groupBox1 = new System.Windows.Forms.GroupBox();
            txtEstado = new System.Windows.Forms.TextBox();
            label7 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            txtID_Funcionario = new System.Windows.Forms.TextBox();
            txtMotivo = new System.Windows.Forms.TextBox();
            label3 = new System.Windows.Forms.Label();
            txtHoraFin = new System.Windows.Forms.TextBox();
            txtHoraInicio = new System.Windows.Forms.TextBox();
            dtp_Fecha = new System.Windows.Forms.DateTimePicker();
            label1 = new System.Windows.Forms.Label();
            grdLista = new System.Windows.Forms.DataGridView();
            IdCita = new System.Windows.Forms.DataGridViewTextBoxColumn();
            IdPaciente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            IdFuncionario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Motivo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            HoraInicio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            HoraFin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            btnLimpiar = new System.Windows.Forms.Button();
            btnSalir = new System.Windows.Forms.Button();
            btnEliminar = new System.Windows.Forms.Button();
            btnGuardar = new System.Windows.Forms.Button();
            btnBuscar = new System.Windows.Forms.Button();
            label5 = new System.Windows.Forms.Label();
            txtID_Cita = new System.Windows.Forms.TextBox();
            label10 = new System.Windows.Forms.Label();
            label6 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            txtID_Paciente = new System.Windows.Forms.TextBox();
            grdEspecialista = new System.Windows.Forms.DataGridView();
            NOMBRE_ESPECIALIDAD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ID_FUNCIONARIO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            NOMBRE_FUNCIONARIO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            APELLIDOS_FUNCIONARIO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            FECHA_CITA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            HORA_INICIO_CITA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            HORA_FIN_CITA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            groupBox2 = new System.Windows.Forms.GroupBox();
            label8 = new System.Windows.Forms.Label();
            groupBox3 = new System.Windows.Forms.GroupBox();
            label9 = new System.Windows.Forms.Label();
            grdPaciente = new System.Windows.Forms.DataGridView();
            ID_PACIENTE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            NOMBRE_PACIENTE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            APELLIDOS_PACIENTE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            CEDULA_PACIENTE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            TELEFONO_PACIENTE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            CORREO_PACIENTE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            DIRECCION_PACIENTE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            FECHA_NACIMIENTO_PACIENTE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Existe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)grdLista).BeginInit();
            ((System.ComponentModel.ISupportInitialize)grdEspecialista).BeginInit();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)grdPaciente).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackColor = System.Drawing.Color.Transparent;
            groupBox1.Controls.Add(txtEstado);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(txtID_Funcionario);
            groupBox1.Controls.Add(txtMotivo);
            groupBox1.Controls.Add(label3);
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
            groupBox1.Controls.Add(txtID_Cita);
            groupBox1.Controls.Add(label10);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(txtID_Paciente);
            groupBox1.Location = new System.Drawing.Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new System.Drawing.Size(872, 421);
            groupBox1.TabIndex = 58;
            groupBox1.TabStop = false;
            groupBox1.Text = "Agendar una Cita";
            // 
            // txtEstado
            // 
            txtEstado.BackColor = System.Drawing.SystemColors.Info;
            txtEstado.Enabled = false;
            txtEstado.Location = new System.Drawing.Point(724, 36);
            txtEstado.Name = "txtEstado";
            txtEstado.Size = new System.Drawing.Size(100, 23);
            txtEstado.TabIndex = 72;
            txtEstado.TextChanged += txtEstado_TextChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new System.Drawing.Point(724, 18);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(42, 15);
            label7.TabIndex = 71;
            label7.Text = "Estado";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(227, 16);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(84, 15);
            label4.TabIndex = 69;
            label4.Text = "ID Funcionario";
            // 
            // txtID_Funcionario
            // 
            txtID_Funcionario.BackColor = System.Drawing.SystemColors.Info;
            txtID_Funcionario.Enabled = false;
            txtID_Funcionario.Location = new System.Drawing.Point(227, 36);
            txtID_Funcionario.Name = "txtID_Funcionario";
            txtID_Funcionario.Size = new System.Drawing.Size(100, 23);
            txtID_Funcionario.TabIndex = 70;
            // 
            // txtMotivo
            // 
            txtMotivo.Location = new System.Drawing.Point(15, 87);
            txtMotivo.Name = "txtMotivo";
            txtMotivo.Size = new System.Drawing.Size(809, 23);
            txtMotivo.TabIndex = 68;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(15, 69);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(45, 15);
            label3.TabIndex = 67;
            label3.Text = "Motivo";
            // 
            // txtHoraFin
            // 
            txtHoraFin.BackColor = System.Drawing.SystemColors.Info;
            txtHoraFin.Enabled = false;
            txtHoraFin.Location = new System.Drawing.Point(615, 36);
            txtHoraFin.Name = "txtHoraFin";
            txtHoraFin.Size = new System.Drawing.Size(100, 23);
            txtHoraFin.TabIndex = 66;
            // 
            // txtHoraInicio
            // 
            txtHoraInicio.Location = new System.Drawing.Point(511, 36);
            txtHoraInicio.Name = "txtHoraInicio";
            txtHoraInicio.Size = new System.Drawing.Size(100, 23);
            txtHoraInicio.TabIndex = 65;
            txtHoraInicio.TextChanged += txtHoraInicio_TextChanged;
            // 
            // dtp_Fecha
            // 
            dtp_Fecha.CalendarMonthBackground = System.Drawing.SystemColors.Menu;
            dtp_Fecha.Enabled = false;
            dtp_Fecha.Location = new System.Drawing.Point(335, 36);
            dtp_Fecha.Name = "dtp_Fecha";
            dtp_Fecha.Size = new System.Drawing.Size(170, 23);
            dtp_Fecha.TabIndex = 64;
            dtp_Fecha.ValueChanged += dtp_Fecha_ValueChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(333, 18);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(38, 15);
            label1.TabIndex = 63;
            label1.Text = "Fecha";
            // 
            // grdLista
            // 
            grdLista.BackgroundColor = System.Drawing.SystemColors.ActiveBorder;
            grdLista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grdLista.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { IdCita, IdPaciente, IdFuncionario, Motivo, Fecha, HoraInicio, HoraFin, Estado, dataGridViewTextBoxColumn3 });
            grdLista.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            grdLista.GridColor = System.Drawing.SystemColors.ActiveBorder;
            grdLista.Location = new System.Drawing.Point(15, 116);
            grdLista.Name = "grdLista";
            grdLista.RowTemplate.Height = 25;
            grdLista.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            grdLista.Size = new System.Drawing.Size(845, 210);
            grdLista.TabIndex = 62;
            grdLista.DoubleClick += grdLista_DoubleClick;
            // 
            // IdCita
            // 
            IdCita.DataPropertyName = "IdCita";
            IdCita.HeaderText = "#Cita";
            IdCita.Name = "IdCita";
            // 
            // IdPaciente
            // 
            IdPaciente.DataPropertyName = "IdPaciente";
            IdPaciente.HeaderText = "#Paciente";
            IdPaciente.Name = "IdPaciente";
            // 
            // IdFuncionario
            // 
            IdFuncionario.DataPropertyName = "IdFuncionario";
            IdFuncionario.HeaderText = "#Funcionario";
            IdFuncionario.Name = "IdFuncionario";
            // 
            // Motivo
            // 
            Motivo.DataPropertyName = "Motivo";
            Motivo.HeaderText = "Motivo";
            Motivo.Name = "Motivo";
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
            // Estado
            // 
            Estado.DataPropertyName = "Estado";
            Estado.HeaderText = "Estado";
            Estado.Name = "Estado";
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
            btnLimpiar.Location = new System.Drawing.Point(284, 334);
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
            btnSalir.Location = new System.Drawing.Point(588, 334);
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
            btnEliminar.Location = new System.Drawing.Point(497, 334);
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
            btnGuardar.Location = new System.Drawing.Point(387, 332);
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
            btnBuscar.Location = new System.Drawing.Point(189, 332);
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
            label5.Location = new System.Drawing.Point(615, 18);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(52, 15);
            label5.TabIndex = 49;
            label5.Text = "Hora Fin";
            // 
            // txtID_Cita
            // 
            txtID_Cita.BackColor = System.Drawing.SystemColors.Info;
            txtID_Cita.Enabled = false;
            txtID_Cita.Location = new System.Drawing.Point(15, 36);
            txtID_Cita.Name = "txtID_Cita";
            txtID_Cita.Size = new System.Drawing.Size(100, 23);
            txtID_Cita.TabIndex = 54;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new System.Drawing.Point(121, 18);
            label10.Name = "label10";
            label10.Size = new System.Drawing.Size(66, 15);
            label10.TabIndex = 51;
            label10.Text = "ID Paciente";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new System.Drawing.Point(15, 18);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(42, 15);
            label6.TabIndex = 53;
            label6.Text = "ID Cita";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(511, 18);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(65, 15);
            label2.TabIndex = 47;
            label2.Text = "Hora Inicio";
            // 
            // txtID_Paciente
            // 
            txtID_Paciente.BackColor = System.Drawing.SystemColors.Info;
            txtID_Paciente.Enabled = false;
            txtID_Paciente.Location = new System.Drawing.Point(121, 36);
            txtID_Paciente.Name = "txtID_Paciente";
            txtID_Paciente.Size = new System.Drawing.Size(100, 23);
            txtID_Paciente.TabIndex = 52;
            // 
            // grdEspecialista
            // 
            grdEspecialista.BackgroundColor = System.Drawing.SystemColors.ActiveBorder;
            grdEspecialista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grdEspecialista.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { NOMBRE_ESPECIALIDAD, ID_FUNCIONARIO, NOMBRE_FUNCIONARIO, APELLIDOS_FUNCIONARIO, FECHA_CITA, HORA_INICIO_CITA, HORA_FIN_CITA });
            grdEspecialista.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            grdEspecialista.GridColor = System.Drawing.SystemColors.ActiveBorder;
            grdEspecialista.Location = new System.Drawing.Point(3, 39);
            grdEspecialista.Name = "grdEspecialista";
            grdEspecialista.RowTemplate.Height = 25;
            grdEspecialista.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            grdEspecialista.Size = new System.Drawing.Size(863, 173);
            grdEspecialista.TabIndex = 63;
            grdEspecialista.CellContentDoubleClick += grdEspecialista_CellContentDoubleClick;
            // 
            // NOMBRE_ESPECIALIDAD
            // 
            NOMBRE_ESPECIALIDAD.DataPropertyName = "NOMBRE_ESPECIALIDAD";
            NOMBRE_ESPECIALIDAD.HeaderText = "Especialidad";
            NOMBRE_ESPECIALIDAD.Name = "NOMBRE_ESPECIALIDAD";
            NOMBRE_ESPECIALIDAD.Width = 110;
            // 
            // ID_FUNCIONARIO
            // 
            ID_FUNCIONARIO.DataPropertyName = "ID_FUNCIONARIO";
            ID_FUNCIONARIO.HeaderText = "#Funcionario";
            ID_FUNCIONARIO.Name = "ID_FUNCIONARIO";
            // 
            // NOMBRE_FUNCIONARIO
            // 
            NOMBRE_FUNCIONARIO.DataPropertyName = "NOMBRE_FUNCIONARIO";
            NOMBRE_FUNCIONARIO.HeaderText = "Especialista";
            NOMBRE_FUNCIONARIO.Name = "NOMBRE_FUNCIONARIO";
            // 
            // APELLIDOS_FUNCIONARIO
            // 
            APELLIDOS_FUNCIONARIO.DataPropertyName = "APELLIDOS_FUNCIONARIO";
            APELLIDOS_FUNCIONARIO.HeaderText = "";
            APELLIDOS_FUNCIONARIO.Name = "APELLIDOS_FUNCIONARIO";
            // 
            // FECHA_CITA
            // 
            FECHA_CITA.DataPropertyName = "FECHA";
            FECHA_CITA.HeaderText = "Dia";
            FECHA_CITA.Name = "FECHA_CITA";
            // 
            // HORA_INICIO_CITA
            // 
            HORA_INICIO_CITA.DataPropertyName = "HORA_INICIO";
            HORA_INICIO_CITA.HeaderText = "Inicio del  Turno";
            HORA_INICIO_CITA.Name = "HORA_INICIO_CITA";
            HORA_INICIO_CITA.Width = 150;
            // 
            // HORA_FIN_CITA
            // 
            HORA_FIN_CITA.DataPropertyName = "HORA_FIN";
            HORA_FIN_CITA.HeaderText = "Fin del Turno";
            HORA_FIN_CITA.Name = "HORA_FIN_CITA";
            HORA_FIN_CITA.Width = 150;
            // 
            // groupBox2
            // 
            groupBox2.BackColor = System.Drawing.Color.Transparent;
            groupBox2.Controls.Add(label8);
            groupBox2.Controls.Add(grdEspecialista);
            groupBox2.Location = new System.Drawing.Point(12, 439);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new System.Drawing.Size(872, 218);
            groupBox2.TabIndex = 64;
            groupBox2.TabStop = false;
            groupBox2.Text = "Especialistas Disponibles";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new System.Drawing.Point(6, 21);
            label8.Name = "label8";
            label8.Size = new System.Drawing.Size(388, 15);
            label8.TabIndex = 64;
            label8.Text = "*Doble click para elegir al Especialista con el que se desea agendar la cita";
            // 
            // groupBox3
            // 
            groupBox3.BackColor = System.Drawing.Color.Transparent;
            groupBox3.Controls.Add(label9);
            groupBox3.Controls.Add(grdPaciente);
            groupBox3.Location = new System.Drawing.Point(890, 12);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new System.Drawing.Size(415, 645);
            groupBox3.TabIndex = 65;
            groupBox3.TabStop = false;
            groupBox3.Text = "Paciente";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new System.Drawing.Point(17, 36);
            label9.Name = "label9";
            label9.Size = new System.Drawing.Size(373, 15);
            label9.TabIndex = 65;
            label9.Text = "*Doble click para elegir al Paciente con el que se desea agendar la cita";
            // 
            // grdPaciente
            // 
            grdPaciente.BackgroundColor = System.Drawing.SystemColors.ActiveBorder;
            grdPaciente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grdPaciente.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { ID_PACIENTE, NOMBRE_PACIENTE, APELLIDOS_PACIENTE, CEDULA_PACIENTE, TELEFONO_PACIENTE, CORREO_PACIENTE, DIRECCION_PACIENTE, FECHA_NACIMIENTO_PACIENTE, Existe });
            grdPaciente.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            grdPaciente.GridColor = System.Drawing.SystemColors.ActiveBorder;
            grdPaciente.Location = new System.Drawing.Point(6, 69);
            grdPaciente.Name = "grdPaciente";
            grdPaciente.RowTemplate.Height = 25;
            grdPaciente.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            grdPaciente.Size = new System.Drawing.Size(402, 570);
            grdPaciente.TabIndex = 15;
            grdPaciente.CellDoubleClick += gdrPaciente_CellDoubleClick;
            // 
            // ID_PACIENTE
            // 
            ID_PACIENTE.DataPropertyName = "IdPaciente";
            ID_PACIENTE.HeaderText = "#Paciente";
            ID_PACIENTE.Name = "ID_PACIENTE";
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
            CORREO_PACIENTE.Visible = false;
            CORREO_PACIENTE.Width = 150;
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
            // 
            // Existe
            // 
            Existe.DataPropertyName = "Existe";
            Existe.HeaderText = "Existe";
            Existe.Name = "Existe";
            Existe.Visible = false;
            // 
            // Frm_Citas
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            BackgroundImage = Properties.Resources.Screenshot_2023_06_10_171827;
            BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            ClientSize = new System.Drawing.Size(1313, 666);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            DoubleBuffered = true;
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Frm_Citas";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Citas";
            Load += Frm_Citas_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)grdLista).EndInit();
            ((System.ComponentModel.ISupportInitialize)grdEspecialista).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)grdPaciente).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtMotivo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtHoraFin;
        private System.Windows.Forms.TextBox txtHoraInicio;
        private System.Windows.Forms.DateTimePicker dtp_Fecha;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView grdLista;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtID_Cita;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtID_Paciente;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtID_Funcionario;
        private System.Windows.Forms.TextBox txtEstado;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView grdEspecialista;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdCita;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdPaciente;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdFuncionario;
        private System.Windows.Forms.DataGridViewTextBoxColumn Motivo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn HoraInicio;
        private System.Windows.Forms.DataGridViewTextBoxColumn HoraFin;
        private System.Windows.Forms.DataGridViewTextBoxColumn Estado;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView grdPaciente;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_PACIENTE;
        private System.Windows.Forms.DataGridViewTextBoxColumn NOMBRE_PACIENTE;
        private System.Windows.Forms.DataGridViewTextBoxColumn APELLIDOS_PACIENTE;
        private System.Windows.Forms.DataGridViewTextBoxColumn CEDULA_PACIENTE;
        private System.Windows.Forms.DataGridViewTextBoxColumn TELEFONO_PACIENTE;
        private System.Windows.Forms.DataGridViewTextBoxColumn CORREO_PACIENTE;
        private System.Windows.Forms.DataGridViewTextBoxColumn DIRECCION_PACIENTE;
        private System.Windows.Forms.DataGridViewTextBoxColumn FECHA_NACIMIENTO_PACIENTE;
        private System.Windows.Forms.DataGridViewTextBoxColumn Existe;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridViewTextBoxColumn NOMBRE_ESPECIALIDAD;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_FUNCIONARIO;
        private System.Windows.Forms.DataGridViewTextBoxColumn NOMBRE_FUNCIONARIO;
        private System.Windows.Forms.DataGridViewTextBoxColumn APELLIDOS_FUNCIONARIO;
        private System.Windows.Forms.DataGridViewTextBoxColumn FECHA_CITA;
        private System.Windows.Forms.DataGridViewTextBoxColumn HORA_INICIO_CITA;
        private System.Windows.Forms.DataGridViewTextBoxColumn HORA_FIN_CITA;
    }
}