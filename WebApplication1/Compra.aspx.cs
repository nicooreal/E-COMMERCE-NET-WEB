using NEGOCIO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class Compra : System.Web.UI.Page
    {

   
        protected void Page_Load(object sender, EventArgs e)
        {
            CompraNegocio compraNegocio = new CompraNegocio();
            //listaVenta = ventaNegocio.listarVenta();

            List<DOMINIO.Compra> listaCompraNOeliminada = compraNegocio.listar().Where(p => p.entregado != "ELIMINADO").ToList();


            GridViewCompras.DataSource = listaCompraNOeliminada;
            GridViewCompras.DataBind();







        }

        protected void ButtonNuevaComprass_Click(object sender, EventArgs e)
        {
            Response.Redirect("DetalleCompra.aspx");
        }

        protected void GridViewCompras_SelectedIndexChanged(object sender, EventArgs e)
        {
            var id = GridViewCompras.SelectedDataKey.Value.ToString();

            Response.Redirect("ElementosDeLaCompra.aspx?id=" + id);
        }

        protected void Buttonlistartodos_Click(object sender, EventArgs e)
        {


            CompraNegocio compraNegocio = new CompraNegocio();
            //listaVenta = ventaNegocio.listarVenta();

            List<DOMINIO.Compra> listaCompraNOeliminada = compraNegocio.listar().Where(p => p.entregado != "ELIMINADO").ToList();


            GridViewCompras.DataSource = listaCompraNOeliminada;
            GridViewCompras.DataBind();




        }

        protected void ButtonListaRealizadas_Click(object sender, EventArgs e)
        {

            CompraNegocio CompraNegocio = new CompraNegocio();


            List<DOMINIO.Compra> listaCompraNOeliminada = CompraNegocio.listar().Where(p => p.entregado == "REALIZADA").ToList();


            GridViewCompras.DataSource = listaCompraNOeliminada;
            GridViewCompras.DataBind();



        }

        protected void ButtonListaPendientes_Click(object sender, EventArgs e)
        {
            CompraNegocio CompraNegocio = new CompraNegocio();


            List<DOMINIO.Compra> listaCompraNOeliminada = CompraNegocio.listar().Where(p => p.entregado == "PENDIENTE").ToList();


            GridViewCompras.DataSource = listaCompraNOeliminada;
            GridViewCompras.DataBind();

        }
    }
}