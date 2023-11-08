using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using DOMINIO;

namespace NEGOCIO
{
    public class ClienteNegocio
    {

            List<Cliente> listaClientes = new List<Cliente>();
        public List<Cliente> listar()
        {



            AccesoDatos datos = new AccesoDatos();
            
            datos.setearQuery("select IdCliente as IdCLiente, NombreFantasia as NombreFantasia, Direccion as Direccion, Telefono as Telefono, Correo as Correo, FechaNacimiento as FechaNacimiento from Clientes ");
             datos.ejecutarLectura();
           
            while (datos.Lector.Read())
            {
                Cliente cliente = new Cliente();
                
                cliente.id = (int)datos.Lector["IdCliente"];

                if (!datos.Lector.IsDBNull(datos.Lector.GetOrdinal("NombreFantasia")))
                   cliente.nombre = (string)datos.Lector["NombreFantasia"];


                if (!datos.Lector.IsDBNull(datos.Lector.GetOrdinal("Direccion")))
                    cliente.direccion = (string)datos.Lector["Direccion"];

                if (!datos.Lector.IsDBNull(datos.Lector.GetOrdinal("Telefono")))
                    cliente.telefono = (string)datos.Lector["Telefono"];

                if (!datos.Lector.IsDBNull(datos.Lector.GetOrdinal("Correo")))
                    cliente.correo = (string)datos.Lector["Correo"];

                if (!datos.Lector.IsDBNull(datos.Lector.GetOrdinal("FechaNacimiento")))
                    cliente.fechaNacimiento = (DateTime)datos.Lector["FechaNacimiento"];



                listaClientes.Add(cliente);


            }
            datos.cerrarConexion();

            return listaClientes;




        }
    }




}

