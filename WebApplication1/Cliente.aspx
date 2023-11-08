<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Cliente.aspx.cs" Inherits="WebApplication1.Clientes"  MasterPageFile="~/master.Master" %>



<asp:Content ID="head" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    
             <h2 class="my-4 p-3 text-center bg-primary text-light">CLIENTES</h2>

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


