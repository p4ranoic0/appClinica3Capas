using Clinica_BL;
using System.Data;
using System.Windows.Forms;
using System;
namespace CLinica_GUI
{
    public partial class frmListarPacientes : Form
    {
        PacienteBL pacienteBL = new PacienteBL();
        DataView dtv = new DataView();


        public frmListarPacientes()
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


        private void frmListarPacientes_Load(object sender, EventArgs e)
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
