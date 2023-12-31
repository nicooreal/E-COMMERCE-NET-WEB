﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Productos.aspx.cs" Inherits="WebApplication1.Productos" MasterPageFile="~/master.Master" %>

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


    
         <h2 class="my-4 p-3 text-center bg-primary text-light">PRODUCTOS</h2>

        <%if (Session["usuario"] != null && ((DOMINIO.Usuario)Session["usuario"]).TipoUsuario == DOMINIO.TipoUsuario.ADMIN)  %>   <%{ %> 


    <asp:Button ID="ButtonNuevoProd" OnClick="ButtonNuevoProd_Click" class="btn btn-warning margen-botones" runat="server" Text="NUEVO PRODUCTO" />

                                                                                                                                    <%  }%>
   


            <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataKeyNames ="Id" OnSelectedIndexChanged ="GridView1_SelectedIndexChanged" CssClass="table table-bordered table-striped table-hover">
                <Columns>
        <asp:BoundField DataField="Id" HeaderText="ID Producto" ReadOnly ="true" />
        <asp:BoundField DataField="Nombre" HeaderText="Nombre" />
        <asp:BoundField DataField="PrecioCompra" HeaderText="Precio de Compra (en pesos)" />
        <asp:BoundField DataField="PrecioVenta" HeaderText="Precio de Venta (en pesos)" />
        <asp:BoundField DataField="IdMarca.nomMarca" HeaderText="Marca" />
        <asp:BoundField DataField="IdCategoria.nomCategoria" HeaderText="Categoria" />
        <asp:BoundField DataField="StockActual" HeaderText="Stock Actual" />
        <asp:BoundField DataField="StockMinimo" HeaderText="Stock Mínimo" />
        <asp:BoundField DataField="Descripcion" HeaderText="Descripción" />             
        <asp:BoundField DataField="Proveedor.nombreEmpresa" HeaderText="Proveedor" /> 
                    <asp:CommandField ShowSelectButton ="true" SelectText ="SELECCIONAR" />

                   

 

                </Columns>
                   </asp:GridView>        
        
        
  </asp:Content>
