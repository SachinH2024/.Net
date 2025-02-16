using System.Net;
using System.Xml.Serialization;
using Microsoft.Data.SqlClient;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {

           // CaseStudy1();
            CaseStudy2();

        }

        private static void CaseStudy2()
        {
            var connectionString = "server=.\\sqlexpress;database=rrd_db1;Integrated security=true;TrustServerCertificate=true";
            var con = new SqlConnection(connectionString);
            var cmd = new SqlCommand("select * from" +
                " product", con);
            con.Open();
            
            AddProduct("Laptop1",10,1200);
            DeleteProduct(1);
            
            var reader = cmd.ExecuteReader();
            while (reader.Read())
            {
               Console.WriteLine(reader["name"]);
                Console.WriteLine(reader["quantity"]);
                Console.WriteLine(reader["price"]);

            }

            con.Close();

        }

        private static void AddProduct(string name, int quntity, int price)
        {
            var connectionString = "server=.\\sqlexpress;database=rrd_db1;Integrated security=true;TrustServerCertificate=true";
            var con = new SqlConnection(connectionString);
            //var cmd = new SqlCommand("select * from" +
            //    " product", con);
            
            //con.Open();
            string query = "INSERT INTO Product(name,quantity,price) VALUES (@name,@quantity,@price)";
            var cmd = new SqlCommand(query, con);
            con.Open();
            
            cmd.Parameters.AddWithValue("@name", name);
            cmd.Parameters.AddWithValue("@quantity", quntity);
            cmd.Parameters.AddWithValue("@price", price);
            cmd.ExecuteNonQuery();

            Console.WriteLine("Product Updated");
            
            con.Close();

        }

        private static void DeleteProduct(int id)
        {
            var connectionString = "server=.\\sqlexpress;database=rrd_db1;Integrated security=true;TrustServerCertificate=true";
            var con = new SqlConnection(connectionString);
            //var cmd = new SqlCommand("select * from" +
            //    " product", con);

            //con.Open();
            string query = "DELETE FROM Product WHERE Id  =@Id";
            var cmd = new SqlCommand(query, con);
            con.Open();

            cmd.Parameters.AddWithValue("@Id", id);
            cmd.ExecuteNonQuery();

            Console.WriteLine("Product Deleted");
            con.Close();

        }

        
    }
}
