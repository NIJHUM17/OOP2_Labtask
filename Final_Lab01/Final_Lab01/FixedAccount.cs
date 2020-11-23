using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Lab01
{
    class FixedAccount : Account
    {
        private int tenureYear;

        public int TenureYear
        {
            get { return tenureYear; }
            set { tenureYear = value; }
        }
        private int createYear;

        public int CreateYear
        {
            get { return createYear; }
            set { createYear = value; }
        }


        public FixedAccount()
        {

        }
        public FixedAccount(string accNo, string accName, double balance, int createYear, int tenureYear) : base(accNo, accName, balance)
        {
            this.createYear = createYear;
            this.tenureYear = tenureYear;
        }


        override public void Withdraw(double amount)
        {
            string currentYear = DateTime.Now.Year.ToString();
            int cyear = Int32.Parse(currentYear);
            if (((cyear - createYear) >= tenureYear) && amount <= balance)
            {
                balance -= amount;
            }
            else
                Console.WriteLine("Your account is not matured enough");
        }
        public override void ShowInfo()
        {
            base.ShowInfo();
            Console.WriteLine("Account Opening Year: " + createYear);
            Console.WriteLine("Account Tenure Year: " + tenureYear);
            Console.WriteLine();
        }

    }
}
