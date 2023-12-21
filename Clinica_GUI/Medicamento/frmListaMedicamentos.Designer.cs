using System.Windows.Forms;
using System.Drawing;
namespace CLinica_GUI.Medicamento
{
    partial class frmListaMedicamentos
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
            this.dtgMedicamento = new System.Windows.Forms.DataGridView();
            this.cod_medicamento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nom_medicamento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comp_medicamento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cod_lab = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.peso_medicamento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCad = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblRegistros = new System.Windows.Forms.Label();
            this.btnSalir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgMedicamento)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgMedicamento
            // 
            this.dtgMedicamento.AllowUserToAddRows = false;
            this.dtgMedicamento.AllowUserToDeleteRows = false;
            this.dtgMedicamento.AllowUserToOrderColumns = true;
            this.dtgMedicamento.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgMedicamento.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgMedicamento.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgMedicamento.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cod_medicamento,
            this.nom_medicamento,
            this.comp_medicamento,
            this.cod_lab,
            this.peso_medicamento});
            this.dtgMedicamento.Location = new System.Drawing.Point(45, 77);
            this.dtgMedicamento.Name = "dtgMedicamento";
            this.dtgMedicamento.RowHeadersVisible = false;
            this.dtgMedicamento.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgMedicamento.Size = new System.Drawing.Size(879, 322);
            this.dtgMedicamento.TabIndex = 0;
            // 
            // cod_medicamento
            // 
            this.cod_medicamento.DataPropertyName = "cod_medi";
            this.cod_medicamento.FillWeight = 6F;
            this.cod_medicamento.HeaderText = "Id";
            this.cod_medicamento.Name = "cod_medicamento";
            // 
            // nom_medicamento
            // 
            this.nom_medicamento.DataPropertyName = "nom_medi";
            this.nom_medicamento.FillWeight = 19.53263F;
            this.nom_medicamento.HeaderText = "Nombre";
            this.nom_medicamento.Name = "nom_medicamento";
            // 
            // comp_medicamento
            // 
            this.comp_medicamento.DataPropertyName = "comp_medi";
            this.comp_medicamento.FillWeight = 55.09535F;
            this.comp_medicamento.HeaderText = "Composicion";
            this.comp_medicamento.Name = "comp_medicamento";
            // 
            // cod_lab
            // 
            this.cod_lab.DataPropertyName = "cod_lab";
            this.cod_lab.FillWeight = 4.883158F;
            this.cod_lab.HeaderText = "Cod Laboratorio";
            this.cod_lab.Name = "cod_lab";
            // 
            // peso_medicamento
            // 
            this.peso_medicamento.DataPropertyName = "mlgr_medi";
            this.peso_medicamento.FillWeight = 4.883158F;
            this.peso_medicamento.HeaderText = "Peso";
            this.peso_medicamento.Name = "peso_medicamento";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(54, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nombre del Medicamento";
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
            this.btnSalir.Location = new System.Drawing.Point(820, 16);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(104, 37);
            this.btnSalir.TabIndex = 4;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // frmListaMedicamentos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(971, 463);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.lblRegistros);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtCad);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtgMedicamento);
            this.Name = "frmListaMedicamentos";
            this.Text = "Lista de Medicamentos";
            this.Load += new System.EventHandler(this.fmrListaMedicamento_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgMedicamento)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        #endregion

        private DataGridView dtgMedicamento;
        private Label label1;
        private TextBox txtCad;
        private Label label2;
        private Label lblRegistros;
        private Button btnSalir;
        private DataGridViewTextBoxColumn cod_medicamento;
        private DataGridViewTextBoxColumn nom_medicamento;
        private DataGridViewTextBoxColumn comp_medicamento;
        private DataGridViewTextBoxColumn cod_lab;
        private DataGridViewTextBoxColumn peso_medicamento;
    }
}