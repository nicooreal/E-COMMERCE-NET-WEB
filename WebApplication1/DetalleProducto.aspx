<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="DetalleProducto.aspx.cs" Inherits="WebApplication1.DetalleProducto" MasterPageFile="~/master.Master" %>


<asp:Content ID="head" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">




    <style>
    .custom-textbox {
        width: 300px; 

    }
</style>

    <style>
    .espacio {
        margin-bottom: 100px; 

    }
</style>

 



<%if (Session["usuario"] != null && ((DOMINIO.Usuario)Session["usuario"]).TipoUsuario == DOMINIO.TipoUsuario.ADMIN)  %>   

<%{%>


   
    
 <div class="container text-center">
  <div class="row align-items-start">
    <div class="col">





   <div class="mb-3">
<label for="exampleFormControlTextarea1" class="form-label">ID:</label>
<asp:TextBox ID="txtId" class="form-control custom-textbox" type="number" runat="server" ReadOnly ="true" />
<br />
            </div>

 <div class="mb-3">
<label for="txtNombre">Nombre:</label>
<asp:TextBox ID="txtNombre" class="form-control custom-textbox" runat="server"/>
<br />
 </div>

   <div class="mb-3">
<label for="txtPrecioCompra">Precio de Compra:</label>
<asp:TextBox ID="txtPrecioCompra"  class="form-control custom-textbox" runat="server" />
<br />
  </div>

<%--<label for="txtIdMarca">ID de Marca:</label>
<asp:TextBox ID="txtIdMarca" runat="server" class="form-control custom-textbox" />
<br />--%>
        <asp:DropDownList ID="dropDownListMarca"  runat="server"></asp:DropDownList>


    </div>
    <div class="col">

<label for="txtPrecioVenta">Precio de Venta:</label>
<asp:TextBox ID="txtPrecioVenta"  class="form-control custom-textbox" runat="server" />
<br />

<%--<label for="txtIdCategoria">ID de Categoría:</label>
<asp:TextBox ID="txtIdCategoria" runat="server" class="form-control custom-textbox" />
<br />--%>


<label for="txtStockActual">Stock Actual:</label>
<asp:TextBox ID="txtStockActual" runat="server" type="number" class="form-control custom-textbox" />
<br />
        <asp:DropDownList ID="dropDownListCategoria"  runat="server"></asp:DropDownList>




    </div>
    <div class="col">




<label for="txtStockMinimo">Stock Mínimo:</label>
<asp:TextBox ID="txtStockMinimo" runat="server" type="number" class="form-control custom-textbox" />
<br />

<label for="txtDescripcion">Descripción:</label>
<asp:TextBox ID="txtDescripcion" runat="server"  class="form-control custom-textbox"/>
<br />

<%--<label for="txtIdProveedor">ID de Proveedor:</label>
<asp:TextBox ID="txtIdProveedor" runat="server" class="form-control custom-textbox" />--%>


        <asp:DropDownList ID="dropDownListprov"  runat="server"></asp:DropDownList>

 
   
    </div>

    
      
  </div>
  </div>

    <div class="d-flex justify-content-center">

   
 <div class="btn-group mb-3 " role="group" aria-label="Basic mixed styles example">
  
<asp:Button ID="ButtonBajaLogica"  class="btn btn-danger" runat="server" Text="ELIMINAR" OnClick="ButtonBajaLogica_Click" />
<asp:Button ID="ButtonEditar" runat="server" Text="GUARDAR" class="btn btn-success"  OnClick="ButtonEditar_Click" />   




</div>
    </div>
   

   


<div class="form-check">
<asp:CheckBox ID="CheckBoxBaja" class="form-check-input"  runat="server" />
<asp:Label class="form-check-label" ID="LabelBajaProducto" runat="server" >
 ELIMINAR PRODUCTO
</asp:Label>
    </div>




    <div>

        <asp:Label ID="LabelConfirmacion" runat="server" Style=" font-weight: bold;"></asp:Label>

    </div>



  <% } else   { %>         <asp:Label ID="LabelDePermisos" runat="server" Text="NO TIENE ACCESO A ESTA PANTALLA"></asp:Label>                   <% }%>



</asp:Content>