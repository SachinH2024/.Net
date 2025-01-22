using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountDetails.Models
{
    public class Account
    {
        public string Name { get; set; }
        public decimal Balance { get; set; }

        public Account(string name, decimal balance)
        {
            Name = name;
            Balance = balance;
        }
    }

    public static class AccountExtensions
    {
        // 1. Find the richest account holder using LINQ
        public static Account RichestAccountHolder(this IEnumerable<Account> accounts)
        {
            return accounts.OrderByDescending(a => a.Balance).FirstOrDefault();
        }

        // 2. Find all account holders with name length >= 8 using LINQ
        public static IEnumerable<Account> FindAccountsWithLongNames(this IEnumerable<Account> accounts)
        {
            return accounts.Where(a => a.Name.Length >= 8);
        }

        // 3. Transfer balance between accounts
        public static void TransferBalance(this Account fromAccount, Account toAccount, decimal amount)
        {
            if (amount <= 0)
            {
                throw new ArgumentException("Amount to transfer must be positive.");
            }

            if (fromAccount.Balance < amount)
            {
                throw new InvalidOperationException("Insufficient balance in the fromAccount.");
            }

            fromAccount.Balance -= amount;
            toAccount.Balance += amount;
        }
    }
}
