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

<style>
    .margen-botones {
        margin: 20px; 
   
        }

    .button-container {
        text-align: right; /* Alinea los botones al centro */
    }

    .button-container div {
        display: inline-block; /* Muestra los divs en línea */
        margin-right: 10px; /* Agrega espacio entre los botones */
    }

</style>





    <div>

        <asp:Button ID="ButtonNuevoProd"  class="btn btn-outline-info" OnClick="ButtonNuevoProd_Click" runat="server"  Text="NUEVA VENTA" />
    </div>

<div class="button-container">
    <div>
        <asp:Button ID="Buttonlistartodos" class="btn btn-secondary" runat="server" OnClick="Buttonlistartodos_Click" Text="TODAS LAS VENTAS" />
    </div>
    <div>
        <asp:Button ID="ButtonListaPendientes" class="btn btn-warning" runat="server" OnClick="ButtonListaPendientes_Click" Text="VENTAS PENDIENTES" />
    </div>
   
    <div>
        <asp:Button ID="ButtonListaEntregados" class="btn btn-success" runat="server" OnClick="ButtonListaEntregados_Click" Text="VENTAS ENTREGADAS" />
    </div>



</div>
        
    


    
    <asp:GridView ID="GridViewVentas" runat="server" AutoGenerateColumns="False" DataKeyNames ="codigo" OnSelectedIndexChanged="GridViewVentas_SelectedIndexChanged"  CssClass="table table-bordered table-striped table-hover">
                <Columns>
        <asp:BoundField DataField="codigo" HeaderText="Numero de venta" />
              <asp:BoundField DataField="cliente.nombre" HeaderText="nombre del cliente" /> 
      <%--  <asp:BoundField DataField="cliente.id" HeaderText="id cliente" />--%>
        <asp:BoundField DataField="vendedor.nombre" HeaderText="Vendedor" />
        <asp:BoundField DataField="fechaVenta" HeaderText="Fecha de venta" />
        <asp:BoundField DataField="observacion" HeaderText="observacion" />             
        <asp:BoundField DataField="cantidadDeProductos" HeaderText="Cantidad de productos" />   
        <asp:BoundField DataField="entregado"  HeaderText="Estado" ReadOnly ="true" />
       
                    
                    <asp:BoundField DataField="total" HeaderText="Total" />

<%--      <asp:BoundField DataField="Proveedor.IdProveedor" HeaderText="Proveedor" /> --%>
                    <asp:CommandField ShowSelectButton ="true" SelectText ="SELECCIONAR" />

                </Columns>
                  
            
            </asp:GridView>        
        
                












</asp:Content>