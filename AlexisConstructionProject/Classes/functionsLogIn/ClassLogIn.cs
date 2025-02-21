using AlexisConstructionProject.Objects;
using ComponentFactory.Krypton.Toolkit;
using System;
using System.Data.SqlClient;

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

    public class validation
    {
        public static void isAccountExist()
        {
            using (SqlConnection connection = Sqlconnection.connection())
            {
                using (SqlCommand command = new SqlCommand("SELECT Count(*) FROM ACS.UserAccounts WHERE Username = @username", connection))
                {
                    command.Parameters.AddWithValue("@username", CreateUser.username);

                    int isExist = (int)command.ExecuteScalar();

                    if (isExist != 0) Validities.isPresent = true;
                }
            }
        }
    }

    public class UserCreation
    {
        public static void createUser()
        {
            validation.isAccountExist();

            if (!(Validities.isPresent))
            {
                using (SqlConnection connection = Sqlconnection.connection())
                {
                    using (SqlCommand command = new SqlCommand("INSERT INTO ACS.UserAccounts (Username, Password, FirstName, LastName, Age, Gender) VALUES(@username, @password, @fname, @lname, @age, @gender)", connection))
                    {
                        command.Parameters.AddWithValue("@username", CreateUser.username);
                        command.Parameters.AddWithValue("@password", CreateUser.password);
                        command.Parameters.AddWithValue("@fname", CreateUser.fname);
                        command.Parameters.AddWithValue("@lname", CreateUser.lname);
                        command.Parameters.AddWithValue("@age", CreateUser.age);
                        command.Parameters.AddWithValue("@gender", CreateUser.gender);
                        command.ExecuteNonQuery();
                    }
                }
            }
            else { System.Windows.Forms.MessageBox.Show("Account Already Existing", "Registration Error", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error); }
        }
    }
}
