<%@ Page Title="" Language="C#" MasterPageFile="~/master.Master" AutoEventWireup="true" CodeBehind="ElementosDeLaCompra.aspx.cs" Inherits="WebApplication1.ElementosDeLaCompra" %>
    



<asp:Content ID="head" runat="server" ContentPlaceHolderID="ContentPlaceHolder1">

         <style>
    .table td, .table th {
        border: 2px solid #007bff; 
        border: 1px solid #ff6a00; 
        font-weight: bold;
        }

    .bottom-center {
        position: absolute;
        bottom: 20px;
        width: 100%;
        text-align: center;
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
    

     <asp:Button ID="ButtonVolverACompras" runat="server" Text="VOLVER" class= "btn btn-dark" OnClick="ButtonVolverACompras_Click" />


                    <asp:GridView ID="GridViewDetalleCompraElementos" runat="server" AutoGenerateColumns="False" DataKeyNames ="idDelProducto"  CssClass="table table-bordered table-striped table-hover">
                <Columns>
<%--        <asp:BoundField DataField="codigo" HeaderText="Codigo de venta" ReadOnly ="true" />--%>
        
         <asp:BoundField DataField="nombreDeProducto" HeaderText="Nombre del producto" />
        <asp:BoundField DataField="cantidadDeProductos" HeaderText="Cantidad de productos" />             
        <asp:BoundField DataField="precio" HeaderText="Precio por unidad (en pesos)" />
        <asp:BoundField DataField="totalPorProducto" HeaderText="Total por producto (en pesos)" />




                </Columns>
                   </asp:GridView>  

        <asp:Label runat="server" ID="labelDetalleCompra"  BackColor="Orange"></asp:Label>

   

        <section>

        
        <asp:Button ID="ButtonRealizado" runat="server" Text="PASAR A REALIZADA" class= "btn btn-outline-success" OnClick="ButtonRealizado_Click" />
    <asp:Label ID="Labelentrega" runat="server" ></asp:Label>
    <br />

    </section>
  
    

    <section>




    <asp:Button ID="ButtonPendiente" runat="server" Text="PASAR A PENDIENTE" class="btn btn-outline-warning" OnClick="ButtonPendiente_Click" />
    <asp:Label ID="LabelAnularEntrega" runat="server" ></asp:Label>
    <br />

    </section>
  
 <aside class="bottom-center">
    <asp:Button ID="ButtonEliminarCompra" runat="server" Text="ELIMINAR COMPRA" class="btn btn-danger" OnClick= "ButtonEliminarCompra_Click" />
    <asp:Label ID="LabelEliminarVenta" runat="server"></asp:Label>
    <br />
</aside>













</asp:Content>
