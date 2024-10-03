using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace WindowsFormsAppMagazine
{
    internal class dbConnector
    {
        private static string connString = @"Data Source = DESKTOP-QGQ7GHC; Initial Catalog = magazine_db; Integrated Security = true;";
        private static SqlConnection conn = new SqlConnection(connString);
        //@"Data Source=DESKTOP-QGQ7GHC;Initial Catalog=magazine_db;Integrated Security=true;"
        public static SqlConnection getConnect()
        {
            return new SqlConnection(connString);
        }
        public static SqlConnection openConnect()
        {
            if(conn.State == System.Data.ConnectionState.Closed)
                conn.Open();
            return conn;
        }
        public static SqlConnection closeConnect()
        {
            if(conn.State == System.Data.ConnectionState.Open)
                conn.Close();
            return conn;
        }
    }
}
