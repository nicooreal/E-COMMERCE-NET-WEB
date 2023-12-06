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

        public List<DetalleCompra> listarDetalleCompra()
        {



            AccesoDatos datos = new AccesoDatos();

            List<DetalleCompra> listaDetalleCompras = new List<DetalleCompra>();

            datos.setearQuery("select DetC.cantidad as cantidadPRoductos, P.idProducto as idProducto ,DetC.precio, (DetC.precio * DetC.cantidad) as totalPorProducto, P.nombre as nombreProducto,  C.idCompra as idCompra from Compras C   inner join Detalles_Compra DetC on DetC.idCompra = C.idCompra inner join Productos P on P.idProducto = DetC.idProducto");
            datos.ejecutarLectura();
            while (datos.Lector.Read())
            {

                DetalleCompra compr = new DetalleCompra();

                if (!datos.Lector.IsDBNull(datos.Lector.GetOrdinal("idCompra")))
                    compr.codigo = (int)datos.Lector["idCompra"];


                if (!datos.Lector.IsDBNull(datos.Lector.GetOrdinal("cantidadPRoductos")))
                    compr.cantidadDeProductos = (int)datos.Lector["cantidadPRoductos"];



                if (!datos.Lector.IsDBNull(datos.Lector.GetOrdinal("precio")))
                    compr.precio = (decimal)datos.Lector["precio"];

                if (!datos.Lector.IsDBNull(datos.Lector.GetOrdinal("idProducto")))
                    compr.idDelProducto = (int)datos.Lector["idProducto"];

                if (!datos.Lector.IsDBNull(datos.Lector.GetOrdinal("totalPorProducto")))
                    compr.totalPorProducto = (decimal)datos.Lector["totalPorProducto"];

                if (!datos.Lector.IsDBNull(datos.Lector.GetOrdinal("nombreProducto")))
                    compr.nombreDeProducto = (string)datos.Lector["nombreProducto"];



                listaDetalleCompras.Add(compr);



            }


            datos.cerrarConexion();
            return listaDetalleCompras;




        }














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
