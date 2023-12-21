
using System.Windows.Forms;
using System;
using Clinica_GUI;
using CLinica_GUI.Medico;
using Clinica_GUI.Medico;
using CLinica_GUI;
using CLinica_GUI.Medicamento;
using CLinica_GUI.Atencion;
using ProyWinC_Clinica.Atencion;
using CLinica_GUI.Paciente;
using Microsoft.VisualBasic.Devices;

namespace Clinica_GUI
{
    public partial class MDIPrincipal : Form
    {
        //Variables de trabajo...
        Computer miComputadora = new Computer();
        String miRed = String.Empty;
        private TimeSpan horaEntrada;

        public MDIPrincipal()
        {
            InitializeComponent();
        }

        private void MDIPrincipal_Resize(object sender, EventArgs e)
        {
            //Refresca la imagen de fondo
            this.Refresh();
        }

        private void MDIPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult vrpta;
            vrpta = MessageBox.Show("Seguro de salir de la aplicacion?", "Confirmar", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);
            if (vrpta == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //Manejamos el texto del formulario MDI...
            this.Text = "Clinica del Bienestar " + DateTime.Now;

            //Mostramos el tiempo de iniciada la sesion, segundo a segundo...
            lblsesion.Text = "Sesion:" +
                DateTime.Now.TimeOfDay.Subtract(horaEntrada).ToString().Substring(0, 8);//hh:mm:ss
        }


        private void MDIPrincipal_Load(object sender, EventArgs e)
        {
            //Mostramos informacion del equipo
            if (miComputadora.Network.IsAvailable == true)
            {
                miRed = "Equipo con conexion disponible";
            }
            else
            {
                miRed = "Equipo sin conexion disponible";
            }
            lblEquipo.Text = "Equipo" + miComputadora.Name + "." + miRed;

            //Resgistramos la hora de entrada
            horaEntrada = DateTime.Now.TimeOfDay;
        }

        private void MDIPrincipal_FormClosed(object sender, FormClosedEventArgs e)
        {
            //Si no se desea hacer nada mas tras el cierre del MDI...
            Application.Exit();
        }

        private void SalirTsmi_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ListaMedicosTsmi_Click(object sender, EventArgs e)
        {
            frmListaMedicos frm = new frmListaMedicos();
            frm.MdiParent = this;
            frm.Show();
        }

        private void ConsultarMedicoTsmi_Click(object sender, EventArgs e)
        {
            frmConsultaMedico frm = new frmConsultaMedico();
            frm.MdiParent = this;
            frm.Show();
        }

        private void ManMedicoTsmi_Click(object sender, EventArgs e)
        {
            frmListaMedicoAdm frm = new frmListaMedicoAdm();
            frm.MdiParent = this;
            frm.Show();
        }

        private void ListaPacientesTsmi_Click(object sender, EventArgs e)
        {
            frmListarPacientes frm = new frmListarPacientes();
            frm.MdiParent = this;
            frm.Show();
        }

        private void ListaMedicamentosTsmi_Click(object sender, EventArgs e)
        {
            frmListaMedicamentos frm = new frmListaMedicamentos();
            frm.MdiParent = this;
            frm.Show();
        }

        private void atencionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmListaAtenciones frm = new frmListaAtenciones();
            frm.MdiParent = this;
            frm.Show();
        }

        private void ConsultarMedicamentoTsmi_Click(object sender, EventArgs e)
        {
            frmConsultaMedicamento frm = new frmConsultaMedicamento();
            frm.MdiParent = this;
            frm.Show();
        }

        private void ConsultarRecetaTsmi_Click(object sender, EventArgs e)
        {

        }

        private void ConsultarAtencionTsmi_Click(object sender, EventArgs e)
        {
            frmConsultaAtencion frm = new frmConsultaAtencion();
            frm.MdiParent = this;
            frm.Show();
        }

        private void consultarPacienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmConsultaPaciente frm = new frmConsultaPaciente();
            frm.MdiParent = this;
            frm.Show();
        }

        private void ManPacienteTsmi_Click(object sender, EventArgs e)
        {
            frmListaPacienteAdm frm = new frmListaPacienteAdm();
            frm.MdiParent = this;
            frm.Show();
        }

        private void ManMedicamentoTsmi_Click(object sender, EventArgs e)
        {
            frmListaMedicamentoAdm frm = new frmListaMedicamentoAdm();
            frm.MdiParent = this;
            frm.Show();
        }

        private void ManAtencionTsmi_Click(object sender, EventArgs e)
        {
            frmListaAtencionAdm frm = new frmListaAtencionAdm();
            frm.MdiParent = this;
            frm.Show();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
