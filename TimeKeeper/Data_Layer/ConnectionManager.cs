using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace TimeKeeper.Data_Layer
{
    public class ConnectionManager
    {
        /* Establishing connection between the application and database
         * Instantiating SqlConnection object */
        public static SqlConnection DatabaseConnection()
        {
            string connection = "Data Source=JOCELYN\\SQLEXPRESS;Initial Catalog=TimeKeeper;User ID=sa;Password=sqlexpress";
            SqlConnection conn = new SqlConnection(connection);
            return conn;
        }


    }
}
