using DOMINIO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NEGOCIO
{
    public class CategoriaNegocio
    {

        List<Categoria> listaCategoria = new List<Categoria>();

        public List<Categoria> listar()
        {



            AccesoDatos datos = new AccesoDatos();
            datos.setearQuery("select C.idCategoria as idCategoria , C.nombre as nombre from Categorias C");

            datos.ejecutarLectura();
            while (datos.Lector.Read())
            {
                Categoria categoria = new Categoria();
                categoria.idCategoria = (int)datos.Lector["idCategoria"];

                if (!datos.Lector.IsDBNull(datos.Lector.GetOrdinal("Nombre")))
                    categoria.nomCategoria = (string)datos.Lector["Nombre"];







                listaCategoria.Add(categoria);


            }
            datos.cerrarConexion();

            return listaCategoria;









        }
    }
}
