<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Proveedor.aspx.cs" Inherits="WebApplication1.Proveedor" MasterPageFile="~/master.Master" %>

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
</style>



      <h2 class="my-4 p-3 text-center bg-primary text-light">PROVEEDORES</h2>





                    <asp:GridView ID="GridViewProveedores" runat="server" AutoGenerateColumns="False" DataKeyNames ="idProveedor" OnSelectedIndexChanged="GridViewProveedores_SelectedIndexChanged" CssClass="table table-bordered table-striped table-hover" >
                <Columns>
        <asp:BoundField DataField="idProveedor" HeaderText="ID Proveedor"/>
        <asp:BoundField DataField="nombreEmpresa" HeaderText="Nombre" />
        <asp:BoundField DataField="Direccion" HeaderText="Direccion" />        
        <asp:BoundField DataField="telefono" HeaderText="Telefono" />
        <asp:BoundField DataField="correo" HeaderText="Correo" />
       <asp:BoundField DataField="fechaNacimiento" HeaderText=" Fecha de Alta " />
                    
        <asp:CommandField ShowSelectButton ="true" SelectText ="SELECCIONAR" />

                </Columns>
                   </asp:GridView>   
        
        
        
      
</asp:Content>
