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
    public partial class DetalleVenta : System.Web.UI.Page
    {

        public List<DOMINIO.DetalleVenta> listaDetalleVentaDeID;

        protected void Page_Load(object sender, EventArgs e)
        {

            int idSeleccionado = int.Parse(Request.QueryString["id"]);
          
            Session.Add("idVenta",idSeleccionado);

           VentaNegocio vnngocio = new VentaNegocio();

            List<DOMINIO.Venta> listaVentasEstado = vnngocio.listarVenta();

            DOMINIO.Venta ventaEStado = listaVentasEstado.Find(venti => venti.codigo == idSeleccionado);

            if (ventaEStado.entregado == "PENDIENTE")
            {
                ButtonAnulaEntrega.Visible = false;
                    
            }

            if (ventaEStado.entregado == "ENTREGADO")
            {
 ButtonEntregado.Visible = false;

            }



            DetalleVentaNegocio detVenta = new DetalleVentaNegocio();
             List<DOMINIO.DetalleVenta> listaDetalleVenta =  detVenta.listarDetalleVenta();

             listaDetalleVentaDeID = listaDetalleVenta.Where(DetVenta => DetVenta.codigo == idSeleccionado).ToList();


            decimal TotalDeVenta = listaDetalleVentaDeID.Sum(det => det.totalPorProducto);

            labelDetalleVenta.Text = ("TOTAL $" + TotalDeVenta ).ToString();

            GridViewDetalleVenta.DataSource = listaDetalleVentaDeID;
            GridViewDetalleVenta.DataBind();
        
        
        }

        protected void ButtonEntregado_Click(object sender, EventArgs e)
        {

           int idSeleccionado =  (int)Session["idVenta"];
  


            VentaNegocio ventaNegocio = new VentaNegocio();
            ventaNegocio.pasarAEntregado(idSeleccionado);
             Labelentrega.Text = "PEDIDO ENTREGADO";
             Labelentrega.ForeColor = System.Drawing.Color.Green;
        LabelAnularEntrega.ForeColor = System.Drawing.Color.White;
         LabelEliminarVenta.ForeColor = System.Drawing.Color.White;

        }

        protected void ButtonAnulaEntrega_Click(object sender, EventArgs e)
        {
            int idSeleccionado = (int)Session["idVenta"];
            VentaNegocio ventaNegocio = new VentaNegocio();
            ventaNegocio.anularEntrega(idSeleccionado);
            LabelAnularEntrega.Text = "PEDIDO PENDIENTE";
            LabelAnularEntrega.ForeColor = System.Drawing.Color.DarkOrange;
            Labelentrega.ForeColor = System.Drawing.Color.White;
            LabelEliminarVenta.ForeColor = System.Drawing.Color.White;

        }

        protected void ButtonEliminarVenta_Click(object sender, EventArgs e)
        {
            DetalleVentaNegocio detVentNegocio = new DetalleVentaNegocio();

            int idSeleccionado = (int)Session["idVenta"];
            VentaNegocio ventaNegocio = new VentaNegocio();
            ventaNegocio.eliminarVenta(idSeleccionado);
            LabelEliminarVenta.Text = "VENTA ELIMINADA";
            LabelEliminarVenta.ForeColor = System.Drawing.Color.Red;
            Labelentrega.ForeColor = System.Drawing.Color.White;
            LabelAnularEntrega.ForeColor = System.Drawing.Color.White;


            ButtonAnulaEntrega.Visible = false;
            ButtonEntregado.Visible = false;

           
            
            int i = 0;
            
            
            
            while ( listaDetalleVentaDeID.Count > i)
            {

            detVentNegocio.sumarStockConSP(listaDetalleVentaDeID[i]);

                i++;
            }
           

        
        
        
        }

        protected void ButtonVolverAVentas_Click(object sender, EventArgs e)
        {
            Response.Redirect("Venta.aspx");
        }
    }
}