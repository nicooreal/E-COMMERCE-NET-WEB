using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using DOMINIO;

namespace NEGOCIO
{
    public class ProveedorNegocio
    {

        List<Proveedor> listaProveedor = new List<Proveedor>();
        public List<Proveedor> listar()
        {



            AccesoDatos datos = new AccesoDatos();



            datos.setearQuery("select idProveedor as Id, nombre as Nombre, direccion as Direccion, telefono as Telefono, correo as Correo from Proveedores");
            datos.ejecutarLectura();



            while (datos.Lector.Read())
            {

                Proveedor prov = new Proveedor();

                prov.id = (int)datos.Lector["Id"];

                if (!datos.Lector.IsDBNull(datos.Lector.GetOrdinal("Nombre")))
                { prov.nombreEmpresa = (string)datos.Lector["Nombre"];
                    prov.nombre = (string)datos.Lector["Nombre"];
                        }


                if (!datos.Lector.IsDBNull(datos.Lector.GetOrdinal("Direccion")))
                    prov.direccion = (string)datos.Lector["Direccion"];

                if (!datos.Lector.IsDBNull(datos.Lector.GetOrdinal("Telefono")))
                    prov.telefono = (string)datos.Lector["Telefono"];

                if (!datos.Lector.IsDBNull(datos.Lector.GetOrdinal("Correo")))
                    prov.correo = (string)datos.Lector["Correo"];

                listaProveedor.Add(prov);


            }
            datos.cerrarConexion();

            return listaProveedor;











        }
    }
}