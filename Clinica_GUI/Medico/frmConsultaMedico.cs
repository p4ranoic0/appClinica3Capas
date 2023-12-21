using Clinica_BE;
using Clinica_BL;
using System.Data;
using System.Windows.Forms;
using System;

namespace Clinica_GUI.Medico
{
    public partial class frmConsultaMedico : Form
    {
        //Declaramos las instancias
        MedicoBL medicoBL = new MedicoBL();
        MedicoBE medicoBE = new MedicoBE();
        DataView dv = new DataView();

        public frmConsultaMedico()
        {
            InitializeComponent();
        }
        private void txtcod_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (e.KeyChar == 13)
                {
                    medicoBE = medicoBL.ConsultarMedico(txtcod.Text);
                    //Preguntamos si se devolvio un resultado
                    if (medicoBE != null)
                    {
                        lblNombre.Text = medicoBE.Nom_med;
                        lblApellido.Text = medicoBE.Ape_med;
                        lblEmail.Text = medicoBE.Email;
                        lblTel.Text = medicoBE.Telf;
                        lblColegiatura.Text = medicoBE.Num_colegiatura.ToString();
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
