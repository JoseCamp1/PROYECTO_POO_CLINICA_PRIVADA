namespace Capa01_Presentacion
{
    partial class Frm_BuscarFuncionario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_BuscarFuncionario));
            groupBox1 = new System.Windows.Forms.GroupBox();
            btnAceptar = new System.Windows.Forms.Button();
            btnBuscar = new System.Windows.Forms.Button();
            btnCancelar = new System.Windows.Forms.Button();
            label2 = new System.Windows.Forms.Label();
            txtNombre = new System.Windows.Forms.TextBox();
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
            groupBox1.Controls.Add(txtNombre);
            groupBox1.Location = new System.Drawing.Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new System.Drawing.Size(1263, 295);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Buscar";
            // 
            // btnAceptar
            // 
            btnAceptar.BackColor = System.Drawing.SystemColors.Window;
            btnAceptar.Image = Properties.Resources._4115228_accept_checklist_checkmark_yes_114037;
            btnAceptar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            btnAceptar.Location = new System.Drawing.Point(1095, 12);
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
            btnBuscar.BackColor = System.Drawing.SystemColors.Window;
            btnBuscar.Image = Properties.Resources.seo_social_web_network_internet_340_icon_icons_com_61497;
            btnBuscar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            btnBuscar.Location = new System.Drawing.Point(1014, 12);
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
            btnCancelar.BackColor = System.Drawing.SystemColors.Window;
            btnCancelar.Image = Properties.Resources._1487086345_cross_815771;
            btnCancelar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            btnCancelar.Location = new System.Drawing.Point(1176, 12);
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
            label2.Size = new System.Drawing.Size(107, 15);
            label2.TabIndex = 26;
            label2.Text = "Ingrese el Nombre ";
            // 
            // txtNombre
            // 
            txtNombre.Location = new System.Drawing.Point(6, 41);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new System.Drawing.Size(284, 23);
            txtNombre.TabIndex = 27;
            // 
            // grdLista
            // 
            grdLista.BackgroundColor = System.Drawing.SystemColors.ActiveBorder;
            grdLista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grdLista.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { ID_FUNCIONARIO, ID_PuestodeTrabajo, Id_Especialidad, NOMBRE_PACIENTE, APELLIDOS_PACIENTE, CEDULA_PACIENTE, TELEFONO_PACIENTE, CORREO_PACIENTE, DIRECCION_PACIENTE, FECHA_NACIMIENTO_PACIENTE, Existe });
            grdLista.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            grdLista.GridColor = System.Drawing.SystemColors.ActiveBorder;
            grdLista.Location = new System.Drawing.Point(6, 89);
            grdLista.Name = "grdLista";
            grdLista.RowTemplate.Height = 25;
            grdLista.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            grdLista.Size = new System.Drawing.Size(1245, 193);
            grdLista.TabIndex = 30;
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
            // Frm_BuscarFuncionario
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            BackgroundImage = Properties.Resources.Screenshot_2023_06_10_171827;
            BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            ClientSize = new System.Drawing.Size(1287, 315);
            Controls.Add(groupBox1);
            DoubleBuffered = true;
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Frm_BuscarFuncionario";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Buscar Funcionario";
            Load += Frm_BuscarFuncionario_Load;
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
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.DataGridView grdLista;
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