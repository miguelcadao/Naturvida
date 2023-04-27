using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class CD_Conexion
    {
        //private SqlConnection conexion = new SqlConnection("Server=BUCDFPCSEFSD028;Database=NaturVida;Integrated Security=True");
        private SqlConnection conexion = new SqlConnection("Data Source=SQL5110.site4now.net;Initial Catalog=db_a982f7_naturvida;User Id=db_a982f7_naturvida_admin;Password=Naturvida123");
        public SqlConnection AbrirConexion()
        {
            if (conexion.State == ConnectionState.Closed)
                conexion.Open();
            return conexion;
        }
        public SqlConnection CerrarConexion()
        {
            if (conexion.State == ConnectionState.Open)
                conexion.Close();
            return conexion;
        }
    }
}
