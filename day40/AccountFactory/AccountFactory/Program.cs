using AccountFactory.BL;

namespace AccountFactory
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create accounts using the AccountFactory
            SavingAccount savingAccount = (SavingAccount)AccountFactoryy.CreateAccount("saving", "SA123", 1000, 2.5);
            CurrentAccount currentAccount = (CurrentAccount)AccountFactoryy.CreateAccount("current", "CA456", 500, overdraftLimit: 500);

            // Perform operations on accounts
            savingAccount.Deposit(500);
            savingAccount.Withdraw(200);
            savingAccount.CalculateInterest();

            currentAccount.Deposit(200);
            currentAccount.Withdraw(1000);
            currentAccount.Withdraw(300);

            Console.ReadKey();
        }
    }
}
