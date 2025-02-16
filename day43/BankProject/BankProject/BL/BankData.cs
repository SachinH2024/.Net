using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankProject.BL
{
    public class BankData
    {
        private string connectionString;

        public BankData(string connectionString)
        {
            this.connectionString = connectionString;
        }

        public void CreateDatabase()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand(@"
                CREATE TABLE BankAccount (
                    AccountNumber INT PRIMARY KEY,
                    Balance DECIMAL(18, 2)
                );

                CREATE TABLE BankTransaction (
                    TransactionId INT PRIMARY KEY,
                    AccountNumber INT,
                    Amount DECIMAL(18, 2),
                    TransactionType VARCHAR(50),
                    FOREIGN KEY (AccountNumber) REFERENCES BankAccount(AccountNumber)
                );
            ", connection))
                {
                    command.ExecuteNonQuery();
                }
            }
        }

        public void InsertSampleData()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand(@"
                INSERT INTO BankAccount (AccountNumber, Balance) VALUES (1, 1000);
                INSERT INTO BankAccount (AccountNumber, Balance) VALUES (2, 500);

                INSERT INTO BankTransaction (TransactionId, AccountNumber, Amount, TransactionType) VALUES (1, 1, 500, 'Deposit');
                INSERT INTO BankTransaction (TransactionId, AccountNumber, Amount, TransactionType) VALUES (2, 1, 200, 'Withdrawal');
                INSERT INTO BankTransaction (TransactionId, AccountNumber, Amount, TransactionType) VALUES (3, 2, 100, 'Deposit');
            ", connection))
                {
                    command.ExecuteNonQuery();
                }
            }
        }

        public List<BankAccount> GetAllBankAccounts()
        {
            List<BankAccount> accounts = new List<BankAccount>();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand("SELECT * FROM BankAccount", connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            int accountNumber = reader.GetInt32(0);
                            decimal balance = reader.GetDecimal(1);
                            accounts.Add(new BankAccount(accountNumber, balance));
                        }
                    }
                }
            }

            return accounts;
        }

        public List<BankTransaction> GetAllBankTransactions()
        {
            List<BankTransaction> transactions = new List<BankTransaction>();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand("SELECT * FROM BankTransaction", connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            int transactionId = reader.GetInt32(0);
                            int accountNumber = reader.GetInt32(1);
                            decimal amount = reader.GetDecimal(2);
                            string transactionType = reader.GetString(3);
                            transactions.Add(new BankTransaction(transactionId, accountNumber, amount, transactionType));
                        }
                    }
                }
            }

            return transactions;
        }
    }
}
