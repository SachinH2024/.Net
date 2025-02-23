using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadeDesignPatternApp.Models
{
    public class Account
    {
        public string AccountHolder { get; set; }
        public decimal Balance { get; private set; }

        public Account(string accountHolder, decimal initialBalance)
        {
            AccountHolder = accountHolder;
            Balance = initialBalance;
        }

        public string Deposit(decimal amount)
        {
            Balance += amount;
            return $"Deposited {amount}. New balance: {Balance}";
        }

        public string Withdraw(decimal amount)
        {
            if (Balance >= amount)
            {
                Balance -= amount;
                return $"Withdrew {amount}. New balance: {Balance}";
            }
            else
            {
                return "Insufficient funds!";
            }
        }
    }
}