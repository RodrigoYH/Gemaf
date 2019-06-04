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
    class CopiaLibroModel : ICopiaLibro
    {
        private SqlConnection cn;
        public bool AgregarCopiaLibro(CopiaLibro copia)
        {
            bool exito = false;
            cn = new DbManager().Conectar();
            SqlCommand cmd = new SqlCommand("InsertarCopiaLibro", cn);
            try
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@nombre", copia.Nombre);
                cmd.Parameters.AddWithValue("@idCopia", copia.IdCopia);
                cmd.Parameters.AddWithValue("@idLibro", copia.IdLibro);

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

        public bool BorrarCopiaLibro(int id)
        {
            throw new NotImplementedException();
        }

        public CopiaLibro GetCopiaLibro(int id)
        {
            throw new NotImplementedException();
        }

        public bool ModificarCopiaLibro(CopiaLibro copia)
        {
            throw new NotImplementedException();
        }

        public DataSet MostrarCopiaLibros()
        {
            throw new NotImplementedException();
        }
    }
}
