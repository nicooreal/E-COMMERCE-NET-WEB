﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DOMINIO
{
    public class Marca
    {
        public int idMarca { get; set; }
        public string nomMarca { get; set; }

        public override string ToString()
        {
            return nomMarca;
        }


    }
}
