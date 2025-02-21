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
                        //List<int> priceList = new List<int>();
                        while (reader.Read())
                        {
                            servicesList.Add(reader.GetString(0));
                            //priceList.Add(reader.GetInt32(1));
                        }
                        Items.services = servicesList.ToArray();
                        //Items.price = priceList.ToArray();
                    }
                }
            }
        }
    }
}
