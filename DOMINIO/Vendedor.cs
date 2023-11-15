using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DOMINIO
{
    public class Vendedor : Persona
    {
        public int legajo { get; set; }
        public List<Cliente> listaClientes { get; set; }

    
    
    }
}
