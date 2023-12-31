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
    public partial class Proveedor : System.Web.UI.Page
    {
        public List<DOMINIO.Proveedor> listaProveedor { get; set; }


        public void Page_Load(object sender, EventArgs e)
        {




            ProveedorNegocio provNegocio = new ProveedorNegocio();
            listaProveedor =  provNegocio.listar() ;


            GridViewProveedores.DataSource = listaProveedor;

            GridViewProveedores.DataBind();
        }
           
        
        protected void GridViewProveedores_SelectedIndexChanged(object sender, EventArgs e)

            {
                var id = GridViewProveedores.SelectedDataKey.Value.ToString();
                Response.Redirect("DetalleProveedor.aspx?id=" + id);
            }

        protected void ButtonNuevoProveedor_Click(object sender, EventArgs e)
        {
            Response.Redirect("DetalleProveedor.aspx?id=" + 0);
        }
    }

}