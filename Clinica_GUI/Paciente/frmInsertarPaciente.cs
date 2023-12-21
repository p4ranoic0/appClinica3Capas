using Clinica_BE;
using Clinica_BL;
using System.Windows.Forms;
using System;

namespace CLinica_GUI.Paciente
{
    public partial class frmInsertarPaciente : Form
    {
        PacienteBE pacienteBE = new PacienteBE();
        PacienteBL pacienteBL = new PacienteBL();

        public frmInsertarPaciente()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {

                pacienteBE.Nom_pac = txtNombres.Text.Trim().ToUpper();
                pacienteBE.Ape_pac = txtApellidos.Text.Trim().ToUpper();
                pacienteBE.Dir_pac = txtDireccion.Text.Trim().ToUpper();
                pacienteBE.Email = txtEmail.Text.Trim();
                pacienteBE.Telf = mskTel.Text.Trim();

                pacienteBE.Cod_ubigeo = cboDepartamento.SelectedValue.ToString() +
                                           cboProvincia.SelectedValue.ToString() +
                                           cboDistrito.SelectedValue.ToString();
                pacienteBE.Fech_nac_pac = dtpFecNac.Value;
                pacienteBE.Est_pac = (chkEstado.Checked) ? "1" : "2";
                pacienteBE.Genero = (cboGenero.SelectedIndex.Equals(0) ? "M" : "F");
                pacienteBE.Cod_seg = (string)cboSeguro.SelectedValue;
                pacienteBE.Dni = mskDni.Text.Trim();
                pacienteBE.Sangre = txtSangre.Text.Trim().ToUpper();
                pacienteBE.Usu_Registro1 = "Admin";
                pacienteBE.Usu_Ult_Mod1 = "Admin";
                pacienteBE.Fec_Ult_Mod1 = DateTime.Now;

                if (pacienteBL.InsertarPaciente(pacienteBE))
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

        private void frmInsertarPaciente_Load(object sender, EventArgs e)
        {
            try
            {
                // Por defecto elegiremos Lima, Lima , Lima (14,01,01)
                CargarUbigeo("14", "01", "01");
                CargarSeguro();
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

        private void CargarSeguro()
        {
            try
            {
                cboSeguro.DataSource = pacienteBL.ListarSeguro();
                cboSeguro.ValueMember = "cod_seg";
                cboSeguro.DisplayMember = "nom_sug";
                cboSeguro.SelectedValue = "";
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
