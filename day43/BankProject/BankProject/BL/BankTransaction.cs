using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankProject.BL
{
    public class BankTransaction
    {
        public int TransactionId { get; set; }
        public int AccountNumber { get; set; }
        public decimal Amount { get; set; }
        public string TransactionType { get; set; }

        public BankTransaction(int transactionId, int accountNumber, decimal amount, string transactionType)
        {
            TransactionId = transactionId;
            AccountNumber = accountNumber;
            Amount = amount;
            TransactionType = transactionType;
        }
    }
}
