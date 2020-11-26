using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Lab02_Interface01
{
    class Program
    {
        static void Main(string[] args)
        {
            int result;

            Console.WriteLine("Basic Calculator : ");
            CasioBasic b1 = new CasioBasic();

            result = b1.Sum(17, 10);
            Console.WriteLine("Summation = " + result);

            result = b1.Sub(17, 10);
            Console.WriteLine("Substraction = " + result);

            result = b1.Multiplication(17, 10);
            Console.WriteLine("Multiplication = " + result);

            result = b1.Division(17, 10);
            Console.WriteLine("Division = " + result);

            Console.WriteLine();

            Console.WriteLine("Scientific Calculator : ");
            CasioScientific s1 = new CasioScientific();

            result = s1.Sum(17, 10);
            Console.WriteLine("Summation = " + result);

            result = s1.Sub(17, 10);
            Console.WriteLine("Substraction = " + result);

            result = s1.Multiplication(17, 10);
            Console.WriteLine("Multiplication = " + result);

            result = s1.Division(17, 10);
            Console.WriteLine("Division = " + result);

            result = s1.XtoY(7,2);
            Console.WriteLine("X to the power Y = " + result);
            
            double ans = s1.Log(10);
            Console.WriteLine("Log = " + ans);

            Console.WriteLine();
        }
    }
}
