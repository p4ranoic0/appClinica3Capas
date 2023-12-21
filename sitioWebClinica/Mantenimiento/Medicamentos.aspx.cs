using Clinica_BE;
using Clinica_BL;
using System;
using System.Data;
using System.Web.UI.WebControls;
using System.Web.UI;

namespace sitioWebClinica.Mantenimiento
{
    public partial class Medicamentos : System.Web.UI.Page
    {

        MedicamentoBL medicamentoBL = new MedicamentoBL();
        MedicamentoBE medicamentoBE = new MedicamentoBE();
        UbigeoBL ubigeo = new UbigeoBL();
        DataView dv;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                try
                {
                    InicializarVista();
                    CargarDatos("");

                }
                catch (Exception ex)
                {
                    MostrarError(ex.Message);
                }
            }
        }
        private void InicializarVista()
        {
            dv = new DataView(medicamentoBL.ListarMedicamento());
            Session["Vista"] = dv;
        }



        private void CargarDatos(String filtro)
        {
            try
            {
                dv = (DataView)Session["Vista"];
                dv.RowFilter = $"nom_medi like '%{filtro}%'";
                gvMedicamento.DataSource = dv;
                gvMedicamento.DataBind();

                if (gvMedicamento.Rows.Count == 0)
                {
                    MostrarError("No existen registros con el criterio ingresado.");
                }
            }
            catch (Exception ex)
            {
                MostrarError(ex.Message);
            }

        }
        protected void btnNuevoMedicamento_Click(object sender, EventArgs e)
        {
            medicamentoBE = new MedicamentoBE();
            LimpiarFormulario();
            MostrartModalMedicamento();
        }


        protected void btnGuardarMedicamento_Click(object sender, EventArgs e)
        {
            try
            {
                //Verifico si es nuevo o editar con un campo oculto
                string modo = modoActual.Text;

                medicamentoBE.Cod_medi = txtCodMedicamento.Text;
                medicamentoBE.Nom_medi = txtNombre.Text;
                medicamentoBE.Comp_medi = txtComposicion.Text;
                medicamentoBE.Mlgr_medi = txtPeso.Text;
                medicamentoBE.Cod_lab = cboLaboratorio.SelectedValue;
                medicamentoBE.Est_medi1 = chkEstado.Checked ? 1 : 0; // Activo si el checkbox está marcado, inactivo si no


                medicamentoBE.Usu_Registro1 = "Admin";
                medicamentoBE.Usu_Ult_Mod1 = "Admin";
                medicamentoBE.Fec_Ult_Mod1 = DateTime.Now;


                // Crear una instancia de MedicamentoBL y llamar al método para agregar medicamento

                bool resultado = (modo.Equals("nuevo")) ? medicamentoBL.InsertarMedicamento(medicamentoBE) : medicamentoBL.ActualizarMedicamento(medicamentoBE);

                if (resultado)
                {
                    string mensajeExito = (modo.Equals("nuevo")) ? "Se agrego el nuevo Medicamento" : "Se modificó los datos del Medicamento: " + txtCodMedicamento.Text;
                    MostrarExito(mensajeExito);

                    // Limpiar los campos del formulario o cerrar el modal, según lo prefieras
                    LimpiarFormulario();
                    InicializarVista();
                    CargarDatos("");
                }
                else
                {
                    MostrarError("No se pudieron guardar datos.");
                }
            }
            catch (Exception ex)
            {
                // Manejar cualquier excepción que pueda ocurrir durante el proceso
                MostrarError(ex.Message);
            }
        }



        // Función para limpiar los campos del formulario después de agregar un nuevo medicamento
        private void LimpiarFormulario()
        {
            modoActual.Text = "nuevo";
            txtCodMedicamento.Text = "";
            txtNombre.Text = "";
            txtComposicion.Text = "";
            txtPeso.Text = "";
            cboLaboratorio.SelectedIndex = 0;

            CargarLaboratorio();
            chkEstado.Checked = true; // Puedes ajustar esto según tus necesidades
        }


        protected void btnEditarMedicamento_Click(object sender, EventArgs e)
        {
            LinkButton btnEditar = (LinkButton)sender;

            string cod = btnEditar.Attributes["data-cod-pac"];

            ScriptManager.RegisterStartupScript(this, this.GetType(), "ConfigurarModoEdicion", "configurarModoEdicion();", true);

            cargarDatosModal(cod);
            MostrartModalMedicamento();
        }

        private void cargarDatosModal(string cod)
        {
            try
            {
                medicamentoBE = medicamentoBL.ConsultarMedicamento(cod);
                LimpiarFormulario();
                txtCodMedicamento.Text = cod;
                txtNombre.Text = medicamentoBE.Nom_medi;
                txtComposicion.Text = medicamentoBE.Comp_medi;
                txtPeso.Text = medicamentoBE.Mlgr_medi;
                cboLaboratorio.SelectedValue = medicamentoBE.Cod_lab;
                chkEstado.Checked = medicamentoBE.Est_medi1.Equals(1) ? true : false;

            }
            catch (Exception ex)
            {
                MostrarError(ex.Message);
            }


        }

        protected void btnFiltrar_Click(object sender, EventArgs e)
        {
            try
            {
                CargarDatos(txtFiltro.Text);
            }
            catch (Exception ex)
            {
                MostrarError(ex.Message);
            }
        }


        protected void gvMedicamento_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            gvMedicamento.PageIndex = e.NewPageIndex;
            InicializarVista();
            CargarDatos(txtFiltro.Text.Trim());
        }

        protected void txtFiltro_TextChanged(object sender, EventArgs e)
        {
            CargarDatos(txtFiltro.Text.Trim());
        }


        protected string ObtenerNombreLaboratorio(object codLab)
        {
            DataView dv = new DataView(medicamentoBL.ListarLaboratorio());
            dv.RowFilter = $"cod_lab = '{codLab}'";

            // Verificar si se encontró un laboratorio con el código proporcionado
            if (dv.Count > 0)
            {
                // Obtener el nombre del laboratorio
                return dv[0]["nom_lab"].ToString();
            }
            else
            {
                return "Laboratorio no encontrado";
            }
        }
        private void CargarLaboratorio()
        {
            try
            {
                cboLaboratorio.DataSource = medicamentoBL.ListarLaboratorio();
                cboLaboratorio.DataValueField = "cod_lab";
                cboLaboratorio.DataTextField = "nom_lab";
                cboLaboratorio.DataBind();
                //cboLaboratorio.SelectedValue = "";
            }
            catch (Exception ex)
            {
                ((PageMaster)Master).MostrarToast("Error", "danger", ex.Message);
            }
        }

        private void MostrartModalMedicamento()
        {
            ScriptManager.RegisterStartupScript(this, this.GetType(), "mostrarModalMedicamento", "mostrarModalMedicamento();", true);
        }
        private void MostrarExito(string message)
        {
            ((PageMaster)Master).MostrarToast("Éxito", "success", message);
        }

        private void MostrarError(string message)
        {
            ((PageMaster)Master).MostrarToast("Error", "danger", message);
        }
    }
}