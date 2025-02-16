using System.Data.SqlClient;

namespace SQLInjection
{
    public class UserAuthentication
    {
        private string connectionString; 

        public UserAuthentication(string connectionString)
        {
            this.connectionString = connectionString;
        }

        public bool AuthenticateUser(string userId, string password)
        {
            
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    
                    string query = "SELECT COUNT(*) FROM Appuser WHERE userid = @UserId AND password = @Password";


                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        
                        command.Parameters.Add("@UserId", System.Data.SqlDbType.VarChar).Value = userId;
                        command.Parameters.Add("@Password", System.Data.SqlDbType.VarChar).Value = password;



                        int count = (int)command.ExecuteScalar();
                        return count > 0;
                    }
                }
            
        }


        public static void Main(string[] args)
        {
            
            string connectionString = "server=.\\sqlexpress;database=Training_db;Integrated security=true;TrustServerCertificate=true"; ; // Replace with your actual connection string.

            UserAuthentication auth = new UserAuthentication(connectionString);

            Console.Write("Enter User ID: ");
            string userId = Console.ReadLine();
            Console.Write("Enter Password: ");
            string password = Console.ReadLine();

            if (auth.AuthenticateUser(userId, password))
            {
                Console.WriteLine("Authentication successful!");
            }
            else
            {
                Console.WriteLine("Authentication failed.");
            }

            Console.ReadKey();
        }
    }
}
