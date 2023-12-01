using DOMINIO;
using NEGOCIO;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class nuevaVenta : System.Web.UI.Page
    {

       public List<DOMINIO.Producto> listaProdutos { get; set; }


        protected void Page_Load(object sender, EventArgs e)
        {

            List<DOMINIO.Cliente> listaCliente;
            ClienteNegocio clienteNegocio = new ClienteNegocio();
            listaCliente = clienteNegocio.listar();
            int idCliente= int.Parse(Request.QueryString["id"]);
            
            Cliente cliente = listaCliente.Find(x => x.id == idCliente);

            txtClient.Text = cliente.nombre.ToString();


            if (!IsPostBack)
            {



            

            ProductoNegocio prodNegoci = new ProductoNegocio();
            listaProdutos = prodNegoci.listar();
            List<Producto> productosActivos = listaProdutos.Where(p => p.estado == 1).ToList();






            dropdonwListPoducto.DataSource = productosActivos;
            dropdonwListPoducto.DataTextField = "nombre";
            dropdonwListPoducto.DataValueField = "id";
            dropdonwListPoducto.DataBind();










            
            }


           

        }

        protected void ButtonSumarProducto_Click(object sender, EventArgs e)
        {


            List<DOMINIO.DetalleVenta> listaDetalleVenta;

            if (Session["listaDetalleVenta"] != null)
            {
                listaDetalleVenta = (List<DOMINIO.DetalleVenta>)Session["listaDetalleVenta"];
            }
            else
            {
                listaDetalleVenta = new List<DOMINIO.DetalleVenta>();
            }




 
           DOMINIO.DetalleVenta detVenta = new DOMINIO.DetalleVenta();
            
            int idDelDropdown = int.Parse(dropdonwListPoducto.Text);

            ProductoNegocio prodNegoci = new ProductoNegocio();
            listaProdutos = prodNegoci.listar();
            Producto productoSeleccionado = listaProdutos.Find(p => p.id == idDelDropdown);


            detVenta.precio = productoSeleccionado.precioVenta;
            detVenta.nombreDeProducto = productoSeleccionado.nombre;
            detVenta.cantidadDeProductos = int.Parse (TextBoxCantidadProducto.Text);
            decimal totalPorProducto = int.Parse(TextBoxCantidadProducto.Text) * detVenta.precio; 



            listaDetalleVenta.Add(detVenta);

            Session.Add("listaDetalleVenta", listaDetalleVenta);


           List<DOMINIO.DetalleVenta> listaDetalleVentaSesion = new List<DOMINIO.DetalleVenta>();
            
            listaDetalleVentaSesion =   (List<DOMINIO.DetalleVenta>)Session["listaDetalleVenta"];

                

            GridViewNuevaVenta.DataSource = listaDetalleVentaSesion;

            GridViewNuevaVenta.DataBind();




        }

        protected void dropdonwListPoducto_SelectedIndexChanged(object sender, EventArgs e)
        {

            

            int codigoProductoSeleccionado = int.Parse(dropdonwListPoducto.SelectedValue);
            
            ProductoNegocio prodNegoci = new ProductoNegocio();
            List<DOMINIO.Producto> listaProdutos = prodNegoci.listar();

            DOMINIO.Producto productoSeleccionado = listaProdutos.FirstOrDefault(p => p.id == codigoProductoSeleccionado);

        
            if (productoSeleccionado != null)
            {
                lblPrecio.Text = "PRECIO POR UNIDAD $" + productoSeleccionado.precioVenta.ToString();
            }
            else
            {
                lblPrecio.Text = "Precio no disponible";
            }
            
            
            
            
        }
    }
}