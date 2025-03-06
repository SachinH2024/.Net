using System.ComponentModel.DataAnnotations;

namespace EmployeeCRUDWithDBApp.DTOs
{
    public class EmployeeAddDto
    {

        public int Id { get; set; } = 0;
        public string HeaderTitle { get; set; } = "";
        public string Message { get; set; } = "";

        [Required]
        public string Name { get; set; } = "";

        [Required]
        public decimal Salary { get; set; }

    }
}