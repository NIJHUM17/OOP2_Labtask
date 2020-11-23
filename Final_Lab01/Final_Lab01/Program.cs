using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Lab01
{
    class Program
    {
        static void Main(string[] args)
        {
            Account fa1 = new FixedAccount("101", "Fixed", 5000, 2017, 2027);
            Account sa1 = new SavingsAccount("102", "Savings", 5000);
            Account od1 = new Overdraft("103", "Overdraft", 5000, 1000);
            Account ss1 = new SpecialSavings("104", "Special Savings", 5000);

            fa1.Deposit(2000);
            fa1.Withdraw(3000);
            Console.WriteLine();
            fa1.ShowInfo();
            
            sa1.Deposit(2000);
            sa1.Withdraw(3000);
            Console.WriteLine();
            sa1.ShowInfo();
            
            od1.Deposit(2000);
            od1.Withdraw(8001);
            Console.WriteLine();
            od1.ShowInfo();
            
            ss1.Deposit(2000);
            ss1.Withdraw(6001);
            Console.WriteLine();
            ss1.ShowInfo();
        }
    }
}
