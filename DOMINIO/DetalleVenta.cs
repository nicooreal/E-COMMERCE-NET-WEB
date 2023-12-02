using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DOMINIO
{
    public class DetalleVenta
    {
        public int codigo { get; set; }
        public decimal precio { get; set; }
        public int cantidadDeProductos { get; set; }
        public decimal totalPorProducto { get; set; }

        public string nombreDeProducto { get; set; }

      public decimal totalDeTodo { get; set; }

        public int idDelProducto { get; set; }
    }
}
