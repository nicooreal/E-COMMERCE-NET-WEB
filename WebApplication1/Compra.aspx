<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Compra.aspx.cs" Inherits="WebApplication1.Compra" MasterPageFile="~/master.Master" %>




    <asp:Content ID="head" runat="server" ContentPlaceHolderID="ContentPlaceHolder1">


    <style>
        .tituloCompras
        {
            display:flex;
            align-items:center;
            justify-items:center;
            justify-content:center;

            font-size:30px;
        }

        .contenedorBotones
        {
            display:flex;
            align-items:center;
            justify-content:center;
            justify-items:center;

        }

        .contenedorBotones-btnAgregar
        {
            padding:20px;
        }

        .contenedorBotones-btnMostrar
        {
            padding:20px;
        }

    </style>

    <div class="tituloCompras">

        <asp:Label ID="lblAviso" runat="server" Text=""></asp:Label>
        <asp:Label ID="lblComprar" runat="server" Text="Compras"></asp:Label>


    </div>

    <div class="contenedorBotones">
        <div class="contenedorBotones-btnAgregar">
            <asp:Button ID="btnAgregar" runat="server" Text="Agregar nueva compra"  CssClass="btn btn-info" OnClick="btnAgregar_Click"/>
        </div>



        </div>

















    </asp:Content>