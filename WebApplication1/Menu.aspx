<%@ Page Title="" Language="C#" MasterPageFile="~/master.Master" AutoEventWireup="true" CodeBehind="Menu.aspx.cs" Inherits="WebApplication1.Menu" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    

    <h1 style="justify-content:center; display:flex;">Bienvenido</h1>


    <div class="row row-cols-1 row-cols-md-3 g-4" style=" ">
        <div class="col" style="">
            <div class="card" >
                
                <div class="card-body">
                    <h5 class="card-title">Compras</h5>
                    <p class="card-text">Acceso a Compras</p>
                </div>
                <div class="botonboton" style="padding:10px">
                    <asp:Button ID="btnCompra" runat="server" Text="Abrir" cssclass="btn btn-primary" OnClick="btnCompra_Click"/>
                </div>
            </div>
        </div>
        <div class="col">
            <div class="card" >
              
                <div class="card-body">
                    <h5 class="card-title">Ventas</h5>
                    <p class="card-text">Acceso a Ventas</p>
                </div>
                 <div class="botonboton" style="">
                    <asp:Button ID="btnVentas" runat="server" Text="Abrir" cssclass="btn btn-primary" OnClick="btnVentas_Click"/>
                </div>

                    <div class="col">
    <div class="card">
        
            <h5 class="card-title">Productos</h5>
           
        </div>
        <div class="botonboton" style="padding:10px">
            <asp:Button ID="btnProductos" runat="server" Text="Abrir" cssclass="btn btn-primary" OnClick="btnProductos_Click"/>
        </div>
    </div>
</div>











                </asp:Content>