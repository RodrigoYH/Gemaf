using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GEMAF.Modelos.Entidades
{
    class Pelicula
    {
        private int idPelicula;
        private string titulo;
        private string director;
        private string clasificacion;
        private string genero;
        private string seccion;
        private string locacion;
        private int año;

        public int IdPelicula { get => idPelicula; set => idPelicula = value; }
        public string Titulo { get => titulo; set => titulo = value; }
        public string Director { get => director; set => director = value; }
        public string Clasificacion { get => clasificacion; set => clasificacion = value; }
        public string Genero { get => genero; set => genero = value; }
        public string Seccion { get => seccion; set => seccion = value; }
        public string Locacion { get => locacion; set => locacion = value; }
        public int Año { get => año; set => año = value; }
    }
}
