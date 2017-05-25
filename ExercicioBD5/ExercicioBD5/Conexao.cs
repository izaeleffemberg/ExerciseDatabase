using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace ExercicioBD5
{
    class Conexao
    {
        private static SqlConnection con;

        public static SqlConnection ConAbrir()
        {
            if (con == null)
            {
                con = new SqlConnection("server=USER-PC; User=sa; Password=senha;Database=exercicioBD5");

            }
            if (con.State == System.Data.ConnectionState.Closed)
            {
                con.Open();
            }
            return con;
        }
        public static SqlConnection ConFechar()
        {
            if (con != null & con.State != System.Data.ConnectionState.Closed)
            {
                con.Close();
            }
            return con;
        }
        public static bool ConEstaAberta()
        {
            if (con == null)
            {
                return false;
            }
            else
            {
                if (con.State == System.Data.ConnectionState.Open)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }
    }
}
