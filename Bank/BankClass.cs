using System;

namespace Bank
{
    public class BankClass
    {
        private double balance;

        public string EnterPassword(Password password)
        {
            if (password.GetLength() < 8)
            {
                return "password is too short";
            }
            return "password is okay";
        }

        public void DepositMoney(int depositamount)
        {
            balance += depositamount;
        }

        public double GetBalance()
        {
            return balance;
        }

        public void WithdrawalMoney(int withdrawalamount)
        {
            balance -= withdrawalamount;
        }
    }
}