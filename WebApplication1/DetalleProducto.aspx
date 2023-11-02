<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="DetalleProducto.aspx.cs" Inherits="WebApplication1.DetalleProducto" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
<label for="txtId">ID:</label>
<asp:TextBox ID="txtId" runat="server" />
<br />

<label for="txtNombre">Nombre:</label>
<asp:TextBox ID="txtNombre" runat="server" />
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


            <asp:Button ID="ButtonEditar" runat="server" Text="editar"  OnClick="ButtonEditar_Click" />   

        </div>
    </form>
</body>
</html>
