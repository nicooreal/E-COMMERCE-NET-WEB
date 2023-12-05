using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DOMINIO;


namespace NEGOCIO
{
    public class CompraNegocio
    {
        public List<Compra> listaCompraSimple = new List<Compra>();

        public List<Compra> listar()
        {
            List<Compra> lista = new List<Compra>();
            AccesoDatos datos = new AccesoDatos();


            try
            {
                datos.setearQuery("Select c.id as id, p.dni as dni, p.nombre as nombre,c.fecha as fecha, c.formaPago as formapago from Compras as c inner join Proveedores as p on p.id=c.id_proveedor");

                datos.ejecutarLectura();

                while (datos.Lector.Read())
                {
                    Compra aux = new Compra();



                    if (!(datos.Lector["id"] is DBNull))
                        aux.id = (int)datos.Lector["id"];

                  
                    if (!(datos.Lector["fecha"] is DBNull))
                        aux.fechaCompra = (DateTime)datos.Lector["fecha"];

                    if (!(datos.Lector["nombre"] is DBNull))
                        aux.Proveedor.nombre = (string)datos.Lector["nombre"];


                    aux.Proveedor = new Proveedor();
                    if (!(datos.Lector["dni"] is DBNull))
                        aux.Proveedor.idProveedor = (char)datos.Lector["dni"];
                    //aux.Producto = new Producto();
                    //if (!(datos.Lector["IdProducto"] is DBNull))
                    //    aux.Producto.Codigo = (int)datos.Lector["IdProducto"];

                    if (!(datos.Lector["formaPago"] is DBNull))
                        aux.metodoPago = (char)datos.Lector["formaPago"];










                    lista.Add(aux);
                }

                return lista;
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                datos.cerrarConexion();
            }
        }



        public List<Compra> listarCompraSimple()
        {

            AccesoDatos datos = new AccesoDatos();


            datos.setearQuery("select idCompra from Compras");

            datos.ejecutarLectura();


            while (datos.Lector.Read())
            {

                Compra compra = new Compra();
                if (!datos.Lector.IsDBNull(datos.Lector.GetOrdinal("idCompra")))
                    compra.id = (int)datos.Lector["idCompra"];



                listaCompraSimple.Add(compra);

            }
            return listaCompraSimple;
        }





        }
}
