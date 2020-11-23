using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Lab01
{
    class SpecialSavings : Account
    {
        private double openingBalance;

        public double OpeningBalance
        {
            get { return openingBalance; }
            set { openingBalance = value; }
        }


        public SpecialSavings() { }
        public SpecialSavings(string accNo, string accName, double balance) : base(accNo, accName, balance)
        {
            openingBalance = balance;
        }


        public override void Deposit(double amount)
        {
            base.Deposit(amount);
        }

        public override void Withdraw(double amount)
        {

            if ((balance - amount) >= (openingBalance * 0.2))
                balance -= amount;
            else
                Console.WriteLine("Amount should be less than " + (1+balance - (openingBalance * 0.2)));
        }

        public override void ShowInfo()
        {
            base.ShowInfo();
            Console.WriteLine();
        }
    }
}
