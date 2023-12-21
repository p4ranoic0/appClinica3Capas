using System.Windows.Forms;
using System.Drawing;
namespace Clinica_GUI.Medico
{
    partial class frmConsultaMedico
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
            this.lblApellido = new System.Windows.Forms.Label();
            this.Label5 = new System.Windows.Forms.Label();
            this.lblTel = new System.Windows.Forms.Label();
            this.Label7 = new System.Windows.Forms.Label();
            this.Label8 = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.Label10 = new System.Windows.Forms.Label();
            this.lblColegiatura = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            this.txtcod = new System.Windows.Forms.TextBox();
            this.GroupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // GroupBox1
            // 
            this.GroupBox1.Controls.Add(this.Label2);
            this.GroupBox1.Controls.Add(this.lblNombre);
            this.GroupBox1.Controls.Add(this.lblApellido);
            this.GroupBox1.Controls.Add(this.Label5);
            this.GroupBox1.Controls.Add(this.lblTel);
            this.GroupBox1.Controls.Add(this.Label7);
            this.GroupBox1.Controls.Add(this.Label8);
            this.GroupBox1.Controls.Add(this.lblEmail);
            this.GroupBox1.Controls.Add(this.Label10);
            this.GroupBox1.Controls.Add(this.lblColegiatura);
            this.GroupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.GroupBox1.Location = new System.Drawing.Point(9, 41);
            this.GroupBox1.Name = "GroupBox1";
            this.GroupBox1.Size = new System.Drawing.Size(440, 160);
            this.GroupBox1.TabIndex = 8;
            this.GroupBox1.TabStop = false;
            this.GroupBox1.Text = "Datos del  Medico";
            // 
            // Label2
            // 
            this.Label2.Location = new System.Drawing.Point(24, 24);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(104, 16);
            this.Label2.TabIndex = 0;
            this.Label2.Text = "Nombre";
            // 
            // lblNombre
            // 
            this.lblNombre.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblNombre.Location = new System.Drawing.Point(160, 24);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(249, 16);
            this.lblNombre.TabIndex = 0;
            // 
            // lblApellido
            // 
            this.lblApellido.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblApellido.Location = new System.Drawing.Point(160, 48);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(96, 16);
            this.lblApellido.TabIndex = 0;
            // 
            // Label5
            // 
            this.Label5.Location = new System.Drawing.Point(24, 48);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(80, 16);
            this.Label5.TabIndex = 0;
            this.Label5.Text = "Apellidos";
            // 
            // lblTel
            // 
            this.lblTel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTel.Location = new System.Drawing.Point(160, 96);
            this.lblTel.Name = "lblTel";
            this.lblTel.Size = new System.Drawing.Size(64, 16);
            this.lblTel.TabIndex = 0;
            // 
            // Label7
            // 
            this.Label7.Location = new System.Drawing.Point(24, 96);
            this.Label7.Name = "Label7";
            this.Label7.Size = new System.Drawing.Size(80, 16);
            this.Label7.TabIndex = 0;
            this.Label7.Text = "Telefono:";
            // 
            // Label8
            // 
            this.Label8.Location = new System.Drawing.Point(24, 72);
            this.Label8.Name = "Label8";
            this.Label8.Size = new System.Drawing.Size(104, 16);
            this.Label8.TabIndex = 0;
            this.Label8.Text = "Correo Electronico";
            // 
            // lblEmail
            // 
            this.lblEmail.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblEmail.Location = new System.Drawing.Point(160, 72);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(264, 16);
            this.lblEmail.TabIndex = 0;
            // 
            // Label10
            // 
            this.Label10.Location = new System.Drawing.Point(24, 120);
            this.Label10.Name = "Label10";
            this.Label10.Size = new System.Drawing.Size(111, 16);
            this.Label10.TabIndex = 0;
            this.Label10.Text = "Num Colegiatura";
            // 
            // lblColegiatura
            // 
            this.lblColegiatura.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblColegiatura.Location = new System.Drawing.Point(160, 120);
            this.lblColegiatura.Name = "lblColegiatura";
            this.lblColegiatura.Size = new System.Drawing.Size(200, 16);
            this.lblColegiatura.TabIndex = 0;
            // 
            // Label1
            // 
            this.Label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.Label1.Location = new System.Drawing.Point(41, 9);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(128, 16);
            this.Label1.TabIndex = 7;
            this.Label1.Text = "Ingrese Codigo Medico:";
            // 
            // txtcod
            // 
            this.txtcod.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtcod.Location = new System.Drawing.Point(169, 9);
            this.txtcod.MaxLength = 4;
            this.txtcod.Name = "txtcod";
            this.txtcod.Size = new System.Drawing.Size(56, 20);
            this.txtcod.TabIndex = 6;
            this.txtcod.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtcod_KeyPress);
            // 
            // frmConsultaMedico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(459, 207);
            this.Controls.Add(this.GroupBox1);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.txtcod);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmConsultaMedico";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consulta de Medicos";
            this.GroupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal GroupBox GroupBox1;
        internal Label Label2;
        internal Label lblNombre;
        internal Label lblApellido;
        internal Label Label5;
        internal Label lblTel;
        internal Label Label7;
        internal Label Label8;
        internal Label lblEmail;
        internal Label Label10;
        internal Label lblColegiatura;
        internal Label Label1;
        internal TextBox txtcod;
    }
}