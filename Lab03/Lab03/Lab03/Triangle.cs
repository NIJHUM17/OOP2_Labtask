using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab03
{
    class Triangle
    {
        int x;
        int y;
        int z;

        public int x
        {
            set { x = value; }
            get { return x; }
        }

        public int y
        {
            set { y = value; }
            get { return y; }
        }

        public int z
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

        }
    }
}
