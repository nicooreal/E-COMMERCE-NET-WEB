<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="DetalleProducto.aspx.cs" Inherits="WebApplication1.DetalleProducto" MasterPageFile="~/master.Master" %>


<asp:Content ID="head" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">


        
<label for="txtId">ID:</label>
<asp:TextBox ID="txtId" runat="server" ReadOnly ="true" />
<br />

<label for="txtNombre">Nombre:</label>
<asp:TextBox ID="txtNombre" runat="server"/>
<br />

<label for="txtPrecioCompra">Precio de Compra:</label>
<asp:TextBox ID="txtPrecioCompra" runat="server" />
<br />

<label for="txtPrecioVenta">Precio de Venta:</label>
<asp:TextBox ID="txtPrecioVenta" runat="server" />
<br />

<label for="txtIdMarca">ID de Marca:</label>
<asp:TextBox ID="txtIdMarca" runat="server" />
<br />

<label for="txtIdCategoria">ID de Categoría:</label>
<asp:TextBox ID="txtIdCategoria" runat="server" />
<br />

<label for="txtStockActual">Stock Actual:</label>
<asp:TextBox ID="txtStockActual" runat="server" />
<br />

<label for="txtStockMinimo">Stock Mínimo:</label>
<asp:TextBox ID="txtStockMinimo" runat="server" />
<br />

<label for="txtDescripcion">Descripción:</label>
<asp:TextBox ID="txtDescripcion" runat="server" />
<br />

<label for="txtIdProveedor">ID de Proveedor:</label>
<asp:TextBox ID="txtIdProveedor" runat="server" />


            <asp:Button ID="ButtonEditar" runat="server" Text="EDITAR"  OnClick="ButtonEditar_Click" />   

 
   
    <div>


    <div>


<asp:Label ID="LabelBajaProducto" runat="server" Text="ELIMINAR PRODUCTO"></asp:Label>
<asp:CheckBox ID="CheckBoxBaja" runat="server" />
    </div>

    <div>

<asp:Button ID="ButtonBajaLogica" runat="server" Text="ELIMINAR" OnClick="ButtonBajaLogica_Click" />
    
    </div>
    </div>

</asp:Content>