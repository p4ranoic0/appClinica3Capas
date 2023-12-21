using Clinica_BE;
using Clinica_BL;
using System.Windows.Forms;
using System;

namespace CLinica_GUI.Medicamento
{

    public partial class frmModificarMedicamento : Form
    {
        MedicamentoBL medicamentoBL = new MedicamentoBL();
        MedicamentoBE medicamentoBE = new MedicamentoBE();

        public frmModificarMedicamento()
        {
            InitializeComponent();
        }

        public string Codigo { get; internal set; }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {

                medicamentoBE.Nom_medi = txtNombres.Text.Trim().ToUpper();
                medicamentoBE.Comp_medi = txtComposicion.Text.Trim();
                medicamentoBE.Mlgr_medi = txtPeso.Text.Trim();
                medicamentoBE.Est_medi1 = (chkEstado.Checked) ? 1 : 0;
                medicamentoBE.Cod_lab = (string)cboLaboratorio.SelectedValue;

                medicamentoBE.Usu_Registro1 = "Admin";


                //medicamentoBE.Est_med = true;
                if (medicamentoBL.ActualizarMedicamento(medicamentoBE))
                {
                    MessageBox.Show("Actualizacion Exitosa", "Modificar");
                    this.Close();
                }
                else
                {
                    throw new Exception("No se guardo la informacion");
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Se ha producido el error: " + ex.Message);
            }

        }

        private void frmModificarMedicamento_Load(object sender, EventArgs e)
        {
            CargarLaboratorios();
            medicamentoBE = medicamentoBL.ConsultarMedicamento(Codigo);
            txtNombres.Text = medicamentoBE.Nom_medi;
            txtComposicion.Text = medicamentoBE.Comp_medi;
            txtPeso.Text = medicamentoBE.Mlgr_medi;
            chkEstado.Checked = (medicamentoBE.Est_medi1 == 1 ? true : false);
            cboLaboratorio.SelectedValue = medicamentoBE.Cod_lab;

        }
        private void CargarLaboratorios()
        {
            try
            {
                cboLaboratorio.DataSource = medicamentoBL.ListarLaboratorio();
                cboLaboratorio.ValueMember = "cod_lab";
                cboLaboratorio.DisplayMember = "nom_lab";
                cboLaboratorio.SelectedValue = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error : " + ex.Message);
            }
        }
    }
}
