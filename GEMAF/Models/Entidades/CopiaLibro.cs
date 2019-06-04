using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GEMAF.Modelos.Entidades
{
    class CopiaLibro:Articulo
    {
        private int idLibro;
        private int idCopia;

        public int IdLibro { get => idLibro; set => idLibro = value; }
        public int IdCopia { get => idCopia; set => idCopia = value; }
    }
}
