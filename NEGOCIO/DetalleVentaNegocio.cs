using DOMINIO;
using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NEGOCIO
{
    public class DetalleVentaNegocio
    {
        public List<DetalleVenta> listarDetalleVenta()
        {

            

            AccesoDatos datos = new AccesoDatos();

            List<DetalleVenta> listaDetalleVentas = new List<DetalleVenta>();

            datos.setearQuery("select DetV.cantidad as cantidadPRoductos, DetV.precio, (DetV.precio * DetV.cantidad) as totalPorProducto, P.nombre as nombreProducto,  V.idVenta as idVenta from Ventas V  inner join Vendedores vend on vend.idVendedor = V.idVendedor inner join Detalles_Venta DetV on DetV.idVenta = V.idVenta inner join Productos P on P.idProducto = DetV.idProducto");
            datos.ejecutarLectura();
            while (datos.Lector.Read())
            {

                DetalleVenta vent = new DetalleVenta();

                if (!datos.Lector.IsDBNull(datos.Lector.GetOrdinal("idVenta")))
                    vent.codigo = (int)datos.Lector["idVenta"];


                if (!datos.Lector.IsDBNull(datos.Lector.GetOrdinal("cantidadPRoductos")))
                    vent.cantidadDeProductos= (int)datos.Lector["cantidadPRoductos"];

                

                if (!datos.Lector.IsDBNull(datos.Lector.GetOrdinal("precio")))
                    vent.precio = (decimal)datos.Lector["precio"];
                
                

                if (!datos.Lector.IsDBNull(datos.Lector.GetOrdinal("totalPorProducto")))
                    vent.totalPorProducto = (decimal)datos.Lector["totalPorProducto"];

                if (!datos.Lector.IsDBNull(datos.Lector.GetOrdinal("nombreProducto")))
                    vent.nombreDeProducto = (string)datos.Lector["nombreProducto"];



                listaDetalleVentas.Add(vent);

            
            
            }
            
            
            datos.cerrarConexion();
            return listaDetalleVentas;




        } 
    }
}
