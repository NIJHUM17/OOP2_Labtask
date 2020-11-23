using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Lab01
{
    class Overdraft : Account
    {
        private double overdraftLimit;

        public double OverdraftLimit
        {
            get { return overdraftLimit; }
            set { overdraftLimit = value; }
        }

        private double totalLimit;

        public double TotalLimit
        {
            get { return totalLimit; }
            set { totalLimit = value; }
        }


        public Overdraft() { }
        public Overdraft(string accNo, string accName, double balance, double overdraftLimit) : base(accNo, accName, balance)
        {
            this.overdraftLimit = overdraftLimit;
        }


        public override void Deposit(double amount)
        {
            base.Deposit(amount);
        }

        public override void Withdraw(double amount)
        {
            totalLimit = balance + overdraftLimit;
            if (amount <= totalLimit)
            {
                balance -= amount;
            }
            else
                Console.WriteLine("Amount has crossed the limit.");
        }

        public override void ShowInfo()
        {
            base.ShowInfo();
            Console.WriteLine("Overdraft Limit : " + overdraftLimit);
            Console.WriteLine();
        }
    }
}
