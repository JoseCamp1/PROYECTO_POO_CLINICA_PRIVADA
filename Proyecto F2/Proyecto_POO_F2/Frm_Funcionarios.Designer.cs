namespace Capa01_Presentacion
{
    partial class Frm_Funcionarios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Funcionarios));
            groupBoxPaciente = new System.Windows.Forms.GroupBox();
            groupBox2 = new System.Windows.Forms.GroupBox();
            grdEspecialidad = new System.Windows.Forms.DataGridView();
            groupBox1 = new System.Windows.Forms.GroupBox();
            grdPuesto = new System.Windows.Forms.DataGridView();
            label11 = new System.Windows.Forms.Label();
            txt_ID_PUESTO_TRABAJO = new System.Windows.Forms.TextBox();
            btnLimpiar = new System.Windows.Forms.Button();
            btnSalir = new System.Windows.Forms.Button();
            btnEliminar = new System.Windows.Forms.Button();
            label12 = new System.Windows.Forms.Label();
            btnGuardar = new System.Windows.Forms.Button();
            btnBuscar = new System.Windows.Forms.Button();
            txtID_Especialidad = new System.Windows.Forms.TextBox();
            label9 = new System.Windows.Forms.Label();
            label6 = new System.Windows.Forms.Label();
            txtFechaNacimiento = new System.Windows.Forms.TextBox();
            txtID_Funcionario = new System.Windows.Forms.TextBox();
            label2 = new System.Windows.Forms.Label();
            label10 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            txtNombre = new System.Windows.Forms.TextBox();
            txtTelefono = new System.Windows.Forms.TextBox();
            txtCorreo = new System.Windows.Forms.TextBox();
            grdLista = new System.Windows.Forms.DataGridView();
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
            txtDireccion = new System.Windows.Forms.TextBox();
            label1 = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            txtApellidos = new System.Windows.Forms.TextBox();
            label8 = new System.Windows.Forms.Label();
            label7 = new System.Windows.Forms.Label();
            txtCedula = new System.Windows.Forms.TextBox();
            IdPuestoTrabajo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Nombre_PuestoTrabajo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            IdEspecialidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            groupBoxPaciente.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)grdEspecialidad).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)grdPuesto).BeginInit();
            ((System.ComponentModel.ISupportInitialize)grdLista).BeginInit();
            SuspendLayout();
            // 
            // groupBoxPaciente
            // 
            groupBoxPaciente.BackColor = System.Drawing.Color.Transparent;
            groupBoxPaciente.Controls.Add(groupBox2);
            groupBoxPaciente.Controls.Add(groupBox1);
            groupBoxPaciente.Controls.Add(label11);
            groupBoxPaciente.Controls.Add(txt_ID_PUESTO_TRABAJO);
            groupBoxPaciente.Controls.Add(btnLimpiar);
            groupBoxPaciente.Controls.Add(btnSalir);
            groupBoxPaciente.Controls.Add(btnEliminar);
            groupBoxPaciente.Controls.Add(label12);
            groupBoxPaciente.Controls.Add(btnGuardar);
            groupBoxPaciente.Controls.Add(btnBuscar);
            groupBoxPaciente.Controls.Add(txtID_Especialidad);
            groupBoxPaciente.Controls.Add(label9);
            groupBoxPaciente.Controls.Add(label6);
            groupBoxPaciente.Controls.Add(txtFechaNacimiento);
            groupBoxPaciente.Controls.Add(txtID_Funcionario);
            groupBoxPaciente.Controls.Add(label2);
            groupBoxPaciente.Controls.Add(label10);
            groupBoxPaciente.Controls.Add(label3);
            groupBoxPaciente.Controls.Add(label4);
            groupBoxPaciente.Controls.Add(txtNombre);
            groupBoxPaciente.Controls.Add(txtTelefono);
            groupBoxPaciente.Controls.Add(txtCorreo);
            groupBoxPaciente.Controls.Add(grdLista);
            groupBoxPaciente.Controls.Add(txtDireccion);
            groupBoxPaciente.Controls.Add(label1);
            groupBoxPaciente.Controls.Add(label5);
            groupBoxPaciente.Controls.Add(txtApellidos);
            groupBoxPaciente.Controls.Add(label8);
            groupBoxPaciente.Controls.Add(label7);
            groupBoxPaciente.Controls.Add(txtCedula);
            groupBoxPaciente.Location = new System.Drawing.Point(10, 10);
            groupBoxPaciente.Name = "groupBoxPaciente";
            groupBoxPaciente.Size = new System.Drawing.Size(1258, 512);
            groupBoxPaciente.TabIndex = 49;
            groupBoxPaciente.TabStop = false;
            groupBoxPaciente.Text = "Informacion del Funcionario";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(grdEspecialidad);
            groupBox2.Location = new System.Drawing.Point(624, 83);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new System.Drawing.Size(627, 164);
            groupBox2.TabIndex = 53;
            groupBox2.TabStop = false;
            groupBox2.Text = "Especialidades Medicas";
            // 
            // grdEspecialidad
            // 
            grdEspecialidad.BackgroundColor = System.Drawing.SystemColors.ActiveBorder;
            grdEspecialidad.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grdEspecialidad.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { IdEspecialidad, Nombre, Descripcion, dataGridViewTextBoxColumn1 });
            grdEspecialidad.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            grdEspecialidad.GridColor = System.Drawing.SystemColors.ActiveBorder;
            grdEspecialidad.Location = new System.Drawing.Point(6, 22);
            grdEspecialidad.Name = "grdEspecialidad";
            grdEspecialidad.RowTemplate.Height = 25;
            grdEspecialidad.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            grdEspecialidad.Size = new System.Drawing.Size(615, 137);
            grdEspecialidad.TabIndex = 47;
            grdEspecialidad.CellDoubleClick += grdEspecialidad_CellDoubleClick;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(grdPuesto);
            groupBox1.Location = new System.Drawing.Point(6, 82);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new System.Drawing.Size(612, 165);
            groupBox1.TabIndex = 52;
            groupBox1.TabStop = false;
            groupBox1.Text = "Puestos de Trabajo";
            // 
            // grdPuesto
            // 
            grdPuesto.BackgroundColor = System.Drawing.SystemColors.ActiveBorder;
            grdPuesto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grdPuesto.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { IdPuestoTrabajo, Nombre_PuestoTrabajo, dataGridViewTextBoxColumn2, dataGridViewTextBoxColumn3 });
            grdPuesto.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            grdPuesto.GridColor = System.Drawing.SystemColors.ActiveBorder;
            grdPuesto.Location = new System.Drawing.Point(6, 22);
            grdPuesto.Name = "grdPuesto";
            grdPuesto.RowTemplate.Height = 25;
            grdPuesto.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            grdPuesto.Size = new System.Drawing.Size(600, 137);
            grdPuesto.TabIndex = 48;
            grdPuesto.CellDoubleClick += grdPuesto_CellDoubleClick;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new System.Drawing.Point(121, 66);
            label11.Name = "label11";
            label11.Size = new System.Drawing.Size(288, 15);
            label11.TabIndex = 49;
            label11.Text = "*Doble click sobre el puesto de trabajo para agregarlo";
            // 
            // txt_ID_PUESTO_TRABAJO
            // 
            txt_ID_PUESTO_TRABAJO.BackColor = System.Drawing.SystemColors.Info;
            txt_ID_PUESTO_TRABAJO.Enabled = false;
            txt_ID_PUESTO_TRABAJO.Location = new System.Drawing.Point(203, 40);
            txt_ID_PUESTO_TRABAJO.Name = "txt_ID_PUESTO_TRABAJO";
            txt_ID_PUESTO_TRABAJO.Size = new System.Drawing.Size(100, 23);
            txt_ID_PUESTO_TRABAJO.TabIndex = 51;
            // 
            // btnLimpiar
            // 
            btnLimpiar.BackColor = System.Drawing.SystemColors.Window;
            btnLimpiar.Image = Properties.Resources.broom_5182;
            btnLimpiar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            btnLimpiar.Location = new System.Drawing.Point(509, 435);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new System.Drawing.Size(75, 71);
            btnLimpiar.TabIndex = 48;
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
            btnSalir.Location = new System.Drawing.Point(803, 435);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new System.Drawing.Size(75, 71);
            btnSalir.TabIndex = 47;
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
            btnEliminar.Location = new System.Drawing.Point(704, 435);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new System.Drawing.Size(75, 71);
            btnEliminar.TabIndex = 46;
            btnEliminar.Text = "&Eliminar";
            btnEliminar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            btnEliminar.UseVisualStyleBackColor = false;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new System.Drawing.Point(803, 66);
            label12.Name = "label12";
            label12.Size = new System.Drawing.Size(323, 15);
            label12.TabIndex = 50;
            label12.Text = "*Doble click sobre la especialidad del medico para agregarlo";
            // 
            // btnGuardar
            // 
            btnGuardar.BackColor = System.Drawing.SystemColors.Window;
            btnGuardar.Image = Properties.Resources._1490129329_rounded38_82203;
            btnGuardar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            btnGuardar.Location = new System.Drawing.Point(612, 435);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new System.Drawing.Size(75, 71);
            btnGuardar.TabIndex = 45;
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
            btnBuscar.Location = new System.Drawing.Point(412, 435);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new System.Drawing.Size(75, 71);
            btnBuscar.TabIndex = 44;
            btnBuscar.Text = "&Buscar";
            btnBuscar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            btnBuscar.UseVisualStyleBackColor = false;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // txtID_Especialidad
            // 
            txtID_Especialidad.BackColor = System.Drawing.SystemColors.Info;
            txtID_Especialidad.Enabled = false;
            txtID_Especialidad.Location = new System.Drawing.Point(309, 40);
            txtID_Especialidad.Name = "txtID_Especialidad";
            txtID_Especialidad.Size = new System.Drawing.Size(100, 23);
            txtID_Especialidad.TabIndex = 46;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new System.Drawing.Point(309, 22);
            label9.Name = "label9";
            label9.Size = new System.Drawing.Size(86, 15);
            label9.TabIndex = 45;
            label9.Text = "ID Especialidad";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new System.Drawing.Point(202, 22);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(57, 15);
            label6.TabIndex = 43;
            label6.Text = "ID Puesto";
            // 
            // txtFechaNacimiento
            // 
            txtFechaNacimiento.Location = new System.Drawing.Point(1047, 40);
            txtFechaNacimiento.Name = "txtFechaNacimiento";
            txtFechaNacimiento.Size = new System.Drawing.Size(100, 23);
            txtFechaNacimiento.TabIndex = 35;
            // 
            // txtID_Funcionario
            // 
            txtID_Funcionario.BackColor = System.Drawing.SystemColors.Info;
            txtID_Funcionario.Enabled = false;
            txtID_Funcionario.Location = new System.Drawing.Point(90, 40);
            txtID_Funcionario.Name = "txtID_Funcionario";
            txtID_Funcionario.Size = new System.Drawing.Size(100, 23);
            txtID_Funcionario.TabIndex = 42;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(412, 22);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(51, 15);
            label2.TabIndex = 21;
            label2.Text = "Nombre";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new System.Drawing.Point(90, 22);
            label10.Name = "label10";
            label10.Size = new System.Drawing.Size(84, 15);
            label10.TabIndex = 41;
            label10.Text = "ID Funcionario";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(731, 22);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(52, 15);
            label3.TabIndex = 22;
            label3.Text = "Telefono";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(941, 22);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(57, 15);
            label4.TabIndex = 23;
            label4.Text = "Direccion";
            // 
            // txtNombre
            // 
            txtNombre.Location = new System.Drawing.Point(412, 40);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new System.Drawing.Size(100, 23);
            txtNombre.TabIndex = 25;
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new System.Drawing.Point(731, 40);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new System.Drawing.Size(100, 23);
            txtTelefono.TabIndex = 26;
            // 
            // txtCorreo
            // 
            txtCorreo.Location = new System.Drawing.Point(835, 40);
            txtCorreo.Name = "txtCorreo";
            txtCorreo.Size = new System.Drawing.Size(100, 23);
            txtCorreo.TabIndex = 37;
            // 
            // grdLista
            // 
            grdLista.BackgroundColor = System.Drawing.SystemColors.ActiveBorder;
            grdLista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grdLista.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { ID_FUNCIONARIO, ID_PuestodeTrabajo, Id_Especialidad, NOMBRE_PACIENTE, APELLIDOS_PACIENTE, CEDULA_PACIENTE, TELEFONO_PACIENTE, CORREO_PACIENTE, DIRECCION_PACIENTE, FECHA_NACIMIENTO_PACIENTE, Existe });
            grdLista.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            grdLista.GridColor = System.Drawing.SystemColors.ActiveBorder;
            grdLista.Location = new System.Drawing.Point(6, 253);
            grdLista.Name = "grdLista";
            grdLista.RowTemplate.Height = 25;
            grdLista.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            grdLista.Size = new System.Drawing.Size(1245, 179);
            grdLista.TabIndex = 14;
            grdLista.DoubleClick += grdLista_DoubleClick;
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
            // txtDireccion
            // 
            txtDireccion.Location = new System.Drawing.Point(941, 40);
            txtDireccion.Name = "txtDireccion";
            txtDireccion.Size = new System.Drawing.Size(100, 23);
            txtDireccion.TabIndex = 27;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(835, 22);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(43, 15);
            label1.TabIndex = 36;
            label1.Text = "Correo";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new System.Drawing.Point(518, 22);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(56, 15);
            label5.TabIndex = 28;
            label5.Text = "Apellidos";
            // 
            // txtApellidos
            // 
            txtApellidos.Location = new System.Drawing.Point(518, 40);
            txtApellidos.Name = "txtApellidos";
            txtApellidos.Size = new System.Drawing.Size(100, 23);
            txtApellidos.TabIndex = 29;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new System.Drawing.Point(1047, 22);
            label8.Name = "label8";
            label8.Size = new System.Drawing.Size(119, 15);
            label8.TabIndex = 34;
            label8.Text = "Fecha de Nacimiento";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new System.Drawing.Point(624, 22);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(44, 15);
            label7.TabIndex = 32;
            label7.Text = "Cedula";
            // 
            // txtCedula
            // 
            txtCedula.Location = new System.Drawing.Point(624, 40);
            txtCedula.Name = "txtCedula";
            txtCedula.Size = new System.Drawing.Size(100, 23);
            txtCedula.TabIndex = 33;
            // 
            // IdPuestoTrabajo
            // 
            IdPuestoTrabajo.DataPropertyName = "IdPuestoTrabajo";
            IdPuestoTrabajo.HeaderText = "ID Puesto de Trabajo";
            IdPuestoTrabajo.Name = "IdPuestoTrabajo";
            IdPuestoTrabajo.Width = 150;
            // 
            // Nombre_PuestoTrabajo
            // 
            Nombre_PuestoTrabajo.DataPropertyName = "Nombre";
            Nombre_PuestoTrabajo.HeaderText = "Nombre del Puesto";
            Nombre_PuestoTrabajo.Name = "Nombre_PuestoTrabajo";
            Nombre_PuestoTrabajo.Width = 150;
            // 
            // dataGridViewTextBoxColumn2
            // 
            dataGridViewTextBoxColumn2.DataPropertyName = "Descripcion";
            dataGridViewTextBoxColumn2.HeaderText = "Descripcion del Puesto";
            dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            dataGridViewTextBoxColumn2.Width = 250;
            // 
            // dataGridViewTextBoxColumn3
            // 
            dataGridViewTextBoxColumn3.DataPropertyName = "Existe";
            dataGridViewTextBoxColumn3.HeaderText = "Existe";
            dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            dataGridViewTextBoxColumn3.Visible = false;
            // 
            // IdEspecialidad
            // 
            IdEspecialidad.DataPropertyName = "IdEspecialidad";
            IdEspecialidad.HeaderText = "ID Especialidad";
            IdEspecialidad.Name = "IdEspecialidad";
            IdEspecialidad.Width = 150;
            // 
            // Nombre
            // 
            Nombre.DataPropertyName = "Nombre";
            Nombre.HeaderText = "Nombre";
            Nombre.Name = "Nombre";
            Nombre.Width = 150;
            // 
            // Descripcion
            // 
            Descripcion.DataPropertyName = "Descripcion";
            Descripcion.HeaderText = "Descripcion";
            Descripcion.Name = "Descripcion";
            Descripcion.Width = 250;
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.DataPropertyName = "Existe";
            dataGridViewTextBoxColumn1.HeaderText = "Existe";
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            dataGridViewTextBoxColumn1.Visible = false;
            // 
            // Frm_Funcionarios
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            BackgroundImage = Properties.Resources.Screenshot_2023_06_10_171827;
            BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            ClientSize = new System.Drawing.Size(1280, 534);
            Controls.Add(groupBoxPaciente);
            DoubleBuffered = true;
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Frm_Funcionarios";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Funcionarios";
            Load += Frm_Funcionarios_Load;
            groupBoxPaciente.ResumeLayout(false);
            groupBoxPaciente.PerformLayout();
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)grdEspecialidad).EndInit();
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)grdPuesto).EndInit();
            ((System.ComponentModel.ISupportInitialize)grdLista).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxPaciente;
        private System.Windows.Forms.TextBox txtFechaNacimiento;
        private System.Windows.Forms.TextBox txtID_Funcionario;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.TextBox txtCorreo;
        private System.Windows.Forms.DataGridView grdLista;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtApellidos;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtCedula;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TextBox txtID_Especialidad;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView grdEspecialidad;
        private System.Windows.Forms.DataGridView grdPuesto;
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
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txt_ID_PUESTO_TRABAJO;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdPuestoTrabajo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre_PuestoTrabajo;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdEspecialidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
    }
}