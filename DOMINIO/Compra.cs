using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DOMINIO
{
    public class Compra
    {

    public int id { get; set; }

    public char metodoPago { get; set; } // seria E o T
    public DateTime fechaCompra { get; set; }
        public string entregado { get; set; }
        public string observacion { get; set; }
    public Proveedor Proveedor { get; set; }

    public decimal total { get; set; }
    public int cantidadDeProductos { get; set; }
    
    }
}
