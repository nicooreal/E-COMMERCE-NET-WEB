<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Proveedor.aspx.cs" Inherits="WebApplication1.Proveedor" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        
                    <asp:GridView ID="GridViewProveedores" runat="server" AutoGenerateColumns="False" DataKeyNames ="IdP" OnSelectedIndexChanged="GridViewProveedores_SelectedIndexChanged" >
                <Columns>
        <asp:BoundField DataField="Id" HeaderText="ID Proveedor"/>
        <asp:BoundField DataField="Nombre" HeaderText="Nombre" />
        <asp:BoundField DataField="Direccion" HeaderText="Direccion" />        
        <asp:BoundField DataField="Telefono" HeaderText="Telefono" />
        <asp:BoundField DataField="correo" HeaderText="Correo" />
       
                    
        <asp:CommandField ShowSelectButton ="true" SelectText ="Editar" />

                </Columns>
                   </asp:GridView>   
        
        
        
        </div>
    </form>
</body>
</html>
