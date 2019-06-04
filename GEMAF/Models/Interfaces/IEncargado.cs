using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GEMAF.Modelos.Entidades;
using System.Data;

namespace GEMAF.Modelos.Interfaces
{
    interface IEncargado
    {
        bool AgregarEncargado(Encargado encargado);
        bool ModificarEncargado(Encargado encargado);
        bool BorrarEncargado(int id);
        DataSet MostrarEncargados();
        Encargado GetEncargado(int id);
    }
}
