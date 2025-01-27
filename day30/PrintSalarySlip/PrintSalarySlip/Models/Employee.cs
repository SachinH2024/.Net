using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrintSalarySlip.Models
{
    class Employee
    {
        public string Name { get; set; }
        public decimal BasicPayment { get; set; }

        public Employee(string name, decimal basicPayment)
        {
            Name = name;
            BasicPayment = basicPayment;
        }

        public virtual decimal CalculateSalary()
        {
            return 0; // Base class doesn't have a default salary calculation
        }

        public void PrintSalarySlip()
        {
            Console.WriteLine($"Employee Name: {Name}");
            Console.WriteLine($"Basic Payment: {BasicPayment}");
            Console.WriteLine($"Total Salary: {CalculateSalary()}");
        }
    }
}
