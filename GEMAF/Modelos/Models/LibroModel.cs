using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GEMAF.Modelos.Entidades;
using GEMAF.Modelos.Interfaces;
using System.Data.SqlClient;

namespace GEMAF.Modelos.Models
{
    class LibroModel : ILibro
    {
        private SqlConnection cn;
        public bool AgregarLibro(Libro libro)
        {
            bool exito = false;
            cn = new DbManager().Conectar();
            SqlCommand cmd = new SqlCommand("InsertarLibro",cn);
            try
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@titulo", libro.Titulo);
                cmd.Parameters.AddWithValue("@autor", libro.Autor);
                cmd.Parameters.AddWithValue("@genero", libro.Genero);
                cmd.Parameters.AddWithValue("@seccion", libro.Seccion);
                cmd.Parameters.AddWithValue("@locacion", libro.Locacion);

                cmd.ExecuteNonQuery();
                exito = true;
            }
            catch
            {
                exito = false;
            }
            finally
            {
                if(cn.State==ConnectionState.Open)
                {
                    cn.Close();
                }
            }
            return exito;
        }

        public bool BorrarLibro(int id)
        {
            throw new NotImplementedException();
        }

        public Libro GetLibro(int id)
        {
            throw new NotImplementedException();
        }

        public bool ModificarLibro(Libro libro)
        {
            throw new NotImplementedException();
        }

        public DataSet MostrarLibros()
        {
            throw new NotImplementedException();
        }
    }
}
