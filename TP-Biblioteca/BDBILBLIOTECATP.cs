using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
using System.Data;

namespace TP_Biblioteca
{
    public class BDBILBLIOTECATP
    {
        public static DataTable Select(string sql)
        {
            string cadena = "Data Source=DESKTOP-1F3E5MP\\SQLEXPRESS;Initial Catalog=BIBLIOTECATP;Integrated Security=True;Trust Server Certificate=True";
            SqlConnection con = new SqlConnection(cadena);
            SqlCommand comando = new SqlCommand();
            comando.CommandText = sql;
            comando.Connection = con;
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = comando;
            DataSet ds = new DataSet();
            da.Fill(ds);
            return ds.Tables[0];
        }
        public static void Grabar(string sql)
        {
            string cadena = "Data Source=DESKTOP-1F3E5MP\\SQLEXPRESS;Initial Catalog=BIBLIOTECATP;Integrated Security=True;Trust Server Certificate=True";
            SqlConnection con = new SqlConnection(cadena);
            SqlCommand comando = new SqlCommand();
            comando.CommandText = sql;
            comando.Connection = con;

            con.Open();
            comando.ExecuteNonQuery();
            con.Close();
        }
    }
}
