using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GEMAF.Modelos.Entidades;
using System.Data;

namespace GEMAF.Modelos.Interfaces
{
    interface IPelicula
    {
        bool AgregarPelicula(Pelicula pelicula);
        bool ModificarPelicula(Pelicula pelicula);
        bool BorrarPelicula(int id);
        DataSet MostrarPeliculas();
        Pelicula GetPelicula(int id);
    }
}
