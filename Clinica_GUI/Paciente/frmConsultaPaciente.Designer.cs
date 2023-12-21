using System.Windows.Forms;
using System.Drawing;
namespace CLinica_GUI.Paciente
{
    partial class frmConsultaPaciente
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
            this.lblCel = new System.Windows.Forms.Label();
            this.lblApellido = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Label5 = new System.Windows.Forms.Label();
            this.lblSangre = new System.Windows.Forms.Label();
            this.lblFecNac = new System.Windows.Forms.Label();
            this.lblDir = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Label7 = new System.Windows.Forms.Label();
            this.Label8 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.Label10 = new System.Windows.Forms.Label();
            this.lblSeguro = new System.Windows.Forms.Label();
            this.lblUbigeo = new System.Windows.Forms.Label();
            this.lblGenero = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            this.txtcod = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.lblDNI = new System.Windows.Forms.Label();
            this.GroupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // GroupBox1
            // 
            this.GroupBox1.Controls.Add(this.Label2);
            this.GroupBox1.Controls.Add(this.lblNombre);
            this.GroupBox1.Controls.Add(this.lblCel);
            this.GroupBox1.Controls.Add(this.lblApellido);
            this.GroupBox1.Controls.Add(this.label4);
            this.GroupBox1.Controls.Add(this.Label5);
            this.GroupBox1.Controls.Add(this.lblSangre);
            this.GroupBox1.Controls.Add(this.lblFecNac);
            this.GroupBox1.Controls.Add(this.lblDir);
            this.GroupBox1.Controls.Add(this.label12);
            this.GroupBox1.Controls.Add(this.label3);
            this.GroupBox1.Controls.Add(this.Label7);
            this.GroupBox1.Controls.Add(this.Label8);
            this.GroupBox1.Controls.Add(this.label11);
            this.GroupBox1.Controls.Add(this.lblEmail);
            this.GroupBox1.Controls.Add(this.Label10);
            this.GroupBox1.Controls.Add(this.lblSeguro);
            this.GroupBox1.Controls.Add(this.lblUbigeo);
            this.GroupBox1.Controls.Add(this.lblGenero);
            this.GroupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.GroupBox1.Location = new System.Drawing.Point(9, 41);
            this.GroupBox1.Name = "GroupBox1";
            this.GroupBox1.Size = new System.Drawing.Size(440, 230);
            this.GroupBox1.TabIndex = 8;
            this.GroupBox1.TabStop = false;
            this.GroupBox1.Text = "Datos del  Paciente";
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
            this.lblNombre.Size = new System.Drawing.Size(114, 16);
            this.lblNombre.TabIndex = 0;
            // 
            // lblCel
            // 
            this.lblCel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblCel.Location = new System.Drawing.Point(277, 50);
            this.lblCel.Name = "lblCel";
            this.lblCel.Size = new System.Drawing.Size(124, 16);
            this.lblCel.TabIndex = 0;
            // 
            // lblApellido
            // 
            this.lblApellido.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblApellido.Location = new System.Drawing.Point(277, 23);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(124, 16);
            this.lblApellido.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(220, 51);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 16);
            this.label4.TabIndex = 0;
            this.label4.Text = "Celular";
            // 
            // Label5
            // 
            this.Label5.Location = new System.Drawing.Point(220, 24);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(80, 16);
            this.Label5.TabIndex = 0;
            this.Label5.Text = "Apellidos";
            // 
            // lblSangre
            // 
            this.lblSangre.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblSangre.Location = new System.Drawing.Point(160, 157);
            this.lblSangre.Name = "lblSangre";
            this.lblSangre.Size = new System.Drawing.Size(64, 16);
            this.lblSangre.TabIndex = 0;
            // 
            // lblFecNac
            // 
            this.lblFecNac.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblFecNac.Location = new System.Drawing.Point(160, 127);
            this.lblFecNac.Name = "lblFecNac";
            this.lblFecNac.Size = new System.Drawing.Size(64, 16);
            this.lblFecNac.TabIndex = 0;
            // 
            // lblDir
            // 
            this.lblDir.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblDir.Location = new System.Drawing.Point(160, 77);
            this.lblDir.Name = "lblDir";
            this.lblDir.Size = new System.Drawing.Size(241, 16);
            this.lblDir.TabIndex = 0;
            // 
            // label12
            // 
            this.label12.Location = new System.Drawing.Point(24, 158);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(80, 16);
            this.label12.TabIndex = 0;
            this.label12.Text = "Sangre";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(24, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 16);
            this.label3.TabIndex = 0;
            this.label3.Text = "Fecha Nac";
            // 
            // Label7
            // 
            this.Label7.Location = new System.Drawing.Point(24, 78);
            this.Label7.Name = "Label7";
            this.Label7.Size = new System.Drawing.Size(80, 16);
            this.Label7.TabIndex = 0;
            this.Label7.Text = "Direccion";
            // 
            // Label8
            // 
            this.Label8.Location = new System.Drawing.Point(24, 51);
            this.Label8.Name = "Label8";
            this.Label8.Size = new System.Drawing.Size(53, 16);
            this.Label8.TabIndex = 0;
            this.Label8.Text = "Email";
            // 
            // label11
            // 
            this.label11.Location = new System.Drawing.Point(245, 157);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(55, 16);
            this.label11.TabIndex = 0;
            this.label11.Text = "Seguro";
            // 
            // lblEmail
            // 
            this.lblEmail.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblEmail.Location = new System.Drawing.Point(102, 50);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(114, 16);
            this.lblEmail.TabIndex = 0;
            // 
            // Label10
            // 
            this.Label10.Location = new System.Drawing.Point(245, 127);
            this.Label10.Name = "Label10";
            this.Label10.Size = new System.Drawing.Size(55, 16);
            this.Label10.TabIndex = 0;
            this.Label10.Text = "Genero";
            // 
            // lblSeguro
            // 
            this.lblSeguro.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblSeguro.Location = new System.Drawing.Point(307, 157);
            this.lblSeguro.Name = "lblSeguro";
            this.lblSeguro.Size = new System.Drawing.Size(94, 16);
            this.lblSeguro.TabIndex = 0;
            // 
            // lblUbigeo
            // 
            this.lblUbigeo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblUbigeo.Location = new System.Drawing.Point(160, 101);
            this.lblUbigeo.Name = "lblUbigeo";
            this.lblUbigeo.Size = new System.Drawing.Size(241, 16);
            this.lblUbigeo.TabIndex = 0;
            // 
            // lblGenero
            // 
            this.lblGenero.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblGenero.Location = new System.Drawing.Point(307, 127);
            this.lblGenero.Name = "lblGenero";
            this.lblGenero.Size = new System.Drawing.Size(94, 16);
            this.lblGenero.TabIndex = 0;
            // 
            // Label1
            // 
            this.Label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.Label1.Location = new System.Drawing.Point(11, 12);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(128, 16);
            this.Label1.TabIndex = 7;
            this.Label1.Text = "Ingrese Codigo Paciente:";
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
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(283, 13);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 15);
            this.label6.TabIndex = 9;
            this.label6.Text = "DNI: ";
            // 
            // lblDNI
            // 
            this.lblDNI.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblDNI.Location = new System.Drawing.Point(335, 14);
            this.lblDNI.Name = "lblDNI";
            this.lblDNI.Size = new System.Drawing.Size(114, 16);
            this.lblDNI.TabIndex = 10;
            // 
            // frmConsultaPaciente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(459, 295);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblDNI);
            this.Controls.Add(this.GroupBox1);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.txtcod);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmConsultaPaciente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consultar Paciente";
            this.Load += new System.EventHandler(this.frmConsultaPaciente_Load_1);
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
        internal Label lblDir;
        internal Label Label7;
        internal Label Label8;
        internal Label lblEmail;
        internal Label Label10;
        internal Label lblGenero;
        internal Label Label1;
        internal TextBox txtcod;
        internal Label lblFecNac;
        internal Label label3;
        internal Label lblUbigeo;
        internal Label lblSangre;
        internal Label label12;
        internal Label label11;
        internal Label lblSeguro;
        internal Label lblCel;
        internal Label label4;
        internal Label label6;
        internal Label lblDNI;
    }
}