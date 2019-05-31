using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GEMAF.Modelos.Entidades
{
    class Externo:Usuario
    {
        private string telefono;

        public string Telefono { get => telefono; set => telefono = value; }
    }
}
