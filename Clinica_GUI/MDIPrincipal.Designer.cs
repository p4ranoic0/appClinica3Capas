using System.Windows.Forms;
using System.Drawing;

namespace Clinica_GUI
{
    partial class MDIPrincipal
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MDIPrincipal));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ListasTsmi = new System.Windows.Forms.ToolStripMenuItem();
            this.ListaMedicosTsmi = new System.Windows.Forms.ToolStripMenuItem();
            this.ListaPacientesTsmi = new System.Windows.Forms.ToolStripMenuItem();
            this.ListaMedicamentosTsmi = new System.Windows.Forms.ToolStripMenuItem();
            this.atencionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.SalirTsmi = new System.Windows.Forms.ToolStripMenuItem();
            this.ConsultasTsmi = new System.Windows.Forms.ToolStripMenuItem();
            this.ConsultarMedicoTsmi = new System.Windows.Forms.ToolStripMenuItem();
            this.ConsultarMedicamentoTsmi = new System.Windows.Forms.ToolStripMenuItem();
            this.ConsultarRecetaTsmi = new System.Windows.Forms.ToolStripMenuItem();
            this.ConsultarAtencionTsmi = new System.Windows.Forms.ToolStripMenuItem();
            this.consultarPacienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MantenimientoTsmi = new System.Windows.Forms.ToolStripMenuItem();
            this.ManMedicoTsmi = new System.Windows.Forms.ToolStripMenuItem();
            this.ManPacienteTsmi = new System.Windows.Forms.ToolStripMenuItem();
            this.ManMedicamentoTsmi = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.ManAtencionTsmi = new System.Windows.Forms.ToolStripMenuItem();
            this.ManRecetaTsmi = new System.Windows.Forms.ToolStripMenuItem();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lblEquipo = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblsesion = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusStrip2 = new System.Windows.Forms.StatusStrip();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ListasTsmi,
            this.ConsultasTsmi,
            this.MantenimientoTsmi});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(686, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // ListasTsmi
            // 
            this.ListasTsmi.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ListaMedicosTsmi,
            this.ListaPacientesTsmi,
            this.ListaMedicamentosTsmi,
            this.atencionesToolStripMenuItem,
            this.toolStripMenuItem1,
            this.SalirTsmi});
            this.ListasTsmi.Image = global::Clinica_GUI.Properties.Resources.Control_Panel;
            this.ListasTsmi.Name = "ListasTsmi";
            this.ListasTsmi.Size = new System.Drawing.Size(64, 20);
            this.ListasTsmi.Text = "Listas";
            // 
            // ListaMedicosTsmi
            // 
            this.ListaMedicosTsmi.Name = "ListaMedicosTsmi";
            this.ListaMedicosTsmi.Size = new System.Drawing.Size(180, 22);
            this.ListaMedicosTsmi.Text = "Medicos";
            this.ListaMedicosTsmi.Click += new System.EventHandler(this.ListaMedicosTsmi_Click);
            // 
            // ListaPacientesTsmi
            // 
            this.ListaPacientesTsmi.Image = global::Clinica_GUI.Properties.Resources.dude4;
            this.ListaPacientesTsmi.Name = "ListaPacientesTsmi";
            this.ListaPacientesTsmi.Size = new System.Drawing.Size(180, 22);
            this.ListaPacientesTsmi.Text = "Pacientes";
            this.ListaPacientesTsmi.Click += new System.EventHandler(this.ListaPacientesTsmi_Click);
            // 
            // ListaMedicamentosTsmi
            // 
            this.ListaMedicamentosTsmi.Image = ((System.Drawing.Image)(resources.GetObject("ListaMedicamentosTsmi.Image")));
            this.ListaMedicamentosTsmi.Name = "ListaMedicamentosTsmi";
            this.ListaMedicamentosTsmi.Size = new System.Drawing.Size(180, 22);
            this.ListaMedicamentosTsmi.Text = "Medicamentos";
            this.ListaMedicamentosTsmi.Click += new System.EventHandler(this.ListaMedicamentosTsmi_Click);
            // 
            // atencionesToolStripMenuItem
            // 
            this.atencionesToolStripMenuItem.Name = "atencionesToolStripMenuItem";
            this.atencionesToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.atencionesToolStripMenuItem.Text = "Atenciones";
            this.atencionesToolStripMenuItem.Click += new System.EventHandler(this.atencionesToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(177, 6);
            // 
            // SalirTsmi
            // 
            this.SalirTsmi.Image = ((System.Drawing.Image)(resources.GetObject("SalirTsmi.Image")));
            this.SalirTsmi.Name = "SalirTsmi";
            this.SalirTsmi.Size = new System.Drawing.Size(180, 22);
            this.SalirTsmi.Text = "Salir del proyecto";
            this.SalirTsmi.Click += new System.EventHandler(this.SalirTsmi_Click);
            // 
            // ConsultasTsmi
            // 
            this.ConsultasTsmi.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ConsultarMedicoTsmi,
            this.ConsultarMedicamentoTsmi,
            this.ConsultarRecetaTsmi,
            this.ConsultarAtencionTsmi,
            this.consultarPacienteToolStripMenuItem});
            this.ConsultasTsmi.Image = global::Clinica_GUI.Properties.Resources.Buscar;
            this.ConsultasTsmi.Name = "ConsultasTsmi";
            this.ConsultasTsmi.Size = new System.Drawing.Size(87, 20);
            this.ConsultasTsmi.Text = "Consultas";
            // 
            // ConsultarMedicoTsmi
            // 
            this.ConsultarMedicoTsmi.Image = ((System.Drawing.Image)(resources.GetObject("ConsultarMedicoTsmi.Image")));
            this.ConsultarMedicoTsmi.Name = "ConsultarMedicoTsmi";
            this.ConsultarMedicoTsmi.Size = new System.Drawing.Size(202, 22);
            this.ConsultarMedicoTsmi.Text = "Consultar Medico";
            this.ConsultarMedicoTsmi.Click += new System.EventHandler(this.ConsultarMedicoTsmi_Click);
            // 
            // ConsultarMedicamentoTsmi
            // 
            this.ConsultarMedicamentoTsmi.Name = "ConsultarMedicamentoTsmi";
            this.ConsultarMedicamentoTsmi.Size = new System.Drawing.Size(202, 22);
            this.ConsultarMedicamentoTsmi.Text = "Consultar Medicamento";
            this.ConsultarMedicamentoTsmi.Click += new System.EventHandler(this.ConsultarMedicamentoTsmi_Click);
            // 
            // ConsultarRecetaTsmi
            // 
            this.ConsultarRecetaTsmi.Name = "ConsultarRecetaTsmi";
            this.ConsultarRecetaTsmi.Size = new System.Drawing.Size(202, 22);
            this.ConsultarRecetaTsmi.Text = "Consultar Receta";
            // 
            // ConsultarAtencionTsmi
            // 
            this.ConsultarAtencionTsmi.Name = "ConsultarAtencionTsmi";
            this.ConsultarAtencionTsmi.Size = new System.Drawing.Size(202, 22);
            this.ConsultarAtencionTsmi.Text = "Consultar Atencion";
            this.ConsultarAtencionTsmi.Click += new System.EventHandler(this.ConsultarAtencionTsmi_Click);
            // 
            // consultarPacienteToolStripMenuItem
            // 
            this.consultarPacienteToolStripMenuItem.Name = "consultarPacienteToolStripMenuItem";
            this.consultarPacienteToolStripMenuItem.Size = new System.Drawing.Size(202, 22);
            this.consultarPacienteToolStripMenuItem.Text = "Consultar Paciente";
            this.consultarPacienteToolStripMenuItem.Click += new System.EventHandler(this.consultarPacienteToolStripMenuItem_Click);
            // 
            // MantenimientoTsmi
            // 
            this.MantenimientoTsmi.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ManMedicoTsmi,
            this.ManPacienteTsmi,
            this.ManMedicamentoTsmi,
            this.toolStripSeparator1,
            this.ManAtencionTsmi,
            this.ManRecetaTsmi});
            this.MantenimientoTsmi.Name = "MantenimientoTsmi";
            this.MantenimientoTsmi.Size = new System.Drawing.Size(101, 20);
            this.MantenimientoTsmi.Text = "Mantenimiento";
            // 
            // ManMedicoTsmi
            // 
            this.ManMedicoTsmi.Name = "ManMedicoTsmi";
            this.ManMedicoTsmi.Size = new System.Drawing.Size(180, 22);
            this.ManMedicoTsmi.Text = "Medico";
            this.ManMedicoTsmi.Click += new System.EventHandler(this.ManMedicoTsmi_Click);
            // 
            // ManPacienteTsmi
            // 
            this.ManPacienteTsmi.Name = "ManPacienteTsmi";
            this.ManPacienteTsmi.Size = new System.Drawing.Size(180, 22);
            this.ManPacienteTsmi.Text = "Paciente";
            this.ManPacienteTsmi.Click += new System.EventHandler(this.ManPacienteTsmi_Click);
            // 
            // ManMedicamentoTsmi
            // 
            this.ManMedicamentoTsmi.Name = "ManMedicamentoTsmi";
            this.ManMedicamentoTsmi.Size = new System.Drawing.Size(180, 22);
            this.ManMedicamentoTsmi.Text = "Medicamento";
            this.ManMedicamentoTsmi.Click += new System.EventHandler(this.ManMedicamentoTsmi_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(177, 6);
            // 
            // ManAtencionTsmi
            // 
            this.ManAtencionTsmi.Name = "ManAtencionTsmi";
            this.ManAtencionTsmi.Size = new System.Drawing.Size(180, 22);
            this.ManAtencionTsmi.Text = "Atencion";
            this.ManAtencionTsmi.Click += new System.EventHandler(this.ManAtencionTsmi_Click);
            // 
            // ManRecetaTsmi
            // 
            this.ManRecetaTsmi.Name = "ManRecetaTsmi";
            this.ManRecetaTsmi.Size = new System.Drawing.Size(180, 22);
            this.ManRecetaTsmi.Text = "Receta";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblEquipo,
            this.lblsesion});
            this.statusStrip1.Location = new System.Drawing.Point(0, 368);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 12, 0);
            this.statusStrip1.Size = new System.Drawing.Size(686, 22);
            this.statusStrip1.TabIndex = 3;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lblEquipo
            // 
            this.lblEquipo.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblEquipo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblEquipo.Name = "lblEquipo";
            this.lblEquipo.Size = new System.Drawing.Size(47, 17);
            this.lblEquipo.Text = "Equipo:";
            // 
            // lblsesion
            // 
            this.lblsesion.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblsesion.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblsesion.Name = "lblsesion";
            this.lblsesion.Size = new System.Drawing.Size(44, 17);
            this.lblsesion.Text = "Sesion:";
            // 
            // statusStrip2
            // 
            this.statusStrip2.Location = new System.Drawing.Point(0, 346);
            this.statusStrip2.Name = "statusStrip2";
            this.statusStrip2.Padding = new System.Windows.Forms.Padding(1, 0, 12, 0);
            this.statusStrip2.Size = new System.Drawing.Size(686, 22);
            this.statusStrip2.TabIndex = 4;
            this.statusStrip2.Text = "statusStrip2";
            // 
            // MDIPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Clinica_GUI.Properties.Resources.clinica;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(686, 390);
            this.Controls.Add(this.statusStrip2);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MDIPrincipal";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem ListasTsmi;
        private ToolStripMenuItem ListaMedicamentosTsmi;
        private ToolStripMenuItem ListaPacientesTsmi;
        private ToolStripSeparator toolStripMenuItem1;
        private ToolStripMenuItem SalirTsmi;
        private System.Windows.Forms.Timer timer1;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel lblEquipo;
        private ToolStripStatusLabel lblsesion;
        private StatusStrip statusStrip2;
        private ToolStripMenuItem ConsultasTsmi;
        private ToolStripMenuItem ConsultarMedicoTsmi;
        private ToolStripMenuItem MantenimientoTsmi;
        private ToolStripMenuItem ManMedicoTsmi;
        private ToolStripMenuItem ManPacienteTsmi;
        private ToolStripMenuItem ManMedicamentoTsmi;
        private ToolStripMenuItem ConsultarMedicamentoTsmi;
        private ToolStripMenuItem ConsultarRecetaTsmi;
        private ToolStripMenuItem ConsultarAtencionTsmi;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripMenuItem ManAtencionTsmi;
        private ToolStripMenuItem ManRecetaTsmi;
        private ToolStripMenuItem ListaMedicosTsmi;
        private ToolStripMenuItem atencionesToolStripMenuItem;
        private ToolStripMenuItem consultarPacienteToolStripMenuItem;
    }
}