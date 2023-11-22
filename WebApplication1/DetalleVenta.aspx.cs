﻿using DOMINIO;
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
        protected void Page_Load(object sender, EventArgs e)
        {

            int idSeleccionado = int.Parse(Request.QueryString["id"]);
          
            Session.Add("idVenta",idSeleccionado);

            DetalleVentaNegocio detVenta = new DetalleVentaNegocio();
             List<DOMINIO.DetalleVenta> listaDetalleVenta =  detVenta.listarDetalleVenta();

            List<DOMINIO.DetalleVenta> listaDetalleVentaDeID = listaDetalleVenta.Where(DetVenta => DetVenta.codigo == idSeleccionado).ToList();


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
        }

        protected void ButtonAnulaEntrega_Click(object sender, EventArgs e)
        {
            int idSeleccionado = (int)Session["idVenta"];
            VentaNegocio ventaNegocio = new VentaNegocio();
            ventaNegocio.anularEntrega(idSeleccionado);
            LabelAnularEntrega.Text = "ENTREGA ANULADA";
            LabelAnularEntrega.ForeColor = System.Drawing.Color.Red;
            Labelentrega.ForeColor = System.Drawing.Color.White;
        }
    }
}