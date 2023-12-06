<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="DetalleCompra.aspx.cs" Inherits="WebApplication1.DetalleCompra" MasterPageFile="~/master.Master" %>


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
</style>


        <asp:Label ID="Label1" runat="server" Text="SELECCIONE EL PROVEEDOR:"></asp:Label>
        <br />




                    <asp:GridView ID="GridViewProveedoresEnCompra" runat="server" AutoGenerateColumns="False" DataKeyNames ="idProveedor"  OnSelectedIndexChanged="GridViewProveedoresEnCompra_SelectedIndexChanged" CssClass="table table-bordered table-striped table-hover" >
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
