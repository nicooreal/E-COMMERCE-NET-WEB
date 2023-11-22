using NEGOCIO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class DetalleVendedor : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            int idEditar = int.Parse(Request.QueryString["id"]);
            VendedorNegocio vendNegocio = new VendedorNegocio();
            List<DOMINIO.Vendedor> vendedorList = new List<DOMINIO.Vendedor>();
            vendedorList= vendNegocio.listar();

          
            if (idEditar > 0)
            {




            }
            else
            {





            int cantidadDeVendedores = vendedorList.Count;
            txtID.Text = (cantidadDeVendedores + 1).ToString();

            }
            














        }
    }
}