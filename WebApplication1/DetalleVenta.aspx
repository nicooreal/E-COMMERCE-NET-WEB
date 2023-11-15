﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="DetalleVenta.aspx.cs" Inherits="WebApplication1.DetalleVenta" MasterPageFile="~/master.Master" %>

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


  


                <asp:GridView ID="GridViewDetalleVenta" runat="server" AutoGenerateColumns="False" DataKeyNames ="codigo"  CssClass="table table-bordered table-striped table-hover">
                <Columns>
<%--        <asp:BoundField DataField="codigo" HeaderText="Codigo de venta" ReadOnly ="true" />--%>
        <asp:BoundField DataField="nombreDeProducto" HeaderText="Tombre del producto" />
        <asp:BoundField DataField="cantidadDeProductos" HeaderText="Cantidad de productos" />             
        <asp:BoundField DataField="precio" HeaderText="Precio por unidad" />
        <asp:BoundField DataField="totalPorProducto" HeaderText="Total por producto producto" />




                </Columns>
                   </asp:GridView>        


<div class="d-flex justify-content-center mb-3">
    <b>

    <asp:Label runat="server" ID="labelDetalleVenta"  BackColor="Orange"></asp:Label>
    </b>
</div>



</asp:Content>