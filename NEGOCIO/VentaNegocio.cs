using DOMINIO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NEGOCIO
{
    public class VentaNegocio
    {

      
        public  List<Venta> listaVentas = new List<Venta>();
        public List<Venta> listarVenta()
        {

        AccesoDatos datos = new AccesoDatos();


            datos.setearQuery("\tSELECT V.idVenta, V.entregado as entregado, SUM(DetV.cantidad * DetV.precio) as totalVenta, SUM( DetV.cantidad) as cantidadProductos, C.nombreFantasia as nombreCliente,  V.fecha as fecha, V.idCliente as idCliente,  V.observacion as observacion, V.idVendedor as idVendedor, vend.nombre as nombreVendedor   FROM  Ventas V   INNER JOIN Vendedores vend ON vend.idVendedor = V.idVendedor  INNER JOIN Clientes C ON V.idCliente = C.idCliente  INNER JOIN Detalles_Venta DetV ON DetV.idVenta = V.idVenta  GROUP BY  V.idVenta, C.nombreFantasia, V.fecha, V.idCliente, V.observacion, V.idVendedor, vend.nombre, V.entregado   \r\n\r\n ");


            datos.ejecutarLectura();
            while (datos.Lector.Read())
            {

                Venta vent = new Venta();

                if (!datos.Lector.IsDBNull(datos.Lector.GetOrdinal("idVenta")))
                    vent.codigo = (int)datos.Lector["idVenta"];


                if (!datos.Lector.IsDBNull(datos.Lector.GetOrdinal("fecha")))
                    vent.fechaVenta = (DateTime)datos.Lector["fecha"];

                vent.cliente = new Cliente();

                if (!datos.Lector.IsDBNull(datos.Lector.GetOrdinal("idCliente")))
                {
                    vent.cliente.id = (int)datos.Lector["idCliente"];
                    vent.cliente.nombre = (string)datos.Lector["nombreCliente"];
                }

                if (!datos.Lector.IsDBNull(datos.Lector.GetOrdinal("observacion")))
                    vent.fechaVenta =  (DateTime)datos.Lector["fecha"];

                if (!datos.Lector.IsDBNull(datos.Lector.GetOrdinal("observacion")))
                    vent.observacion = (string)datos.Lector["observacion"];


                vent.vendedor = new Vendedor();
                
                if (!datos.Lector.IsDBNull(datos.Lector.GetOrdinal("idVendedor")))
                {
                    vent.vendedor.legajo = (int)datos.Lector["idVendedor"];
                    vent.vendedor.nombre = (string)datos.Lector["nombreVendedor"];

                }

                if (!datos.Lector.IsDBNull(datos.Lector.GetOrdinal("totalVenta")))
                    vent.total = (decimal)datos.Lector["totalVenta"];

                if (!datos.Lector.IsDBNull(datos.Lector.GetOrdinal("cantidadProductos")))
                    vent.cantidadDeProductos = (int)datos.Lector["cantidadProductos"];

                if (!datos.Lector.IsDBNull(datos.Lector.GetOrdinal("entregado")))
                  
                    vent.entregado = (bool)datos.Lector["entregado"];
              

                listaVentas.Add(vent);
            
            }

            datos.cerrarConexion();


            return listaVentas;
        
        }
        

        public void pasarAEntregado(int idEntregado)
        {

            AccesoDatos datos = new AccesoDatos();

            datos.setParameters("@id", idEntregado);

            datos.setearQuery("update Ventas set entregado = 0 where idVenta = @id"); 
            datos.ejecutarLectura();
            datos.cerrarConexion();


        }








    }
}
