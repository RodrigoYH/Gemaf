using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GEMAF.Modelos.Entidades
{
    class Tableta:Articulo
    {
        private int idTableta;
        private string modelo;

        public int IdTableta { get => idTableta; set => idTableta = value; }
        public string Modelo { get => modelo; set => modelo = value; }
    }
}
