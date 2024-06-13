using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_Encapsulation
{
    public class BankAccount
    {
        public BankAccount()
        {
            
        }

        private double balance = 0;
        public double  Balance { get; set; }

        public void Deposit(double amount)
        {
            balance = amount;
        }

        public double GetBalance()
        {
            return balance;
        }
    }
}
