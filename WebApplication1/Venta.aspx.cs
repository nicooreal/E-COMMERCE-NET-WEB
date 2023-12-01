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
    public partial class Venta : System.Web.UI.Page
    {
        public List<DOMINIO.Venta> listaVenta { get; set; }

        protected void Page_Load(object sender, EventArgs e)
        {

        
        VentaNegocio ventaNegocio = new VentaNegocio();
            //listaVenta = ventaNegocio.listarVenta();
            
            List<DOMINIO.Venta> listaVentaNOeliminada = ventaNegocio.listarVenta().Where(p => p.entregado != "ELIMINADO").ToList();


            GridViewVentas.DataSource = listaVentaNOeliminada;
            GridViewVentas.DataBind();



        }


        protected void GridViewVentas_SelectedIndexChanged(object sender, EventArgs e)
        {
            var id = GridViewVentas.SelectedDataKey.Value.ToString();
            
            Response.Redirect("DetalleVenta.aspx?id=" + id);

        }

        protected void ButtonListaPendientes_Click(object sender, EventArgs e)
        {


            VentaNegocio ventaNegocio = new VentaNegocio();
            

            List<DOMINIO.Venta> listaVentaNOeliminada = ventaNegocio.listarVenta().Where(p => p.entregado == "PENDIENTE").ToList();


            GridViewVentas.DataSource = listaVentaNOeliminada;
            GridViewVentas.DataBind();



        }

        protected void ButtonListaEntregados_Click(object sender, EventArgs e)
        {


            VentaNegocio ventaNegocio = new VentaNegocio();


            List<DOMINIO.Venta> listaVentaNOeliminada = ventaNegocio.listarVenta().Where(p => p.entregado == "ENTREGADO").ToList();


            GridViewVentas.DataSource = listaVentaNOeliminada;
            GridViewVentas.DataBind();


        }

        protected void Buttonlistartodos_Click(object sender, EventArgs e)
        {


            VentaNegocio ventaNegocio = new VentaNegocio();
            //listaVenta = ventaNegocio.listarVenta();

            List<DOMINIO.Venta> listaVentaNOeliminada = ventaNegocio.listarVenta().Where(p => p.entregado != "ELIMINADO").ToList();


            GridViewVentas.DataSource = listaVentaNOeliminada;
            GridViewVentas.DataBind();
        }

        protected void ButtonNuevoProd_Click(object sender, EventArgs e)
        {
            Response.Redirect("nuevaVentaCliente.aspx");
        }
    }
}