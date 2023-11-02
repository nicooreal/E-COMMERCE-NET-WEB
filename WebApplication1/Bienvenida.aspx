<%@ Page Title="" Language="C#" MasterPageFile="~/master.Master" AutoEventWireup="true" CodeBehind="Bienvenida.aspx.cs" Inherits="WebApplication1.Bienvenida" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

<div style="display:flex; flex-direction: column; align-items: center; justify-content: center; height: 100vh;"">
         <div>
             <p style="margin-left: 40px">
            &nbsp;<img src="miComercio.png" style="background-color:blueviolet; border-radius:50%;width:276px; height: 248px;"/>
             </p>
        </div>
    <div style="padding:20px">
    
        <h1>Bienvenido a mi Comercio</h1>
        
    </div>

    <div>
         <%if (Session["usuario"] == null)
             { %>
        <asp:Button ID="btnPaginaLogin" runat="server" CssClass="btn btn-primary" Text="Acceder" OnClick="btnPaginaLogin_Click" style="background-color:blueviolet;border-color:black;color:black;"/>
        <%} %>
    </div>
</div>
    


</asp:Content>
