using NEGOCIO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class ElementosDeLaCompra : System.Web.UI.Page
    {

        public List<DOMINIO.DetalleCompra> listaDetalleCompraDeID;

        protected void Page_Load(object sender, EventArgs e)
        {

            int idSeleccionado = int.Parse(Request.QueryString["id"]);

            Session.Add("idCompra", idSeleccionado);

            DetalleCompraNegocio detCompra = new DetalleCompraNegocio();
            List<DOMINIO.DetalleCompra> listaDetalleCompra = detCompra.listarDetalleCompra();

            listaDetalleCompraDeID = listaDetalleCompra.Where(DetCompra => DetCompra.codigo == idSeleccionado).ToList();


            decimal TotalDeVenta = listaDetalleCompraDeID.Sum(det => det.totalPorProducto);

            labelDetalleCompra.Text = ("TOTAL $" + TotalDeVenta).ToString();

            GridViewDetalleCompraElementos.DataSource = listaDetalleCompraDeID;
            GridViewDetalleCompraElementos.DataBind();














        }

        protected void ButtonRealizado_Click(object sender, EventArgs e)
        {
            int idSeleccionado = (int)Session["idCompra"];



            CompraNegocio compraNegocio = new CompraNegocio();
            compraNegocio.pasarARealizado(idSeleccionado);
            Labelentrega.Text = "PEDIDO REALIZADO";
            Labelentrega.ForeColor = System.Drawing.Color.Green;
            LabelAnularEntrega.ForeColor = System.Drawing.Color.White;
            LabelEliminarVenta.ForeColor = System.Drawing.Color.White;
        }

        protected void ButtonPendiente_Click(object sender, EventArgs e)
        {

            int idSeleccionado = (int)Session["idCompra"];
            CompraNegocio compraNegocio = new CompraNegocio();
            compraNegocio.ponerEnPendiente(idSeleccionado);
            LabelAnularEntrega.Text = "PEDIDO PENDIENTE";
            LabelAnularEntrega.ForeColor = System.Drawing.Color.DarkOrange;
            Labelentrega.ForeColor = System.Drawing.Color.White;
            LabelEliminarVenta.ForeColor = System.Drawing.Color.White;



        }

        protected void ButtonEliminarCompra_Click(object sender, EventArgs e)
        {
            DetalleVentaNegocio detVentNegocio = new DetalleVentaNegocio();

            int idSeleccionado = (int)Session["idCompra"];
            CompraNegocio compraNegocio = new CompraNegocio();
            compraNegocio.eliminarCompra(idSeleccionado);
            LabelEliminarVenta.Text = "COMPRA ELIMINADA";
            LabelEliminarVenta.ForeColor = System.Drawing.Color.Red;
            Labelentrega.ForeColor = System.Drawing.Color.White;
            LabelAnularEntrega.ForeColor = System.Drawing.Color.White;


            ButtonPendiente.Visible = false;
            ButtonRealizado.Visible = false;














        }

        protected void ButtonVolverACompras_Click(object sender, EventArgs e)
        {

            Response.Redirect("Compra.aspx");
        
        }
    }
}