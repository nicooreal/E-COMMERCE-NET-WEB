using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using DOMINIO;

namespace NEGOCIO
{
    public class MarcaNegocio

    {
            List<Marca> listaMarcas = new List<Marca>();

        public List<Marca> listar()
        {



            AccesoDatos datos = new AccesoDatos();
            datos.setearQuery("select M.Id as Idmarca, M.nombre as Nombre  from Marcas M");

            datos.ejecutarLectura();
            while (datos.Lector.Read())
            {
                Marca marca = new Marca();
                marca.idMarca = (int)datos.Lector["Id"];
                
                if (!datos.Lector.IsDBNull(datos.Lector.GetOrdinal("Nombre")))
                    marca.nomMarca = (string)datos.Lector["Nombre"];
                

                



               
                listaMarcas.Add(marca);


            }
            datos.cerrarConexion();

            return listaMarcas;




        }
    }




}

