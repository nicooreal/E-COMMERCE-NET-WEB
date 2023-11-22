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
    public partial class DetalleCliente : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int idEditar = int.Parse(Request.QueryString["id"]);
            ClienteNegocio clienteNegocio = new ClienteNegocio();


            List<Cliente> listCliente = new List<Cliente>();
            listCliente = clienteNegocio.listar();

            if (idEditar > 0)
            {

            }
            else
            {

                txtId.Text =  (listCliente.Count() + 1).ToString();


            }




        }
    }
}