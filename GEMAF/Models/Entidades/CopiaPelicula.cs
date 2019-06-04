using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GEMAF.Modelos.Entidades
{
    class CopiaPelicula:Articulo
    {
        private int idPelicula;
        private int idCopia;

        public int IdPelicula { get => idPelicula; set => idPelicula = value; }
        public int IdCopia { get => idCopia; set => idCopia = value; }
    }
}
