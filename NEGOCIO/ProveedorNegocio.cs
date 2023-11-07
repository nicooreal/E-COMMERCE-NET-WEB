using DOMINIO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NEGOCIO
{
    public class ProveedorNegocio
    {

        public List<Proveedor> listar()
        {


            List<Proveedor> listaProveedor = new List<Proveedor>();

            AccesoDatos datos = new AccesoDatos();



            datos.setearQuery("select idProveedor as Id, nombre as Nombre, direccion as Direccion, telefono as Telefono, correo as Correo from Proveedores\r\n");
            datos.ejecutarLectura();



            while (datos.Lector.Read())
            {

                Proveedor prov = new Proveedor();

                prov.id = (int)datos.Lector["Id"];

                if (!datos.Lector.IsDBNull(datos.Lector.GetOrdinal("Nombre")))
                    prov.nombre = (string)datos.Lector["Nombre"];




                if (!datos.Lector.IsDBNull(datos.Lector.GetOrdinal("Direccion")))
                    prov.direccion = (string)datos.Lector["Direccion"];

                if (!datos.Lector.IsDBNull(datos.Lector.GetOrdinal("Telefono")))
                    prov.numeroTelefono = (int)datos.Lector["Telefono"];

                if (!datos.Lector.IsDBNull(datos.Lector.GetOrdinal("Correo")))
                    prov.correo = (string)datos.Lector["Correo"];

                listaProveedor.Add(prov);


            }
            datos.cerrarConexion();

            return listaProveedor;











        }
    }
}

