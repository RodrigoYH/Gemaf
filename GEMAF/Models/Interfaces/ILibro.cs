using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GEMAF.Modelos.Entidades;
using System.Data;

namespace GEMAF.Modelos.Interfaces
{
    interface ILibro
    {
        bool AgregarLibro(Libro libro);
        bool ModificarLibro(Libro libro);
        bool BorrarLibro(int id);
        DataSet MostrarLibros();
        Libro GetLibro(int id);
    }
}
