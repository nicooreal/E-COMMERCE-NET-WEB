using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace DOMINIO
{
    public class Proveedor : Persona
    {
    public int id { get; set; }

        public string nombreEmpresa { get; set; }
        public override string ToString()
        {
            return nombreEmpresa;
        }
    }
}
