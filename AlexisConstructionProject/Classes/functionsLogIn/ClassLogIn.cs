using AlexisConstructionProject.Objects;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

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
            else { MessageBox.Show("Account Already Existing", "Registration Error", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error); }
        }

        public static void deleteUser(DataGridView datagrid)
        {
            if (MessageBox.Show("Delete the Record? You cannot undo this action.", "Notice!", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {

                if (datagrid.SelectedRows.Count > 0)
                {
                    DataGridViewRow selectedRow = datagrid.CurrentRow;

                    long? id = selectedRow.Cells["ID"].Value as long?;

                    using (SqlConnection connection = Sqlconnection.connection())
                    {
                        using (SqlCommand delete = new SqlCommand($"DELETE FROM ACS.UserAccounts WHERE ID = {id}", connection))
                        {
                            delete.ExecuteNonQuery();

                            MessageBox.Show("Successfully Deleted Record!", "Notice!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }
                    }
                }
            }
        }
    }

    public class booking
    {
        public static void registerBooking()
        {
            using (SqlConnection connection = Sqlconnection.connection())
            {
                using (SqlCommand command = new SqlCommand("SELECT DateBooked FROM ACS.registerBooking WHERE DateBooked = @datebooked", connection))
                {
                    command.Parameters.AddWithValue("@datebooked", selectedItem.DateBooked);
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Validities.isValid = true;
                        }
                    }
                }

                if (!(Validities.isValid))
                {
                    using (SqlCommand command = new SqlCommand("INSERT INTO ACS.registerBooking (Service, DateBooked, RentalDuration, Fee, TotalFee) VALUES(@service, @datebooked, @rentalduration, @fee, @totalfee);", connection))
                    {
                        command.Parameters.AddWithValue("@service", selectedItem.service);
                        command.Parameters.AddWithValue("@datebooked", selectedItem.DateBooked);
                        command.Parameters.AddWithValue("@rentalduration", selectedItem.duration);
                        command.Parameters.AddWithValue("@fee", Items.price);
                        command.Parameters.AddWithValue("@TotalFee", selectedItem.TotalFee);
                        command.ExecuteNonQuery();
                        MessageBox.Show("Booking Complete wait for further update on request.", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                    using (SqlCommand command = new SqlCommand("INSERT INTO ACS.BillingTransaction (TransactionID, DateBooked, TotalFee) VALUES(@Id, @datebooked, @totalfee)", connection))
                    {
                        //command.Parameters.AddWithValue("@Id", );
                        ////command.Parameters.AddWithValue("@", )
                        command.Parameters.AddWithValue("@DateBooked", selectedItem.DateBooked);
                        command.Parameters.AddWithValue("@TotalFee", selectedItem.TotalFee);
                        command.ExecuteNonQuery();
                    }
                }
                else { MessageBox.Show("Date is scheduled reserve for other day", "Invalid Booking", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); }
            }
        }
    }

    public class DataGrids
    {
        public static void transactionLogs(DataGridView datagrid)
        {
            using (SqlConnection connection = Sqlconnection.connection())
            {
                using (SqlCommand command = new SqlCommand("SELECT Service, DateBooked, RentalDuration, Fee, TotalFee FROM ACS.registerBooking", connection))
                {
                    using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                    {
                        DataTable table = new DataTable();
                        adapter.Fill(table);
                        datagrid.AutoGenerateColumns = true;
                        datagrid.DataSource = table;
                    }
                }
            }
        }

        public static void AvailableServices(DataGridView datagrid)
        {
            using (SqlConnection connection = Sqlconnection.connection())
            {
                using (SqlCommand command = new SqlCommand("SELECT Service, Tool FROM ACS.Tools ORDER BY Service", connection))
                {
                    using (SqlDataAdapter dapter = new SqlDataAdapter(command))
                    {
                        DataTable table = new DataTable();
                        dapter.Fill(table);
                        datagrid.AutoGenerateColumns = true;
                        datagrid.DataSource = table;
                    }
                }
            }
        }

        public static void clientLists(DataGridView datagrid)
        {
            using (SqlConnection connection = Sqlconnection.connection())
            {
                using (SqlCommand command = new SqlCommand("SELECT * FROM ACS.UserAccounts", connection))
                {
                    using (SqlDataAdapter dapter = new SqlDataAdapter(command))
                    {
                        DataTable table = new DataTable();
                        dapter.Fill(table);
                        datagrid.AutoGenerateColumns = true;
                        datagrid.DataSource = table;
                    }
                }
            }

        }

        public static void transactionBilling(DataGridView datagrid)
        {
            using(SqlConnection connection = Sqlconnection.connection())
            {
                using (SqlCommand command = new SqlCommand("SELECT * FROM ACS.TransactionBilling", connection))
                {
                    using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                    {
                        DataTable table = new DataTable();
                        adapter.Fill(table);
                        datagrid.AutoGenerateColumns = true;
                        datagrid.DataSource = table;
                    }
                }
            }  
        }
    }
}
