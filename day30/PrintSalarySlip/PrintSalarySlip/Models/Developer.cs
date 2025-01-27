using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrintSalarySlip.Models
{
    class Developer : Employee
    {
        public decimal Pa { get; set; }

        public Developer(string name, decimal basicPayment, decimal pa) : base(name, basicPayment)
        {
            Pa = pa;
        }

        public override decimal CalculateSalary()
        {
            return BasicPayment * 0.4M + Pa;
        }
    }
}
