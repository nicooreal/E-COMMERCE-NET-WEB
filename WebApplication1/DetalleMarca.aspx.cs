using NEGOCIO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class DetalleMarca : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {


            MarcaNegocio marcaNegocio = new MarcaNegocio();
            List<DOMINIO.Marcas> listaMarcas = marcaNegocio.listar();
            int cantidadDeMarcas = listaMarcas.Count;



              txtID.Text = (cantidadDeMarcas + 1).ToString();
        
        
        
        }
    }
}