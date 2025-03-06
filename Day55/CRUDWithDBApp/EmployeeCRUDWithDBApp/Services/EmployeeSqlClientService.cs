using System.Configuration;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Xml.Linq;
using EmployeeCRUDWithDBApp.Domain;
using EmployeeCRUDWithDBApp.Services;
using Microsoft.Extensions.Configuration;

namespace EmployeeCRUDApp.Services
{
    public class EmployeeSqlClientService : IEmployeeService
    {
         public void Add(Employee employee)
        {
            var constring = "server=.\\sqlexpress;database=rrd_db1;Integrated security=true;TrustServerCertificate=true";
            //var con = new SqlConnection(constring);
            var con = new SqlConnection(constring);
            var cmd = new SqlCommand("INSERT INTO EMPLOYEE (Id,Name,Salary) VALUES (@value1, @value2, @value3)", con);
            cmd.Parameters.AddWithValue("@value1", employee.Id);
            cmd.Parameters.AddWithValue("@value2", employee.Name);
            cmd.Parameters.AddWithValue("@value3", employee.Salary);
            con.Open();
            var reader = cmd.ExecuteNonQuery();
            con.Close(); ;
        }

        public IEnumerable<Employee> Get()
        {
            var constring = "server=.\\sqlexpress;database=rrd_db1;Integrated security=true;TrustServerCertificate=true";
            var con = new SqlConnection(constring);
            var cmd = new SqlCommand("select * from" + " Employee", con);
            con.Open();
            var reader = cmd.ExecuteReader();
            List<Employee> _employees = new List<Employee>();
            while (reader.Read())
            {
                _employees.Add(new Employee()
                {
                    Id = (int)reader["id"],
                    Name = (string)reader["Name"],
                    Salary = (decimal)reader["Salary"]


                }
                );
            }
            con.Close();
            return _employees;
        }

        public Employee GetById(int id)
        {

            var _employees = new Employee();
            var constring = "server=.\\sqlexpress;database=rrd_db1;Integrated security=true;TrustServerCertificate=true";
            var con = new SqlConnection(constring);
            var cmd = new SqlCommand($"SELECT * FROM Employee WHERE id={id}", con);
            con.Open();
            var reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                _employees.Id = (int)reader["id"];
                _employees.Name = (string)reader["Name"];
                _employees.Salary = (decimal)reader["Salary"];
            }
            con.Close();
            return _employees;

        }

        public int HeadCount()
        {
            int count = 0;
            var constring = "server=.\\sqlexpress;database=rrd_db1;Integrated security=true;TrustServerCertificate=true";
            using (var con = new SqlConnection(constring))
            {
                var cmd = new SqlCommand("SELECT COUNT(*) FROM EMPLOYEE", con);
                con.Open();
                count = (int)cmd.ExecuteScalar();
            }
            return count;
        }

        public void Remove(int id)
        {
            var conString = "server=.\\sqlexpress;database=rrd_db1;Integrated security=true; TrustServerCErtificate=true";
            var con = new SqlConnection(conString);
            var cmd = new SqlCommand($"delete employee where ID = {id}", con);
            try
            {
                con.Open();
                int rowsAffected = cmd.ExecuteNonQuery();
                      }
            catch (Exception ex)
            {
                throw new Exception("Employee Was not found");
            }
        }
        //var emp = GetById(id);
        //    if (emp != null)
        //    {
        //        var constring = "server=.\\sqlexpress;database=rrd_db1;Integrated security=true;TrustServerCertificate=true";
        //        var con = new SqlConnection(constring);
        //        var cmd = new SqlCommand($"DELETE FROM EMPLOYEE WHERE ID={id}", con);
        //        con.Open();
        //        var reader = cmd.ExecuteNonQuery();
        //        con.Close();

        //    }
        //    else

        //        throw new Exception("Employee Was not found");

        //}

        public void Update(Employee employee)
        {
            var emp = GetById(employee.Id);
            if (emp != null)
            {
                var constring = "server=.\\sqlexpress;database=rrd_db1;Integrated security=true;TrustServerCertificate=true";
                var con = new SqlConnection(constring);
                var cmd = new SqlCommand($"UPDATE Employee SET Name = '{employee.Name}',Salary= {employee.Salary} WHERE id={employee.Id}", con);
                con.Open();
                var reader = cmd.ExecuteNonQuery();
                con.Close();
            }
            else
                throw new Exception("Employee Was not found");
        }
    }
}