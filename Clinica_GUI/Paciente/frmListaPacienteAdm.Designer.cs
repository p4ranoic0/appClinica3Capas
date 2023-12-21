using System.Windows.Forms;
using System.Drawing;
namespace CLinica_GUI.Paciente
{
    partial class frmListaPacienteAdm
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
            this.dtgPaciente = new System.Windows.Forms.DataGridView();
            this.cod_paciente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nom_paciente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ape_paciente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fec_nacimiento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.correo_paciente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dir_paciente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tel_paciente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCad = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblRegistros = new System.Windows.Forms.Label();
            this.btnInsertar = new System.Windows.Forms.Button();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgPaciente)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgPaciente
            // 
            this.dtgPaciente.AllowUserToAddRows = false;
            this.dtgPaciente.AllowUserToDeleteRows = false;
            this.dtgPaciente.AllowUserToOrderColumns = true;
            this.dtgPaciente.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgPaciente.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgPaciente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgPaciente.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cod_paciente,
            this.nom_paciente,
            this.ape_paciente,
            this.fec_nacimiento,
            this.correo_paciente,
            this.dir_paciente,
            this.tel_paciente});
            this.dtgPaciente.Location = new System.Drawing.Point(45, 77);
            this.dtgPaciente.Name = "dtgPaciente";
            this.dtgPaciente.RowHeadersVisible = false;
            this.dtgPaciente.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgPaciente.Size = new System.Drawing.Size(889, 327);
            this.dtgPaciente.TabIndex = 0;
            // 
            // cod_paciente
            // 
            this.cod_paciente.DataPropertyName = "cod_pac";
            this.cod_paciente.HeaderText = "Id";
            this.cod_paciente.Name = "cod_paciente";
            // 
            // nom_paciente
            // 
            this.nom_paciente.DataPropertyName = "nom_pac";
            this.nom_paciente.HeaderText = "Nombre";
            this.nom_paciente.Name = "nom_paciente";
            // 
            // ape_paciente
            // 
            this.ape_paciente.DataPropertyName = "ape_pac";
            this.ape_paciente.HeaderText = "Apellido";
            this.ape_paciente.Name = "ape_paciente";
            // 
            // fec_nacimiento
            // 
            this.fec_nacimiento.DataPropertyName = "fech_nac_pac";
            this.fec_nacimiento.HeaderText = "Fecha Nacimiento";
            this.fec_nacimiento.Name = "fec_nacimiento";
            // 
            // correo_paciente
            // 
            this.correo_paciente.DataPropertyName = "email";
            this.correo_paciente.HeaderText = "Correo";
            this.correo_paciente.Name = "correo_paciente";
            // 
            // dir_paciente
            // 
            this.dir_paciente.DataPropertyName = "dir_pac";
            this.dir_paciente.HeaderText = "Direccion";
            this.dir_paciente.Name = "dir_paciente";
            // 
            // tel_paciente
            // 
            this.tel_paciente.DataPropertyName = "telf";
            this.tel_paciente.HeaderText = "Telefono";
            this.tel_paciente.Name = "tel_paciente";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(54, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nombre o Apellido del Paciente";
            // 
            // txtCad
            // 
            this.txtCad.Location = new System.Drawing.Point(218, 26);
            this.txtCad.Name = "txtCad";
            this.txtCad.Size = new System.Drawing.Size(368, 20);
            this.txtCad.TabIndex = 2;
            this.txtCad.TextChanged += new System.EventHandler(this.txtCad_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(820, 420);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Registros:";
            // 
            // lblRegistros
            // 
            this.lblRegistros.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblRegistros.Location = new System.Drawing.Point(880, 413);
            this.lblRegistros.Name = "lblRegistros";
            this.lblRegistros.Size = new System.Drawing.Size(54, 26);
            this.lblRegistros.TabIndex = 3;
            // 
            // btnInsertar
            // 
            this.btnInsertar.Location = new System.Drawing.Point(610, 474);
            this.btnInsertar.Name = "btnInsertar";
            this.btnInsertar.Size = new System.Drawing.Size(104, 37);
            this.btnInsertar.TabIndex = 4;
            this.btnInsertar.Text = "Insertar";
            this.btnInsertar.UseVisualStyleBackColor = true;
            this.btnInsertar.Click += new System.EventHandler(this.btnInsertar_Click);
            // 
            // btnActualizar
            // 
            this.btnActualizar.Location = new System.Drawing.Point(720, 474);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(104, 37);
            this.btnActualizar.TabIndex = 4;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(830, 474);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(104, 37);
            this.btnSalir.TabIndex = 4;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // frmListaPacienteAdm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 535);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.btnInsertar);
            this.Controls.Add(this.lblRegistros);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtCad);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtgPaciente);
            this.Name = "frmListaPacienteAdm";
            this.Text = "Lista de Pacientes";
            this.Load += new System.EventHandler(this.frmListaPacienteAdm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgPaciente)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DataGridView dtgPaciente;
        private Label label1;
        private TextBox txtCad;
        private Label label2;
        private Label lblRegistros;
        private Button btnInsertar;
        private Button btnActualizar;
        private Button btnSalir;
        private DataGridViewTextBoxColumn cod_paciente;
        private DataGridViewTextBoxColumn nom_paciente;
        private DataGridViewTextBoxColumn ape_paciente;
        private DataGridViewTextBoxColumn fec_nacimiento;
        private DataGridViewTextBoxColumn correo_paciente;
        private DataGridViewTextBoxColumn dir_paciente;
        private DataGridViewTextBoxColumn tel_paciente;
    }
}