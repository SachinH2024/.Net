using EmployeeCRUDApp.Domain;

namespace EmployeeCRUDApp.Services
{
    public class EmployeeInMemoryService : IEmployeeService
    {

        private readonly List<Employee> _employees;

        public EmployeeInMemoryService()
        {

            Console.WriteLine("employee service created");
            _employees = new List<Employee>();

            _employees.Add(new Employee { Id = 1, Name = "Venkatesh", Salary = 1000 });
            _employees.Add(new Employee { Id = 2, Name = "Bala", Salary = 2000 });
            _employees.Add(new Employee { Id = 3, Name = "Prem", Salary = 3000 });
        }

        public IEnumerable<Employee> Get()
        {

            return _employees;
        }
        public int HeadCount()
        {
            return _employees.Count();
        }

        public Employee GetById(int id)
        {
            return _employees.SingleOrDefault(e => e.Id == id);

        }

        public void Add(Employee employee)
        {
            _employees.Add(employee);
        }

        public void Update(Employee employee)
        {
            var emp = GetById(employee.Id);
            if (emp != null)
            {
                emp.Salary = employee.Salary;
                emp.Name = employee.Name;
            }
            else
                throw new Exception("Employee Was not found");

        }

        public void Remove(int id)
        {
            var emp = GetById(id);
            if (emp != null)
                _employees.Remove(emp);
            else

                throw new Exception("Employee Was not found");


        }
    }
}