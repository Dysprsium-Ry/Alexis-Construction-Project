using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;

namespace AlexisConstructionProject.Classes
{
    public static class DatabaseConnection
    {
        public static string ConnectionString => ConfigurationManager.ConnectionStrings["DbConnection"].ConnectionString;
    }

    public static class Sqlconnection
    {
        public static SqlConnection connection()
        {
            var Connection = new SqlConnection();
            Connection.Open();
            return Connection;
        }
    }
}
