using Clinica_BL;
using System.Data;
using System.Windows.Forms;
using System;

namespace CLinica_GUI.Medico
{
    public partial class frmListaMedicos : Form
    {
        MedicoBL medicoBL = new MedicoBL();
        DataView dtv = new DataView();

        public frmListaMedicos()
        {
            InitializeComponent();
        }

        public void cargarDatos(String cad)
        {
            dtv.RowFilter = "nom_med like '%" + cad + "%'" + "OR ape_med like '%" + cad + "%'";
            dtgMedico.DataSource = dtv;
            lblRegistros.Text = dtgMedico.Rows.Count.ToString();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmListaMedicos_Load(object sender, EventArgs e)
        {
            try
            {
                dtgMedico.AutoGenerateColumns = false;
                dtv = new DataView(medicoBL.ListarMedico());
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
