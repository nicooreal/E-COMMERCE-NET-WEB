﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DOMINIO
{
    public class Venta
    {
       
        public string entregado { get; set; }
        public DateTime fechaVenta { get; set; }
        public int codigo { get; set; }
        public Vendedor vendedor { get; set; }
        public Cliente cliente { get; set; }
        public float descuento { get; set; }
        public decimal total { get; set; }
        public string observacion { get; set; }

        public int cantidadDeProductos { get; set; }

    }
}
