using Clinica_BL;
using System.Data;
using System.Windows.Forms;

using System;
namespace CLinica_GUI.Atencion
{
    public partial class frmListaAtenciones : Form
    {
        public frmListaAtenciones()
        {
            InitializeComponent();
        }

        AtencionBL atencionBL = new AtencionBL();
        DataView dtv = new DataView();

        public void cargarDatos(String cad)
        {
            dtv.RowFilter = "cod_ate like '%" + cad + "%'";
            dtgAtencion.DataSource = dtv;
            lblRegistros.Text = dtgAtencion.Rows.Count.ToString();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void fmrListaAtencion_Load(object sender, EventArgs e)
        {
            try
            {
                dtgAtencion.AutoGenerateColumns = false;
                dtv = new DataView(atencionBL.ListarAtencion());
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
