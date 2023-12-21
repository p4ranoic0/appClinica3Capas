using System.Windows.Forms;
using System.Drawing;
namespace CLinica_GUI.Medico
{
    partial class frmListaMedicoAdm
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
            this.dtgMedico = new System.Windows.Forms.DataGridView();
            this.cod_medico = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nom_medico = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ape_medico = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nro_colegio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.correo_medico = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dir_medico = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tel_medico = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCad = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblRegistros = new System.Windows.Forms.Label();
            this.btnInsertar = new System.Windows.Forms.Button();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgMedico)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgMedico
            // 
            this.dtgMedico.AllowUserToAddRows = false;
            this.dtgMedico.AllowUserToDeleteRows = false;
            this.dtgMedico.AllowUserToOrderColumns = true;
            this.dtgMedico.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgMedico.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgMedico.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgMedico.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cod_medico,
            this.nom_medico,
            this.ape_medico,
            this.nro_colegio,
            this.correo_medico,
            this.dir_medico,
            this.tel_medico});
            this.dtgMedico.Location = new System.Drawing.Point(45, 77);
            this.dtgMedico.Name = "dtgMedico";
            this.dtgMedico.RowHeadersVisible = false;
            this.dtgMedico.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgMedico.Size = new System.Drawing.Size(889, 327);
            this.dtgMedico.TabIndex = 0;
            // 
            // cod_medico
            // 
            this.cod_medico.DataPropertyName = "cod_med";
            this.cod_medico.HeaderText = "Id";
            this.cod_medico.Name = "cod_medico";
            // 
            // nom_medico
            // 
            this.nom_medico.DataPropertyName = "nom_med";
            this.nom_medico.HeaderText = "Nombre";
            this.nom_medico.Name = "nom_medico";
            // 
            // ape_medico
            // 
            this.ape_medico.DataPropertyName = "ape_med";
            this.ape_medico.HeaderText = "Apellido";
            this.ape_medico.Name = "ape_medico";
            // 
            // nro_colegio
            // 
            this.nro_colegio.DataPropertyName = "num_colegiatura";
            this.nro_colegio.HeaderText = "Nro Colegio";
            this.nro_colegio.Name = "nro_colegio";
            // 
            // correo_medico
            // 
            this.correo_medico.DataPropertyName = "email";
            this.correo_medico.HeaderText = "Correo";
            this.correo_medico.Name = "correo_medico";
            // 
            // dir_medico
            // 
            this.dir_medico.DataPropertyName = "dir_med";
            this.dir_medico.HeaderText = "Direccion";
            this.dir_medico.Name = "dir_medico";
            // 
            // tel_medico
            // 
            this.tel_medico.DataPropertyName = "telf";
            this.tel_medico.HeaderText = "Telefono";
            this.tel_medico.Name = "tel_medico";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(54, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nombre o Apellido del Medico";
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
            // frmListaMedicoAdm
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
            this.Controls.Add(this.dtgMedico);
            this.Name = "frmListaMedicoAdm";
            this.Text = "Lista de Medicos";
            this.Load += new System.EventHandler(this.fmrListaMedicoAdm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgMedico)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }



        #endregion

        private DataGridView dtgMedico;
        private Label label1;
        private TextBox txtCad;
        private Label label2;
        private Label lblRegistros;
        private Button btnInsertar;
        private Button btnActualizar;
        private Button btnSalir;
        private DataGridViewTextBoxColumn cod_medico;
        private DataGridViewTextBoxColumn nom_medico;
        private DataGridViewTextBoxColumn ape_medico;
        private DataGridViewTextBoxColumn nro_colegio;
        private DataGridViewTextBoxColumn correo_medico;
        private DataGridViewTextBoxColumn dir_medico;
        private DataGridViewTextBoxColumn tel_medico;
    }
}