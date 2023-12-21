<%@ Page Title="" Language="C#" MasterPageFile="~/PageMaster.Master" AutoEventWireup="true" CodeBehind="Atencion.aspx.cs" Inherits="sitioWebClinica.Mantenimiento.Atencion" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     <div class="container mt-4">

     <!-- Modal para Nuevo Atencion -->
     <div class="modal fade" id="modalAtencion" tabindex="-1" aria-labelledby="modalLabel"
         aria-hidden="true">
         <div class="modal-dialog modal-lg modal-dialog-centered">
             <div class="modal-content" id="modalContent">
                 <div class="modal-header">
                     <h5 class="modal-title" id="modalLabel">Nuevo Atencion</h5>
                     <button type="button" class="btn-close" data-bs-dismiss="modal" aria-label="Close"></button>
                 </div>
                 <div class="modal-body">
                     <!-- Contenido del formulario para agregar nuevo Atencion -->
                     <form id="frmAtencion">
                         <div class="row">
                             <asp:TextBox ID="modoActual" runat="server" CssClass="form-control" ClientIDMode="Static" type="hidden" />
                             <asp:TextBox ID="txtCodAtencion" runat="server" CssClass="form-control" ClientIDMode="Static" type="hidden" />
                             <div class="col">
                                 <div class="form-floating mb-3">
                                     <asp:DropDownList ID="cboPaciente" runat="server" CssClass="form-control">
                                     </asp:DropDownList>
                                     <label for="cboPaciente">Paciente:</label>
                                 </div>
                                 <div class="form-floating mb-3">
                                     <asp:DropDownList ID="cboMedico" runat="server" CssClass="form-control">
                                     </asp:DropDownList>
                                     <label for="cboMedico">Medico:</label>
                                 </div>

                                 <div class="form-floating mb-3">
                                     <asp:TextBox ID="txtComentario" runat="server" CssClass="form-control"
                                         placeholder="Ingrese nombre del Atencion" TextMode="MultiLine" />
                                     <label for="txtComentario">Comentario: </label>
                                 </div>

                                 <div class="form-floating mb-3">
                                     <asp:DropDownList ID="cboSucursal" runat="server" CssClass="form-control">
                                     </asp:DropDownList>
                                     <label for="cboSucursal">Sucursal:</label>
                                 </div>


                                 <div class="form-floating mb-3">
                                     <asp:TextBox ID="txtSala" runat="server" CssClass="form-control"
                                         placeholder="Ingrese el peso del Atencion" TextMode="Number" />
                                     <label for="txtSala">Sala:</label>
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
                     <asp:LinkButton type="button" class="btn btn-success" OnClick="btnGuardarAtencion_Click"
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
             titulo.textContent = 'Editar Atencion';
         }
         // Función para mostrar el modal Atencion
         function mostrarModalAtencion() {
             var modal = new bootstrap.Modal(document.getElementById('modalAtencion'));
             modal.show();
         }

     </script>
     <!-- Modal para Atencion -->


     <h2 class="text-center mb-4">Listado de Atencion</h2>
     <p class="text-end">
         <asp:HyperLink ID="HyperLink" runat="server" NavigateUrl="~/Home.aspx" CssClass="btn btn-outline-secondary">
             Retornar al Registro</asp:HyperLink>
     </p>



     <div class="text-end mb-3 mt-3">
         <asp:LinkButton ID="btnNuevo" runat="server" CssClass="btn btn-success" OnClick="btnNuevoAtencion_Click">
             Nueva Atencion</asp:LinkButton>
     </div>
     <asp:GridView ID="gvAtencion" runat="server" AutoGenerateColumns="False"
         CssClass="table table-bordered table-hover table-responsive" GridLines="None" AllowPaging="True" EnableViewState="true"
         OnPageIndexChanging="gvAtencion_PageIndexChanging">

         <Columns>
             <asp:BoundField DataField="cod_ate" HeaderText="Código" />
             <asp:TemplateField HeaderText="Medico">
                 <ItemTemplate>
                     <%# ObtenerNombreMedico(Eval("cod_med")) %>
                 </ItemTemplate>
             </asp:TemplateField>
             <asp:TemplateField HeaderText="Paciente">
                 <ItemTemplate>
                     <%# ObtenerNombrePaciente(Eval("cod_pac")) %>
                 </ItemTemplate>
             </asp:TemplateField>
             <asp:TemplateField HeaderText="Sucursal">
                 <ItemTemplate>
                     <%# ObtenerNombreSucursal(Eval("cod_suc")) %>
                 </ItemTemplate>
             </asp:TemplateField>

             <asp:BoundField DataField="num_sala" HeaderText="Sala" />
           

             <asp:TemplateField HeaderText="Acciones">
                 <ItemTemplate>
                     <asp:LinkButton ID="btnEditar" runat="server" CssClass="btn btn-warning"
                         OnClick="btnEditarAtencion_Click"
                         data-cod-ate='<%# Eval("cod_ate") %>'>
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
