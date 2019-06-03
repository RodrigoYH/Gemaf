using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GEMAF.Modelos.Entidades;
using System.Data;

namespace GEMAF.Modelos.Interfaces
{
    interface IAlumno
    {
        bool AgregarAlumno(Alumno alumno);
        bool ModificarAlumno(Alumno alumno);
        bool BorrarAlumno(int id);
        DataSet MostrarAlumnos();
        Alumno GetAlumno(int id);
    }
}
