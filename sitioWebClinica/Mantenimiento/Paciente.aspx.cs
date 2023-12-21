using Clinica_BE;
using Clinica_BL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace sitioWebClinica.Mantenimiento
{
    public partial class Paciente : System.Web.UI.Page
    {

        PacienteBL pacienteBL = new PacienteBL();
        PacienteBE pacienteBE = new PacienteBE();
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
            dv = new DataView(pacienteBL.ListarPaciente());
            Session["Vista"] = dv;
        }



        private void CargarDatos(String filtro)
        {
            try
            {
                dv = (DataView)Session["Vista"];
                dv.RowFilter = "nom_pac like '%" + filtro + "%'" + "OR ape_pac like '%" + filtro + "%'";
                gvPaciente.DataSource = dv;
                gvPaciente.DataBind();

                if (gvPaciente.Rows.Count == 0)
                {
                    MostrarError("No existen registros con el criterio ingresado.");
                }
            }
            catch (Exception ex)
            {
                MostrarError(ex.Message);
            }

        }
        protected void btnNuevoPaciente_Click(object sender, EventArgs e)
        {
            pacienteBE = new PacienteBE();
            LimpiarFormulario();
            MostrartModalPaciente();
        }


        protected void btnGuardarPaciente_Click(object sender, EventArgs e)
        {
            try
            {
                //Verifico si es nuevo o editar con un campo oculto
                string modo = modoActual.Text;

                pacienteBE.Cod_pac = txtCodPaciente.Text;
                pacienteBE.Nom_pac = txtNombre.Text.ToUpper();
                pacienteBE.Ape_pac = txtApellido.Text.ToUpper();
                pacienteBE.Genero = cboGenero.SelectedValue;
                pacienteBE.Telf = txtTelefono.Text;
                pacienteBE.Sangre = txtSangre.Text;
                pacienteBE.Cod_seg = cboSeguro.SelectedValue;
                pacienteBE.Dir_pac = txtDireccion.Text.ToUpper();
                pacienteBE.Cod_ubigeo = cboDepartamento.SelectedValue + cboProvincia.SelectedValue + cboDistrito.SelectedValue;
                pacienteBE.Fech_nac_pac = Convert.ToDateTime(txtFechaNacimiento.Text.ToString());
                pacienteBE.Email = txtEmail.Text;
                pacienteBE.Est_pac = chkEstado.Checked ? "2" : "1"; // Activo si el checkbox está marcado, inactivo si no



                pacienteBE.Usu_Registro1 = "Admin";
                pacienteBE.Usu_Ult_Mod1 = "Admin";
                pacienteBE.Fec_Ult_Mod1 = DateTime.Now;


                // Crear una instancia de PacienteBL y llamar al método para agregar paciente

                bool resultado = (modo.Equals("nuevo")) ? pacienteBL.InsertarPaciente(pacienteBE) : pacienteBL.ActualizarPaciente(pacienteBE);

                if (resultado)
                {
                    string mensajeExito = (modo.Equals("nuevo")) ? "Se agrego el nuevo Paciente" : "Se modifico los datos del Paciente: " + txtCodPaciente.Text;
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



        // Función para limpiar los campos del formulario después de agregar un nuevo paciente
        private void LimpiarFormulario()
        {
            modoActual.Text = "nuevo";
            txtCodPaciente.Text = "";
            txtNombre.Text = "";
            txtApellido.Text = "";
            txtFechaNacimiento.Text = "";
            txtEmail.Text = "";
            cboGenero.SelectedIndex = 0;
            txtTelefono.Text = "";
            txtSangre.Text = "";            
            txtDireccion.Text = "";
            CargarUbigeo("14", "01", "01");
            CargarSeguro();
            chkEstado.Checked = true; // Puedes ajustar esto según tus necesidades
        }


        protected void btnEditarPaciente_Click(object sender, EventArgs e)
        {
            LinkButton btnEditar = (LinkButton)sender;

            string cod = btnEditar.Attributes["data-cod-pac"];

            ScriptManager.RegisterStartupScript(this, this.GetType(), "ConfigurarModoEdicion", "configurarModoEdicion();", true);

            cargarDatosModal(cod);
            MostrartModalPaciente();
        }

        private void cargarDatosModal(string cod)
        {
            try
            {
                pacienteBE = pacienteBL.ConsultarPaciente(cod);
                LimpiarFormulario();
                txtCodPaciente.Text = cod;
                txtNombre.Text = pacienteBE.Nom_pac;
                txtApellido.Text = pacienteBE.Ape_pac;
                txtFechaNacimiento.Text = pacienteBE.Fech_nac_pac.ToString("yyyy-MM-dd");
                txtEmail.Text = pacienteBE.Email;
                cboGenero.SelectedValue = pacienteBE.Genero;
                txtTelefono.Text = pacienteBE.Telf;
                txtSangre.Text = pacienteBE.Sangre;
                cboSeguro.SelectedValue = pacienteBE.Cod_seg;
                txtDireccion.Text = pacienteBE.Dir_pac;
                string codUbigeo = pacienteBE.Cod_ubigeo;
                CargarUbigeo(codUbigeo.Substring(0, 2), codUbigeo.Substring(2, 2), codUbigeo.Substring(4, 2));
                chkEstado.Checked = pacienteBE.Est_pac.Equals("2") ? true : false;

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


        protected void gvPaciente_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            gvPaciente.PageIndex = e.NewPageIndex;
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
            ScriptManager.RegisterStartupScript(this, this.GetType(), "mostrarModalPaciente", "mostrarModalPaciente();", true);
        }

        protected void cboProvincia_SelectedIndexChanged(object sender, EventArgs e)
        {
            CargarUbigeo(cboDepartamento.SelectedValue.ToString(), cboProvincia.SelectedValue.ToString(), "01");
            //Para que al postear el evento SelectedIndexChanged se mantenga abierto el PopMant
            ScriptManager.RegisterStartupScript(this, this.GetType(), "mostrarModalPaciente", "mostrarModalPaciente();", true);
        }


        private void CargarSeguro()
        {
            try
            {
                cboSeguro.DataSource = pacienteBL.ListarSeguro();
                cboSeguro.DataValueField = "cod_seg";
                cboSeguro.DataTextField = "nom_sug";
                cboSeguro.DataBind();
                //cboSeguro.SelectedValue = "";
            }
            catch (Exception ex)
            {
                ((PageMaster)Master).MostrarToast("Error", "danger", ex.Message);
            }
        }

        private void MostrartModalPaciente()
        {
            ScriptManager.RegisterStartupScript(this, this.GetType(), "mostrarModalPaciente", "mostrarModalPaciente();", true);
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