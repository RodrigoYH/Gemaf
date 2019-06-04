using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GEMAF.Modelos.Interfaces;
using System.Data.SqlClient;
using GEMAF.Modelos.Entidades;
using System.Data;

namespace GEMAF.Modelos.Models
{
    class AlumnoModel : IAlumno
    {
        private SqlConnection cn;
        public bool AgregarAlumno(Alumno alumno)
        {
            bool exito = false;
            cn = new DbManager().Conectar();
            SqlCommand cmd = new SqlCommand("InsertarAlumno", cn);
            try
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@nombre", alumno.Nombre);
                cmd.Parameters.AddWithValue("@apPaterno", alumno.ApPaterno);
                cmd.Parameters.AddWithValue("@apMaterno", alumno.ApMaterno);
                cmd.Parameters.AddWithValue("@correo", alumno.Correo);
                cmd.Parameters.AddWithValue("@matricula", alumno.Matricula);
                cmd.Parameters.AddWithValue("@nivel", alumno.Nivel);
                cmd.Parameters.AddWithValue("@curso", alumno.Curso);

                cmd.ExecuteNonQuery();
                exito = true;
            }
            catch
            {
                exito = false;
            }
            finally
            {
                if (cn.State == ConnectionState.Open)
                    cn.Close();
            }
            return exito;
        }

        public bool BorrarAlumno(int id)
        {
            throw new NotImplementedException();
        }

        public Alumno GetAlumno(int id)
        {
            throw new NotImplementedException();
        }

        public bool ModificarAlumno(Alumno alumno)
        {
            throw new NotImplementedException();
        }

        public DataSet MostrarAlumnos()
        {
            throw new NotImplementedException();
        }
    }
}
