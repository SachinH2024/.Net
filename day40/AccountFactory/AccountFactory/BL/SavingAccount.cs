using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountFactory.BL
{
    public class SavingAccount : Account
    {
        public double InterestRate { get; set; }

        public SavingAccount(string accountNumber, double balance, double interestRate)
            : base(accountNumber, balance)
        {
            InterestRate = interestRate;
        }

        public void CalculateInterest()
        {
            double interest = Balance * (InterestRate / 100);
            Balance += interest;
            Console.WriteLine($"Interest calculated: {interest}. New balance: {Balance}");
        }
    }
}
