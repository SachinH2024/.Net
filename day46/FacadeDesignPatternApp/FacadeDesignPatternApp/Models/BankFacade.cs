using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace FacadeDesignPatternApp.Models
{
    public class BankFacade
    {
        private Account _account;
        private Transaction _transaction;
        private Notification _notification;

        public BankFacade(Account account, Transaction transaction, Notification notification)
        {
            _account = account;
            _transaction = transaction;
            _notification = notification;
        }

        public string DepositFunds(decimal amount)
        {
            string transactionResult = _transaction.Deposit(_account, amount);
            string notificationResult = _notification.SendNotification($"Deposited {amount} to account {_account.AccountHolder}.");
            return $"{transactionResult}\n{notificationResult}";
        }

        public string WithdrawFunds(decimal amount)
        {
            string transactionResult = _transaction.Withdraw(_account, amount);
            string notificationResult = "";

            if (_account.Balance >= amount)
            {
                notificationResult = _notification.SendNotification($"Withdrew {amount} from account {_account.AccountHolder}.");
            }

            return $"{transactionResult}\n{notificationResult}";
        }

        public decimal GetBalance()
        {
            return _account.Balance;
        }
    }
}