using System;

namespace Assessment2
{
    internal class Program
    {

        static void Main(string[] args)
        {
            BankAccocunt account = new BankAccocunt();
            Console.WriteLine("Enter name");
            account.AccountHolder = Console.ReadLine();
            Console.WriteLine("Enter Account number");
            account.AccountNumber = Int64.Parse(Console.ReadLine());
            Console.WriteLine("deposit or withdrawal?");

            String option = Console.ReadLine();
            if (option == "deposit")
            {
                Console.WriteLine("Enter deposit amount");
                account.DepositAmount = double.Parse(Console.ReadLine());
                account.AccountDeposit();
            }
            if(option == "withdrawal")
            {
                Console.WriteLine("Enter withdrawal amount");
                account.WithdrawalAmount = double.Parse(Console.ReadLine());
                account.AccountWithdraw();

            }

        }
    }
}
