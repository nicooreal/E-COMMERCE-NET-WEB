<%@ Page Title="" Language="C#" MasterPageFile="~/master.Master" AutoEventWireup="true" CodeBehind="nuevaVenta.aspx.cs" Inherits="WebApplication1.nuevaVenta" %>
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
<asp:DropDownList ID="txtPoducto"  class="form-control custom-textbox" runat="server" />
<br />
   </div>
   
        <div>
<label for="txtProducto">cantidad</label>
<asp:TextBox ID="TextBoxCantidadProducto"  class="form-control custom-textbox" type="number" runat="server" />
<br />
   
   
   </div>















</asp:Content>
