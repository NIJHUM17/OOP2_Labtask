using System;
using System.Globalization;

namespace Lab_Task_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Question 1 :");
            int n = 27,i;
            Console.WriteLine("Even Numbers are : ");
            for (i = 1; i <= n; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i);
                }
            }

            Console.WriteLine();

            Console.WriteLine("Question 2 :");

            int j;
            for (i = 0; i < 4; i++)
            {
                for (j = 0; j < 6; j++)
                {
                    if (i % 2 == 0)
                    {
                        if (j % 2 == 0)
                        {
                            Console.Write("X");

                        }
                        else
                        {
                            Console.Write("0");
                        }
                    }
                    else
                    {
                        if (j % 2 == 0)
                        {
                            Console.Write("0");

                        }
                        else
                        {
                            Console.Write("X");
                        }
                    }
                }
                Console.WriteLine();
            }

            Console.WriteLine();

            Console.WriteLine("Question 3 :");

            int row, col;
            for (row = 1; row <= 5; row++)
            {
                for (col = row; col <= (row + 4); col++)
                {
                    Console.Write(col);
                }
                Console.WriteLine();
            }

            Console.WriteLine();

            Console.WriteLine("Question 4 :");

            int even = 0;
            int odd = 0;
            for (i = 1; i <= 100; i++)
            {
                if (i % 2 == 0)
                {
                    even = even + i;

                }
                else
                {
                    odd = odd + i;

                }
            }
            Console.WriteLine("Sum of all even number is : " + even);
            Console.WriteLine("Sum of all odd number is : " + odd);
            Console.WriteLine();

            Console.WriteLine("Question 5 :");

            for (row = 1; row <= 5; row++)
            {
                for (col = 1; col <= (row - 1); col++)
                {
                    Console.Write(" ");
                }
                for (col = row; col <= row; col++)
                {
                    Console.Write(col);
                }
                Console.WriteLine();
            }

            Console.WriteLine();

            Console.WriteLine("Question 6 :");

            int fact = 1;
            for (i = 1; i <= 5; i++)
            {
                fact = fact * i;
            }
            Console.WriteLine("Factorial result : " + fact);
            Console.WriteLine();

            Console.WriteLine("Question 7 :");

            for (row = 1; row <= 5; row++)
            {
                for (col = 1; col <= row; col++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            for (row = 4; row >= 1; row--)
            {
                for (col = 1; col <= row; col++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

        }
    }
}