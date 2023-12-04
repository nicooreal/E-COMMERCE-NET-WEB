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
            int idCliente = int.Parse(Request.QueryString["id"]);

            Cliente cliente = listaCliente.Find(x => x.id == idCliente);

            txtClient.Text = cliente.nombre.ToString();


            if (!IsPostBack)
            {

                VendedorNegocio vendedorNegocio = new VendedorNegocio();
                List<DOMINIO.Vendedor> listaVendedor;
                listaVendedor = vendedorNegocio.listar();

                DropDownListVendedor.DataSource = listaVendedor;
                DropDownListVendedor.DataTextField = "nombre";
                DropDownListVendedor.DataValueField = "idVendedor";
                DropDownListVendedor.DataBind();


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


            if (!string.IsNullOrEmpty(TextBoxCantidadProducto.Text))
            {
                
                if (productoSeleccionado.stockActual <  int.Parse(TextBoxCantidadProducto.Text) ) 
                {
                    labelSumarProducto.Text = "NO SE PUEDE SUMAR ESA CANTIDAD, EL MAXIMO ES " + productoSeleccionado.stockActual;
                return;
                } 
                else
                {

                detVenta.cantidadDeProductos = int.Parse(TextBoxCantidadProducto.Text);
                labelSumarProducto.Text = "";

                }
                
            }
            else
            {
                labelSumarProducto.Text = "HAY CAMPOS OBLIGATORIOS";
                return;

            }


            detVenta.idDelProducto = productoSeleccionado.id;

            decimal totalPorProducto = int.Parse(TextBoxCantidadProducto.Text) * detVenta.precio;
            detVenta.totalPorProducto = totalPorProducto;







            listaDetalleVenta.Add(detVenta);

            Session.Add("listaDetalleVenta", listaDetalleVenta);


            List<DOMINIO.DetalleVenta> listaDetalleVentaSesion = new List<DOMINIO.DetalleVenta>();

            listaDetalleVentaSesion = (List<DOMINIO.DetalleVenta>)Session["listaDetalleVenta"];

            decimal TotalDeVenta = listaDetalleVentaSesion.Sum(det => det.totalPorProducto);

            labeltotalVenta.Text = ("TOTAL $" + TotalDeVenta).ToString();


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
                LabelStock.Text = "STOCK ACTUAL" + productoSeleccionado.stockActual.ToString() + " UNIDADES";
            
            }
            else
            {
                lblPrecio.Text = "Precio no disponible";
            }




        }

        protected void GridViewNuevaVenta_SelectedIndexChanged(object sender, EventArgs e)
        {

            var idEliminar = int.Parse(GridViewNuevaVenta.SelectedDataKey.Value.ToString());



            List<DOMINIO.DetalleVenta> listaDetVenta = new List<DOMINIO.DetalleVenta>();

            if (Session["listaDetalleVenta"] != null)
            {
                listaDetVenta = (List<DOMINIO.DetalleVenta>)Session["listaDetalleVenta"];


                listaDetVenta.RemoveAll(det => det.idDelProducto == idEliminar);


                //Session["listaDetalleVenta"] = listaDetVenta;


                Session.Add("listaDetalleVenta", listaDetVenta);

                GridViewNuevaVenta.DataSource = listaDetVenta;

                GridViewNuevaVenta.DataBind();



                decimal TotalDeVenta = listaDetVenta.Sum(det => det.totalPorProducto);
                labeltotalVenta.Text = "TOTAL $" + TotalDeVenta.ToString();

            }







        }

        protected void ButtonTerminarVenta_Click(object sender, EventArgs e)
        {

            if (GridViewNuevaVenta.Rows.Count > 0)
            {




                AccesoDatos datos = new AccesoDatos();

                string observacion = TextObservacion.Text;
                DateTime fechaHoy = DateTime.Now;
                int idVendedor = int.Parse(DropDownListVendedor.SelectedValue);

                int idCliente = int.Parse(Request.QueryString["id"]);
                datos.setParameters("@idCliente", idCliente);
                datos.setParameters("@fecha", fechaHoy);
                datos.setParameters("@idVendedor", idVendedor);
                datos.setParameters("@observacion", (object)observacion ?? DBNull.Value);

                datos.setearQuery("INSERT INTO Ventas (idCliente, fecha, idVendedor, observacion) VALUES (@idCliente, @fecha, @idVendedor, @observacion)");

                datos.ejecutarLectura();
                datos.cerrarConexion();


                VentaNegocio ventNegocio = new VentaNegocio();




                List<DOMINIO.DetalleVenta> detalleVentaSession = new List<DOMINIO.DetalleVenta>();

                detalleVentaSession = (List<DOMINIO.DetalleVenta>)Session["listaDetalleVenta"];

                DOMINIO.DetalleVenta detVent = new DOMINIO.DetalleVenta();

                List<DOMINIO.Venta> listVenta = new List<DOMINIO.Venta>();
                listVenta = ventNegocio.listarVentaSimple();

                int cantidadVentas = listVenta.Count;

                int i = 0;
                while (i < detalleVentaSession.Count)
                {
                    detVent.idDelProducto = detalleVentaSession[i].idDelProducto;
                    detVent.cantidadDeProductos = detalleVentaSession[i].cantidadDeProductos;
                    detVent.precio = detalleVentaSession[i].precio;

                    datos.setParameters("@idVenta", cantidadVentas);
                    datos.setParameters("@idProducto", detVent.idDelProducto);
                    datos.setParameters("@cantidadDeProductos", detVent.cantidadDeProductos);
                    datos.setParameters("@precio", detVent.precio);


                    datos.setearQuery("INSERT INTO Detalles_Venta (idVenta, idProducto, cantidad, precio) VALUES (@idVenta, @idProducto, @cantidadDeProductos, @precio)");


                    datos.ejecutarLectura();
                    datos.cerrarConexion();

                    i++;


                }


               
                
                
                
                
                
                
                detalleVentaSession.Clear();

                GridViewNuevaVenta.DataSource = detalleVentaSession;

                GridViewNuevaVenta.DataBind(); GridViewNuevaVenta.DataSource = detalleVentaSession;



                LabelpedidoTerminado.Text = "PEDIDO EN PENDIENTES";
                Session.Add("listaDetalleVenta", detalleVentaSession);

            } else
            {
                labeltotalVenta.Text = "EL PEDIDO ESTA VACIO";
            }


        }

    }

}