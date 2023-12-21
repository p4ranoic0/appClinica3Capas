using Clinica_BE;
using Clinica_BL;
using System.Windows.Forms;
using System;

namespace CLinica_GUI.Atencion
{
    public partial class frmInsertarAtencion : Form
    {
        AtencionBE atencionBE = new AtencionBE();
        AtencionBL atencionBL = new AtencionBL();
        MedicoBL atecoBL = new MedicoBL();
        PacienteBL pacienteBL = new PacienteBL();
        public frmInsertarAtencion()
        {
            InitializeComponent();
        }

        private void frmInsertarAtencion_Load(object sender, EventArgs e)
        {
            cargarPaciente();
            cargarMedico();
            cargarSucursal();
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
                cboMedico.DataSource = atecoBL.ListarMedico();
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

                atencionBE.Usu_Registro1 = "Admin";
                atencionBE.Fec_reg1 = DateTime.Now;


                //atencionBE.Est_med = true;
                if (atencionBL.InsertarAtencion(atencionBE))
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
