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
    public List<Producto> listaProductosCompra { get; set; } // tener en cuenta que la Producto tiene como metodo a Proveedor, habria que filtar para que la lista que se arme para comprar sea solo de un solo proveedor
    public char metodoPago { get; set; } // seria E o T
    public DateTime fechaCompra { get; set; }
    public bool compraEntregada { get; set; }
    public string observacion { get; set; }
         
    }
}
