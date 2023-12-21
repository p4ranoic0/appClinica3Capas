using Clinica_BL;
using System.Data;
using System.Windows.Forms;
using System;
using Clinica_GUI.Paciente;

namespace CLinica_GUI.Paciente
{
    public partial class frmListaPacienteAdm : Form
    {
        PacienteBL pacienteBL = new PacienteBL();
        DataView dtv = new DataView();

        public frmListaPacienteAdm()
        {
            InitializeComponent();
        }
        public void cargarDatos(String cad)
        {
            dtv.RowFilter = "nom_pac like '%" + cad + "%'" + "OR ape_pac like '%" + cad + "%'";
            dtgPaciente.DataSource = dtv;
            lblRegistros.Text = dtgPaciente.Rows.Count.ToString();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            try
            {
                String codigo = dtgPaciente.CurrentRow.Cells[0].Value.ToString();
                frmModificarPaciente frm = new frmModificarPaciente();
                frm.Codigo = codigo;
                frm.ShowDialog();
                txtCad.Clear();
                dtv = new DataView(pacienteBL.ListarPaciente());
                cargarDatos(txtCad.Text.Trim());
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error : " + ex.Message);
            }
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            frmInsertarPaciente frm = new frmInsertarPaciente();
            frm.ShowDialog();
            txtCad.Clear();
            dtv = new DataView(pacienteBL.ListarPaciente());
            cargarDatos(txtCad.Text.TrimEnd());
        }

        private void frmListaPacienteAdm_Load(object sender, EventArgs e)
        {
            try
            {
                dtgPaciente.AutoGenerateColumns = false;
                dtv = new DataView(pacienteBL.ListarPaciente());
                cargarDatos(txtCad.Text.Trim());
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:" + ex.Message);
            }
        }
        private void txtCad_TextChanged(object sender, EventArgs e)
        {
            cargarDatos(txtCad.Text.Trim());
        }
    }
}
