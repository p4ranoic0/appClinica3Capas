using Clinica_BE;
using Clinica_BL;
using System.Windows.Forms;
using System;

namespace CLinica_GUI.Atencion
{
    public partial class frmModificarAtencion : Form
    {
        public frmModificarAtencion()
        {
            InitializeComponent();
        }

        public string Codigo { get; internal set; }

        AtencionBE atencionBE = new AtencionBE();
        AtencionBL atencionBL = new AtencionBL();
        MedicoBL medicoBL = new MedicoBL();
        PacienteBL pacienteBL = new PacienteBL();

        private void frmModificarAtencion_Load(object sender, EventArgs e)
        {
            cargarPaciente();
            cargarMedico();
            cargarSucursal();

            atencionBE = atencionBL.ConsultarAtencion(Codigo);

            cboPaciente.SelectedValue = atencionBE.Cod_pac;
            cboMedico.SelectedValue = atencionBE.Cod_med;
            cboSucursal.SelectedValue = atencionBE.Cod_suc;
            txtSala.Text = atencionBE.Num_sala;
            txtComentario.Text = atencionBE.Comen_ate;
            chkEstado.Checked = (atencionBE.Est_ate == "1") ? true : false;

        }

        private void cargarSucursal()
        {
            try
            {
                cboSucursal.DataSource = atencionBL.ListarSucursal();
                cboSucursal.ValueMember = "cod_suc";
                cboSucursal.DisplayMember = "nom_suc";
                cboSucursal.SelectedValue = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error : " + ex.Message);
            }
        }

        private void cargarMedico()
        {
            try
            {
                cboMedico.DataSource = medicoBL.ListarMedico();
                cboMedico.ValueMember = "cod_med";
                cboMedico.DisplayMember = "NombreCompleto";
                cboMedico.SelectedValue = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error : " + ex.Message);
            }
        }

        private void cargarPaciente()
        {
            try
            {
                cboPaciente.DataSource = pacienteBL.ListarPaciente();
                cboPaciente.ValueMember = "cod_pac";
                cboPaciente.DisplayMember = "NombreCompleto";
                cboPaciente.SelectedValue = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error : " + ex.Message);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {

                atencionBE.Comen_ate = txtComentario.Text.Trim();
                atencionBE.Num_sala = txtSala.Text.Trim();
                atencionBE.Est_ate = (chkEstado.Checked) ? "1" : "2";
                atencionBE.Cod_suc = (string)cboSucursal.SelectedValue;
                atencionBE.Cod_pac = (string)cboPaciente.SelectedValue;
                atencionBE.Cod_med = (string)cboMedico.SelectedValue;

                atencionBE.Usu_Ult_Mod1 = "Admin";
                atencionBE.Fec_Ult_Mod1 = DateTime.Now;


                //atencionBE.Est_med = true;
                if (atencionBL.ActualizarAtencion(atencionBE))
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
    }
}
