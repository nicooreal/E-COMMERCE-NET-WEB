using DOMINIO;
using NEGOCIO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class ArmarCompra : System.Web.UI.Page
    {




        public List<DOMINIO.Producto> listaProdutos { get; set; }
        protected void Page_Load(object sender, EventArgs e)
        {


            if (!IsPostBack)
            {
                int idProveedor = int.Parse(Request.QueryString["id"]);

                ProductoNegocio prodNegoci = new ProductoNegocio();
                listaProdutos = prodNegoci.listar();
                List<Producto> productosActivos = listaProdutos.Where(p => p.estado == 1).ToList();


                dropdonwListPoducto.DataSource = productosActivos;
                dropdonwListPoducto.DataTextField = "nombre";
                dropdonwListPoducto.DataValueField = "id";
                dropdonwListPoducto.DataBind();

            }




        }

        protected void ButtonSumarProductoEnCompra_Click(object sender, EventArgs e)
        {
            List<DOMINIO.DetalleCompra> listaDetalleCompra;

            if (Session["listaDetalleCompra"] != null)
            {
                listaDetalleCompra = (List<DOMINIO.DetalleCompra>)Session["listaDetalleCompra"];
            }
            else
            {
                listaDetalleCompra = new List<DOMINIO.DetalleCompra>();
            }






            DOMINIO.DetalleCompra detCompra = new DOMINIO.DetalleCompra();

            int idDelDropdown = int.Parse(dropdonwListPoducto.Text);

            ProductoNegocio prodNegoci = new ProductoNegocio();  //             falta metodo de listar
            listaProdutos = prodNegoci.listar();
            Producto productoSeleccionado = listaProdutos.Find(p => p.id == idDelDropdown);



            detCompra.precio = productoSeleccionado.precioVenta;
            detCompra.nombreDeProducto = productoSeleccionado.nombre;
            detCompra.cantidadDeProductos = int.Parse(TextBoxCantidadProducto.Text);




            detCompra.idDelProducto = productoSeleccionado.id;

            decimal totalPorProducto = int.Parse(TextBoxCantidadProducto.Text) * detCompra.precio;
            detCompra.totalPorProducto = totalPorProducto;


            int i = 0;



            while (listaDetalleCompra.Count > i)
            {
                if (listaDetalleCompra[i].idDelProducto == productoSeleccionado.id)
                {
                    labelSumarProducto.Text = "YA SELECCIONO ESE PRODUCTO";
                    return;
                }




                i++;
            }



            listaDetalleCompra.Add(detCompra);

            Session.Add("listaDetalleCompra", listaDetalleCompra);


            List<DOMINIO.DetalleCompra> listaDetalleCompraSesion = new List<DOMINIO.DetalleCompra>();

            listaDetalleCompraSesion = (List<DOMINIO.DetalleCompra>)Session["listaDetalleCompra"];

            decimal TotalDeCompra = listaDetalleCompraSesion.Sum(det => det.totalPorProducto);

            labeltotalVenta.Text = ("TOTAL $" + TotalDeCompra).ToString();


            GridViewNuevaCompra.DataSource = listaDetalleCompraSesion;

            GridViewNuevaCompra.DataBind();

            

        }
    }
}