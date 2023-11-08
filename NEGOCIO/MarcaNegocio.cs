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
            List<Marcas> listaMarcas = new List<Marcas>();

        public List<Marcas> listar()
        {



            AccesoDatos datos = new AccesoDatos();
            datos.setearQuery("select M.idMarca as IdMarca, M.nombre as Nombre  from Marcas M");

            datos.ejecutarLectura();
            while (datos.Lector.Read())
            {
                Marcas marca = new Marcas();
                marca.idMarca = (int)datos.Lector["IdMarca"];
                
                if (!datos.Lector.IsDBNull(datos.Lector.GetOrdinal("Nombre")))
                    marca.nomMarca = (string)datos.Lector["Nombre"];
                

                



               
                listaMarcas.Add(marca);


            }
            datos.cerrarConexion();

            return listaMarcas;




        }
    }




}

