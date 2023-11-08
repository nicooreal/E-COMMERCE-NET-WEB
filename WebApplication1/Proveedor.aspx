<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Proveedor.aspx.cs" Inherits="WebApplication1.Proveedor" MasterPageFile="~/master.Master" %>

  <asp:Content ID="head" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

                    <asp:GridView ID="GridViewProveedores" runat="server" AutoGenerateColumns="False" DataKeyNames ="IdP" OnSelectedIndexChanged="GridViewProveedores_SelectedIndexChanged" >
                <Columns>
        <asp:BoundField DataField="Id" HeaderText="ID Proveedor"/>
        <asp:BoundField DataField="Nombre" HeaderText="Nombre" />
        <asp:BoundField DataField="Direccion" HeaderText="Direccion" />        
        <asp:BoundField DataField="Telefono" HeaderText="Telefono" />
        <asp:BoundField DataField="correo" HeaderText="Correo" />
       
                    
        <asp:CommandField ShowSelectButton ="true" SelectText ="Editar" />

                </Columns>
                   </asp:GridView>   
        
        
        
      
</asp:Content>
