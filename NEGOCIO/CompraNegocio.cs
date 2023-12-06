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
                datos.setearQuery("SELECT C.idCompra AS idCompra, C.fecha AS fecha, C.idProveedor AS proveedor ,C.estado AS estado, C.observacion AS observacion, SUM(DetC.cantidad * DetC.precio) AS totalCompra, SUM(DetC.cantidad) AS cantidadProductos,P.nombre as nombreProveedor FROM Compras C INNER JOIN Detalles_Compra DetC ON C.idCompra = DetC.idCompra inner join Proveedores P on P.idProveedor = C.idProveedor GROUP BY C.idCompra, C.fecha, C.idProveedor,  C.estado, C.observacion, P.nombre;");
                datos.ejecutarLectura();

                while (datos.Lector.Read())
                {
                    Compra aux = new Compra();



                    if (!(datos.Lector["idCompra"] is DBNull))
                        aux.id = (int)datos.Lector["idCompra"];


                    if (!(datos.Lector["fecha"] is DBNull))
                        aux.fechaCompra = (DateTime)datos.Lector["fecha"];




                    aux.Proveedor = new Proveedor();
                    if (!(datos.Lector["proveedor"] is DBNull))
                        aux.Proveedor.idProveedor = (int)datos.Lector["proveedor"];

                    aux.Proveedor = new Proveedor();
                    if (!(datos.Lector["nombreProveedor"] is DBNull))
                        aux.Proveedor.nombreEmpresa = (string)datos.Lector["nombreProveedor"];



                    if (!(datos.Lector["estado"] is DBNull))
                        aux.entregado = (string)datos.Lector["estado"];

                    if (!(datos.Lector["observacion"] is DBNull))
                        aux.observacion = (string)datos.Lector["observacion"];

                    if (!(datos.Lector["totalCompra"] is DBNull))
                        aux.total = (decimal)datos.Lector["totalCompra"];



                    if (!(datos.Lector["cantidadProductos"] is DBNull))
                        aux.cantidadDeProductos = (int)datos.Lector["cantidadProductos"];











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






        public void pasarARealizado(int idEntregado)
        {

            AccesoDatos datos = new AccesoDatos();

            datos.setParameters("@id", idEntregado);

            datos.setearQuery("update Compras set estado = 'REALIZADA' where idCompra = @id");
            datos.ejecutarLectura();
            datos.cerrarConexion();


        }



        public void ponerEnPendiente(int idEntregado)
        {

            AccesoDatos datos = new AccesoDatos();

            datos.setParameters("@id", idEntregado);

            datos.setearQuery("update Compras set estado = 'PENDIENTE' where idCompra = @id");
            datos.ejecutarLectura();
            datos.cerrarConexion();










        }



        public void eliminarCompra(int idEntregado)
        {

            AccesoDatos datos = new AccesoDatos();

            datos.setParameters("@id", idEntregado);

            datos.setearQuery("update Compras set estado = 'ELIMINADO' where idCompra = @id");
            datos.ejecutarLectura();
            datos.cerrarConexion();










        }
    }
}

