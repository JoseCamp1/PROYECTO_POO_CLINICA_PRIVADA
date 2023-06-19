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
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)grdLista).BeginInit();
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
            groupBox1.Size = new System.Drawing.Size(872, 389);
            groupBox1.TabIndex = 58;
            groupBox1.TabStop = false;
            groupBox1.Text = "Cita";
            // 
            // txtEstado
            // 
            txtEstado.Location = new System.Drawing.Point(724, 36);
            txtEstado.Name = "txtEstado";
            txtEstado.Size = new System.Drawing.Size(100, 23);
            txtEstado.TabIndex = 72;
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
            // 
            // dtp_Fecha
            // 
            dtp_Fecha.Location = new System.Drawing.Point(335, 36);
            dtp_Fecha.Name = "dtp_Fecha";
            dtp_Fecha.Size = new System.Drawing.Size(170, 23);
            dtp_Fecha.TabIndex = 64;
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
            grdLista.Size = new System.Drawing.Size(845, 164);
            grdLista.TabIndex = 62;
            grdLista.DoubleClick += grdLista_DoubleClick;
            // 
            // IdCita
            // 
            IdCita.DataPropertyName = "IdCita";
            IdCita.HeaderText = "ID Cita";
            IdCita.Name = "IdCita";
            // 
            // IdPaciente
            // 
            IdPaciente.DataPropertyName = "IdPaciente";
            IdPaciente.HeaderText = "ID Paciente";
            IdPaciente.Name = "IdPaciente";
            // 
            // IdFuncionario
            // 
            IdFuncionario.DataPropertyName = "IdFuncionario";
            IdFuncionario.HeaderText = "ID Funcionario";
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
            btnLimpiar.BackColor = System.Drawing.SystemColors.Window;
            btnLimpiar.Image = Properties.Resources.broom_5182;
            btnLimpiar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            btnLimpiar.Location = new System.Drawing.Point(111, 296);
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
            btnSalir.Location = new System.Drawing.Point(415, 296);
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
            btnEliminar.Location = new System.Drawing.Point(324, 296);
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
            btnGuardar.Location = new System.Drawing.Point(214, 294);
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
            btnBuscar.Location = new System.Drawing.Point(16, 294);
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
            // Frm_Citas
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            BackgroundImage = Properties.Resources.Screenshot_2023_06_10_171827;
            BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            ClientSize = new System.Drawing.Size(1492, 694);
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
        private System.Windows.Forms.DataGridViewTextBoxColumn IdCita;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdPaciente;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdFuncionario;
        private System.Windows.Forms.DataGridViewTextBoxColumn Motivo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn HoraInicio;
        private System.Windows.Forms.DataGridViewTextBoxColumn HoraFin;
        private System.Windows.Forms.DataGridViewTextBoxColumn Estado;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.TextBox txtEstado;
        private System.Windows.Forms.Label label7;
    }
}