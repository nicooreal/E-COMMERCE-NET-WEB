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









    }
}
