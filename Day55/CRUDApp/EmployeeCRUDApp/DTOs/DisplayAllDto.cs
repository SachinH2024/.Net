using EmployeeCRUDApp.Domain;

namespace EmployeeCRUDApp.DTOs
{
    //model to the view
    public class DisplayAllDto
    {

        public int Count { get; set; }
        public string HeaderTitle { get; set; }

        public List<Employee> Employees { get; set; }

    }
}