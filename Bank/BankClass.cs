using System;

namespace Bank
{
    public class BankClass
    {
        private double balance = 150;
        private double overdraftfee = 5;
        private String BankAcctPassword = "1234";

        public String GetPassword() {
            return BankAcctPassword;
        }
       
        public void DepositMoney(double depositamount)
        {
            balance += depositamount;
        }


        public void WithdrawalMoney(double withdrawalamount)
        {
            if (withdrawalamount > balance)
            {
                balance -= (withdrawalamount + overdraftfee);
            }
            else
            {
                balance -= withdrawalamount;
            }
        }
        public double GetBalance()
        {
           return balance;
        }
    }
}