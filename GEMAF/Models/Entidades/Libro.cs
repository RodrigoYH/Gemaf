using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GEMAF.Modelos.Entidades
{
    class Libro
    {
        private int idLibro;
        private string titulo;
        private string autor;
        private string genero;
        private string seccion;
        private string locacion;

        public int IdLibro { get => idLibro; set => idLibro = value; }
        public string Titulo { get => titulo; set => titulo = value; }
        public string Autor { get => autor; set => autor = value; }
        public string Genero { get => genero; set => genero = value; }
        public string Seccion { get => seccion; set => seccion = value; }
        public string Locacion { get => locacion; set => locacion = value; }
    }
}
