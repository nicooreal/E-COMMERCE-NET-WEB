using DOMINIO;
using NEGOCIO;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class nuevaVenta : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            List<Cliente> listaCliente;
            ClienteNegocio clienteNegocio = new ClienteNegocio();
            listaCliente = clienteNegocio.listar();



            int idCliente= int.Parse(Request.QueryString["id"]);
            
            Cliente cliente = listaCliente.Find(x => x.id == idCliente);

            txtClient.Text = cliente.nombre.ToString();



        }
    }
}