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
    public partial class DetalleProducto : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {

                ProductoNegocio productoNegocio = new ProductoNegocio();
                List<Producto> lista = productoNegocio.listar();

                int idEditar = int.Parse(Request.QueryString["id"]);

                Producto produc = lista.Find(x => x.id == idEditar);

                txtNombre.Text = produc.nombre;
                txtPrecioCompra.Text = produc.precioCompra.ToString();
                txtPrecioVenta.Text = produc.precioVenta.ToString();
                txtStockActual.Text = produc.stockActual.ToString();
                txtStockMinimo.Text = produc.stockMinimo.ToString();
                txtDescripcion.Text = produc.descripcion.ToString();
                txtId.Text = produc.id.ToString();
            }







        }

        protected void ButtonEditar_Click(object sender, EventArgs e)
        {

            AccesoDatos datos = new AccesoDatos();




            if (txtId.Text != null)
            {

                int id = int.Parse(txtId.Text);
                string nombrenuevo = txtNombre.Text;

                datos.setParameters("@nombre", nombrenuevo);
                datos.setParameters("@id", id);

                datos.setearQuery("UPDATE Productos SET nombre = @nombre WHERE idProducto = @id");
                //falta para que se puedan cambiar el resto de los datos

                datos.ejecutarLectura();
                datos.cerrarConexion();
            }



        }
        
    }
    
}
