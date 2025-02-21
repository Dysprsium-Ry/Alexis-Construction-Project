using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using AlexisConstructionProject.Objects;
using System.Runtime.CompilerServices;
using System.ComponentModel.Design;

namespace AlexisConstructionProject.Classes.functionsLogIn
{
    public class ClassLogIn
    {
        public static void signin()
        {
            using (SqlConnection connection = Sqlconnection.connection())
            {
                using (SqlCommand command = new SqlCommand("SELECT ID, Username FROM ACS.UserAccounts WHERE Username = @username AND Password = @password", connection))
                {
                    command.Parameters.AddWithValue("@username", UserCredentials.Username);
                    command.Parameters.AddWithValue("@password", UserCredentials.Password);
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        int rowCount = 0;
                        while (reader.Read())
                        {
                            rowCount++;
                            UserCredentials.ID = (Int64)reader["ID"];

                            if (rowCount != 0)
                            {

                                using (SqlCommand fetcher = new SqlCommand("SELECT * FROM ACS.UserAccounts WHERE ID = @id", connection))
                                {
                                    fetcher.Parameters.AddWithValue("@ID", UserCredentials.ID);

                                    while (reader.Read())
                                    {
                                        UserCredentials.FName = reader["FirstName"].ToString();
                                        UserCredentials.LName = reader["LastName"].ToString();
                                        UserCredentials.age = (int)reader["Age"];
                                        UserCredentials.gender = (char)reader["Gender"];
                                        UserCredentials.ProfileImage = (byte[])reader["ProfilePicture"];
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }

        public static void isAccountExist()
        {
            using (SqlConnection connection = Sqlconnection.connection())
            {
                using (SqlCommand command = new SqlCommand("SELECT Count(*) FROM ACS.UserAccounts WHERE ID = @id", connection))
                {
                    command.Parameters.AddWithValue("@id", UserCredentials.ID);
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Validities.isValid = true;
                        }
                    }
                }
            }
        }
    }
}
