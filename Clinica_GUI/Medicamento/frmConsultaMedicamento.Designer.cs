using System.Drawing;
using System.Windows.Forms;

namespace CLinica_GUI.Medicamento
{
    partial class frmConsultaMedicamento
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
            this.GroupBox1 = new System.Windows.Forms.GroupBox();
            this.Label2 = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblPeso = new System.Windows.Forms.Label();
            this.lblLaboratorio = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Label7 = new System.Windows.Forms.Label();
            this.Label8 = new System.Windows.Forms.Label();
            this.lblComposicion = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            this.txtcod = new System.Windows.Forms.TextBox();
            this.GroupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // GroupBox1
            // 
            this.GroupBox1.Controls.Add(this.Label2);
            this.GroupBox1.Controls.Add(this.lblNombre);
            this.GroupBox1.Controls.Add(this.lblPeso);
            this.GroupBox1.Controls.Add(this.lblLaboratorio);
            this.GroupBox1.Controls.Add(this.label3);
            this.GroupBox1.Controls.Add(this.Label7);
            this.GroupBox1.Controls.Add(this.Label8);
            this.GroupBox1.Controls.Add(this.lblComposicion);
            this.GroupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.GroupBox1.Location = new System.Drawing.Point(9, 56);
            this.GroupBox1.Name = "GroupBox1";
            this.GroupBox1.Size = new System.Drawing.Size(440, 187);
            this.GroupBox1.TabIndex = 8;
            this.GroupBox1.TabStop = false;
            this.GroupBox1.Text = "Datos del  Medicamento";
            // 
            // Label2
            // 
            this.Label2.Location = new System.Drawing.Point(24, 24);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(71, 16);
            this.Label2.TabIndex = 0;
            this.Label2.Text = "Nombres";
            // 
            // lblNombre
            // 
            this.lblNombre.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblNombre.Location = new System.Drawing.Point(102, 24);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(299, 16);
            this.lblNombre.TabIndex = 0;
            // 
            // lblPeso
            // 
            this.lblPeso.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblPeso.Location = new System.Drawing.Point(102, 134);
            this.lblPeso.Name = "lblPeso";
            this.lblPeso.Size = new System.Drawing.Size(64, 16);
            this.lblPeso.TabIndex = 0;
            // 
            // lblLaboratorio
            // 
            this.lblLaboratorio.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblLaboratorio.Location = new System.Drawing.Point(102, 105);
            this.lblLaboratorio.Name = "lblLaboratorio";
            this.lblLaboratorio.Size = new System.Drawing.Size(299, 16);
            this.lblLaboratorio.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(24, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 16);
            this.label3.TabIndex = 0;
            this.label3.Text = "Peso";
            // 
            // Label7
            // 
            this.Label7.Location = new System.Drawing.Point(24, 105);
            this.Label7.Name = "Label7";
            this.Label7.Size = new System.Drawing.Size(80, 16);
            this.Label7.TabIndex = 0;
            this.Label7.Text = "Laboratorio";
            // 
            // Label8
            // 
            this.Label8.Location = new System.Drawing.Point(24, 51);
            this.Label8.Name = "Label8";
            this.Label8.Size = new System.Drawing.Size(71, 16);
            this.Label8.TabIndex = 0;
            this.Label8.Text = "Composicion";
            // 
            // lblComposicion
            // 
            this.lblComposicion.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblComposicion.Location = new System.Drawing.Point(102, 50);
            this.lblComposicion.Name = "lblComposicion";
            this.lblComposicion.Size = new System.Drawing.Size(299, 41);
            this.lblComposicion.TabIndex = 0;
            // 
            // Label1
            // 
            this.Label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.Label1.Location = new System.Drawing.Point(11, 12);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(128, 16);
            this.Label1.TabIndex = 7;
            this.Label1.Text = "Ingrese Codigo Medicamento:";
            // 
            // txtcod
            // 
            this.txtcod.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtcod.Location = new System.Drawing.Point(153, 10);
            this.txtcod.MaxLength = 4;
            this.txtcod.Name = "txtcod";
            this.txtcod.Size = new System.Drawing.Size(94, 20);
            this.txtcod.TabIndex = 6;
            this.txtcod.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtcod_KeyPress);
            // 
            // frmConsultaMedicamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(459, 254);
            this.Controls.Add(this.GroupBox1);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.txtcod);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmConsultaMedicamento";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consultar Medicamento";
            this.GroupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal GroupBox GroupBox1;
        internal Label Label2;
        internal Label lblNombre;
        internal Label lblLaboratorio;
        internal Label Label7;
        internal Label Label8;
        internal Label lblComposicion;
        internal Label Label1;
        internal TextBox txtcod;
        internal Label lblPeso;
        internal Label label3;
    }

}