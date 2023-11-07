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
    public partial class Proveedor : System.Web.UI.Page
    {
        public List<Proveedor> listaProveedor { get; set; }


        protected void Page_Load(object sender, EventArgs e)
        {




            ProveedorNegocio provNegocio = new ProveedorNegocio();
          // listaProveedor = provNegocio.listar();

            GridViewProveedores.DataSource = listaProveedor;

            GridViewProveedores.DataBind();
        }
           
        
        protected void GridViewProveedores_SelectedIndexChanged(object sender, EventArgs e)

            {
                var id = GridViewProveedores.SelectedDataKey.Value.ToString();
                Response.Redirect("DetalleProveedor.aspx?id=" + id);
            }
        

    }

}