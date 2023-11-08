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
    public partial class Clientes : System.Web.UI.Page
    {
        public List<Cliente> listaCliente { get; set; }
        protected void Page_Load(object sender, EventArgs e)
        {




            ClienteNegocio clienteNegocio = new ClienteNegocio();
            listaCliente = clienteNegocio.listar();

            GridViewClientes.DataSource = listaCliente;

            GridViewClientes.DataBind();


        }

        protected void GridViewClientes_SelectedIndexChanged(object sender, EventArgs e)
        {
            var id = GridViewClientes.SelectedDataKey.Value.ToString();
            Response.Redirect("DetalleCliente.aspx?id=" + id);
        }
    }
}