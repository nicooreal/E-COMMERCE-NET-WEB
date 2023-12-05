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
                List<Producto> productosDeProveedor = listaProdutos.Where(p => p.proveedor.idProveedor == idProveedor).ToList();

                dropdonwListPoducto.DataSource = productosDeProveedor;
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



            detCompra.precio = productoSeleccionado.precioCompra;
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

        protected void GridViewNuevaCompra_SelectedIndexChanged(object sender, EventArgs e)
        {

            var idEliminar = int.Parse(GridViewNuevaCompra.SelectedDataKey.Value.ToString());



            List<DOMINIO.DetalleCompra> listaDetCompra = new List<DOMINIO.DetalleCompra>();

            if (Session["listaDetalleCompra"] != null)
            {
                listaDetCompra = (List<DOMINIO.DetalleCompra>)Session["listaDetalleCompra"];


                listaDetCompra.RemoveAll(det => det.idDelProducto == idEliminar);


                //Session["listaDetalleVenta"] = listaDetVenta;


                Session.Add("listaDetalleCompra", listaDetCompra);

                GridViewNuevaCompra.DataSource = listaDetCompra;

                GridViewNuevaCompra.DataBind();



                decimal TotalDeVenta = listaDetCompra.Sum(det => det.totalPorProducto);
                labeltotalVenta.Text = "TOTAL $" + TotalDeVenta.ToString();

                labelSumarProducto.Text = "";

            }
        }

        protected void ButtonTerminarVenta_Click(object sender, EventArgs e)
        {


                if (GridViewNuevaCompra.Rows.Count > 0)
                {




                    AccesoDatos datos = new AccesoDatos();

                    string observacion = TextObservacion.Text;
                    DateTime fechaHoy = DateTime.Now;
                    

                    int idProveedor = int.Parse(Request.QueryString["id"]);
                    datos.setParameters("@idProveedor", idProveedor);
                    datos.setParameters("@fecha", fechaHoy);
                    datos.setParameters("@observacion", (object)observacion ?? DBNull.Value);
                    datos.setParameters("@estado","PENDIENTE");
                datos.setParameters("metodoPago", "E");


                datos.setearQuery("INSERT INTO Compras (idProveedor, fecha,metodoPago ,observacion, estado) VALUES (@idProveedor, @fecha,@metodoPago ,@observacion, @estado)");

                    datos.ejecutarLectura();
                    datos.cerrarConexion();


                    CompraNegocio compraNegocio = new CompraNegocio();




                    List<DOMINIO.DetalleCompra> detalleCompraSession = new List<DOMINIO.DetalleCompra>();

                    detalleCompraSession = (List<DOMINIO.DetalleCompra>)Session["listaDetalleCompra"];

                    DOMINIO.DetalleCompra detCompra = new DOMINIO.DetalleCompra();

                    List<DOMINIO.Compra> listCompra = new List<DOMINIO.Compra>();
                    listCompra = compraNegocio.listarCompraSimple();

                    int cantidadCompras = listCompra.Count;

                    int i = 0;



                    DetalleCompraNegocio detCompraNegocio = new DetalleCompraNegocio();


                    try
                    {

                        while (i < detalleCompraSession.Count)
                        {
                        detCompra.idDelProducto = detalleCompraSession[i].idDelProducto;
                        detCompra.cantidadDeProductos = detalleCompraSession[i].cantidadDeProductos;
                        detCompra.precio = detalleCompraSession[i].precio;
                        detCompra.codigo = cantidadCompras;

                            //datos.setParameters("@cantidadDeProductos", detVent.cantidadDeProductos);
                            //datos.setParameters("@precio", detVent.precio);
                            //datos.setParameters("@idProducto", detVent.idDelProducto);
                            //datos.setParameters("@idVenta", detVent.codigo);


                            //datos.setearQuery("INSERT INTO Detalles_Venta (idVenta, idProducto, cantidad, precio) VALUES (@idVenta, @idProducto, @cantidadDeProductos, @precio)");



                            //datos.ejecutarLectura();
                            //datos.cerrarConexion();
                            detCompraNegocio.agregarConSP(detCompra);


                            i++;


                        }



                    }
                    catch (Exception)
                    {

                        throw;
                    }
                    finally
                    {




                    }

                    i = 0;








                    detalleCompraSession.Clear();

                 GridViewNuevaCompra.DataSource = detalleCompraSession;
              

                
                 GridViewNuevaCompra.DataBind(); 



                    LabelpedidoTerminado.Text = "COMPRA EN PENDIENTES";
                    Session.Add("listaDetalleCompra", detalleCompraSession);

                }
                else
                {
                    labeltotalVenta.Text = "EL PEDIDO ESTA VACIO";
                }

                labelSumarProducto.Text = "";
            }





      

        protected void dropdonwListPoducto_SelectedIndexChanged1(object sender, EventArgs e)
        {
            int codigoProductoSeleccionado = int.Parse(dropdonwListPoducto.SelectedValue);

            ProductoNegocio prodNegoci = new ProductoNegocio();
            List<DOMINIO.Producto> listaProdutos = prodNegoci.listar();

            DOMINIO.Producto productoSeleccionado = listaProdutos.FirstOrDefault(p => p.id == codigoProductoSeleccionado);


            if (productoSeleccionado != null)
            {
                lblPrecio.Text = "PRECIO DE COMPRA POR UNIDAD $" + productoSeleccionado.precioCompra.ToString();
                LabelStock.Text = " STOCK ACTUAL " + productoSeleccionado.stockActual.ToString() + " UNIDADES";

            }
            else
            {
                lblPrecio.Text = "Precio no disponible";
            }


        }
    }
    }
