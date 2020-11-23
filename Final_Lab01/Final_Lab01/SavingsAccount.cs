using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Lab01
{
    class SavingsAccount : Account
    {
        public SavingsAccount() { }
        public SavingsAccount(string accNo, string accName, double balance) : base(accNo, accName, balance)
        {

        }


        public override void Deposit(double amount)
        {
            base.Deposit(amount);
        }

        public override void Withdraw(double amount)
        {
            if (balance - amount >= 500)
            {
                balance -= amount;
            }
            else
                Console.WriteLine("Insufficient Balance");
        }

        public override void ShowInfo()
        {
            base.ShowInfo();
            Console.WriteLine();
        }
    }
}
