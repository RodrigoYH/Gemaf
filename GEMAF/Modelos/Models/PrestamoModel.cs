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
    class PrestamoModel : IPrestamo
    {
        private SqlConnection cn;
        public bool InsertarPrestamo(Prestamo prestamo)
        {
            bool exito = false;
            cn = new DbManager().Conectar();
            SqlCommand cmd = new SqlCommand("InsertarPrestamo", cn);
            try
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@idArticulo", prestamo.IdArticulo);
                cmd.Parameters.AddWithValue("@idUsuario", prestamo.IdUsuario);
                cmd.Parameters.AddWithValue("@fechaPrestamo", prestamo.FechaPrestamo);
                cmd.Parameters.AddWithValue("@fechaDevolucion", prestamo.FechaDevolucion);

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
    }
}
