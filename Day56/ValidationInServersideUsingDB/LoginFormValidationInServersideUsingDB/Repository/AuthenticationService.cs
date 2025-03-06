using Microsoft.Data.SqlClient;

namespace LoginFormValidationInServersideUsingDB.Repository
{
    public class AuthenticationService : IService
    {
        private string connectionString = "server=.\\sqlexpress;database=rrd_db1;Integrated security=true;TrustServerCertificate=true";

        public bool IsUserAvailable(string username)
        {
            bool isEmailExists = false;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand("SELECT COUNT(*) FROM Register WHERE Email = @Email", connection))
                {
                    command.Parameters.AddWithValue("@username", username);
                    isEmailExists = (int)command.ExecuteScalar() > 0;
                }
            }
            return isEmailExists;
        }
        

        public bool ValidateUser(string username, string password)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = "SELECT COUNT(*) FROM USERLOGIN WHERE username = @username AND userpwd = @userpwd";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@username", username);
                        command.Parameters.AddWithValue("@userpwd", password);

                        int count = (int)command.ExecuteScalar();
                        return count > 0;
                    }
                }
                catch (Exception ex)
                {
                    return false;
                }
            }
        }
    }
}