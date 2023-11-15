using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using DOMINIO;

namespace NEGOCIO
{
    public class ProductoNegocio
    {

        public List<Producto> listar()
        {


            List<Producto> listaProductos = new List<Producto>();

            AccesoDatos datos = new AccesoDatos();
            datos.setearQuery("SELECT P.estado as Estado, Prov.nombre as NombreProveedor, Prov.idProveedor as idProveedor , P.idProducto AS Id, P.nombre AS Nombre, P.precioCompra AS PrecioCompra, C.idCategoria as idCategoria, C.nombre as NombreCategoria, P.precioVenta AS PrecioVenta, M.nombre as NombreMarca,M.idMarca as idMarca, C.nombre AS NombreCategoria, P.stockActual AS StockActual, P.stockMinimo AS StockMinimo, P.descripcion as Descripcion   FROM Productos P  INNER JOIN Marcas M ON P.idMarca = M.idMarca inner join Categorias C on P.idCategoria = C.idCategoria inner join Proveedores prov on prov.idProveedor = P.idProveedor");
       
            datos.ejecutarLectura();
            while (datos.Lector.Read())
            {
                Producto producto = new Producto();
                producto.id = (int)datos.Lector["Id"];

                if (!datos.Lector.IsDBNull(datos.Lector.GetOrdinal("Estado")))
                    producto.estado = (int)datos.Lector["Estado"];


                if (!datos.Lector.IsDBNull(datos.Lector.GetOrdinal("Nombre")))
                    producto.nombre = (string)datos.Lector["Nombre"];

                if (!datos.Lector.IsDBNull(datos.Lector.GetOrdinal("PrecioCompra")))
                    producto.precioCompra = (decimal)datos.Lector["PrecioCompra"];

                if (!datos.Lector.IsDBNull(datos.Lector.GetOrdinal("PrecioVenta")))
                    producto.precioVenta = (decimal)datos.Lector["PrecioVenta"];

                producto.idmarca = new Marcas();
                if (!(datos.Lector["NombreMarca"] is DBNull))
                {
                    producto.idmarca.nomMarca = (string)datos.Lector["NombreMarca"];
                    producto.idmarca.idMarca = (int)datos.Lector["idMarca"];
                }

                producto.idcategoria = new Categoria();
                if (!datos.Lector.IsDBNull(datos.Lector.GetOrdinal("NombreCategoria")))
                {
                    producto.idcategoria.nomCategoria = (string)datos.Lector["NombreCategoria"];
                    producto.idcategoria.idCategoria = (int)datos.Lector["idCategoria"];

                }

                if (!datos.Lector.IsDBNull(datos.Lector.GetOrdinal("StockActual")))
                    producto.stockActual = (int)datos.Lector["StockActual"];

                if (!datos.Lector.IsDBNull(datos.Lector.GetOrdinal("StockMinimo")))
                    producto.stockMinimo = (int)datos.Lector["StockMinimo"];

                if (!datos.Lector.IsDBNull(datos.Lector.GetOrdinal("Descripcion")))
                    producto.descripcion = (string)datos.Lector["Descripcion"];


                producto.proveedor = new Proveedor();
                if (!datos.Lector.IsDBNull(datos.Lector.GetOrdinal("NombreProveedor")))
                {
                    producto.proveedor.nombreEmpresa = (string)datos.Lector["NombreProveedor"];
                    producto.proveedor.idProveedor = (int)datos.Lector["idProveedor"];
                }


            

                 listaProductos.Add(producto);


            }
            datos.cerrarConexion();

            return listaProductos;




        }
    
    
    
    
        

    
    
    
    }




}

