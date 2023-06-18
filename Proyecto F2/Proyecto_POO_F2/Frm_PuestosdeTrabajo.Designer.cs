namespace Capa01_Presentacion
{
    partial class Frm_PuestosdeTrabajo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_PuestosdeTrabajo));
            groupBoxPaciente = new System.Windows.Forms.GroupBox();
            txtID_PuestoTrabajo = new System.Windows.Forms.TextBox();
            label2 = new System.Windows.Forms.Label();
            label10 = new System.Windows.Forms.Label();
            txtNombrePuesto = new System.Windows.Forms.TextBox();
            grdLista = new System.Windows.Forms.DataGridView();
            label5 = new System.Windows.Forms.Label();
            txtDescripcionPuesto = new System.Windows.Forms.TextBox();
            btnLimpiar = new System.Windows.Forms.Button();
            btnSalir = new System.Windows.Forms.Button();
            btnEliminar = new System.Windows.Forms.Button();
            btnGuardar = new System.Windows.Forms.Button();
            btnBuscar = new System.Windows.Forms.Button();
            IdPuestoTrabajo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Nombre_PuestoTrabajo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Existe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            groupBoxPaciente.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)grdLista).BeginInit();
            SuspendLayout();
            // 
            // groupBoxPaciente
            // 
            groupBoxPaciente.BackColor = System.Drawing.Color.Transparent;
            groupBoxPaciente.Controls.Add(txtID_PuestoTrabajo);
            groupBoxPaciente.Controls.Add(label2);
            groupBoxPaciente.Controls.Add(label10);
            groupBoxPaciente.Controls.Add(txtNombrePuesto);
            groupBoxPaciente.Controls.Add(grdLista);
            groupBoxPaciente.Controls.Add(label5);
            groupBoxPaciente.Controls.Add(txtDescripcionPuesto);
            groupBoxPaciente.Location = new System.Drawing.Point(12, 12);
            groupBoxPaciente.Name = "groupBoxPaciente";
            groupBoxPaciente.Size = new System.Drawing.Size(557, 369);
            groupBoxPaciente.TabIndex = 55;
            groupBoxPaciente.TabStop = false;
            groupBoxPaciente.Text = "Informacion de los Puesto de Trabajo";
            // 
            // txtID_PuestoTrabajo
            // 
            txtID_PuestoTrabajo.BackColor = System.Drawing.SystemColors.Info;
            txtID_PuestoTrabajo.Enabled = false;
            txtID_PuestoTrabajo.Location = new System.Drawing.Point(46, 41);
            txtID_PuestoTrabajo.Name = "txtID_PuestoTrabajo";
            txtID_PuestoTrabajo.Size = new System.Drawing.Size(100, 23);
            txtID_PuestoTrabajo.TabIndex = 42;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(198, 23);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(109, 15);
            label2.TabIndex = 21;
            label2.Text = "Nombre del Puesto";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new System.Drawing.Point(46, 23);
            label10.Name = "label10";
            label10.Size = new System.Drawing.Size(114, 15);
            label10.TabIndex = 41;
            label10.Text = "ID Puesto de Trabajo";
            // 
            // txtNombrePuesto
            // 
            txtNombrePuesto.Location = new System.Drawing.Point(198, 41);
            txtNombrePuesto.Name = "txtNombrePuesto";
            txtNombrePuesto.Size = new System.Drawing.Size(100, 23);
            txtNombrePuesto.TabIndex = 25;
            // 
            // grdLista
            // 
            grdLista.BackgroundColor = System.Drawing.SystemColors.ActiveBorder;
            grdLista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grdLista.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { IdPuestoTrabajo, Nombre_PuestoTrabajo, Descripcion, Existe });
            grdLista.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            grdLista.GridColor = System.Drawing.SystemColors.ActiveBorder;
            grdLista.Location = new System.Drawing.Point(6, 70);
            grdLista.Name = "grdLista";
            grdLista.RowTemplate.Height = 25;
            grdLista.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            grdLista.Size = new System.Drawing.Size(545, 293);
            grdLista.TabIndex = 14;
            grdLista.DoubleClick += grdLista_DoubleClick_1;
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
            // txtDescripcionPuesto
            // 
            txtDescripcionPuesto.Location = new System.Drawing.Point(347, 41);
            txtDescripcionPuesto.Name = "txtDescripcionPuesto";
            txtDescripcionPuesto.Size = new System.Drawing.Size(100, 23);
            txtDescripcionPuesto.TabIndex = 29;
            // 
            // btnLimpiar
            // 
            btnLimpiar.BackColor = System.Drawing.SystemColors.Window;
            btnLimpiar.Image = Properties.Resources.broom_5182;
            btnLimpiar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            btnLimpiar.Location = new System.Drawing.Point(133, 391);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new System.Drawing.Size(75, 71);
            btnLimpiar.TabIndex = 54;
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
            btnSalir.Location = new System.Drawing.Point(494, 391);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new System.Drawing.Size(75, 71);
            btnSalir.TabIndex = 53;
            btnSalir.Text = "&Salir";
            btnSalir.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            btnSalir.UseVisualStyleBackColor = false;
            btnSalir.Click += btnSalir_Click_1;
            // 
            // btnEliminar
            // 
            btnEliminar.BackColor = System.Drawing.SystemColors.Window;
            btnEliminar.Image = Properties.Resources.trash_bin_icon_icons_com_67981;
            btnEliminar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            btnEliminar.Location = new System.Drawing.Point(384, 391);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new System.Drawing.Size(75, 71);
            btnEliminar.TabIndex = 52;
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
            btnGuardar.Location = new System.Drawing.Point(258, 391);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new System.Drawing.Size(75, 71);
            btnGuardar.TabIndex = 51;
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
            btnBuscar.Location = new System.Drawing.Point(12, 391);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new System.Drawing.Size(75, 71);
            btnBuscar.TabIndex = 50;
            btnBuscar.Text = "&Buscar";
            btnBuscar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            btnBuscar.UseVisualStyleBackColor = false;
            btnBuscar.Click += btnBuscar_Click;
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
            // Descripcion
            // 
            Descripcion.DataPropertyName = "Descripcion";
            Descripcion.HeaderText = "Descripcion del Puesto";
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
            // Frm_PuestosdeTrabajo
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Screenshot_2023_06_10_171827;
            BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            ClientSize = new System.Drawing.Size(581, 474);
            Controls.Add(groupBoxPaciente);
            Controls.Add(btnLimpiar);
            Controls.Add(btnSalir);
            Controls.Add(btnEliminar);
            Controls.Add(btnGuardar);
            Controls.Add(btnBuscar);
            DoubleBuffered = true;
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            Name = "Frm_PuestosdeTrabajo";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Puestos de Trabajo";
            Load += Frm_PuestosTrabajo_Load;
            groupBoxPaciente.ResumeLayout(false);
            groupBoxPaciente.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)grdLista).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxPaciente;
        private System.Windows.Forms.TextBox txtID_PuestoTrabajo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtNombrePuesto;
        private System.Windows.Forms.DataGridView grdLista;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtDescripcionPuesto;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdPuestoTrabajo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre_PuestoTrabajo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Existe;
    }
}