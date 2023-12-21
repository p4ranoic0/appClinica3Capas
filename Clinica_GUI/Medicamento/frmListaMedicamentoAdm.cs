using Clinica_BL;
using System.Data;
using System.Windows.Forms;
using System;

namespace CLinica_GUI.Medicamento
{
    public partial class frmListaMedicamentoAdm : Form
    {

        MedicamentoBL medicamentoBL = new MedicamentoBL();
        DataView dtv = new DataView();

        public frmListaMedicamentoAdm()
        {
            InitializeComponent();
        }

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
        private void btnActualizar_Click(object sender, EventArgs e)
        {
            try
            {
                String codigo = dtgMedicamento.CurrentRow.Cells[0].Value.ToString();
                frmModificarMedicamento frm = new frmModificarMedicamento();
                frm.Codigo = codigo;
                frm.ShowDialog();
                txtCad.Clear();
                dtv = new DataView(medicamentoBL.ListarMedicamento());
                cargarDatos(txtCad.Text.Trim());
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error : " + ex.Message);
            }
        }


        private void fmrListaMedicamentoAdm_Load(object sender, EventArgs e)
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

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            frmInsertarMedicamento frm = new frmInsertarMedicamento();
            frm.ShowDialog();
            txtCad.Clear();
            dtv = new DataView(medicamentoBL.ListarMedicamento());
            cargarDatos(txtCad.Text.TrimEnd());
        }
    }
}
