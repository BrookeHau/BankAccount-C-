using System;
using Bank;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BankTests_
{
    [TestClass]
    public class BankAccountTest
    {
                
       [TestMethod]
        public void DeterminePasswordIsLongEnough()
        {
            Password password = new Password("12as12de!");
            BankClass bankacct = new BankClass();
            String actual = bankacct.EnterPassword(password);
            Assert.AreEqual("password is okay", actual);
        }

        [TestMethod]
        public void PasswordNotLongEnough()
        {
            Password password = new Password("123");
            BankClass bankacct = new BankClass();
            String actual = bankacct.EnterPassword(password);
            Assert.AreEqual("password is too short", actual);
        }

        [TestMethod]
        public void GetLength() {
            Password password = new Password("1234");
            double length = password.GetLength();
            Assert.AreEqual(4, length);
        }

        [TestMethod]
        public void DepositAndGetAcctBalance() {
            BankClass acct = new BankClass();
            acct.DepositMoney(5);
            double bal = acct.GetBalance();
            Assert.AreEqual(5, bal);
        }

        [TestMethod]
        public void WithdrawAndGetAcctBal() {
            BankClass acct = new BankClass();
            acct.WithdrawalMoney(5);
            double bal = acct.GetBalance();
            Assert.AreEqual(-5, bal);
        }

       }
}
