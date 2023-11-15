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

      
        public List<Venta> listarVenta()
        {

        AccesoDatos datos = new AccesoDatos();

        List<Venta> listaVentas = new List<Venta>();

            datos.setearQuery("select C.nombreFantasia as nombreCliente, V.fecha as fecha,V.idVenta as idVenta ,V.idCliente as idCliente, V.observacion as observacion,V.idVenta as idVenta,V.idVendedor as idVendedor, vend.nombre as nombreVendedor  from Ventas V  inner join Vendedores vend on vend.idVendedor = V.idVendedor inner join Clientes C on V.idCliente = C.idCliente");


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
                    vent.fechaVenta = (DateTime)datos.Lector["fecha"];

                if (!datos.Lector.IsDBNull(datos.Lector.GetOrdinal("observacion")))
                    vent.observacion = (string)datos.Lector["observacion"];


                vent.vendedor = new Vendedor();
                
                if (!datos.Lector.IsDBNull(datos.Lector.GetOrdinal("idVendedor")))
                {
                    vent.vendedor.legajo = (int)datos.Lector["idVendedor"];
                    vent.vendedor.nombre = (string)datos.Lector["nombreVendedor"];

                }
            
            

                listaVentas.Add(vent);
            
            }

            datos.cerrarConexion();


            return listaVentas;
        
        }
        


        

     

       



    }
}
