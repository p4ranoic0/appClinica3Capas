using Clinica_BE;
using Clinica_BL;
using System.Data;
using System.Windows.Forms;
using System;


namespace CLinica_GUI.Paciente
{
    public partial class frmConsultaPaciente : Form
    {
        PacienteBE pacienteBE = new PacienteBE();
        PacienteBL pacienteBL = new PacienteBL();
        DataView dv = new DataView();
        public frmConsultaPaciente()
        {
            InitializeComponent();
        }

        private void txtcod_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (e.KeyChar == 13)
                {
                    pacienteBE = pacienteBL.ConsultarPaciente(txtcod.Text);
                    //Preguntamos si se devolvio un resultado
                    if (pacienteBE != null)
                    {
                        lblNombre.Text = pacienteBE.Nom_pac;
                        lblApellido.Text = pacienteBE.Ape_pac;
                        lblEmail.Text = pacienteBE.Email;
                        lblCel.Text = pacienteBE.Telf;
                        lblDir.Text = pacienteBE.Dir_pac;
                        lblDNI.Text = pacienteBE.Dni;
                        lblFecNac.Text = pacienteBE.Fech_nac_pac.ToString();
                        lblGenero.Text = (pacienteBE.Genero.Equals("F") ? "Femenino" : "Maculino");
                        lblSangre.Text = pacienteBE.Sangre;
                        PacienteBE pacienteSeguro = pacienteBL.ConsultarSeguro(pacienteBE.Cod_seg.ToString());

                        UbigeoBL objUbigeoBL = new UbigeoBL();
                        lblUbigeo.Text = objUbigeoBL.BuscarUbigeo(pacienteBE.Cod_ubigeo.ToString());

                        lblSeguro.Text = pacienteSeguro.Nom_sug;

                        //lblColegiatura.Text = pacienteBE.Num_colegiatura.ToString();
                    }
                    else
                    {
                        //Limpiamos los label de resultado...
                        foreach (Control miControl in GroupBox1.Controls)
                        {
                            if (miControl.Name.StartsWith("lbl"))
                            {
                                miControl.Text = String.Empty;
                            }
                        }
                        throw new Exception("Medico no existe");
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:" + ex.Message);
            }
        }


        private void frmConsultaPaciente_Load(object sender, EventArgs e)
        {

        }

        private void frmConsultaPaciente_Load_1(object sender, EventArgs e)
        {

        }
    }
}
