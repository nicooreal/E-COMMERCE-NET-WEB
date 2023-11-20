using NEGOCIO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class Vendedor : System.Web.UI.Page
    {

        public List<DOMINIO.Vendedor> listaVendedor { get; set; }


        protected void Page_Load(object sender, EventArgs e)
        {


            VendedorNegocio vendNegocio = new VendedorNegocio();
            listaVendedor = vendNegocio.listar();


            GridViewVendedor.DataSource = listaVendedor;

            GridViewVendedor.DataBind();



        }


        protected void GridViewVendedor_SelectedIndexChanged(object sender, EventArgs e)

        {
            var id = GridViewVendedor.SelectedDataKey.Value.ToString();
            Response.Redirect("DetalleVendedor.aspx?id=" + id);
        }




    }
}