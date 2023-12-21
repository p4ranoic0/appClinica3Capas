using Clinica_BL;
using System.Data;
using System.Windows.Forms;
using System;

namespace CLinica_GUI.Medicamento
{
    public partial class frmListaMedicamentos : Form
    {
        public frmListaMedicamentos()
        {
            InitializeComponent();
        }
        MedicamentoBL medicamentoBL = new MedicamentoBL();
        DataView dtv = new DataView();

        public void cargarDatos(String cad)
        {
            dtv.RowFilter = "nom_medi like '%" + cad + "%'";
            dtgMedicamento.DataSource = dtv;
            lblRegistros.Text = dtgMedicamento.Rows.Count.ToString();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void fmrListaMedicamento_Load(object sender, EventArgs e)
        {
            try
            {
                dtgMedicamento.AutoGenerateColumns = false;
                dtv = new DataView(medicamentoBL.ListarMedicamento());
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
