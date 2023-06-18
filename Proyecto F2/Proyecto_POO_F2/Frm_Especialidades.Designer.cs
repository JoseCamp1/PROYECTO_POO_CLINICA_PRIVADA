namespace Capa01_Presentacion
{
    partial class Frm_Especialidades
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Especialidades));
            groupBoxPaciente = new System.Windows.Forms.GroupBox();
            txtID_Especialidad = new System.Windows.Forms.TextBox();
            label2 = new System.Windows.Forms.Label();
            label10 = new System.Windows.Forms.Label();
            txtNombre = new System.Windows.Forms.TextBox();
            grdLista = new System.Windows.Forms.DataGridView();
            IdEspecialidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Existe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            label5 = new System.Windows.Forms.Label();
            txtDescripcion = new System.Windows.Forms.TextBox();
            btnLimpiar = new System.Windows.Forms.Button();
            btnSalir = new System.Windows.Forms.Button();
            btnEliminar = new System.Windows.Forms.Button();
            btnGuardar = new System.Windows.Forms.Button();
            btnBuscar = new System.Windows.Forms.Button();
            groupBoxPaciente.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)grdLista).BeginInit();
            SuspendLayout();
            // 
            // groupBoxPaciente
            // 
            groupBoxPaciente.BackColor = System.Drawing.Color.Transparent;
            groupBoxPaciente.Controls.Add(txtID_Especialidad);
            groupBoxPaciente.Controls.Add(label2);
            groupBoxPaciente.Controls.Add(label10);
            groupBoxPaciente.Controls.Add(txtNombre);
            groupBoxPaciente.Controls.Add(grdLista);
            groupBoxPaciente.Controls.Add(label5);
            groupBoxPaciente.Controls.Add(txtDescripcion);
            groupBoxPaciente.Location = new System.Drawing.Point(12, 12);
            groupBoxPaciente.Name = "groupBoxPaciente";
            groupBoxPaciente.Size = new System.Drawing.Size(557, 369);
            groupBoxPaciente.TabIndex = 61;
            groupBoxPaciente.TabStop = false;
            groupBoxPaciente.Text = "Informacion de las Especialidades";
            // 
            // txtID_Especialidad
            // 
            txtID_Especialidad.BackColor = System.Drawing.SystemColors.Info;
            txtID_Especialidad.Enabled = false;
            txtID_Especialidad.Location = new System.Drawing.Point(46, 41);
            txtID_Especialidad.Name = "txtID_Especialidad";
            txtID_Especialidad.Size = new System.Drawing.Size(100, 23);
            txtID_Especialidad.TabIndex = 42;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(198, 23);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(51, 15);
            label2.TabIndex = 21;
            label2.Text = "Nombre";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new System.Drawing.Point(46, 23);
            label10.Name = "label10";
            label10.Size = new System.Drawing.Size(86, 15);
            label10.TabIndex = 41;
            label10.Text = "ID Especialidad";
            // 
            // txtNombre
            // 
            txtNombre.Location = new System.Drawing.Point(198, 41);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new System.Drawing.Size(100, 23);
            txtNombre.TabIndex = 25;
            // 
            // grdLista
            // 
            grdLista.BackgroundColor = System.Drawing.SystemColors.ActiveBorder;
            grdLista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grdLista.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { IdEspecialidad, Nombre, Descripcion, Existe });
            grdLista.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            grdLista.GridColor = System.Drawing.SystemColors.ActiveBorder;
            grdLista.Location = new System.Drawing.Point(6, 70);
            grdLista.Name = "grdLista";
            grdLista.RowTemplate.Height = 25;
            grdLista.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            grdLista.Size = new System.Drawing.Size(545, 293);
            grdLista.TabIndex = 14;
            grdLista.DoubleClick += grdLista_DoubleClick;
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
            Descripcion.Width = 200;
            // 
            // Existe
            // 
            Existe.DataPropertyName = "Existe";
            Existe.HeaderText = "Existe";
            Existe.Name = "Existe";
            Existe.Visible = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new System.Drawing.Point(347, 23);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(69, 15);
            label5.TabIndex = 28;
            label5.Text = "Descripcion";
            // 
            // txtDescripcion
            // 
            txtDescripcion.Location = new System.Drawing.Point(347, 41);
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new System.Drawing.Size(100, 23);
            txtDescripcion.TabIndex = 29;
            // 
            // btnLimpiar
            // 
            btnLimpiar.BackColor = System.Drawing.SystemColors.Window;
            btnLimpiar.Image = Properties.Resources.broom_5182;
            btnLimpiar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            btnLimpiar.Location = new System.Drawing.Point(133, 387);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new System.Drawing.Size(75, 71);
            btnLimpiar.TabIndex = 60;
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
            btnSalir.Location = new System.Drawing.Point(494, 387);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new System.Drawing.Size(75, 71);
            btnSalir.TabIndex = 59;
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
            btnEliminar.Location = new System.Drawing.Point(384, 387);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new System.Drawing.Size(75, 71);
            btnEliminar.TabIndex = 58;
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
            btnGuardar.Location = new System.Drawing.Point(258, 387);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new System.Drawing.Size(75, 71);
            btnGuardar.TabIndex = 57;
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
            btnBuscar.Location = new System.Drawing.Point(18, 387);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new System.Drawing.Size(75, 71);
            btnBuscar.TabIndex = 56;
            btnBuscar.Text = "&Buscar";
            btnBuscar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            btnBuscar.UseVisualStyleBackColor = false;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // Frm_Especialidades
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            BackgroundImage = Properties.Resources.Screenshot_2023_06_10_171827;
            BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            ClientSize = new System.Drawing.Size(581, 483);
            Controls.Add(groupBoxPaciente);
            Controls.Add(btnLimpiar);
            Controls.Add(btnSalir);
            Controls.Add(btnEliminar);
            Controls.Add(btnGuardar);
            Controls.Add(btnBuscar);
            DoubleBuffered = true;
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Frm_Especialidades";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Frm_Especialidades";
            Load += Frm_Especialidades_Load;
            groupBoxPaciente.ResumeLayout(false);
            groupBoxPaciente.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)grdLista).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxPaciente;
        private System.Windows.Forms.TextBox txtID_Especialidad;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.DataGridView grdLista;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdEspecialidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Existe;
    }
}