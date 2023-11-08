<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Proveedor.aspx.cs" Inherits="WebApplication1.Proveedor" MasterPageFile="~/master.Master" %>

  <asp:Content ID="head" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

                    <asp:GridView ID="GridViewProveedores" runat="server" AutoGenerateColumns="False" DataKeyNames ="id" OnSelectedIndexChanged="GridViewProveedores_SelectedIndexChanged" CssClass="table table-bordered table-striped table-hover" >
                <Columns>
        <asp:BoundField DataField="id" HeaderText="ID Proveedor"/>
        <asp:BoundField DataField="nombreEmpresa" HeaderText="Nombre" />
        <asp:BoundField DataField="Direccion" HeaderText="Direccion" />        
        <asp:BoundField DataField="telefono" HeaderText="Telefono" />
        <asp:BoundField DataField="correo" HeaderText="Correo" />
       <asp:BoundField DataField="fechaNacimiento" HeaderText=" Fecha de Alta " />
                    
        <asp:CommandField ShowSelectButton ="true" SelectText ="SELECCIONAR" />

                </Columns>
                   </asp:GridView>   
        
        
        
      
</asp:Content>
