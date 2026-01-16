using BankLibrary;
namespace BankApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            //Bank bank = new Bank("kavi");
            //Console.WriteLine($"hi {bank.AccountName}  your account balance is {bank.Balance} and account number is { bank.AccountNumber}");

            //bank.Deposit(10000);
            //Console.WriteLine($"hi {bank.AccountName}  your account balance is {bank.Balance} and account number is {bank.AccountNumber}");
            //bank.WithDraw(500);
            //Console.WriteLine($"hi {bank.AccountName}  your account balance is {bank.Balance} and account number is {bank.AccountNumber}");
            //Bank bank1 = new Bank("kavi");
            //Console.WriteLine($"hi {bank1.AccountName}  your account balance is {bank1.Balance} and account number is {bank1.AccountNumber}");

            //bank.Deposit(10000);
            //Console.WriteLine($"hi {bank.AccountName}  your account balance is {bank.Balance} and account number is {bank.AccountNumber}");
            //bank.WithDraw(500);
            //Console.WriteLine($"hi {bank.AccountName}  your account balance is {bank.Balance} and account number is {bank.AccountNumber}");
            //Console.ReadLine();
            //Console.ReadLine();
            try
            {
                //SavingAccount savingAccount = new SavingAccount("kavi", true);
                //Console.WriteLine(savingAccount);
                //savingAccount.Deposit(10000);
                //Console.WriteLine(savingAccount);
                //savingAccount.WithDraw(15000);
                //Console.WriteLine(savingAccount);

                CurrentAccount currentaccount = new CurrentAccount("kavi", 3000);
                Console.WriteLine(currentaccount);
                currentaccount.Deposit(2000);
                Console.WriteLine(currentaccount);
                currentaccount.WithDraw(6500);
                Console.WriteLine(currentaccount);


            }
            catch (BalanceException ex)
            {
                Console.WriteLine(ex.ToString());

            }
            finally
            {
                Console.WriteLine("successfull");
            }

            Console.ReadKey();
        }
    }
}
