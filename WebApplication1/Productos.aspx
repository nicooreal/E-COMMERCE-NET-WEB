<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Productos.aspx.cs" Inherits="WebApplication1.Productos" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        
            <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataKeyNames ="Id" OnSelectedIndexChanged ="GridView1_SelectedIndexChanged">
                <Columns>
        <asp:BoundField DataField="Id" HeaderText="ID Producto"/>
        <asp:BoundField DataField="Nombre" HeaderText="Nombre" />
        <asp:BoundField DataField="PrecioCompra" HeaderText="Precio de Compra" />
        <asp:BoundField DataField="PrecioVenta" HeaderText="Precio de Venta" />
        <asp:BoundField DataField="IdMarca" HeaderText="Marca" />
        <asp:BoundField DataField="IdCategoria" HeaderText="Categoria" />
        <asp:BoundField DataField="StockActual" HeaderText="Stock Actual" />
        <asp:BoundField DataField="StockMinimo" HeaderText="Stock Mínimo" />
        <asp:BoundField DataField="Descripcion" HeaderText="Descripción" />             
        <asp:CommandField ShowSelectButton ="true" SelectText ="Editar" />

                </Columns>
                   </asp:GridView>        
        
        
        
        
        </div>
    </form>
</body>
</html>
