<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Marca.aspx.cs" Inherits="WebApplication1.Marca"  MasterPageFile="~/master.Master" %>



<asp:Content ID="head" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
  
       <style>
    .table td, .table th {
        border: 2px solid #007bff; 
        border: 1px solid #ff6a00; 
        font-weight: bold;
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


    <%if (Session["usuario"] != null && ((DOMINIO.Usuario)Session["usuario"]).TipoUsuario == DOMINIO.TipoUsuario.ADMIN)  %>   

<%{%>


    <asp:Button ID="ButtonNuevaMarca" OnClick="ButtonNuevaMarca_Click" class="btn btn-warning margen-botones" runat="server" Text="NUEVA MARCA" />

   <% }%>



             <h2 class="my-4 p-3 text-center bg-primary text-light">MARCAS</h2>

            <asp:GridView ID="GridViewMarca" runat="server"  AutoGenerateColumns="False"  CssClass="table table-bordered table-striped table-hover">
                <Columns>
          <asp:BoundField DataField="idMarca" HeaderText="ID marca" ReadOnly ="true" />
          <asp:BoundField DataField="nomMarca" HeaderText="Nombre" />


                </Columns>
                   </asp:GridView> 


</asp:Content>


