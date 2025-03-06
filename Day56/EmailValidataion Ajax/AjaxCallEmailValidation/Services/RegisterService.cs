using Microsoft.Data.SqlClient;

namespace AjaxCallEmailValidation.Services
{
    public class RegisterService : IRegisterService
    {
        private readonly string _connectionString;

        public RegisterService(IConfiguration configuration)
        {
            _connectionString = configuration.GetConnectionString("DefaultConnection");
        }

        public bool IsEmailExists(string email)
        {
            bool isEmailExists = false;
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand("SELECT COUNT(*) FROM Register WHERE Email = @Email", connection))
                {
                    command.Parameters.AddWithValue("@Email", email);
                    isEmailExists = (int)command.ExecuteScalar() > 0;
                }
            }
            return isEmailExists;
        }
    }
}