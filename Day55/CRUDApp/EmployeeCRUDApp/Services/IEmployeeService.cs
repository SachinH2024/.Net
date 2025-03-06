using EmployeeCRUDApp.Domain;

namespace EmployeeCRUDApp.Services
{
    public interface IEmployeeService
    {
        void Add(Employee employee);
        Employee GetById(int id);
        int HeadCount();
        void Remove(int id);
        void Update(Employee employee);
        public IEnumerable<Employee> Get();
    }
}