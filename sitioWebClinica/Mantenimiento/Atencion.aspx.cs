using Clinica_BE;
using Clinica_BL;
using System;
using System.Data;
using System.Web.UI.WebControls;
using System.Web.UI;

namespace sitioWebClinica.Mantenimiento
{
    public partial class Atencion : System.Web.UI.Page
    {
        AtencionBL atencionBL = new AtencionBL();
        AtencionBE atencionBE = new AtencionBE();
        MedicoBL medicoBL = new MedicoBL();
        PacienteBL pacienteBL = new PacienteBL();
      

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                try
                {
                    InicializarVista();                   

                }
                catch (Exception ex)
                {
                    MostrarError(ex.Message);
                }
            }
        }
        private void InicializarVista()
        {
            gvAtencion.DataSource = atencionBL.ListarAtencion();
            gvAtencion.DataBind();
        }

                        
        protected void btnNuevoAtencion_Click(object sender, EventArgs e)
        {
            atencionBE = new AtencionBE();
            LimpiarFormulario();
            MostrartModalAtencion();
        }


        protected void btnGuardarAtencion_Click(object sender, EventArgs e)
        {
            try
            {
                //Verifico si es nuevo o editar con un campo oculto
                string modo = modoActual.Text;

                atencionBE.Cod_ate = txtCodAtencion.Text;
                atencionBE.Cod_med = cboMedico.SelectedValue;
                atencionBE.Cod_pac = cboPaciente.SelectedValue;
                atencionBE.Cod_suc = cboSucursal.SelectedValue;
                atencionBE.Comen_ate = txtComentario.Text;
                atencionBE.Num_sala = txtSala.Text.Trim();
                                  
                atencionBE.Est_ate = chkEstado.Checked ? "2" : "1"; // Activo si el checkbox está marcado, inactivo si no

                atencionBE.Fec_reg1=DateTime.Now;

                atencionBE.Usu_Registro1 = "Admin";
                atencionBE.Usu_Ult_Mod1 = "Admin";
                atencionBE.Fec_Ult_Mod1 = DateTime.Now;


                // Crear una instancia de AtencionBL y llamar al método para agregar atencion

                bool resultado = (modo.Equals("nuevo")) ? atencionBL.InsertarAtencion(atencionBE) : atencionBL.ActualizarAtencion(atencionBE);

                if (resultado)
                {
                    string mensajeExito = (modo.Equals("nuevo")) ? "Se agrego el nuevo Atencion" : "Se modificó los datos del Atencion: " + txtCodAtencion.Text;
                    MostrarExito(mensajeExito);

                    // Limpiar los campos del formulario o cerrar el modal, según lo prefieras
                    LimpiarFormulario();
                    InicializarVista();                    
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



        // Función para limpiar los campos del formulario después de agregar un nuevo atencion
        private void LimpiarFormulario()
        {
            modoActual.Text = "nuevo";
            txtCodAtencion.Text = "";
            txtComentario.Text = "";
            txtSala.Text = "";
            CargarMedico();
            CargarPaciente();
            CargarSucursal();
            cboMedico.SelectedIndex = 0;
            cboSucursal.SelectedIndex = 0;
            cboPaciente.SelectedIndex = 0;
            chkEstado.Checked = true; // Puedes ajustar esto según tus necesidades
        }


        protected void btnEditarAtencion_Click(object sender, EventArgs e)
        {
            LinkButton btnEditar = (LinkButton)sender;

            string cod = btnEditar.Attributes["data-cod-ate"];

            ScriptManager.RegisterStartupScript(this, this.GetType(), "ConfigurarModoEdicion", "configurarModoEdicion();", true);

            cargarDatosModal(cod);
            MostrartModalAtencion();
        }

        private void cargarDatosModal(string cod)
        {
            try
            {
                atencionBE = atencionBL.ConsultarAtencion(cod);
                LimpiarFormulario();
                txtCodAtencion.Text = cod;
                cboMedico.SelectedValue = atencionBE.Cod_med;
                cboPaciente.SelectedValue = atencionBE.Cod_pac;
                cboSucursal.SelectedValue = atencionBE.Cod_suc;
                txtComentario.Text = atencionBE.Comen_ate;
                txtSala.Text = atencionBE.Num_sala.Trim();
                chkEstado.Checked = atencionBE.Est_ate.Equals("2") ? true : false;

            }
            catch (Exception ex)
            {
                MostrarError(ex.Message);
            }
        }

      

        protected void gvAtencion_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            gvAtencion.PageIndex = e.NewPageIndex;
            InicializarVista();      
        }

      


        protected string ObtenerNombreMedico(object codMed)
        {
            DataView dv = new DataView(medicoBL.ListarMedico());
            dv.RowFilter = $"cod_med= '{codMed}'";

            // Verificar si se encontró un laboratorio con el código proporcionado
            if (dv.Count > 0)
            {
                // Obtener el nombre del laboratorio
                return dv[0]["NombreCompleto"].ToString();
            }
            else
            {
                return "Medico no encontrado";
            }
        }
        protected string ObtenerNombrePaciente(object codPac)
        {
            DataView dv = new DataView(pacienteBL.ListarPaciente());
            dv.RowFilter = $"cod_pac= '{codPac}'";

            // Verificar si se encontró un laboratorio con el código proporcionado
            if (dv.Count > 0)
            {
                // Obtener el nombre del laboratorio
                return dv[0]["NombreCompleto"].ToString();
            }
            else
            {
                return "Paciente no encontrado";
            }
        }
        protected string ObtenerNombreSucursal(object codSuc)
        {
            DataView dv = new DataView(atencionBL.ListarSucursal());
            dv.RowFilter = $"cod_suc= '{codSuc}'";

            // Verificar si se encontró un laboratorio con el código proporcionado
            if (dv.Count > 0)
            {
                // Obtener el nombre del laboratorio
                return dv[0]["nom_suc"].ToString();
            }
            else
            {
                return "Sucursal no encontrado";
            }
        }

        private void CargarMedico()
        {
            try
            {
                cboMedico.DataSource = medicoBL.ListarMedico();
                cboMedico.DataValueField = "cod_med";
                cboMedico.DataTextField = "NombreCompleto";
                cboMedico.DataBind();
                //cboLaboratorio.SelectedValue = "";
            }
            catch (Exception ex)
            {
                MostrarError(ex.Message);
            }
        }

        private void CargarPaciente()
        {
            try
            {
                cboPaciente.DataSource = pacienteBL.ListarPaciente();
                cboPaciente.DataValueField = "cod_pac";
                cboPaciente.DataTextField = "NombreCompleto";
                cboPaciente.DataBind();
                //cboLaboratorio.SelectedValue = "";
            }
            catch (Exception ex)
            {
                MostrarError(ex.Message);
            }
        }

        private void CargarSucursal()
        {
            try
            {
                cboSucursal.DataSource = atencionBL.ListarSucursal();
                cboSucursal.DataValueField = "cod_suc";
                cboSucursal.DataTextField = "nom_suc";
                cboSucursal.DataBind();
                //cboLaboratorio.SelectedValue = "";
            }
            catch (Exception ex)
            {
                MostrarError(ex.Message);
            }
        }


        private void MostrartModalAtencion()
        {
            ScriptManager.RegisterStartupScript(this, this.GetType(), "mostrarModalAtencion", "mostrarModalAtencion();", true);
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