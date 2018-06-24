using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class ATM_App
    {
        static void Main(string[] args)
        {
            Bank.BankClass account = new Bank.BankClass();

            int loginAttempts = 0;

            for (int i = 0; i < 3; i++) {

                Console.WriteLine("Welcome to the ATM, please enter your password:");
                String password = Console.ReadLine();

                if (!(password.Equals(account.GetPassword()))){
                    Console.WriteLine("Wrong password, try again.");
                    loginAttempts++;
                }
                else {
                    break;
                }                
            }
            Console.WriteLine("Thank you, your balance is " + account.GetBalance());
        }
    }
}
