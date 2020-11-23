using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Lab01
{
    abstract class Account
    {
        private string accNo;

        public string AccNo
        {
            get { return accNo; }
            set { accNo = value; }
        }
        private string accName;

        public string AccName
        {
            get { return accName; }
            set { accName = value; }
        }
        protected double balance;

        public double Balance
        {
            get { return balance; }
            set { balance = value; }
        }


        public Account()
        {

        }
        public Account(string accNo, string accName, double balance)
        {
            this.accNo = accNo;
            this.accName = accName;
            this.balance = balance;
        }


        virtual public void Deposit(double amount)
        {
            balance += amount;
        }

        abstract public void Withdraw(double amount);

        virtual public void ShowInfo()
        {
            Console.WriteLine("Acc Name: " + accName);
            Console.WriteLine("Acc No: " + accNo);
            Console.WriteLine("Balance: " + balance);
        }
    }
}
