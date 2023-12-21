using Clinica_BE;
using Clinica_BL;
using System;
using System.Data;
using System.Web.UI.WebControls;
using System.Web.UI;
using sitioWebClinica.Mantenimiento;

namespace sitioWebClinica.Reportes
{
    public partial class Reporte1 : System.Web.UI.Page
    {
        AtencionBL atencionBL = new AtencionBL();
        AtencionBE atencionBE = new AtencionBE();
        MedicoBL medicoBL = new MedicoBL();
        PacienteBL pacienteBL = new PacienteBL();
        DataView dv;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                try
                {
                    InicializarVista();
                   
                    CargarMedico();
                    CargarPaciente();
                    CargarSucursal();


                }
                catch (Exception ex)
                {
                    MostrarError(ex.Message);
                }
            }
        }
        private void InicializarVista()
        {
            dv = new DataView(atencionBL.ListarAtencion());
            Session["Vista"] = dv;
            gvAtencion.DataSource = dv;
            gvAtencion.DataBind();

        }

        protected void btnLimpiarFiltros_Click(object sender, EventArgs e)
        {
            // Recargar la página
            Response.Redirect(Request.RawUrl);
        }

        private void CargarDatos(string medico,string paciente, string sucursal)
        {
            try
            {
                dv = (DataView)Session["Vista"];
                dv.RowFilter = $"cod_med = '{medico}' AND cod_pac = '{paciente}' AND cod_suc = '{sucursal}'";

                gvAtencion.DataSource = dv;
                gvAtencion.DataBind();

                if (gvAtencion.Rows.Count == 0)
                {
                    MostrarError("No existen registros con el criterio ingresado.");
                }
            }
            catch (Exception ex)
            {
                MostrarError(ex.Message);
            }
        }

     
                        
        protected void btnNuevoAtencion_Click(object sender, EventArgs e)
        {
            atencionBE = new AtencionBE();
            LimpiarFormulario();
            MostrartModalAtencion();
        }


        // Función para limpiar los campos del formulario después de agregar un nuevo atencion
        private void LimpiarFormulario()
        {
           
            CargarMedico();
            CargarPaciente();
            CargarSucursal();
            cboMedico.SelectedIndex = 0;
            cboSucursal.SelectedIndex = 0;
            cboPaciente.SelectedIndex = 0;
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

        protected void btnBuscarAtencion_Click(object sender, EventArgs e)
        {
            try { 
            CargarDatos(cboMedico.SelectedValue.ToString(), cboPaciente.SelectedValue.ToString(), cboSucursal.SelectedValue.ToString());
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
            // Opcional: Limpiar el GridView si hay un error
            gvAtencion.DataSource = null;
            gvAtencion.DataBind();
        }
    }
}