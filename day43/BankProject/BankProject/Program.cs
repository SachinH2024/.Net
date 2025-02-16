using BankProject.BL;

namespace BankProject
{
    public class Program
    {
        static void Main(string[] args)
        {
            string connectionString = "server=.\\sqlexpress;database=Bank;Integrated security=true;TrustServerCertificate=true"; 

            BankData bankData = new BankData(connectionString);
            bankData.CreateDatabase();
            bankData.InsertSampleData();

            List<BankAccount> accounts = bankData.GetAllBankAccounts();
            foreach (BankAccount account in accounts)
            {
                Console.WriteLine($"Account Number: {account.AccountNumber}, Balance: {account.Balance}");
            }

            List<BankTransaction> transactions = bankData.GetAllBankTransactions();
            foreach (BankTransaction transaction in transactions)
            {
                Console.WriteLine($"Transaction ID: {transaction.TransactionId}, Account Number: {transaction.AccountNumber}, Amount: {transaction.Amount}, Type: {transaction.TransactionType}");
            }
        }
    }
}
