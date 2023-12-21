<%@ Page Title="" Language="C#" MasterPageFile="~/PageMaster.Master" AutoEventWireup="true" CodeBehind="Medicamentos.aspx.cs" Inherits="sitioWebClinica.Mantenimiento.Medicamentos" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container mt-4">

        <!-- Modal para Nuevo Medicamento -->
        <div class="modal fade" id="modalMedicamento" tabindex="-1" aria-labelledby="modalLabel"
            aria-hidden="true">
            <div class="modal-dialog modal-lg modal-dialog-centered">
                <div class="modal-content" id="modalContent">
                    <div class="modal-header">
                        <h5 class="modal-title" id="modalLabel">Nuevo Medicamento</h5>
                        <button type="button" class="btn-close" data-bs-dismiss="modal" aria-label="Close"></button>
                    </div>
                    <div class="modal-body">
                        <!-- Contenido del formulario para agregar nuevo Medicamento -->
                        <form id="frmMedicamento">
                            <div class="row">
                                <asp:TextBox ID="modoActual" runat="server" CssClass="form-control" ClientIDMode="Static" type="hidden" />
                                <asp:TextBox ID="txtCodMedicamento" runat="server" CssClass="form-control" ClientIDMode="Static" type="hidden" />
                                <div class="col">

                                    <div class="form-floating mb-3">
                                        <asp:TextBox ID="txtNombre" runat="server" CssClass="form-control"
                                            placeholder="Ingrese nombre del Medicamento" />
                                        <label for="txtNombre">Nombre: </label>
                                    </div>
                                    <div class="form-floating mb-3">
                                        <asp:TextBox ID="txtComposicion" runat="server" CssClass="form-control"
                                            placeholder="Ingrese Composicion del Medicamento" TextMode="MultiLine" Rows="5" />
                                        <label for="txtComposicion">Composicion: </label>
                                    </div>

                                    <div class="form-floating mb-3">
                                        <asp:TextBox ID="txtPeso" runat="server" CssClass="form-control"
                                            placeholder="Ingrese el peso del Medicamento" TextMode="Number" />
                                        <label for="txtPeso">Peso:</label>
                                    </div>
                                    <div class="form-floating mb-3">
                                        <asp:DropDownList ID="cboLaboratorio" runat="server" CssClass="form-control">
                                        </asp:DropDownList>
                                        <label for="cboLaboratorio">Laboratorio:</label>
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
                        <button type="button" class="btn btn-outline-secondary" data-bs-dismiss="modal"><i class="fas fa-times"></i> Cerrar</button>
                        <asp:LinkButton type="button" class="btn btn-success" OnClick="btnGuardarMedicamento_Click"
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
                titulo.textContent = 'Editar Medicamento';
            }
            // Función para mostrar el modal Medicamento
            function mostrarModalMedicamento() {
                var modal = new bootstrap.Modal(document.getElementById('modalMedicamento'));
                modal.show();
            }

        </script>
        <!-- Modal para Medicamento -->


        <h2 class="text-center mb-4">Listado de Medicamentos</h2>
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
            <asp:LinkButton ID="btnNuevo" runat="server" CssClass="btn btn-success" OnClick="btnNuevoMedicamento_Click">
                Nuevo Medicamento</asp:LinkButton>
        </div>
        <asp:GridView ID="gvMedicamento" runat="server" AutoGenerateColumns="False"
            CssClass="table table-bordered table-hover table-responsive" GridLines="None" AllowPaging="True" EnableViewState="true"
            OnPageIndexChanging="gvMedicamento_PageIndexChanging">

            <Columns>
                <asp:BoundField DataField="cod_medi" HeaderText="Código" />
                <asp:BoundField DataField="nom_medi" HeaderText="Nombre" />
                <asp:BoundField DataField="comp_medi" HeaderText="Composicion" />
                <asp:BoundField DataField="mlgr_medi" HeaderText="Mlgr" />
                <asp:TemplateField HeaderText="Laboratorio">
                    <ItemTemplate>
                        <%# ObtenerNombreLaboratorio(Eval("cod_lab")) %>
                    </ItemTemplate>
                </asp:TemplateField>

                <asp:TemplateField HeaderText="Acciones">
                    <ItemTemplate>
                        <asp:LinkButton ID="btnEditar" runat="server" CssClass="btn btn-warning"
                            OnClick="btnEditarMedicamento_Click"
                            data-cod-pac='<%# Eval("cod_medi") %>'>
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
