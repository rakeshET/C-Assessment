using System;

namespace Assessment2
{
    public class BankAccocunt
    {
        public String AccountHolder;
        public long AccountNumber;
        public double DepositAmount;
        public double WithdrawalAmount;
        public Double AccountBalance = 1000;

        public void AccountDeposit()
        {
            if (DepositAmount > 0)
            {
                AccountBalance += DepositAmount;
                Console.WriteLine("Name :{0}\n," +
                    "AccountNumber : {1}\n," +
                    "Account Balance :{2}", AccountHolder, AccountNumber, AccountBalance);
            }
            else
            {
                Console.WriteLine("Invalid Deposit Amount");
            }
        }
        public void AccountWithdraw()
        {
            if (WithdrawalAmount > 0 && WithdrawalAmount <= AccountBalance)
            {
                Console.WriteLine("Name :{0}\n," +
                    "AccountNumber : {1}\n," +
                    "Account Balance :{2}", AccountHolder, AccountNumber, AccountBalance);
            }
            else
            {
                Console.WriteLine("No sufficient balance");
            }
        }



    }
}
