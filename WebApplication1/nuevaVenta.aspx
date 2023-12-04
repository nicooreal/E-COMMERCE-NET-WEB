<%@ Page Title="" Language="C#" MasterPageFile="~/master.Master" AutoEventWireup="true" CodeBehind="nuevaVenta.aspx.cs" Inherits="WebApplication1.nuevaVenta" %>
<%--<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>



    <asp:Content ID="head" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">--%>

        <asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">




           <div>
<label for="txtPrecioCompra">Cliente:</label>
<asp:TextBox ID="txtClient"  class="form-control custom-textbox" ReadOnly="true" runat="server" />
<br />
  </div>


               <div>
<label for="txtVendedor">Vendedor:</label>
<asp:DropDownList ID="DropDownListVendedor"  class="form-control custom-textbox" runat="server"   />

<br />
   </div>


   <div>
<label for="txtProducto">Producto:</label>
<asp:DropDownList ID="dropdonwListPoducto"  class="form-control custom-textbox" runat="server" OnSelectedIndexChanged="dropdonwListPoducto_SelectedIndexChanged" autopostback="true"  />
       <asp:Label ID="lblPrecio" runat="server"></asp:Label>
<br />
  <asp:Label ID="LabelStock" runat="server"></asp:Label>
   <br />    
   </div>
   
        <div>
<label for="txtProducto">Cantidad</label>
<asp:TextBox ID="TextBoxCantidadProducto"  class="form-control custom-textbox" type="number" runat="server" />
<br />
   
   
   </div>

            <div>
        <asp:Button ID="ButtonSumarProducto" runat="server" Text="AGREGAR"  class="btn btn-primary" OnClick="ButtonSumarProducto_Click"/>
                <asp:Label runat="server" ID="labelSumarProducto"   BackColor="#ff6666"></asp:Label>
            </div>



                    <asp:GridView ID="GridViewNuevaVenta" runat="server" AutoGenerateColumns="False" DataKeyNames ="idDelProducto" OnSelectedIndexChanged="GridViewNuevaVenta_SelectedIndexChanged" CssClass="table table-bordered table-striped table-hover">
                <Columns>
        <asp:BoundField DataField="idDelProducto" HeaderText="Codigo de producto" />
        <asp:BoundField DataField="nombreDeProducto" HeaderText="Nombre" ReadOnly ="true" />
        <asp:BoundField DataField="cantidadDeProductos" HeaderText="Cantidad" />
        <asp:BoundField DataField="precio" HeaderText="Precio" />
        <asp:BoundField DataField="totalPorProducto" HeaderText="Total de producto" />  
                    
                    <asp:CommandField ShowSelectButton ="true" SelectText ="ELIMINAR" />

                   

 

                </Columns>
                   </asp:GridView>        



<div class="d-flex justify-content-center mb-3">
    <b>
            <asp:Label runat="server" ID="labeltotalVenta"   BackColor="Orange"></asp:Label>

    </b>
</div>

           <div >
<label for="exampleFormControlTextarea1" class="form-label">observacion:</label>
<asp:TextBox ID="TextObservacion" class="form-control custom-textbox"  runat="server"  />
<br />
            </div>

            <asp:Button ID="ButtonTerminarVenta" runat="server" Text="ENVIAR" class="btn btn-outline-success" OnClick="ButtonTerminarVenta_Click" />




            <asp:Label ID="LabelpedidoTerminado" runat="server" ></asp:Label>
           <br />
</asp:Content>
