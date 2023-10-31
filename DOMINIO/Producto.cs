using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DOMINIO
{
    public class Producto
    {

        public int codigo { get; set; }
        public int stockActual { get; set; }
        public int stockMinimo { get; set; }
        public float precioVenta { get; set; }
        public float precioCompra { get; set; }   
        public string nombre { get; set; }
        public string descripcion { get; set; }
        public Categoria categoria { get; set; }
    
        public Proveedor proveedor { get; set; }

        public Marca marca { get; set; }
    
    }
}
