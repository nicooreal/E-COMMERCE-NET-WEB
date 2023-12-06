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

            List<DOMINIO.Compra> listaCompraNOeliminada = compraNegocio.listar().Where(p => p.entregado != "TERMINADA").ToList();


            GridViewCompras.DataSource = listaCompraNOeliminada;
            GridViewCompras.DataBind();







        }

        protected void ButtonNuevaComprass_Click(object sender, EventArgs e)
        {
            Response.Redirect("DetalleCompra.aspx");
        }
    }
}