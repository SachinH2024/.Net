using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadeDesignPatternApp.Models
{
    public class Transaction
    {
        public string Deposit(Account account, decimal amount)
        {
            return account.Deposit(amount);
        }

        public string Withdraw(Account account, decimal amount)
        {
            return account.Withdraw(amount);
        }
    }
}