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
            if (Session["usuario"] == null)
            {
                Session.Add("error", "Debes Loguearte Para Ingresar");
                Response.Redirect("ErrorLogin.aspx", false);
            }

        }


        protected void btnVentas_Click(object sender, EventArgs e)
        {


            Session.Add("listaDetalleVenta", null);
            Response.Redirect("Venta.aspx");
        }

        protected void btnCompra_Click(object sender, EventArgs e)
        {
            Session.Add("listaDetalleCompra", null);
            Response.Redirect("Compra.aspx");
        
        }

        protected void btnProductos_Click(object sender, EventArgs e)
        {
            Response.Redirect("Productos.aspx");
        }

        protected void btnProveedores_Click(object sender, EventArgs e)
        {
            Response.Redirect("Proveedor.aspx");
        }

        protected void btnClientes_Click(object sender, EventArgs e)
        {
            Response.Redirect("Cliente.aspx");
        }

        protected void btnMarcas_Click(object sender, EventArgs e)
        {
            Response.Redirect("Marca.aspx");
        }

        protected void vendedores_Click(object sender, ImageClickEventArgs e)
        {
            Response.Redirect("Vendedor.aspx");
        }

        protected void ButtonSalir_Click(object sender, EventArgs e)
        {
            if (Session["usuario"] != null)
            {
                Session.RemoveAll();
            }
            Response.Redirect("Login.aspx", false);
        }
    }
}