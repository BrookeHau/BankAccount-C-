using System;

namespace ConsoleApp2
{
    class ATM_App
    {
        static void Main(string[] args)
        {

            Bank.BankClass account = new Bank.BankClass();
            int maxAttemptsAllowed = 3;
            int loginAttempts = 0;
           
             Console.WriteLine("Welcome to the ATM, please enter your password:");

            for (int i = 0; i < maxAttemptsAllowed; i++)
            {
                String password = Console.ReadLine();
                
                if (!(password.Equals(account.GetPassword())))
                {
                    Console.WriteLine("Wrong password, try again.");
                    loginAttempts++;

                }
                
                else
                {
                    break;
                }
                
            }
            if (loginAttempts > 2) {
                Console.WriteLine("login Failed");
                System.Environment.Exit(0);
               
            }
            Console.WriteLine("Would you like to: 1) Withdrawal 2) Deposit, or 3) Get your Balance");
            String inputRequest = Console.ReadLine();

            if (inputRequest.Equals("1"))
            {
                Console.WriteLine("How much would you like to withdrawal?");
                double withdrawalAmount = Convert.ToInt32(Console.ReadLine());
                account.WithdrawalMoney(withdrawalAmount);

            }

            Console.WriteLine(account.GetBalance());

        }
    }
}
