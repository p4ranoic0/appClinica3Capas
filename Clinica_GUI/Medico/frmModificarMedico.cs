using Clinica_BE;
using Clinica_BL;

using System.Windows.Forms;
using System;
namespace CLinica_GUI.Medico
{
    public partial class frmModificarMedico : Form
    {
        MedicoBL medicoBL = new MedicoBL();
        MedicoBE medicoBE = new MedicoBE();

        public frmModificarMedico()
        {
            InitializeComponent();
        }
        public string Codigo { get; internal set; }
        private void frmModificarMedico_Load(object sender, EventArgs e)
        {
            try
            {
                medicoBE = medicoBL.ConsultarMedico(Codigo);
                string codUbigeo = medicoBE.Cod_ubigeo.ToString();

                CargarUbigeo(codUbigeo.Substring(0, 2), codUbigeo.Substring(2, 2), codUbigeo.Substring(4, 2));
                CargarEspecialidad();
                CargarGenero();

                txtNombres.Text = medicoBE.Nom_med;
                txtApellidos.Text = medicoBE.Ape_med;
                txtDireccion.Text = medicoBE.Dir_med;
                txtEmail.Text = medicoBE.Email;
                mskTel.Text = medicoBE.Telf;
                mskNumColegiatura.Text = medicoBE.Num_colegiatura;
                cboGenero.SelectedIndex = (medicoBE.Genero.Equals("M") ? 0 : 1);
                cboEspecialidad.SelectedValue = medicoBE.Cod_espec;
                chkEstado.Checked = (medicoBE.Est_med1 == 0) ? false : true;
                dtpFecNac.Text = Convert.ToString(medicoBE.Fech_nac_med);


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
                medicoBE.Comen_est_pac = "";
                medicoBE.Est_med1 = (chkEstado.Checked) ? 1 : 0;
                medicoBE.Genero = (cboGenero.SelectedIndex.Equals(0) ? "M" : "F");
                medicoBE.Cod_espec = (string)cboEspecialidad.SelectedValue;


                medicoBE.Usu_Ult_Mod1 = "Admin";
                medicoBE.Fec_Ult_Mod1 = DateTime.Now;

                //medicoBE.Est_med = true;
                if (medicoBL.ActualizarMedico(medicoBE))
                {
                    MessageBox.Show("Se modificaron los Datos", "Modificacion");
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


    }
}
