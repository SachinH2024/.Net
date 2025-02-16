using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankProject.BL
{
    public class BankAccount
    {
        public int AccountNumber { get; set; }
        public decimal Balance { get; set; }

        public BankAccount(int accountNumber, decimal balance)
        {
            AccountNumber = accountNumber;
            Balance = balance;
        }
    }
}
