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
    public partial class DetalleProveedor : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            int idEditar = int.Parse(Request.QueryString["id"]);
            ProveedorNegocio proveedorNegocio = new ProveedorNegocio();


            List<DOMINIO.Proveedor> listProveedor = new List<DOMINIO.Proveedor>();
            listProveedor = proveedorNegocio.listar();

            if (idEditar > 0)
            {

            }
            else
            {

                txtId.Text = (listProveedor.Count() + 1).ToString();


            }




        }
    }
}