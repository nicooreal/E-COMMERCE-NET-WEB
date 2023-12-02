<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="DetalleVenta.aspx.cs" Inherits="WebApplication1.DetalleVenta" MasterPageFile="~/master.Master" %>

<asp:Content ID="head" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
   
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
    <div>

 <asp:Button ID="ButtonVolverAVentas" runat="server" Text="VOLVER" class= "btn btn-dark" OnClick="ButtonVolverAVentas_Click" />

    </div>

                <asp:GridView ID="GridViewDetalleVenta" runat="server" AutoGenerateColumns="False" DataKeyNames ="idDelProducto"  CssClass="table table-bordered table-striped table-hover">
                <Columns>
<%--        <asp:BoundField DataField="codigo" HeaderText="Codigo de venta" ReadOnly ="true" />--%>
        
         <asp:BoundField DataField="nombreDeProducto" HeaderText="Tombre del producto" />
        <asp:BoundField DataField="cantidadDeProductos" HeaderText="Cantidad de productos" />             
        <asp:BoundField DataField="precio" HeaderText="Precio por unidad" />
        <asp:BoundField DataField="totalPorProducto" HeaderText="Total por producto producto" />




                </Columns>
                   </asp:GridView>        


<div class="d-flex justify-content-center mb-3">
    <b>

    <asp:Label runat="server" ID="labelDetalleVenta"  BackColor="Orange"></asp:Label>
    </b>
</div>
   
        <%if (Session["usuario"] != null && ((DOMINIO.Usuario)Session["usuario"]).TipoUsuario == DOMINIO.TipoUsuario.ADMIN)  %>   

<%{%>
    <section>

        
        <asp:Button ID="ButtonEntregado" runat="server" Text="PASAR A ENTREGADO" class= "btn btn-outline-success" OnClick="ButtonEntregado_Click" />
    <asp:Label ID="Labelentrega" runat="server" ></asp:Label>
    <br />

    </section>
  
    

    <section>




    <asp:Button ID="ButtonAnulaEntrega" runat="server" Text="PASAR A PENDIENTE" class="btn btn-outline-warning" OnClick="ButtonAnulaEntrega_Click" />
    <asp:Label ID="LabelAnularEntrega" runat="server" ></asp:Label>
    <br />

    </section>
  
 <aside class="bottom-center">
    <asp:Button ID="ButtonEliminarVenta" runat="server" Text="ELIMINAR VENTA" class="btn btn-danger" OnClick="ButtonEliminarVenta_Click" />
    <asp:Label ID="LabelEliminarVenta" runat="server"></asp:Label>
    <br />
</aside>






   <% }%>

</asp:Content>