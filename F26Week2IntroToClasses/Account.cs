using System;
using System.Collections.Generic;
using System.Text;

namespace F26Week2IntroToClasses
{
    public class Account
    {
        // prop + Tab
        public int MyProperty { get; set; }

        // propg + Tab
        public int MyProperty1 { get; private set; }


        // propfull + Tab
        private double _balance;

        public double Balance
        {
            get { return _balance; }
            private set { _balance = value; }
        }


        public Account(double startingBalance)
        {
            Balance = startingBalance;
        }

        public void Deposit(double amount)
        {
            Balance += amount;
        }

        public void Withdraw(double amount)
        {
            Balance -= amount;
        }
    }
}
