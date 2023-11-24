<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Cliente.aspx.cs" Inherits="WebApplication1.Clientes"  MasterPageFile="~/master.Master" %>



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








             <h2 class="my-4 p-3 text-center bg-primary text-light">CLIENTES</h2>


            <%if (Session["usuario"] != null && ((DOMINIO.Usuario)Session["usuario"]).TipoUsuario == DOMINIO.TipoUsuario.ADMIN)  %>   <%{ %> 


        <asp:Button ID="ButtonNuevoProd" OnClick="ButtonNuevoProd_Click" class="btn btn-warning margen-botones" runat="server" Text="NUEVO CLIENTE" />


                                                                                                                                    <%  }%>




            <asp:GridView ID="GridViewClientes" runat="server" AutoGenerateColumns="False" DataKeyNames ="Id" OnSelectedIndexChanged="GridViewClientes_SelectedIndexChanged" CssClass="table table-bordered table-striped table-hover">
                <Columns>
          <asp:BoundField DataField="Id" HeaderText="Numero de cliente" ReadOnly ="true" />
         <asp:BoundField DataField="Nombre" HeaderText="Nombre" />
          <asp:BoundField DataField="Direccion" HeaderText="Direccion" /> 
          <asp:BoundField DataField="FechaNacimiento" HeaderText="Fecha de nacimiento" />             
          <asp:BoundField DataField="Correo" HeaderText="Correo" />              
         <asp:BoundField DataField="Telefono" HeaderText="Telefono" /> 
                    <asp:CommandField ShowSelectButton ="true" SelectText ="SELECCIONAR" />

                </Columns>
                   </asp:GridView> 


</asp:Content>


