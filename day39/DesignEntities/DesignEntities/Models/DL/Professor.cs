using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignEntities.Models.DL
{
    public class Professor : Person, ISalierdEmployee
    {
        public decimal BaseSalary { get; set; } // Or monthly salary
        public int YearsOfExperience { get; set; }
        public string Department { get; set; }  //Add department for professor

        public decimal CalculateSalary()
        {
            // Example salary calculation logic (customize as needed)
            decimal salary = BaseSalary;

            if (YearsOfExperience > 5)
            {
                salary += BaseSalary * 0.10M; // 10% bonus for experience
            }
            if (Department == "Computer Science") //Example department based bonus
            {
                salary += 5000; //Fixed bonus for CS department
            }
            return salary;
        }
    }
}
