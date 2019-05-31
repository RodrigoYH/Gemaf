using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GEMAF.Modelos.Entidades
{
    class Alumno:Usuario
    {
        private int nivel;
        private int curso;
        private string correo;

        public int Nivel { get => nivel; set => nivel = value; }
        public int Curso { get => curso; set => curso = value; }
        public string Correo { get => correo; set => correo = value; }
    }
}
