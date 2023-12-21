using Clinica_BE;
using Clinica_BL;
using System.Windows.Forms;
using System;

namespace ProyWinC_Clinica.Atencion
{
    public partial class frmConsultaAtencion : Form
    {
        AtencionBE atencionBE = new AtencionBE();
        AtencionBL atencionBL = new AtencionBL();
        PacienteBE pacienteBE = new PacienteBE();
        PacienteBL pacienteBL = new PacienteBL();
        MedicoBE medicoBE = new MedicoBE();
        MedicoBL medicoBL = new MedicoBL();
        public frmConsultaAtencion()
        {
            InitializeComponent();
        }

        private void txtcod_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (e.KeyChar == 13)
                {
                    atencionBE = atencionBL.ConsultarAtencion(txtcod.Text);
                    //Preguntamos si se devolvio un resultado
                    if (atencionBE != null)
                    {

                        pacienteBE = pacienteBL.ConsultarPaciente(atencionBE.Cod_pac);
                        lblPaciente.Text = pacienteBE.Nom_pac + ' ' + pacienteBE.Ape_pac;


                        medicoBE = medicoBL.ConsultarMedico(atencionBE.Cod_med);
                        lblMedico.Text = medicoBE.Nom_med + ' ' + medicoBE.Ape_med;
                        lblComentario.Text = atencionBE.Comen_ate;
                        lblSucursal.Text = atencionBL.BuscarSucursal(atencionBE.Cod_suc);
                        lblSala.Text = atencionBE.Num_sala;
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

    }
}
