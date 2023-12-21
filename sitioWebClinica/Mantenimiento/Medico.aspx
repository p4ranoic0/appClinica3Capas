<%@ Page Title="" Language="C#" MasterPageFile="~/PageMaster.Master" AutoEventWireup="true" CodeBehind="Medico.aspx.cs" Inherits="sitioWebClinica.Mantenimiento.Medico" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container mt-4">

        <!-- Modal para Nuevo Medico -->
        <div class="modal fade" id="modalMedico" tabindex="-1" aria-labelledby="modalLabel"
            aria-hidden="true">
            <div class="modal-dialog modal-xl modal-dialog-centered">
                <div class="modal-content" id="modalContent">

                    <div class="modal-header">
                        <h5 class="modal-title" id="modalLabel">Nuevo Medico</h5>
                        <button type="button" class="btn-close" data-bs-dismiss="modal" aria-label="Close"></button>
                    </div>
                    <div class="modal-body">
                        <!-- Contenido del formulario para agregar nuevo Medico -->
                        <form id="frmMedico">
                            <div class="row">
                                <asp:TextBox ID="modoActual" runat="server" CssClass="form-control" ClientIDMode="Static" type="hidden" />
                                <asp:TextBox ID="txtCodMedico" runat="server" CssClass="form-control" ClientIDMode="Static" type="hidden" />
                                <div class="col-md-6">

                                    <div class="form-floating mb-3">
                                        <asp:TextBox ID="txtNombre" runat="server" CssClass="form-control"
                                            placeholder="Ingrese nombres del Medico" />
                                        <label for="txtNombre">Nombre: </label>
                                    </div>
                                    <div class="form-floating mb-3">
                                        <asp:TextBox ID="txtApellido" runat="server" CssClass="form-control"
                                            placeholder="Ingrese apellidos del Medico" />
                                        <label for="txtApellido">Apellidos: </label>
                                    </div>
                                    <div class="form-floating mb-3">
                                        <asp:TextBox ID="txtFechaNacimiento" runat="server" CssClass="form-control"
                                            placeholder="Ingrese la fecha de nacimiento del Medico" TextMode="Date" />
                                        <label for="txtFechaNacimiento">Fecha de nacimiento:</label>
                                    </div>

                                    <div class="form-floating mb-3">
                                        <asp:TextBox ID="txtEmail" runat="server" CssClass="form-control"
                                            placeholder="Ingrese el correo electrónico del Medico" TextMode="Email" />
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
                                            placeholder="Ingrese el número de teléfono del Medico" TextMode="Number" />
                                        <label for="txtTelefono">Teléfono:</label>
                                    </div>

                                </div>
                                <div class="col-md-6">

                                    <div class="form-floating mb-3">
                                        <asp:TextBox ID="txtColegio" runat="server" CssClass="form-control"
                                            placeholder="Ingrese nro colegio"  TextMode="Number"/>
                                        <label for="txtColegio">Nro Colegio:</label>
                                    </div>

                                    <div class="form-floating mb-3">
                                        <asp:DropDownList ID="cboEspecialidad" runat="server" CssClass="form-control">
                                        </asp:DropDownList>
                                        <label for="cboEspecialidad">Especialidad:</label>
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
                                        <input class="form-check-input" type="checkbox" value="" id="chkEstado"
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
                            <i class="fas fa-times"></i> Cerrar</button>
                        <asp:LinkButton type="button" class="btn btn-success" OnClick="btnGuardarMedico_Click"
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
                titulo.textContent = 'Editar Medico';
            }
            // Función para mostrar el modal Medico
            function mostrarModalMedico() {
                var modal = new bootstrap.Modal(document.getElementById('modalMedico'));
                modal.show();
            }

        </script>
        <!-- Modal para Medico -->


        <h2 class="text-center mb-4">Listado de Medicos</h2>
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
            <asp:LinkButton ID="btnNuevo" runat="server" CssClass="btn btn-success" OnClick="btnNuevoMedico_Click">
            Nuevo Medico</asp:LinkButton>
        </div>
        <asp:GridView ID="gvMedico" runat="server" AutoGenerateColumns="False"
            CssClass="table table-bordered table-hover table-responsive" GridLines="None" AllowPaging="True" EnableViewState="true"
            OnPageIndexChanging="gvMedico_PageIndexChanging">

            <Columns>
                <asp:BoundField DataField="cod_med" HeaderText="Código" />
                <asp:BoundField DataField="NombreCompleto" HeaderText="Nombre" />
                <asp:BoundField DataField="genero" HeaderText="Genero" />
                <asp:BoundField DataField="telf" HeaderText="Telefono" />
                <asp:BoundField DataField="email" HeaderText="Correo" />
                <asp:BoundField DataField="fech_nac_med" HeaderText="Fecha Nacimiento" DataFormatString="{0:d}" />
                <asp:TemplateField HeaderText="Especialidad">
                    <ItemTemplate>
                        <%# ObtenerNombreEspecialidad(Eval("cod_espec")) %>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Acciones">
                    <ItemTemplate>
                        <asp:LinkButton ID="btnEditar" runat="server" CssClass="btn btn-warning"
                            OnClick="btnEditarMedico_Click"
                            data-cod-med='<%# Eval("cod_med") %>'>
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
