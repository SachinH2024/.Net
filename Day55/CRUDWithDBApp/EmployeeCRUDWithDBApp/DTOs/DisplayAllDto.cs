using EmployeeCRUDWithDBApp.Domain;
using System.ComponentModel.DataAnnotations;

namespace EmployeeCRUDWithDBApp.DTOs
{
    //model to the view
    public class DisplayAllDto
    {

        public int Count { get; set; }
        public string HeaderTitle { get; set; }

        public List<Employee> Employees { get; set; }

    }
}