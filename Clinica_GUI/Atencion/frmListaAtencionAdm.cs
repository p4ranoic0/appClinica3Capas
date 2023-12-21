using Clinica_BL;
using System.Data;
using System.Windows.Forms;
using System;

namespace CLinica_GUI.Atencion
{
    public partial class frmListaAtencionAdm : Form
    {
        AtencionBL atencionBL = new AtencionBL();
        DataView dtv = new DataView();
        public frmListaAtencionAdm()
        {
            InitializeComponent();
        }
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

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            try
            {
                String codigo = dtgAtencion.CurrentRow.Cells[0].Value.ToString();
                frmModificarAtencion frm = new frmModificarAtencion();
                frm.Codigo = codigo;
                frm.ShowDialog();
                txtCad.Clear();
                dtv = new DataView(atencionBL.ListarAtencion());
                cargarDatos(txtCad.Text.Trim());
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error : " + ex.Message);
            }
        }


        private void fmrListaAtencionAdm_Load(object sender, EventArgs e)
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

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            frmInsertarAtencion frm = new frmInsertarAtencion();
            frm.ShowDialog();
            txtCad.Clear();
            dtv = new DataView(atencionBL.ListarAtencion());
            cargarDatos(txtCad.Text.TrimEnd());
        }
    }
}
