using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DOMINIO
{
    public class Producto
    {

        public int id { get; set; }
        public int stockActual { get; set; }
        public int stockMinimo { get; set; }
        public decimal precioVenta { get; set; }
        public decimal precioCompra { get; set; }   
        public string nombre { get; set; }
        public string descripcion { get; set; }
        public Categoria idcategoria { get; set; }
    
        public Proveedor proveedor { get; set; }

        public Marca idmarca { get; set; }
    
    }
}
