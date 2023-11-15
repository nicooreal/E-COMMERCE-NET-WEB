<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Venta.aspx.cs" Inherits="WebApplication1.Venta" MasterPageFile="~/master.Master" %>

<asp:Content ID="head" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
  
    
   <style>
    .table td, .table th {
        border: 2px solid #007bff; 
        border: 1px solid #ff6a00; 
        font-weight: bold;
        }
</style>


    <style>

.edit-button {
  
    color: forestgreen; 
    border: none; 
    padding: 5px 10px; 
    cursor: pointer; 
}
    </style>

<style>
    .delete-button {

        color: red; 
        border: none; 
        padding: 5px 10px; 
        cursor: pointer; 
    }
</style>





    <div>

        <asp:Button ID="ButtonNuevoProd"  class="btn btn-warning" runat="server" Text="NUEVA VENTA" />
    </div>



            <asp:GridView ID="GridViewVentas" runat="server" AutoGenerateColumns="False" DataKeyNames ="codigo"  CssClass="table table-bordered table-striped table-hover">
                <Columns>
        <asp:BoundField DataField="codigo" HeaderText="Numero de venta" />
              <asp:BoundField DataField="cliente.nombre" HeaderText="nombre del cliente" /> 
        <asp:BoundField DataField="cliente.id" HeaderText="id cliente" />
        <asp:BoundField DataField="vendedor.nombre" HeaderText="Vendedor" />
        <asp:BoundField DataField="fechaVenta" HeaderText="Fecha de venta" />
        <asp:BoundField DataField="observacion" HeaderText="observacion" />             

                    <asp:BoundField DataField="total" HeaderText="Total" />

<%--      <asp:BoundField DataField="Proveedor.IdProveedor" HeaderText="Proveedor" /> --%>
                    <asp:CommandField ShowSelectButton ="true" SelectText ="SELECCIONAR" />

                </Columns>
                   </asp:GridView>        
        












</asp:Content>