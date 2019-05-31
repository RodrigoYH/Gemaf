using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GEMAF.Modelos.Entidades
{
    class Articulo
    {
        private int idArticulo;
        private string nombre;
        private string estado;
        private string clase;

        public int IdArticulo { get => idArticulo; set => idArticulo = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Estado { get => estado; set => estado = value; }
        public string Clase { get => clase; set => clase = value; }
    }
}
