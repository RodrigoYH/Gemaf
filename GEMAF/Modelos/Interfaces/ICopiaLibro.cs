using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GEMAF.Modelos.Entidades;
using System.Data;

namespace GEMAF.Modelos.Interfaces
{
    interface ICopiaLibro
    {
        bool AgregarCopiaLibro(CopiaLibro copia);
        bool ModificarCopiaLibro(CopiaLibro copia);
        bool BorrarCopiaLibro(int id);
        DataSet MostrarCopiaLibros();
        CopiaLibro GetCopiaLibro(int id);
    }
}
