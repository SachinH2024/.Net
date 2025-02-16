using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountFactory.BL
{
    public class AccountFactoryy
    {
        public static Account CreateAccount(string accountType, string accountNumber, double balance, double interestRate = 0, double overdraftLimit = 0)
        {
            switch (accountType.ToLower())
            {
                case "saving":
                    return new SavingAccount(accountNumber, balance, interestRate);
                case "current":
                    return new CurrentAccount(accountNumber, balance, overdraftLimit);
                default:
                    throw new ArgumentException("Invalid account type.");
            }
        }
    }
}
