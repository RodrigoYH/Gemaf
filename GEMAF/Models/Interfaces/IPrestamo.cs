using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using GEMAF.Modelos.Entidades;

namespace GEMAF.Modelos.Interfaces
{
    interface IPrestamo
    {
        bool InsertarPrestamo(Prestamo prestamo);
    }
}
