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
        private string matricula;
        private int numSanciones;

        public int Nivel { get => nivel; set => nivel = value; }
        public int Curso { get => curso; set => curso = value; }
        public string Correo { get => correo; set => correo = value; }
        public string Matricula { get => matricula; set => matricula = value; }
        public int NumSanciones { get => numSanciones; set => numSanciones = value; }
    }
}
