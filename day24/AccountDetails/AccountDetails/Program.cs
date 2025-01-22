using System.Security.Principal;
using System;
using AccountDetails.Models;

namespace AccountDetails
{
    class Program
    {
        public static void Main(string[] args)
        {
            // Create an array of account holders
            Account[] accounts =
            {
                new Account("Alice", 1000),
                new Account("Bob", 2000),
                new Account("Charlie", 500),
                new Account("David", 3000),
                new Account("Emily", 1500),
                new Account("VeryLongName", 4000)
             };

            // 1. Find the richest account holder
            Account richest = accounts.RichestAccountHolder();
            Console.WriteLine($"Richest account holder: {richest.Name} with balance: {richest.Balance}");

            // 2. Find all account holders with long names
            IEnumerable<Account> longNameAccounts = accounts.FindAccountsWithLongNames();
            Console.WriteLine("Account holders with long names:");
            foreach (Account account in longNameAccounts)
            {
                Console.WriteLine(account.Name);
            }

            // 3. Transfer balance
            try
            {
                accounts[0].TransferBalance(accounts[1], 1000);
                Console.WriteLine("Balance transferred successfully.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }
    }
}
