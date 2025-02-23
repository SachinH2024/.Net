using FacadeDesignPatternApp.Models;

namespace FacadeDesignPatternApp
{
    public class Program
    {
        static void Main(string[] args)
        {
            Account account = new Account("Ammu", 5000);
            Transaction transaction = new Transaction();
            Notification notification = new Notification();


            BankFacade bankFacade = new BankFacade(account, transaction, notification);


            Console.WriteLine($"Initial balance: {account.Balance}");

            string depositMessage = bankFacade.DepositFunds(2000);
            Console.WriteLine(depositMessage);

            string withdrawMessage = bankFacade.WithdrawFunds(1500);
            Console.WriteLine(withdrawMessage);

            string withdrawMessage2 = bankFacade.WithdrawFunds(10000);
            Console.WriteLine(withdrawMessage2);

            Console.WriteLine($"Final balance: {account.Balance}");

        }
    }
}