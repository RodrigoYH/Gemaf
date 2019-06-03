using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using GEMAF.Modelos.Entidades;

namespace GEMAF.Modelos.Interfaces
{
    interface ICopiaPelicula
    {
        bool AgregarCopiaPelicula(CopiaPelicula libro);
        bool ModificarCopiaPelicula(CopiaPelicula libro);
        bool BorrarCopiaPelicula(int id);
        DataSet MostrarCopiaPeliculas();
        CopiaPelicula GetCopiaPelicula(int id);
    }
}
