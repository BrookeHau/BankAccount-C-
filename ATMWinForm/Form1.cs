using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ATMWinForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            showInitialBalanceText.Text = bank.GetBalance().ToString();
        }
        Bank.BankClass bank = new Bank.BankClass();

        private void label1_Click(object sender, EventArgs e)
        {
           
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(withdrawalTextBox.Text)){
                string withdrawalText = this.withdrawalTextBox.Text;
                double withdrawalnum = System.Convert.ToInt32(withdrawalText);
                bank.WithdrawalMoney(withdrawalnum);
            }
            if (!string.IsNullOrEmpty(depositTextBox.Text))
            {
                string depositText = this.depositTextBox.Text;
                double depositnum = System.Convert.ToInt32(depositText);
                bank.DepositMoney(depositnum);
            }
            showBalanceLabel.Text = bank.GetBalance().ToString();
            
        }

        private void textBox1_TextChanged(object sender, EventArgs text)
        {
            

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
           
        }
    }
}
