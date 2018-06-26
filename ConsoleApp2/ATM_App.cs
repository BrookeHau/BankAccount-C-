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
                    if (loginAttempts == 2) {
                        Console.WriteLine("Login Failed");
                        break;
                    }
                    Console.WriteLine("Wrong password, try again. You have " + (maxAttemptsAllowed-1-loginAttempts) + " left");
                    loginAttempts++;

                }
                
                else
                {
                    break;
                }
                
            }
            if (loginAttempts >= 2) {
                Console.WriteLine("login Failed");
                System.Environment.Exit(0);
               
            }

            Start:
            Console.WriteLine("Would you like to: 1) Withdrawal 2) Deposit, or 3) Get your Balance");
            String inputRequest = Console.ReadLine();

            if (inputRequest.Equals("1"))
            {
                Console.WriteLine("How much would you like to withdrawal?");
                double withdrawalAmount = Convert.ToInt32(Console.ReadLine());
                account.WithdrawalMoney(withdrawalAmount);
                Console.WriteLine("After withdrawing $"+ withdrawalAmount + ", your balance is " + account.GetBalance());

            }

            if (inputRequest.Equals("2")) {
                Console.WriteLine("How much would you like to deposit?");
                double depositAmount = Convert.ToInt32(Console.ReadLine());
                account.DepositMoney(depositAmount);
                Console.WriteLine("After depositing $" + depositAmount + ", your balance is " + account.GetBalance());
            }

            if (inputRequest.Equals("3")) {
                Console.WriteLine("Your balance is " + account.GetBalance());
            }
            Console.WriteLine("Thank you, would you like to do anything else: Y or N");
            string inputrequest2 = Console.ReadLine();
            if (inputrequest2.Equals("Y")) {
                goto Start;
            }
            

        }
    }
}
