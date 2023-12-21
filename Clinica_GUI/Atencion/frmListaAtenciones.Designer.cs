using System.Drawing;
using System.Windows.Forms;

namespace CLinica_GUI.Atencion
{
    partial class frmListaAtenciones
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
            this.dtgAtencion = new System.Windows.Forms.DataGridView();
            this.cod_atencion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cod_paciente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cod_medico = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.est_ate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.num_sala = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCad = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblRegistros = new System.Windows.Forms.Label();
            this.btnSalir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgAtencion)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgAtencion
            // 
            this.dtgAtencion.AllowUserToAddRows = false;
            this.dtgAtencion.AllowUserToDeleteRows = false;
            this.dtgAtencion.AllowUserToOrderColumns = true;
            this.dtgAtencion.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgAtencion.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgAtencion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgAtencion.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cod_atencion,
            this.cod_paciente,
            this.cod_medico,
            this.est_ate,
            this.num_sala});
            this.dtgAtencion.Location = new System.Drawing.Point(45, 77);
            this.dtgAtencion.Name = "dtgAtencion";
            this.dtgAtencion.RowHeadersVisible = false;
            this.dtgAtencion.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgAtencion.Size = new System.Drawing.Size(879, 322);
            this.dtgAtencion.TabIndex = 0;
            // 
            // cod_atencion
            // 
            this.cod_atencion.DataPropertyName = "cod_ate";
            this.cod_atencion.HeaderText = "Id";
            this.cod_atencion.Name = "cod_atencion";
            // 
            // cod_paciente
            // 
            this.cod_paciente.DataPropertyName = "cod_pac";
            this.cod_paciente.HeaderText = "CodPaciente";
            this.cod_paciente.Name = "cod_paciente";
            // 
            // cod_medico
            // 
            this.cod_medico.DataPropertyName = "cod_med";
            this.cod_medico.HeaderText = "CodMedico";
            this.cod_medico.Name = "cod_medico";
            // 
            // est_ate
            // 
            this.est_ate.DataPropertyName = "est_ate";
            this.est_ate.HeaderText = "Estado";
            this.est_ate.Name = "est_ate";
            // 
            // num_sala
            // 
            this.num_sala.DataPropertyName = "num_sala";
            this.num_sala.HeaderText = "Nro Sala";
            this.num_sala.Name = "num_sala";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(54, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Cod Atencion";
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
            this.label2.Location = new System.Drawing.Point(810, 419);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Registros:";
            // 
            // lblRegistros
            // 
            this.lblRegistros.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblRegistros.Location = new System.Drawing.Point(870, 412);
            this.lblRegistros.Name = "lblRegistros";
            this.lblRegistros.Size = new System.Drawing.Size(54, 26);
            this.lblRegistros.TabIndex = 3;
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(810, 26);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(104, 37);
            this.btnSalir.TabIndex = 4;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // frmListaAtenciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(971, 463);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.lblRegistros);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtCad);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtgAtencion);
            this.Name = "frmListaAtenciones";
            this.Text = "Lista de Atenciones";
            this.Load += new System.EventHandler(this.fmrListaAtencion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgAtencion)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        #endregion

        private DataGridView dtgAtencion;
        private Label label1;
        private TextBox txtCad;
        private Label label2;
        private Label lblRegistros;
        private Button btnSalir;
        private DataGridViewTextBoxColumn cod_atencion;
        private DataGridViewTextBoxColumn cod_medico;
        private DataGridViewTextBoxColumn cod_paciente;
        private DataGridViewTextBoxColumn est_ate;
        private DataGridViewTextBoxColumn num_sala;
    }
}