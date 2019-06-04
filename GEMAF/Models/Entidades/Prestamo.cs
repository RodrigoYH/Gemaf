using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GEMAF.Modelos.Entidades
{
    class Prestamo
    {
        private int idArticulo;
        private int idUsuario;
        private DateTime fechaPrestamo;
        private DateTime fechaDevolucion;
        private DateTime fechaDevuelto;
        private string tipo;
        private string estado;

        public int IdArticulo { get => idArticulo; set => idArticulo = value; }
        public int IdUsuario { get => idUsuario; set => idUsuario = value; }
        public DateTime FechaPrestamo { get => fechaPrestamo; set => fechaPrestamo = value; }
        public DateTime FechaDevolucion { get => fechaDevolucion; set => fechaDevolucion = value; }
        public DateTime FechaDevuelto { get => fechaDevuelto; set => fechaDevuelto = value; }
        public string Tipo { get => tipo; set => tipo = value; }
        public string Estado { get => estado; set => estado = value; }
    }
}
