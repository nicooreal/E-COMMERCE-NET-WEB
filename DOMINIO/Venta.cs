using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DOMINIO
{
    public class Venta
    {
       
        public DateTime fechaVenta { get; set; }
        public int codigo { get; set; }
        public Vendedor vendedor { get; set; }
        public List<Producto> listaProductosVenta { get; set; }
        public Cliente cliente { get; set; }
        public float descuento { get; set; }
        public float total { get; set; }
        public string observacion { get; set; }


    }
}
