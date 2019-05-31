using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GEMAF.Modelos.Entidades
{
    class Encargado:Usuario
    {
        private string contraseña;

        public string Contraseña { get => contraseña; set => contraseña = value; }
    }
}
