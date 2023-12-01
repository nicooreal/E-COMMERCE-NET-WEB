<%@ Page Title="" Language="C#" MasterPageFile="~/master.Master" AutoEventWireup="true" CodeBehind="nuevaVentaCliente.aspx.cs" Inherits="WebApplication1.nuevaVentaCliente" %>


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







                <asp:GridView ID="GridViewClientesParaVenta" runat="server" AutoGenerateColumns="False" DataKeyNames ="Id" OnSelectedIndexChanged="GridViewClientesParaVenta_SelectedIndexChanged" CssClass="table table-bordered table-striped table-hover">
                <Columns>
          <asp:BoundField DataField="Id" HeaderText="Numero de cliente" ReadOnly ="true" />
         <asp:BoundField DataField="Nombre" HeaderText="Nombre" />
          <asp:BoundField DataField="Direccion" HeaderText="Direccion" /> 
          <asp:BoundField DataField="FechaNacimiento" HeaderText="Fecha de nacimiento" />             
          <asp:BoundField DataField="Correo" HeaderText="Correo" />              
         <asp:BoundField DataField="Telefono" HeaderText="Telefono" /> 
                    <asp:CommandField ShowSelectButton ="true" SelectText ="SELECCIONAR" />

                </Columns>
                   </asp:GridView> 












</asp:Content>

