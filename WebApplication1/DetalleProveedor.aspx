<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="DetalleProveedor.aspx.cs" Inherits="WebApplication1.DetalleProveedor"   MasterPageFile="~/master.Master" %>



<asp:Content ID="head" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

 <div class="container text-center">
  <div class="row align-items-start">
    <div class="col">





   <div class="mb-3">
<label for="exampleFormControlTextarea1" class="form-label">ID:</label>
<asp:TextBox ID="txtId" class="form-control custom-textbox" runat="server" ReadOnly ="true" />
<br />
            </div>

 <div class="mb-3">
<label for="txtNombre">Nombre de la empresa:</label>
<asp:TextBox ID="txtNombre" class="form-control custom-textbox" runat="server"/>
<br />
 </div>


<%--<label for="txtIdMarca">ID de Marca:</label>
<asp:TextBox ID="txtIdMarca" runat="server" class="form-control custom-textbox" />
<br />--%>
     


    </div>
    <div class="col">

<label for="txtCorreo">Correo:</label>
<asp:TextBox ID="TxtCorreo" CssClass="form-control custom-textbox" runat="server" />
 <br />

<%--<label for="txtIdCategoria">ID de Categoría:</label>
<asp:TextBox ID="txtIdCategoria" runat="server" class="form-control custom-textbox" />
<br />--%>



<label for="txtFechaNacimiento">Fecha del alta:</label>
 <asp:TextBox ID="TxtFechaNacimiento" type="date" CssClass="form-control custom-textbox" runat="server" />
 <br />  




    </div>
    <div class="col">


   <div class="mb-3">
 <label for="txtDireccion">Direccion:</label>
 <asp:TextBox ID="TextBoxDireccion" CssClass="form-control custom-textbox" runat="server" />
 <br />
  </div>


 <label for="txtTelefono">Telefono:</label>
<asp:TextBox ID="TxtTelefono" CssClass="form-control custom-textbox" runat="server" />
<br />



 
   
    </div>

    
      
  </div>
  </div>

    <div class="d-flex justify-content-center">

   
 <div class="btn-group mb-3 " role="group" aria-label="Basic mixed styles example">
  
<asp:Button ID="ButtonBajaLogica"  class="btn btn-danger" runat="server" Text="ELIMINAR"  />
<asp:Button ID="ButtonEditar" runat="server" Text="GUARDAR" class="btn btn-success"  />   




</div>
    </div>
   

   


<div class="form-check">
<asp:CheckBox ID="CheckBoxBaja" class="form-check-input"  runat="server" />
<asp:Label class="form-check-label" ID="LabelBajaProducto" runat="server" >
 ELIMINAR PROVEEDOR
</asp:Label>
    </div>




    <div>

        <asp:Label ID="LabelConfirmacion" runat="server" Style=" font-weight: bold;"></asp:Label>

    </div>




    </asp:Content>