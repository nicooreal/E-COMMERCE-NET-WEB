<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Compra.aspx.cs" Inherits="WebApplication1.Compra" MasterPageFile="~/master.Master" %>




    <asp:Content ID="head" runat="server" ContentPlaceHolderID="ContentPlaceHolder1">



   
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

        <asp:Button ID="ButtonNuevaCompra" runat="server" Text="NUEVA COMPRA"  OnClick="ButtonNuevaComprass_Click"/>



    
        <asp:GridView ID="GridViewCompras" runat="server" AutoGenerateColumns="False" DataKeyNames ="id"   CssClass="table table-bordered table-striped table-hover">
                <Columns>
        <asp:BoundField DataField="id" HeaderText="Numero de Compra" />
        <asp:BoundField DataField="Proveedor.nombre" HeaderText="Nombre del proveedor" /> 
        <asp:BoundField DataField="fechaCompra" HeaderText="Fecha de compra" />
        <asp:BoundField DataField="observacion" HeaderText="observacion" />             
        <asp:BoundField DataField="cantidadDeProductos" HeaderText="Cantidad de productos" />   
        <asp:BoundField DataField="entregado"  HeaderText="Estado" ReadOnly ="true" />
       
                    
                    <asp:BoundField DataField="total" HeaderText="Total" />

<%--      <asp:BoundField DataField="Proveedor.IdProveedor" HeaderText="Proveedor" /> --%>
                    <asp:CommandField ShowSelectButton ="true" SelectText ="SELECCIONAR" />

                </Columns>
                  
            
            </asp:GridView>        
        
    
    
    
    
    
    
    
    
    
    
    
    </asp:Content>