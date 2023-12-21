using Clinica_BE;
using Clinica_BL;
using System;
using System.Data;
using System.Web.UI.WebControls;
using System.Web.UI;

namespace sitioWebClinica.Mantenimiento
{
    public partial class Medico : System.Web.UI.Page
    {

        MedicoBL medicoBL = new MedicoBL();
        MedicoBE medicoBE = new MedicoBE();
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
            dv = new DataView(medicoBL.ListarMedico());
            Session["Vista"] = dv;
        }



        private void CargarDatos(String filtro)
        {
            try
            {
                dv = (DataView)Session["Vista"];
                dv.RowFilter = "nom_med like '%" + filtro + "%'" + "OR ape_med like '%" + filtro + "%'";
                gvMedico.DataSource = dv;
                gvMedico.DataBind();

                if (gvMedico.Rows.Count == 0)
                {
                    MostrarError("No existen registros con el criterio ingresado.");
                }
            }
            catch (Exception ex)
            {
                MostrarError(ex.Message);
            }

        }
        protected void btnNuevoMedico_Click(object sender, EventArgs e)
        {
            medicoBE = new MedicoBE();
            LimpiarFormulario();
            MostrartModalMedico();
        }


        protected void btnGuardarMedico_Click(object sender, EventArgs e)
        {
            try
            {
                //Verifico si es nuevo o editar con un campo oculto
                string modo = modoActual.Text;

                medicoBE.Cod_med = txtCodMedico.Text;
                medicoBE.Nom_med = txtNombre.Text.ToUpper();
                medicoBE.Ape_med = txtApellido.Text.ToUpper();
                medicoBE.Genero = cboGenero.SelectedValue;
                medicoBE.Telf = txtTelefono.Text.Trim();
                medicoBE.Num_colegiatura = txtColegio.Text.Trim();
                medicoBE.Cod_espec = cboEspecialidad.SelectedValue;
                medicoBE.Dir_med = txtDireccion.Text.ToUpper();
                medicoBE.Cod_ubigeo = cboDepartamento.SelectedValue + cboProvincia.SelectedValue + cboDistrito.SelectedValue;
                medicoBE.Fech_nac_med = Convert.ToDateTime(txtFechaNacimiento.Text.ToString());
                medicoBE.Email = txtEmail.Text;
                medicoBE.Est_med1 = chkEstado.Checked ? 1 : 0; // Activo si el checkbox está marcado, inactivo si no


                medicoBE.Fec_reg1 = DateTime.Now;
                medicoBE.Usu_Registro1 = "Admin";
                medicoBE.Usu_Ult_Mod1 = "Admin";
                medicoBE.Fec_Ult_Mod1 = DateTime.Now;


                // Crear una instancia de MedicoBL y llamar al método para agregar medico

                bool resultado = (modo.Equals("nuevo")) ? medicoBL.InsertarMedico(medicoBE) : medicoBL.ActualizarMedico(medicoBE);

                if (resultado)
                {
                    string mensajeExito = (modo.Equals("nuevo")) ? "Se agrego el nuevo Medico" : "Se modifico los datos del Medico: " + txtCodMedico.Text;
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



        // Función para limpiar los campos del formulario después de agregar un nuevo medico
        private void LimpiarFormulario()
        {
            modoActual.Text = "nuevo";
            txtCodMedico.Text = "";
            txtNombre.Text = "";
            txtApellido.Text = "";
            txtFechaNacimiento.Text = "";
            txtEmail.Text = "";
            cboGenero.SelectedIndex = 0;
            txtTelefono.Text = "";
            txtColegio.Text = "";
            cboEspecialidad.SelectedIndex = 0;
            txtDireccion.Text = "";
            CargarUbigeo("14", "01", "01");
            CargarEspecialidad();
            chkEstado.Checked = true; // Puedes ajustar esto según tus necesidades
        }


        protected void btnEditarMedico_Click(object sender, EventArgs e)
        {
            LinkButton btnEditar = (LinkButton)sender;

            string cod = btnEditar.Attributes["data-cod-med"];

            ScriptManager.RegisterStartupScript(this, this.GetType(), "ConfigurarModoEdicion", "configurarModoEdicion();", true);

            cargarDatosModal(cod);
            MostrartModalMedico();
        }

        private void cargarDatosModal(string cod)
        {
            try
            {
                medicoBE = medicoBL.ConsultarMedico(cod);
                LimpiarFormulario();
                txtCodMedico.Text = cod;
                txtNombre.Text = medicoBE.Nom_med;
                txtApellido.Text = medicoBE.Ape_med;
                txtFechaNacimiento.Text = medicoBE.Fech_nac_med.ToString("yyyy-MM-dd");
                txtEmail.Text = medicoBE.Email;
                cboGenero.SelectedValue = medicoBE.Genero;
                txtTelefono.Text = medicoBE.Telf.Trim();
                txtColegio.Text = medicoBE.Num_colegiatura.Trim();
                cboEspecialidad.SelectedValue = medicoBE.Cod_espec;
                txtDireccion.Text = medicoBE.Dir_med;
                string codUbigeo = medicoBE.Cod_ubigeo;
                CargarUbigeo(codUbigeo.Substring(0, 2), codUbigeo.Substring(2, 2), codUbigeo.Substring(4, 2));
                chkEstado.Checked = medicoBE.Est_med1.Equals(1) ? true : false;

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


        protected void gvMedico_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            gvMedico.PageIndex = e.NewPageIndex;
            InicializarVista();
            CargarDatos(txtFiltro.Text.Trim());
        }

        protected void txtFiltro_TextChanged(object sender, EventArgs e)
        {
            CargarDatos(txtFiltro.Text.Trim());
        }

        private void CargarUbigeo(String IdDepa, String IdProv, String IdDist)
        {
            // Combos de ubigeo para la insercion del proveedor
            cboDepartamento.DataSource = ubigeo.Ubigeo_Departamentos();
            cboDepartamento.DataValueField = "IdDepa";
            cboDepartamento.DataTextField = "Departamento";
            cboDepartamento.DataBind();

            cboDepartamento.SelectedValue = IdDepa;
            cboProvincia.DataSource = ubigeo.Ubigeo_ProvinciasDepartamento(IdDepa);
            cboProvincia.DataValueField = "IdProv";
            cboProvincia.DataTextField = "Provincia";
            cboProvincia.DataBind();

            cboProvincia.SelectedValue = IdProv;
            cboDistrito.DataSource = ubigeo.Ubigeo_DistritosProvinciaDepartamento
                                                                   (IdDepa, IdProv);
            cboDistrito.DataValueField = "IdDist";
            cboDistrito.DataTextField = "Distrito";
            cboDistrito.DataBind();
            cboDistrito.SelectedValue = IdDist;
        }


        protected void cboDepartamento_SelectedIndexChanged(object sender, EventArgs e)
        {

            CargarUbigeo(cboDepartamento.SelectedValue.ToString(), "01", "01");
            //Para que al postear el evento SelectedIndexChanged se mantenga abierto el PopMant
            ScriptManager.RegisterStartupScript(this, this.GetType(), "mostrarModalMedico", "mostrarModalMedico();", true);
        }

        protected void cboProvincia_SelectedIndexChanged(object sender, EventArgs e)
        {
            CargarUbigeo(cboDepartamento.SelectedValue.ToString(), cboProvincia.SelectedValue.ToString(), "01");
            //Para que al postear el evento SelectedIndexChanged se mantenga abierto el PopMant
            ScriptManager.RegisterStartupScript(this, this.GetType(), "mostrarModalMedico", "mostrarModalMedico();", true);
        }


        private void CargarEspecialidad()
        {
            try
            {
                cboEspecialidad.DataSource = medicoBL.ListarEspecialidad();
                cboEspecialidad.DataValueField = "cod_espec";
                cboEspecialidad.DataTextField = "nom_espec";
                cboEspecialidad.DataBind();
                //cboEspecialidad.SelectedValue = "";
            }
            catch (Exception ex)
            {
                MostrarError(ex.Message);
            }
        }

        protected string ObtenerNombreEspecialidad(object codEspec)
        {
            DataView dv = new DataView(medicoBL.ListarEspecialidad());
            dv.RowFilter = $"cod_espec = '{codEspec}'";

            // Verificar si se encontró un especialidad con el código proporcionado
            if (dv.Count > 0)
            {
                // Obtener el nombre del especialidad
                return dv[0]["nom_espec"].ToString();
            }
            else
            {
                return "Especialidad no encontrado";
            }
        }

        private void MostrartModalMedico()
        {
            ScriptManager.RegisterStartupScript(this, this.GetType(), "mostrarModalMedico", "mostrarModalMedico();", true);
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