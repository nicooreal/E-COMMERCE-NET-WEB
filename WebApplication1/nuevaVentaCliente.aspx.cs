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
    public partial class nuevaVentaCliente : System.Web.UI.Page
    {

        public List<Cliente> listaCliente { get; set; }
        protected void Page_Load(object sender, EventArgs e)
        {

            ClienteNegocio clienteNegocio = new ClienteNegocio();
            listaCliente = clienteNegocio.listar();

            GridViewClientesParaVenta.DataSource = listaCliente;

            GridViewClientesParaVenta.DataBind();
        }

        protected void GridViewClientesParaVenta_SelectedIndexChanged(object sender, EventArgs e)
        {
            var id = GridViewClientesParaVenta.SelectedDataKey.Value.ToString();
            Response.Redirect("nuevaVenta.aspx?id=" + id);
        }
    }
}