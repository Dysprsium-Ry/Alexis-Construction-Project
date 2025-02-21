using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using AlexisConstructionProject.Objects;

namespace AlexisConstructionProject.Classes
{
    public class DataProvider
    {
        public static void Services()
        {
            using (SqlConnection connection = Sqlconnection.connection())
            {
                using (SqlCommand command = new SqlCommand("SELECT * FROM ACS.Services", connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        List<string> servicesList = new List<string>();
                        while (reader.Read())
                        {
                            servicesList.Add(reader.GetString(0));
                        }
                        Items.services = servicesList.ToArray();
                    }
                }
            }
        }
    }
}
