namespace Capa01_Presentacion
{
    partial class Frm_MenuPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_MenuPrincipal));
            menuStrip1 = new System.Windows.Forms.MenuStrip();
            pacientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            pacientesToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            funcionariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            puestosDeTrabajoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            especialidadesMedicasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            agendaEspecialistaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            serviciosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            citasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { pacientesToolStripMenuItem, serviciosToolStripMenuItem });
            menuStrip1.Location = new System.Drawing.Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new System.Drawing.Size(1518, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // pacientesToolStripMenuItem
            // 
            pacientesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { pacientesToolStripMenuItem1, funcionariosToolStripMenuItem, puestosDeTrabajoToolStripMenuItem, especialidadesMedicasToolStripMenuItem, agendaEspecialistaToolStripMenuItem });
            pacientesToolStripMenuItem.Name = "pacientesToolStripMenuItem";
            pacientesToolStripMenuItem.Size = new System.Drawing.Size(49, 20);
            pacientesToolStripMenuItem.Text = "Editar";
            // 
            // pacientesToolStripMenuItem1
            // 
            pacientesToolStripMenuItem1.Image = Properties.Resources.users_people_workers_customers_icon_124243;
            pacientesToolStripMenuItem1.Name = "pacientesToolStripMenuItem1";
            pacientesToolStripMenuItem1.Size = new System.Drawing.Size(197, 22);
            pacientesToolStripMenuItem1.Text = "Pacientes";
            pacientesToolStripMenuItem1.Click += pacientesToolStripMenuItem1_Click;
            // 
            // funcionariosToolStripMenuItem
            // 
            funcionariosToolStripMenuItem.Image = Properties.Resources.users_people_workers_customers_icon_124243;
            funcionariosToolStripMenuItem.Name = "funcionariosToolStripMenuItem";
            funcionariosToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            funcionariosToolStripMenuItem.Text = "Funcionarios";
            funcionariosToolStripMenuItem.Click += funcionariosToolStripMenuItem_Click;
            // 
            // puestosDeTrabajoToolStripMenuItem
            // 
            puestosDeTrabajoToolStripMenuItem.Image = Properties.Resources.effective_employees_users_team_group_icon_152042;
            puestosDeTrabajoToolStripMenuItem.Name = "puestosDeTrabajoToolStripMenuItem";
            puestosDeTrabajoToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            puestosDeTrabajoToolStripMenuItem.Text = "Puestos de Trabajo";
            puestosDeTrabajoToolStripMenuItem.Click += puestosDeTrabajoToolStripMenuItem_Click;
            // 
            // especialidadesMedicasToolStripMenuItem
            // 
            especialidadesMedicasToolStripMenuItem.Image = Properties.Resources.medical_clinic_icon_194649;
            especialidadesMedicasToolStripMenuItem.Name = "especialidadesMedicasToolStripMenuItem";
            especialidadesMedicasToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            especialidadesMedicasToolStripMenuItem.Text = "Especialidades Medicas";
            especialidadesMedicasToolStripMenuItem.Click += especialidadesMedicasToolStripMenuItem_Click;
            // 
            // agendaEspecialistaToolStripMenuItem
            // 
            agendaEspecialistaToolStripMenuItem.Image = Properties.Resources.time_clock_icon_129581;
            agendaEspecialistaToolStripMenuItem.Name = "agendaEspecialistaToolStripMenuItem";
            agendaEspecialistaToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            agendaEspecialistaToolStripMenuItem.Text = "Agenda Especialista";
            agendaEspecialistaToolStripMenuItem.Click += agendaEspecialistaToolStripMenuItem_Click;
            // 
            // serviciosToolStripMenuItem
            // 
            serviciosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { citasToolStripMenuItem });
            serviciosToolStripMenuItem.Name = "serviciosToolStripMenuItem";
            serviciosToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            serviciosToolStripMenuItem.Text = "Servicios";
            // 
            // citasToolStripMenuItem
            // 
            citasToolStripMenuItem.Image = Properties.Resources.calendar_with_a_clock_time_tools_icon_icons_com_56831;
            citasToolStripMenuItem.Name = "citasToolStripMenuItem";
            citasToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            citasToolStripMenuItem.Text = "Citas";
            citasToolStripMenuItem.Click += citasToolStripMenuItem_Click;
            // 
            // Frm_MenuPrincipal
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Screenshot_2023_06_10_171827;
            BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            ClientSize = new System.Drawing.Size(1518, 590);
            Controls.Add(menuStrip1);
            DoubleBuffered = true;
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            IsMdiContainer = true;
            MainMenuStrip = menuStrip1;
            Name = "Frm_MenuPrincipal";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Frm_MenuPrincipal";
            WindowState = System.Windows.Forms.FormWindowState.Maximized;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem pacientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem funcionariosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pacientesToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem serviciosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem citasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem puestosDeTrabajoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem especialidadesMedicasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem agendaEspecialistaToolStripMenuItem;
    }
}