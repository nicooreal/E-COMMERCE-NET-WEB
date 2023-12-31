﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DOMINIO;
using NEGOCIO;

namespace WebApplication1
{
    public partial class Productos : System.Web.UI.Page
    {
         public List<Producto> listaProducto { get; set; }
        
        protected void Page_Load(object sender, EventArgs e)
        {
            ProductoNegocio productoNegocio = new ProductoNegocio();
            listaProducto = productoNegocio.listar();

            List<Producto> productosActivos = listaProducto.Where(p => p.estado == 1).ToList();

            GridView1.DataSource = productosActivos;

            GridView1.DataBind();



        }
        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {


            var id = GridView1.SelectedDataKey.Value.ToString();
            Response.Redirect("DetalleProducto.aspx?id=" + id);

        }

        protected void ButtonNuevoProd_Click(object sender, EventArgs e)
        {
        Response.Redirect("DetalleProducto.aspx?id=" + 0);
        }
    }






}