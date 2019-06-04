using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using GEMAF.Modelos.Interfaces;

namespace GEMAF.Modelos.Models
{
    class DbManager:IDbManager
    {
        private string CadenaConexion = "Data Source=DESKTOP-NP8U205\\SQLEXPRESS;" +
            "Integrated Security=True;" +
            "Initial Catalog=gemaf";

        public SqlConnection Conectar()
        {
            SqlConnection conexion = new SqlConnection(CadenaConexion);
            conexion.Open();
            return conexion;
        }
    }
}
