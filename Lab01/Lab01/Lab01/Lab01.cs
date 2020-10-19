using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab01
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "Tahsin Adiba Nijum";
            Console.WriteLine("Hello");
            Console.WriteLine(name);

            int x = 10;
            int y = 17;

            Console.WriteLine("\n02.The sum of two numbers : " + (x + y));
            Console.WriteLine("\n03.The sum of two numbers : " + ((float)y / x));

            int resa = -5 + 8 * 6;
            int resb = (55 + 9) % 9;
            double resc = 20 + -3 * 5 / 8;
            double resd = 5 + 15 / 3 * 2 - 8 % 3;
            Console.WriteLine("\nResult of 4(a) : " + resa);
            Console.WriteLine("Result of 4(b) : " + resb);
            Console.WriteLine("Result of 4(c) : " + resc);
            Console.WriteLine("Result of 4(d) : " + resd);

            int a = 17;
            int b = 10;
            Console.WriteLine("\nResults of 05 : ");
            Console.WriteLine("Sum = " + (a + b));
            Console.WriteLine("Multiply = " + (a * b));
            Console.WriteLine("Subtract = " + (a - b));
            Console.WriteLine("Divide = " + ((double)a / b));
            Console.WriteLine("Remainder = " + (a % b));

            double p = ((25.5 * 3.5 - 3.5 * 3.5) / (40.5 - 4.5));
            Console.WriteLine("\nResult of 06 : " + p);

            double Width = 5.5;
            double Height = 8.5;
            Console.WriteLine("\nResults of 07 : ");
            Console.WriteLine("Area : "+ (Width * Height));
            Console.WriteLine("Perimeter : " + (2 * (Width + Height)));

        }
    }
}
