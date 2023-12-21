using Clinica_BE;
using Clinica_BL;
using System.Windows.Forms;
using System;

namespace CLinica_GUI.Medicamento
{
    public partial class frmConsultaMedicamento : Form
    {
        MedicamentoBE medicamentoBE = new MedicamentoBE();
        MedicamentoBL medicamentoBL = new MedicamentoBL();

        public frmConsultaMedicamento()
        {
            InitializeComponent();
        }

      private void txtcod_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (e.KeyChar == 13)
                {
                    medicamentoBE = medicamentoBL.ConsultarMedicamento(txtcod.Text);
                    //Preguntamos si se devolvio un resultado
                    if (medicamentoBE != null)
                    {
                        lblNombre.Text = medicamentoBE.Nom_medi;
                        lblComposicion.Text = medicamentoBE.Comp_medi;
                        lblLaboratorio.Text = medicamentoBL.BuscarLaboratorio(medicamentoBE.Cod_lab);
                        lblPeso.Text = medicamentoBE.Mlgr_medi;
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
