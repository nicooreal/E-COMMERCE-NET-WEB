using NEGOCIO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class Venta : System.Web.UI.Page
    {
        public List<DOMINIO.Venta> listaVenta { get; set; }

        protected void Page_Load(object sender, EventArgs e)
        {

        
        VentaNegocio ventaNegocio = new VentaNegocio();
            listaVenta = ventaNegocio.listarVenta();

            GridViewVentas.DataSource = listaVenta;
            GridViewVentas.DataBind();



        }


        protected void GridViewVentas_SelectedIndexChanged(object sender, EventArgs e)
        {
            var id = GridViewVentas.SelectedDataKey.Value.ToString();
            
            Response.Redirect("DetalleVenta.aspx?id=" + id);

        }
    }
}