using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class Menu : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
           /* if (Session["usuario"] == null)
            {
             Session.Add("error", "Debes Loguearte Para Ingresar");
             Response.Redirect("Error.aspx", false);
            }

            */

        }


        protected void btnVentas_Click(object sender, EventArgs e)
        {
            Response.Redirect("Venta.aspx");
        }

        protected void btnCompra_Click(object sender, EventArgs e)
        {
            Response.Redirect("Compra.aspx");
        }

        protected void btnProductos_Click(object sender, EventArgs e)
        {
            Response.Redirect("Productos.aspx");
        }

        protected void btnProveedores_Click(object sender, EventArgs e)
        {
            Response.Redirect("Proveedores.aspx");
        }

        protected void btnClientes_Click(object sender, EventArgs e)
        {
            Response.Redirect("Clientes.aspx");
        }

        protected void btnMarcas_Click(object sender, EventArgs e)
        {
            Response.Redirect("Marcas.aspx");
        }


    }
}