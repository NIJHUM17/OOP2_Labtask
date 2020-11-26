using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Lab02_Interface01
{
    interface IBasicCalculator
    {
        int Sum(int x, int y);
        int Sub(int x, int y);
        int Multiplication(int x, int y);
        int Division(int x, int y);
    }
}
