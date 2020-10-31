using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab03
{
    class Triangle
    {
        private int x;
        private int y;
        private int z;

        public int X
        {
            set { x = value; }
            get { return x; }
        }

        public int Y
        {
            set { y = value; }
            get { return y; }
        }

        public int Z
        {
            set { z = value; }
            get { return z; }
        }

        public void ShowInfo()
        {
            Console.WriteLine("x = " + x);
            Console.WriteLine("y = " + y);
            Console.WriteLine("z = " + z);
        }

        public void TestTriangle()
        {
            if (x == y && y == z)
            {
                Console.WriteLine("An equilateral triangle");
            }
            else if (x == y || x == z || y == z)
            {
                Console.WriteLine("An isosceles triangle");
            }
            else
            {
                Console.WriteLine("A scalene triangle");
            }
        }
    }
}
