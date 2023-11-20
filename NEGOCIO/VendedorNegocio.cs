using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using DOMINIO;

namespace NEGOCIO
{
    public class VendedorNegocio   
    {

        List<Vendedor> listaVendedor = new List<Vendedor>();
        public List<Vendedor> listar()
        {



            AccesoDatos datos = new AccesoDatos();

            datos.setearQuery("select idVendedor as Id, Nombre as Nombre, Direccion as Direccion, Telefono as Telefono, Correo as Correo from Vendedores");
            datos.ejecutarLectura();

            while (datos.Lector.Read())
            {
                Vendedor vendedor = new Vendedor();

                vendedor.idVendedor = (int)datos.Lector["Id"];

                if (!datos.Lector.IsDBNull(datos.Lector.GetOrdinal("Nombre")))
                    vendedor.nombre = (string)datos.Lector["Nombre"];


                if (!datos.Lector.IsDBNull(datos.Lector.GetOrdinal("Direccion")))
                    vendedor.direccion = (string)datos.Lector["Direccion"];

                if (!datos.Lector.IsDBNull(datos.Lector.GetOrdinal("Telefono")))
                    vendedor.telefono = (string)datos.Lector["Telefono"];

                if (!datos.Lector.IsDBNull(datos.Lector.GetOrdinal("Correo")))
                    vendedor.correo = (string)datos.Lector["Correo"];



                listaVendedor.Add(vendedor);


            }
            datos.cerrarConexion();

            return listaVendedor;




        }
    }




}

