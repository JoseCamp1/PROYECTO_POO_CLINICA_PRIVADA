namespace Capa01_Presentacion
{
    partial class Frm_Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Login));
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            txtUsuario = new System.Windows.Forms.TextBox();
            mtxtConstrasena = new System.Windows.Forms.MaskedTextBox();
            btnEntrar = new System.Windows.Forms.Button();
            btnSalir = new System.Windows.Forms.Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = System.Drawing.Color.Transparent;
            label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label1.Location = new System.Drawing.Point(274, 43);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(81, 25);
            label1.TabIndex = 0;
            label1.Text = "Usuario:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = System.Drawing.Color.Transparent;
            label2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label2.Location = new System.Drawing.Point(274, 88);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(112, 25);
            label2.TabIndex = 1;
            label2.Text = "Contraseña:";
            // 
            // txtUsuario
            // 
            txtUsuario.Location = new System.Drawing.Point(383, 43);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new System.Drawing.Size(100, 23);
            txtUsuario.TabIndex = 2;
            // 
            // mtxtConstrasena
            // 
            mtxtConstrasena.Location = new System.Drawing.Point(383, 88);
            mtxtConstrasena.Name = "mtxtConstrasena";
            mtxtConstrasena.PasswordChar = '*';
            mtxtConstrasena.Size = new System.Drawing.Size(100, 23);
            mtxtConstrasena.TabIndex = 3;
            mtxtConstrasena.UseSystemPasswordChar = true;
            // 
            // btnEntrar
            // 
            btnEntrar.BackColor = System.Drawing.Color.Transparent;
            btnEntrar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            btnEntrar.Image = Properties.Resources._4115234_login_sign_in_114046;
            btnEntrar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            btnEntrar.Location = new System.Drawing.Point(307, 367);
            btnEntrar.Name = "btnEntrar";
            btnEntrar.Size = new System.Drawing.Size(75, 71);
            btnEntrar.TabIndex = 30;
            btnEntrar.Text = "&Entrar";
            btnEntrar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            btnEntrar.UseVisualStyleBackColor = false;
            btnEntrar.Click += btnEntrar_Click;
            // 
            // btnSalir
            // 
            btnSalir.BackColor = System.Drawing.Color.Transparent;
            btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            btnSalir.Image = Properties.Resources._4115235_exit_logout_sign_out_114030;
            btnSalir.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            btnSalir.Location = new System.Drawing.Point(408, 367);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new System.Drawing.Size(75, 71);
            btnSalir.TabIndex = 31;
            btnSalir.Text = "&Salir";
            btnSalir.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            btnSalir.UseVisualStyleBackColor = false;
            btnSalir.Click += btnSalir_Click;
            // 
            // Frm_Login
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            BackgroundImage = Properties.Resources.Screenshot_2023_06_10_171827;
            BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            ClientSize = new System.Drawing.Size(800, 450);
            Controls.Add(btnSalir);
            Controls.Add(btnEntrar);
            Controls.Add(mtxtConstrasena);
            Controls.Add(txtUsuario);
            Controls.Add(label2);
            Controls.Add(label1);
            DoubleBuffered = true;
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Frm_Login";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Login";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.MaskedTextBox mtxtConstrasena;
        private System.Windows.Forms.Button btnEntrar;
        private System.Windows.Forms.Button btnSalir;
    }
}