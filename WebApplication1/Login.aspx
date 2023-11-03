  <%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="WebApplication1.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <asp:Label ID="lblUsuario" runat="server" Text="Usuario"></asp:Label>
        <asp:TextBox ID="TxtUsuario" runat="server" Height="16px" style="margin-left: 21px; margin-bottom: 0px" Width="71px"></asp:TextBox>
        <div>



            <asp:Label ID="lblContraseña" runat="server" Text="Contraseña"></asp:Label>
            <asp:TextBox ID="TxtPass" runat="server" Height="16px" Width="71px"></asp:TextBox>

        </div>
        <p>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;



<asp:Button ID="btnLoginUsuario" runat="server" CssClass="btn btn-primary" Text="Acceder" OnClick="btnLoginUsuario_Click" style="background-color:aqua;border-color:black;color:black;" Height="40px" Width="128px"/>

        </p>
    </form>
</body>
</html>
