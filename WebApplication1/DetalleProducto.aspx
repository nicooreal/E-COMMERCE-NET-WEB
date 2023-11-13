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

    <div class="row">
        <div class="col-6">


   <div class="mb-3">


<label for="exampleFormControlTextarea1" class="form-label">ID:</label>
<asp:TextBox ID="txtId" class="form-control custom-textbox" runat="server" ReadOnly ="true" />
<br />
            </div>

 <div class="mb-3">
<label for="txtNombre">Nombre:</label>
<asp:TextBox ID="txtNombre" class="form-control custom-textbox" runat="server"/>
<br />
 </div>

   <div class="mb-3">
<label for="txtPrecioCompra">Precio de Compra:</label>
<asp:TextBox ID="txtPrecioCompra" class="form-control custom-textbox" runat="server" />
<br />
  </div>

<label for="txtPrecioVenta">Precio de Venta:</label>
<asp:TextBox ID="txtPrecioVenta" class="form-control custom-textbox" runat="server" />
<br />

<label for="txtIdMarca">ID de Marca:</label>
<asp:TextBox ID="txtIdMarca" runat="server" class="form-control custom-textbox" />
<br />

<label for="txtIdCategoria">ID de Categoría:</label>
<asp:TextBox ID="txtIdCategoria" runat="server" class="form-control custom-textbox" />
<br />

<label for="txtStockActual">Stock Actual:</label>
<asp:TextBox ID="txtStockActual" runat="server" class="form-control custom-textbox" />
<br />

<label for="txtStockMinimo">Stock Mínimo:</label>
<asp:TextBox ID="txtStockMinimo" runat="server" class="form-control custom-textbox" />
<br />

<label for="txtDescripcion">Descripción:</label>
<asp:TextBox ID="txtDescripcion" runat="server"  class="form-control custom-textbox"/>
<br />

<label for="txtIdProveedor">ID de Proveedor:</label>
<asp:TextBox ID="txtIdProveedor" runat="server" class="form-control custom-textbox espacio" />



 
    </div>
        </div>
   
    
 

   
 <div class="btn-group mb-3" role="group" aria-label="Basic mixed styles example">
  
<asp:Button ID="ButtonBajaLogica"  class="btn btn-danger" runat="server" Text="ELIMINAR" OnClick="ButtonBajaLogica_Click" />
<asp:Button ID="ButtonEditar" runat="server" Text="EDITAR" class="btn btn-success"  OnClick="ButtonEditar_Click" />   




</div>
   

   


<div class="form-check">
<asp:CheckBox ID="CheckBoxBaja" class="form-check-input"  runat="server" />
<asp:Label class="form-check-label" ID="LabelBajaProducto" runat="server" >
 ELIMINAR PRODUCTO
</asp:Label>
    </div>


    <div>

    
    </div>


</asp:Content>