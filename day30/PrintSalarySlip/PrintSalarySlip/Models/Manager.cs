using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrintSalarySlip.Models
{
    class Manager : Employee
    {
        public decimal Hra { get; set; }
        public decimal Ta { get; set; }

        public Manager(string name, decimal basicPayment, decimal hra, decimal ta) : base(name, basicPayment)
        {
            Hra = hra;
            Ta = ta;
        }

        public override decimal CalculateSalary()
        {
            return BasicPayment * 0.5M + Hra + Ta;
        }
    }
}
