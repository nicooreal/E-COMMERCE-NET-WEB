<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Vendedor.aspx.cs" Inherits="WebApplication1.Vendedor"  MasterPageFile="~/master.Master" %>


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


     <h2 class="my-4 p-3 text-center bg-primary text-light">VENDEDORES</h2>

    
    <asp:Button ID="ButtonNuevoVendedor" OnClick="ButtonNuevoVendedor_Click" class="btn btn-warning margen-botones" runat="server" Text="NUEVO VENDEDOR" />



               <asp:GridView ID="GridViewVendedor" runat="server" AutoGenerateColumns="False" DataKeyNames ="idVendedor" OnSelectedIndexChanged="GridViewVendedor_SelectedIndexChanged" CssClass="table table-bordered table-striped table-hover" >
           <Columns>
   <asp:BoundField DataField="idVendedor" HeaderText="ID Vendedor"/>
   <asp:BoundField DataField="nombre" HeaderText="Nombre" />
   <asp:BoundField DataField="Direccion" HeaderText="Direccion" />        
   <asp:BoundField DataField="telefono" HeaderText="Telefono" />
   <asp:BoundField DataField="correo" HeaderText="Correo" />
  <asp:BoundField DataField="fechaNacimiento" HeaderText=" Nacimiento " />
               
   <asp:CommandField ShowSelectButton ="true" SelectText ="SELECCIONAR" />

           </Columns>
              </asp:GridView>   
   
        













    </asp:Content>