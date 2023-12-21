using Clinica_BL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
namespace CLinica_GUI.Medico
{
    public partial class frmListaMedicoAdm : Form
    {
        MedicoBL medicoBL = new MedicoBL();
        DataView dtv = new DataView();

        public frmListaMedicoAdm()
        {
            InitializeComponent();
        }

        public void cargarDatos(String cad)
        {
            dtv.RowFilter = "nom_med like '%" + cad + "%'" + "OR ape_med like '%" + cad + "%'";
            dtgMedico.DataSource = dtv;
            lblRegistros.Text = dtgMedico.Rows.Count.ToString();
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            frmInsertarMedico frm = new frmInsertarMedico();
            frm.ShowDialog();
            txtCad.Clear();
            dtv = new DataView(medicoBL.ListarMedico());
            cargarDatos(txtCad.Text.TrimEnd());
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            try
            {
                String codigo = dtgMedico.CurrentRow.Cells[0].Value.ToString();
                frmModificarMedico frm = new frmModificarMedico();
                frm.Codigo = codigo;
                frm.ShowDialog();
                txtCad.Clear();
                dtv = new DataView(medicoBL.ListarMedico());
                cargarDatos(txtCad.Text.Trim());
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error : " + ex.Message);
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void fmrListaMedicoAdm_Load(object sender, EventArgs e)
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
