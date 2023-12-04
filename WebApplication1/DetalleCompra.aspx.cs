using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DOMINIO;
using NEGOCIO;

namespace WebApplication1
{
    public partial class DetalleCompra : System.Web.UI.Page
    {
        public List<DOMINIO.Proveedor> listaProveedor { get; set; }
        protected void Page_Load(object sender, EventArgs e)
        {


            ProveedorNegocio provNegocio = new ProveedorNegocio();
            listaProveedor = provNegocio.listar();


            GridViewProveedoresEnCompra.DataSource = listaProveedor;

            GridViewProveedoresEnCompra.DataBind();



        }

        protected void GridViewProveedoresEnCompra_SelectedIndexChanged(object sender, EventArgs e)
        {
            var id = GridViewProveedoresEnCompra.SelectedDataKey.Value.ToString();

            Response.Redirect("ArmarCompra.aspx?id=" + id);
  
        }
    }
}