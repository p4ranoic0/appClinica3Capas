using System.Windows.Forms;
using System.Drawing;

namespace ProyWinC_Clinica.Atencion
{
    partial class frmConsultaAtencion
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
            this.label5 = new System.Windows.Forms.Label();
            this.lblMedico = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.lblPaciente = new System.Windows.Forms.Label();
            this.lblSucursal = new System.Windows.Forms.Label();
            this.lblSala = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblComentario = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Label7 = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            this.txtcod = new System.Windows.Forms.TextBox();
            this.GroupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // GroupBox1
            // 
            this.GroupBox1.Controls.Add(this.label5);
            this.GroupBox1.Controls.Add(this.lblMedico);
            this.GroupBox1.Controls.Add(this.Label2);
            this.GroupBox1.Controls.Add(this.lblPaciente);
            this.GroupBox1.Controls.Add(this.lblSucursal);
            this.GroupBox1.Controls.Add(this.lblSala);
            this.GroupBox1.Controls.Add(this.label6);
            this.GroupBox1.Controls.Add(this.lblComentario);
            this.GroupBox1.Controls.Add(this.label3);
            this.GroupBox1.Controls.Add(this.Label7);
            this.GroupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.GroupBox1.Location = new System.Drawing.Point(9, 56);
            this.GroupBox1.Name = "GroupBox1";
            this.GroupBox1.Size = new System.Drawing.Size(440, 187);
            this.GroupBox1.TabIndex = 8;
            this.GroupBox1.TabStop = false;
            this.GroupBox1.Text = "Datos del Atencion";
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(24, 55);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 16);
            this.label5.TabIndex = 0;
            this.label5.Text = "Medico";
            // 
            // lblMedico
            // 
            this.lblMedico.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblMedico.Location = new System.Drawing.Point(102, 55);
            this.lblMedico.Name = "lblMedico";
            this.lblMedico.Size = new System.Drawing.Size(299, 16);
            this.lblMedico.TabIndex = 0;
            // 
            // Label2
            // 
            this.Label2.Location = new System.Drawing.Point(24, 24);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(71, 16);
            this.Label2.TabIndex = 0;
            this.Label2.Text = "Paciente";
            // 
            // lblPaciente
            // 
            this.lblPaciente.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblPaciente.Location = new System.Drawing.Point(102, 24);
            this.lblPaciente.Name = "lblPaciente";
            this.lblPaciente.Size = new System.Drawing.Size(299, 16);
            this.lblPaciente.TabIndex = 0;
            // 
            // lblSucursal
            // 
            this.lblSucursal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblSucursal.Location = new System.Drawing.Point(102, 123);
            this.lblSucursal.Name = "lblSucursal";
            this.lblSucursal.Size = new System.Drawing.Size(139, 16);
            this.lblSucursal.TabIndex = 0;
            // 
            // lblSala
            // 
            this.lblSala.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblSala.Location = new System.Drawing.Point(337, 123);
            this.lblSala.Name = "lblSala";
            this.lblSala.Size = new System.Drawing.Size(64, 16);
            this.lblSala.TabIndex = 0;
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(24, 124);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 16);
            this.label6.TabIndex = 0;
            this.label6.Text = "Sucursal";
            // 
            // lblComentario
            // 
            this.lblComentario.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblComentario.Location = new System.Drawing.Point(102, 89);
            this.lblComentario.Name = "lblComentario";
            this.lblComentario.Size = new System.Drawing.Size(299, 16);
            this.lblComentario.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(259, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 16);
            this.label3.TabIndex = 0;
            this.label3.Text = "Nro Sala";
            // 
            // Label7
            // 
            this.Label7.Location = new System.Drawing.Point(24, 89);
            this.Label7.Name = "Label7";
            this.Label7.Size = new System.Drawing.Size(80, 16);
            this.Label7.TabIndex = 0;
            this.Label7.Text = "Comentario";
            // 
            // Label1
            // 
            this.Label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.Label1.Location = new System.Drawing.Point(14, 12);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(128, 16);
            this.Label1.TabIndex = 7;
            this.Label1.Text = "Ingrese Codigo Atencion:";
            // 
            // txtcod
            // 
            this.txtcod.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtcod.Location = new System.Drawing.Point(156, 10);
            this.txtcod.MaxLength = 4;
            this.txtcod.Name = "txtcod";
            this.txtcod.Size = new System.Drawing.Size(94, 20);
            this.txtcod.TabIndex = 6;
            this.txtcod.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtcod_KeyPress);
            // 
            // frmConsultaAtencion
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
            this.Name = "frmConsultaAtencion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consultar Atencion";
            this.GroupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal GroupBox GroupBox1;
        internal Label Label2;
        internal Label lblPaciente;
        internal Label lblComentario;
        internal Label Label7;
        internal Label Label1;
        internal TextBox txtcod;
        internal Label lblSala;
        internal Label label3;
        internal Label label5;
        internal Label lblMedico;
        internal Label lblSucursal;
        internal Label label6;
    }
}