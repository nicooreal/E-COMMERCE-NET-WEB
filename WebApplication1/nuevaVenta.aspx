﻿<%@ Page Title="" Language="C#" MasterPageFile="~/master.Master" AutoEventWireup="true" CodeBehind="nuevaVenta.aspx.cs" Inherits="WebApplication1.nuevaVenta" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>



    <asp:Content ID="head" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">






           <div>
<label for="txtPrecioCompra">Cliente:</label>
<asp:TextBox ID="txtClient"  class="form-control custom-textbox" ReadOnly="true" runat="server" />
<br />
  </div>

           <div >
<label for="exampleFormControlTextarea1" class="form-label">observacion:</label>
<asp:TextBox ID="txtObservacion" class="form-control custom-textbox"  runat="server"  />
<br />
            </div>


   <div>
<label for="txtProducto">Producto:</label>
<asp:DropDownList ID="dropdonwListPoducto"  class="form-control custom-textbox" runat="server" OnSelectedIndexChanged="dropdonwListPoducto_SelectedIndexChanged" autopostback="true"  />
       <asp:Label ID="lblPrecio" runat="server"></asp:Label>
<br />
   </div>
   
        <div>
<label for="txtProducto">cantidad</label>
<asp:TextBox ID="TextBoxCantidadProducto"  class="form-control custom-textbox" type="number" runat="server" />
<br />
   
   
   </div>


        <asp:Button ID="ButtonSumarProducto" runat="server" Text="AGREGAR"  class="btn btn-primary" OnClick="ButtonSumarProducto_Click"/>



                    <asp:GridView ID="GridViewNuevaVenta" runat="server" AutoGenerateColumns="False" DataKeyNames ="codigo" CssClass="table table-bordered table-striped table-hover">
                <Columns>
        <asp:BoundField DataField="nombreDeProducto" HeaderText="Nombre" ReadOnly ="true" />
        <asp:BoundField DataField="cantidadDeProductos" HeaderText="Cantidad" />
        <asp:BoundField DataField="precio" HeaderText="precio" />
        <asp:BoundField DataField="totalPorProducto" HeaderText="total de producto" />  
                    
                    <%-- <asp:CommandField ShowSelectButton ="true" SelectText ="SELECCIONAR" />--%>

                   

 

                </Columns>
                   </asp:GridView>        
        











</asp:Content>
