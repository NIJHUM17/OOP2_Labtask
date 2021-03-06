﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab03
{
    class Account
    {
        private string accName;
        private string acid;
        private int balance;

        public string AccName
        {
            set { accName = value; }
            get { return accName; }
        }

        public string Acid
        {
            set { acid = value; }
            get { return acid; }
        }

        public int Balance
        {
            set { balance = value; }
            get { return balance; }
        }

        public int Deposit(int amount)
        {
            if (amount > 0)
            {
                Console.WriteLine("Deposited amount = " + amount);
                balance += amount;
                Console.WriteLine("New balance = " + balance);
            }
            else
            {
                Console.WriteLine("Error");
            }
            return amount;
        }

        public int Withdraw(int amount)
        {
            if (amount <= balance)
            {
                Console.WriteLine("Amount withdrawed = "+amount);
                balance -= amount;
                Console.WriteLine("New balance = " + balance);
            }
            else
            {
                Console.WriteLine("Not enough balance to withdraw");
            }
            return amount;
        }
    }
}
