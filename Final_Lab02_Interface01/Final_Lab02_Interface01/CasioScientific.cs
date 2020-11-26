using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Lab02_Interface01
{
    class CasioScientific : IBasicCalculator, IScientificCalculator
    {
        public int Sum(int x, int y)
        {
            return x + y;
        }

        public int Sub(int x, int y)
        {
            return x - y;
        }

        public int Multiplication(int x, int y)
        {
            return x * y;
        }

        public int Division(int x, int y)
        {
            return x / y;
        }


        public int XtoY(int x, int y)
        {
            return Convert.ToInt32(Math.Pow(x,y));
        }

        public double Log(int x)
        {
            return Math.Log(x);
        }
    }
}
