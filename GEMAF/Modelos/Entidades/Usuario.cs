using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GEMAF.Modelos.Entidades
{
    class Usuario
    {
        private int idUsuario;
        private string nombre;
        private string apPaterno;
        private string apMaterno;
        private string estado;
        private string clase;

        public int IdUsuario { get => idUsuario; set => idUsuario = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string ApPaterno { get => apPaterno; set => apPaterno = value; }
        public string ApMaterno { get => apMaterno; set => apMaterno = value; }
        public string Estado { get => estado; set => estado = value; }
        public string Clase { get => clase; set => clase = value; }
    }
}
