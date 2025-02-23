using EmployeeObjectwithLINQApp.Models;
using Microsoft.Data.SqlClient;

namespace EmployeeObjectwithLINQApp
{
    internal class Program
    {
        static string connectionString = "server=.\\sqlexpress;database=rrd_db1;Integrated security=true;TrustServerCertificate=true";

        public static void Main()
        {

            List<Employee> employees = GetEmployeesFromDatabase();

            // Call methods to display results
            DisplayEmployeesInDept10OrderedByName(employees);
            DisplayEmployeesInDept10Or20(employees);
            DisplayManagers(employees);
            DisplayEmployeesWithoutCommission(employees);
        }

        // Fetch employees from the database using ADO.NET
        public static List<Employee> GetEmployeesFromDatabase()
        {
            List<Employee> employees = new List<Employee>();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string query = "SELECT EMPNO, ENAME, JOB, MGR, HIREDATE, SAL, COMM, DEPTNO FROM EMP";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    SqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        employees.Add(new Employee
                        {
                            EmpNo = reader.GetInt32(0),
                            EName = reader.GetString(1),
                            Job = reader.GetString(2),
                            Mgr = reader.IsDBNull(3) ? (int?)null : reader.GetInt32(3),
                            HireDate = reader.GetDateTime(4),
                            Sal = reader.GetDecimal(5),
                            Comm = reader.IsDBNull(6) ? (decimal?)null : reader.GetDecimal(6),
                            DeptNo = reader.GetInt32(7)
                        });
                    }
                }
            }

            return employees;
        }

        // Display Employees in DeptNo 10, ordered by name descending
        static void DisplayEmployeesInDept10OrderedByName(List<Employee> employees)
        {
            var result = employees
                .Where(e => e.DeptNo == 10)
                .OrderByDescending(e => e.EName)
                .ToList();

            Console.WriteLine("Employees in Department 10 (Ordered by name descending):");
            foreach (var emp in result)
            {
                Console.WriteLine($"Name: {emp.EName}, Salary: {emp.Sal:C}, Commission: {emp.Comm:C}, DeptNo: {emp.DeptNo}");
            }

            Console.WriteLine();
        }

        // Display Employees in DeptNo 10 or 20
        static void DisplayEmployeesInDept10Or20(List<Employee> employees)
        {
            var result = employees
                .Where(e => e.DeptNo == 10 || e.DeptNo == 20)
                .ToList();

            Console.WriteLine("Employees in Department 10 or 20:");
            foreach (var emp in result)
            {
                Console.WriteLine($"Name: {emp.EName}, DeptNo: {emp.DeptNo}");
            }

            Console.WriteLine();
        }

        // Display Managers
        static void DisplayManagers(List<Employee> employees)
        {
            var result = employees
                .Where(e => e.Job == "MANAGER")
                .ToList();

            Console.WriteLine("Employees who are Managers:");
            foreach (var emp in result)
            {
                Console.WriteLine($"Name: {emp.EName}, Job: {emp.Job}, DeptNo: {emp.DeptNo}");
            }

            Console.WriteLine();
        }

        // Display Employees who do not have a commission
        static void DisplayEmployeesWithoutCommission(List<Employee> employees)
        {
            var result = employees
                .Where(e => e.Comm == null)
                .ToList();

            Console.WriteLine("Employees who do not have a commission:");
            foreach (var emp in result)
            {
                Console.WriteLine($"Name: {emp.EName}, Salary: {emp.Sal:C}, Commission: {emp.Comm}, DeptNo: {emp.DeptNo}");
            }

            Console.WriteLine();
        }
    }
}