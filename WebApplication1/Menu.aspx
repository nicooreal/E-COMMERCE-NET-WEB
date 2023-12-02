<%@ Page Title="" Language="C#" MasterPageFile="~/master.Master" AutoEventWireup="true" CodeBehind="Menu.aspx.cs" Inherits="WebApplication1.Menu" %>


<asp:Content ID="head" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    
    <div style="display: flex; padding:20px; justify-content:end">


        <div style="margin:5px;">
            <asp:Button ID="ButtonSalir" OnClick="ButtonSalir_Click" runat="server"  class="btn btn-link"  Text="SALIR DE SESION" />
        </div>
        
    </div>


    <h1 style="justify-content:center; display:flex;">Bienvenido</h1>

<style>
    .custom-container {
        max-width: 950px; 
        margin: auto; 
    }
</style>



    <div class="container custom-container">

       
    <div class="row row-cols-1 row-cols-md-4 g-4" style=" ">
        
         
        
        <%if (Session["usuario"] != null && ((DOMINIO.Usuario)Session["usuario"]).TipoUsuario == DOMINIO.TipoUsuario.ADMIN)  %>   

<%{%>


            <div class="col">
            <div class="card">
    <asp:ImageButton ID="ImageButton5" runat="server" class="card-img-top" OnClick="btnCompra_Click"  ImageUrl="https://res.cloudinary.com/dte7upwcr/image/upload/blog/blog2/carrito-de-compras-ecommerce/carrito-de-compras-ecommerce-img_header.jpg" /> 
                            <div class="card-body">
                    <h5 class="card-title">Compras</h5>
                    <p class="card-text">Acceder a la admninistracion de compras, compras de productos a proveedores</p>
                                </div>
                
            </div>
                                </div>



            <div class="col">
            <div class="card">
    <asp:ImageButton ID="ImageButton6" runat="server" class="card-img-top" OnClick="btnProveedores_Click"  ImageUrl="https://www.eleconomista.com.mx/__export/1660698765144/sites/eleconomista/img/2022/08/16/consejos_buena_relacixn_cliente_proveedor_0.jpg_393767599.jpg" /> 
                            <div class="card-body">
                    <h5 class="card-title">Proveedores</h5>
                    <p class="card-text">Informacion sobre nuestros proveedores</p>
                                </div>
                
            </div>
                                </div>




                    <div class="col">
            <div class="card">
    <asp:ImageButton ID="vendedores" runat="server" class="card-img-top" OnClick="vendedores_Click" ImageUrl="https://img.freepik.com/vector-premium/concepto-ventas-adicionales-pequenos-vendedores-compradores-personajes-huge-pc-upselling-online-marketing-tecnica-venta-mas-rentable-promocion-compradores-obsequios-bonificaciones-ilustracion-vector-gente-dibujos-animados_87771-11845.jpg?w=740" />
                   <div class="card-body">
                <h5 class="card-title">Vendedores</h5>

                    <p class="card-text">Acceso a nuestros vendedores</p>    
                  
            
                            </div>
                </div>
                </div>























   <% } %>








            <div class="col">
            <div class="card">
    <asp:ImageButton ID="ImageButton3" runat="server" class="card-img-top" OnClick="btnVentas_Click"  ImageUrl="https://miro.medium.com/v2/resize:fit:720/1*kD63_v2-qaX8yzaXt1Zbbw.jpeg" /> 
                            <div class="card-body">
                    <h5 class="card-title">Ventas</h5>

                    <p class="card-text">Acceder a la administracion de ventas, ventas a clientes</p>
                                </div>
                
            </div>
                                </div>











            <div class="col">
            <div class="card">
                
    <asp:ImageButton ID="ImageButton4" runat="server" class="card-img-top" OnClick="btnMarcas_Click"  ImageUrl="https://franciscotorreblanca.es/wp-content/uploads/2019/11/simbolos-que-acompanan-marcas.jpg" /> 
                            <div class="card-body">
                    <h5 class="card-title">Marcas</h5>
                    <p class="card-text">Administrar las  marcas </p>
                                </div>
                
            </div>
                                </div>







            <div class="col">
            <div class="card">
    <asp:ImageButton ID="ImageButton2" runat="server" class="card-img-top" OnClick="btnClientes_Click"  ImageUrl="https://media.istockphoto.com/id/1224423353/es/vector/marketing-entrante-con-im%C3%A1n-que-atrae-a-la-gente-esbozando-ilustraciones-vectoriales.jpg?s=612x612&w=0&k=20&c=jlIVc-FWlRTJSRw2LgUVq-HKJINBwLTfSJRVhwYzWrg=" /> 
                            <div class="card-body">
                    <h5 class="card-title">Clientes</h5>
                    <p class="card-text">Informacion de los Clientes.</p>
                                </div>
                
            </div>
                                </div>



            <div class="col">
            <div class="card">
    <asp:ImageButton ID="ImageButton1" runat="server" class="card-img-top" OnClick="btnProductos_Click" ImageUrl="https://i0.wp.com/esferacreativa.com/wp-content/uploads/2017/05/fichas-tecnicas-de-productos-ecommerce-Teresa-Alba-MadridNYC.png?fit=640%2C320&ssl=1" />
                            <div class="card-body">
                    <h5 class="card-title">Productos</h5>
                                

                    <p class="card-text">Acceso a detalle de Productos .</p>    
                  
            
                            </div>
                </div>
                </div>




    </div>
    
       
    
    </div>



      

        


</asp:Content>
