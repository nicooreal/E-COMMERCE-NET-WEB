<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Marca.aspx.cs" Inherits="WebApplication1.Marca"  MasterPageFile="~/master.Master" %>



<asp:Content ID="head" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    
             <h2 class="my-4 p-3 text-center bg-primary text-light">MARCAS</h2>

            <asp:GridView ID="GridViewMarca" runat="server" OnSelectedIndexChanged="GridViewMarca_SelectedIndexChanged" AutoGenerateColumns="False" DataKeyNames ="IdMarca" CssClass="table table-bordered table-striped table-hover">
                <Columns>
          <asp:BoundField DataField="idMarca" HeaderText="ID marca" ReadOnly ="true" />
          <asp:BoundField DataField="nomMarca" HeaderText="Nombre" />
                    <asp:CommandField ShowSelectButton ="true" SelectText ="SELECCIONAR" />

                </Columns>
                   </asp:GridView> 


</asp:Content>


