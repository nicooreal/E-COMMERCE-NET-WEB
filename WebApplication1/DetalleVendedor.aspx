<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="DetalleVendedor.aspx.cs" Inherits="WebApplication1.DetalleVendedor"  MasterPageFile="~/master.Master" %>


<asp:Content ID="head" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
   
    
    
    <style>
        .custom-textbox {
            width: 300px;
        }
        .espacio {
            margin-bottom: 100px;
        }


        .position-top-left {
            position: absolute;
            top: 0;
            left: 0;
            transform: translate(50%, 0%);
        }
     


    </style>
    
    
    
    

            
         
               
        
        <div class="container text-center">
  <div class="row align-items-center">
    <div class="col">
     
    </div>
    <div class="col">
    


                    <label for="txtID">ID:</label>
                    <asp:TextBox ID="txtID" CssClass="form-control custom-textbox" runat="server" ReadOnly ="true" />
                    <br />
                 
                <label for="txtNombre">Nombre:</label>
                    <asp:TextBox ID="txtNombre" CssClass="form-control custom-textbox" runat="server" />
                    <br />

                        <label for="txtDireccion">Direccion</label>
                    <asp:TextBox ID="TextBoxDireccion" CssClass="form-control custom-textbox" runat="server" />
                    <br />

                        <label for="txtCorreo">Correo;</label>
                    <asp:TextBox ID="TxtCorreo" CssClass="form-control custom-textbox" runat="server" />
                    <br />

                                <label for="txtFechaNacimiento">Direccion:</label>
                    <asp:TextBox ID="TxtFechaNacimiento" CssClass="form-control custom-textbox" runat="server" />
                    <br />

                                <label for="txtTelefono">Telefono:</label>
                    <asp:TextBox ID="TxtTelefono" CssClass="form-control custom-textbox" runat="server" />
                    <br />


    </div>
    <div class="col">
    
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
 ELIMINAR VENDEDOR
</asp:Label>
    </div>




    <div>

        <asp:Label ID="LabelConfirmacion" runat="server" Style=" font-weight: bold;"></asp:Label>

    </div>







</asp:Content>