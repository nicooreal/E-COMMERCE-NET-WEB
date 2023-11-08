using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using NEGOCIO;
using DOMINIO;

namespace WebApplication1
{
    public partial class Marca : System.Web.UI.Page
    {
        public List<Marcas> listaMarca { get; set; }

        protected void Page_Load(object sender, EventArgs e)
        {
            MarcaNegocio MarcaNegocio = new MarcaNegocio();
            listaMarca = MarcaNegocio.listar();

            GridViewMarca.DataSource = listaMarca;

            GridViewMarca.DataBind();
        }

        protected void GridViewMarca_SelectedIndexChanged(object sender, EventArgs e)
        {

            var id = GridViewMarca.SelectedDataKey.Value.ToString();
            Response.Redirect("DetalleMarca.aspx?id=" + id);



        }
    }
}