using System.ComponentModel.DataAnnotations;

namespace EmployeeCRUDWithDBApp.DTOs
{
    public class EmployeeEditDto
    {
        public int Id { get; set; }
        public string HeaderTitle { get; set; } = "";
        public string Message { get; set; } = "";

        [Required]
        public string Name { get; set; } = "";

        [Required]
        public decimal Salary { get; set; }
    }
}