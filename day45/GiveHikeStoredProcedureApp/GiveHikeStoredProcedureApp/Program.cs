using Microsoft.Data.SqlClient;

namespace GiveHikeStoredProcedureApp
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter Department number:");
            int deptNo = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter hike percentage:");
            float hikePercentage = float.Parse(Console.ReadLine());

            string connectionString = "server=.\\sqlexpress;database=rrd_db1;Integrated security=true;TrustServerCertificate=true";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand("usp_givehike", connection))
                    {
                        command.CommandType = System.Data.CommandType.StoredProcedure;

                        command.Parameters.AddWithValue("@DeptNo", deptNo);
                        command.Parameters.AddWithValue("@HikePercentage", hikePercentage);

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            Console.WriteLine("EMPNO\tENAME\tDEPTNO\tSAL\tCOMM");
                            while (reader.Read())
                            {
                                Console.WriteLine($"{reader["EMPNO"]}\t{reader["ENAME"]}\t{reader["DEPTNO"]}\t{reader["SAL"]}\t{reader["COMM"]}");
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error: " + ex.Message);
                }
            }

        }
    }
}