  <%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="WebApplication1.Login" MasterPageFile="~/master.Master" %>


 <asp:Content ID="head" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

<!DOCTYPE html>




    
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


</asp:Content>