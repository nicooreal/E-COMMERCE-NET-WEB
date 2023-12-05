using DOMINIO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NEGOCIO
{
    public class DetalleCompraNegocio
    {


        public void agregarConSP(DetalleCompra detCompra)
        {
            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.setearProcedimiento("SP_detalleCompra");


                datos.setParameters("@precio", detCompra.precio);
                datos.setParameters("@cantidadDeProductos", detCompra.cantidadDeProductos);
                datos.setParameters("@idProducto", detCompra.idDelProducto);
                datos.setParameters("@idCompra", detCompra.codigo);

                datos.ejecutarAccion();
                datos.cerrarConexion();

            }
            catch (Exception)
            {

                throw;
            }
        }









    }
}
