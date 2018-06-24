using System;
using Bank;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BankTests_
{
    [TestClass]
    public class BankAccountTest
    {

       
        [TestMethod]
        public void DepositAndGetAcctBalance()
        {
            BankClass acct = new BankClass();
            acct.DepositMoney(5);
            double bal = acct.GetBalance();
            Assert.AreEqual(5, bal);
        }

        [TestMethod]
        public void WithdrawAndGetAcctBal()
        {
            BankClass acct = new BankClass();
            acct.DepositMoney(5);
            acct.WithdrawalMoney(5);
            double bal = acct.GetBalance();
            Assert.AreEqual(0, bal);
        }

        [TestMethod]
        public void OverDraftFeeTest()
        {
            BankClass acct = new BankClass();
            acct.WithdrawalMoney(7);
            double bal = acct.GetBalance();
            Assert.AreEqual(-12, bal);
        }

        [TestMethod]
        public void TestDepositAndWithdrawlForOverDraft()
        {
            BankClass acct = new BankClass();
            acct.DepositMoney(1);
            acct.WithdrawalMoney(2);
            double bal = acct.GetBalance();
            Assert.AreEqual(-6, bal);
        }

        [TestMethod]
        public void TestDepositAndWithdrawlRegular()
        {
            BankClass acct = new BankClass();
            acct.DepositMoney(13);
            acct.WithdrawalMoney(2);
            double bal = acct.GetBalance();
            Assert.AreEqual(11, bal);
        }

    }
}
