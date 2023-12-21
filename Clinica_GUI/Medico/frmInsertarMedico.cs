using Clinica_BE;
using Clinica_BL;
using System.Windows.Forms;
using System;
namespace CLinica_GUI.Medico
{
    public partial class frmInsertarMedico : Form
    {
        MedicoBL medicoBL = new MedicoBL();
        MedicoBE medicoBE = new MedicoBE();


        public frmInsertarMedico()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (mskNumColegiatura.MaskFull == false)
                {
                    throw new Exception("Debe llenar el Numero de colegiatura.");
                }
                medicoBE.Num_colegiatura = mskNumColegiatura.Text.Trim();
                medicoBE.Nom_med = txtNombres.Text.Trim().ToUpper();
                medicoBE.Ape_med = txtApellidos.Text.Trim().ToUpper();
                medicoBE.Dir_med = txtDireccion.Text.Trim().ToUpper();
                medicoBE.Email = txtEmail.Text.Trim();
                medicoBE.Telf = mskTel.Text.Trim();
                medicoBE.Num_colegiatura = mskNumColegiatura.Text.Trim();
                medicoBE.Cod_ubigeo = cboDepartamento.SelectedValue.ToString() +
                                           cboProvincia.SelectedValue.ToString() +
                                           cboDistrito.SelectedValue.ToString();
                medicoBE.Fech_nac_med = dtpFecNac.Value;
                medicoBE.Est_med1 = (chkEstado.Checked) ? 1 : 0;
                medicoBE.Genero = (cboGenero.SelectedIndex.Equals(0) ? "M" : "F");
                medicoBE.Cod_espec = (string)cboEspecialidad.SelectedValue;

                medicoBE.Fec_reg1 = DateTime.Now;
                medicoBE.Usu_Registro1 = "Admin";
                medicoBE.Usu_Ult_Mod1 = "Admin";
                medicoBE.Fec_Ult_Mod1 = DateTime.Now;

                //medicoBE.Est_med = true;
                if (medicoBL.InsertarMedico(medicoBE))
                {
                    MessageBox.Show("Registro Exitoso", "Registro");
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

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmInsertarMedico_Load(object sender, EventArgs e)
        {
            try
            {
                //Codifique
                // Cargamos los combos de Ubigeo
                // Por defecto elegiremos Lima, Lima , Lima (14,01,01)
                CargarUbigeo("14", "01", "01");
                CargarEspecialidad();
                CargarGenero();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error : " + ex.Message);
            }
        }

        private void CargarGenero()
        {
            cboGenero.Items.Clear();
            cboGenero.Items.Add(new { Text = "Masculino", Value = "M" });
            cboGenero.Items.Add(new { Text = "Femenino", Value = "F" });
            cboGenero.DisplayMember = "Text";
            cboGenero.ValueMember = "Value";
            cboGenero.SelectedValue = "M";
        }

        private void CargarEspecialidad()
        {
            try
            {
                cboEspecialidad.DataSource = medicoBL.ListarEspecialidad();
                cboEspecialidad.ValueMember = "cod_espec";
                cboEspecialidad.DisplayMember = "nom_espec";
                cboEspecialidad.SelectedValue = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error : " + ex.Message);
            }
        }

        private void CargarUbigeo(String IdDepa, String IdProv, String IdDist)
        {
            UbigeoBL objUbigeoBL = new UbigeoBL();

            cboDepartamento.DataSource = objUbigeoBL.Ubigeo_Departamentos();
            cboDepartamento.ValueMember = "IdDepa";
            cboDepartamento.DisplayMember = "Departamento";
            cboDepartamento.SelectedValue = IdDepa;

            cboProvincia.DataSource = objUbigeoBL.Ubigeo_ProvinciasDepartamento(IdDepa);
            cboProvincia.ValueMember = "IdProv";
            cboProvincia.DisplayMember = "Provincia";
            cboProvincia.SelectedValue = IdProv;

            cboDistrito.DataSource = objUbigeoBL.Ubigeo_DistritosProvinciaDepartamento(IdDepa, IdProv);
            cboDistrito.ValueMember = "IdDist";
            cboDistrito.DisplayMember = "Distrito";
            cboDistrito.SelectedValue = IdDist;

        }


        private void cboDepartamento_SelectionChangeCommitted(object sender, EventArgs e)
        {
            // Refrescamos 
            CargarUbigeo(cboDepartamento.SelectedValue.ToString(), "01", "01");

        }

        private void cboProvincia_SelectionChangeCommitted(object sender, EventArgs e)
        {
            // Refrescamos 
            CargarUbigeo(cboDepartamento.SelectedValue.ToString(), cboProvincia.SelectedValue.ToString(), "01");


        }


    }
}
