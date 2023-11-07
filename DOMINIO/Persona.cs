using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DOMINIO
{
     public  class Persona
    {
        public string nombre { get; set; }
        public int edad { get; set; }
        public string direccion { get; set; }
        public DateTime fechaNacimiento { get; set; }
        public string correo { get; set; }

        public int numeroTelefono { get; set; }

    }
}
