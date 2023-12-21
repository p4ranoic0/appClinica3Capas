<%@ Page Title="" Language="C#" MasterPageFile="~/PageMaster.Master" AutoEventWireup="true" CodeBehind="Paciente.aspx.cs" Inherits="sitioWebClinica.Mantenimiento.Paciente" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container mt-4">

        <!-- Modal para Nuevo Paciente -->
        <div class="modal fade" id="modalPaciente" tabindex="-1" aria-labelledby="modalLabel"
            aria-hidden="true">
            <div class="modal-dialog modal-xl modal-dialog-centered">

                <div class="modal-content" id="modalContent">
                    
                    <div class="modal-header">
                        <h5 class="modal-title" id="modalLabel">Nuevo Paciente</h5>
                        <button type="button" class="btn-close" data-bs-dismiss="modal" aria-label="Close"></button>
                    </div>
                    <div class="modal-body">
                        <!-- Contenido del formulario para agregar nuevo paciente -->
                        <form id="frmPaciente" >
                            <div class="row">
                                 <asp:TextBox ID="modoActual" runat="server" CssClass="form-control"  ClientIDMode="Static" type="hidden"/>
                                 <asp:TextBox ID="txtCodPaciente" runat="server" CssClass="form-control"  ClientIDMode="Static" type="hidden"/>
                                <div class="col-md-6">

                                    <div class="form-floating mb-3">
                                        <asp:TextBox ID="txtNombre" runat="server" CssClass="form-control"
                                            placeholder="Ingrese nombres del paciente" />
                                        <label for="txtNombre">Nombre: </label>
                                    </div>
                                    <div class="form-floating mb-3">
                                        <asp:TextBox ID="txtApellido" runat="server" CssClass="form-control"
                                            placeholder="Ingrese apellidos del paciente" />
                                        <label for="txtApellido">Apellidos: </label>
                                    </div>

                                    <div class="form-floating mb-3">
                                        <asp:TextBox ID="txtFechaNacimiento" runat="server" CssClass="form-control"
                                            placeholder="Ingrese la fecha de nacimiento del paciente" TextMode="Date" />
                                        <label for="txtFechaNacimiento">Fecha de nacimiento:</label>
                                    </div>

                                    <div class="form-floating mb-3">
                                        <asp:TextBox ID="txtEmail" runat="server" CssClass="form-control"
                                            placeholder="Ingrese el correo electrónico del paciente" TextMode="Email" />
                                        <label for="txtEmail">Correo electrónico:</label>
                                    </div>

                                    <div class="form-floating mb-3">
                                        <asp:DropDownList ID="cboGenero" runat="server" CssClass="form-control">
                                            <asp:ListItem Value="M">Masculino</asp:ListItem>
                                            <asp:ListItem Value="F">Femenino</asp:ListItem>
                                        </asp:DropDownList>
                                        <label for="cboGenero">Género:</label>
                                    </div>
                                    <div class="form-floating mb-3">
                                        <asp:TextBox ID="txtTelefono" runat="server" CssClass="form-control"
                                            placeholder="Ingrese el número de teléfono del paciente" TextMode="Phone" />
                                        <label for="txtTelefono">Teléfono:</label>
                                    </div>

                                </div>
                                <div class="col-md-6">

                                    <div class="form-floating mb-3">
                                        <asp:TextBox ID="txtSangre" runat="server" CssClass="form-control"
                                            placeholder="Ingrese tipo sangre" />
                                        <label for="txtSangre">Sangre:</label>
                                    </div>

                                    <div class="form-floating mb-3">
                                        <asp:DropDownList ID="cboSeguro" runat="server" CssClass="form-control">
                                        </asp:DropDownList>
                                        <label for="cboSeguro">Seguro:</label>
                                    </div>


                                    <div class="form-floating mb-3">
                                        <asp:TextBox ID="txtDireccion" runat="server" CssClass="form-control"
                                            placeholder="Ingrese Direccion" />
                                        <label for="txtDireccion">Direccion:</label>
                                    </div>

                                    <div class="form-floating mb-3">
                                        <asp:DropDownList ID="cboDepartamento" runat="server" CssClass="form-control"
                                            AutoPostBack="True"
                                            OnSelectedIndexChanged="cboDepartamento_SelectedIndexChanged">
                                        </asp:DropDownList>
                                        <label for="cboDepartamento">Departamento:</label>
                                    </div>
                                    <div class="form-floating mb-3">
                                        <asp:DropDownList ID="cboProvincia" runat="server" CssClass="form-control"
                                            AutoPostBack="True"
                                            OnSelectedIndexChanged="cboProvincia_SelectedIndexChanged">
                                        </asp:DropDownList>
                                        <label for="cboProvincia">Provincia:</label>
                                    </div>
                                    <div class="form-floating mb-3">
                                        <asp:DropDownList ID="cboDistrito" runat="server" CssClass="form-control">
                                        </asp:DropDownList>
                                        <label for="cboDistrito">Distrito:</label>
                                    </div>

                                    <div class="form-check mb-3">
                                        <input class="form-check-input" type="checkbox" value="" ID="chkEstado"
                                            runat="server" checked>
                                        <label class="form-check-label" for="chkEstado">
                                            Activo
                                        </label>
                                    </div>
                                </div>
                            </div>
                        </form>

                        <!-- Por ejemplo, puedes agregar campos para el nombre, género, teléfono, correo, etc. -->
                    </div>
                    <div class="modal-footer">
                        <button type="button" class="btn btn-outline-secondary" data-bs-dismiss="modal">
                            <i class="fas fa-times"></i> Cerrar

                        </button>
                        <asp:LinkButton type="button" class="btn btn-success" OnClick="btnGuardarPaciente_Click"
                            runat="server"><i class="fas fa-save"></i> Guardar</asp:LinkButton>
                    </div>
                </div>
            </div>
        </div>


        <script>
            function configurarModoEdicion() {

                var inputModo = document.getElementById('modoActual');
                inputModo.setAttribute('value', 'editar');
                // Cambiar el contenido del título
                var titulo = document.getElementById('modalLabel');
                titulo.textContent = 'Editar Paciente';
            }
          // Función para mostrar el modal Paciente
            function mostrarModalPaciente() {
                var modal = new bootstrap.Modal(document.getElementById('modalPaciente'));
                modal.show();
            }

        </script>
        <!-- Modal para Paciente -->


        <h2 class="text-center mb-4">Listado de Pacientes</h2>
        <p class="text-end">
            <asp:HyperLink ID="HyperLink" runat="server" NavigateUrl="~/Home.aspx" CssClass="btn btn-outline-secondary">
                Retornar al Registro</asp:HyperLink>
        </p>

        <div class="row mb-3">
            <div class="col-md-2 labelContenido">Ingrese Filtro:</div>
            <div class="col-md-4">
                <div class="input-group">
                    <asp:TextBox ID="txtFiltro" runat="server" CssClass="form-control"
                        OnTextChanged="txtFiltro_TextChanged" AutoPostBack="true"></asp:TextBox>
                    <div class="input-group-append">
                        <asp:LinkButton ID="btnFiltrar" runat="server" CssClass="btn btn-primary"
                            OnClick="btnFiltrar_Click">
                            <i class="fas fa-search"></i>
                        </asp:LinkButton>
                    </div>
                </div>
            </div>
        </div>

        <div class="text-end mb-3 mt-3">
            <asp:LinkButton ID="btnNuevo" runat="server" CssClass="btn btn-success" OnClick="btnNuevoPaciente_Click">
                Nuevo Paciente</asp:LinkButton>
        </div>
        <asp:GridView ID="gvPaciente" runat="server" AutoGenerateColumns="False"
            CssClass="table table-bordered table-hover table-responsive" GridLines="None" AllowPaging="True" EnableViewState="true"
            OnPageIndexChanging="gvPaciente_PageIndexChanging">

            <Columns>
                <asp:BoundField DataField="cod_pac" HeaderText="Código" />
                <asp:BoundField DataField="NombreCompleto" HeaderText="Nombre" />
                <asp:BoundField DataField="genero" HeaderText="Genero" />
                <asp:BoundField DataField="telf" HeaderText="Telefono" />
                <asp:BoundField DataField="email" HeaderText="Correo" />
                <asp:BoundField DataField="fech_nac_pac" HeaderText="Fecha Nacimiento" DataFormatString="{0:d}" />

                <asp:TemplateField HeaderText="Acciones">
                    <ItemTemplate>
                        <asp:LinkButton ID="btnEditar" runat="server" CssClass="btn btn-warning"
                            OnClick="btnEditarPaciente_Click"
                            data-cod-pac='<%# Eval("cod_pac") %>'>
                            <i class="fas fa-edit"></i> Editar
                        </asp:LinkButton>
                    </ItemTemplate>
                </asp:TemplateField>
            </Columns>
            <PagerStyle CssClass="pagination justify-content-center" HorizontalAlign="Center" />

            <HeaderStyle CssClass="table-dark" />
            <RowStyle CssClass="table-light" />
            <SelectedRowStyle CssClass="table-success" />
        </asp:GridView>
    </div>

</asp:Content>