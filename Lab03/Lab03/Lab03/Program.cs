using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab03
{
    class Program
    {
        static void Main(string[] args)
        {
            Student std = new Student();
            std.Name = "Nijum";
            std.Id = "19-40428-1";
            std.Department = "CSE";
            std.Cgpa = 3.76f;
            std.ShowInfo();

            Console.WriteLine();

            Triangle tr = new Triangle();
            tr.X = 7;
            tr.Y = 7;
            tr.Z = 10;
            tr.ShowInfo();
            tr.TestTriangle();

            Console.WriteLine();

            Account acc = new Account();
            acc.AccName = "tahsinnijum";
            acc.Acid = "101217";
            acc.Balance = 5000;
            acc.Deposit(500);
            acc.Withdraw(250);

            Console.WriteLine();

            Course crs = new Course();
            crs.CourseName = "OOP2";
            crs.CourseCode = "C#";
            crs.CourseCredit = 3;
            crs.ShowCourseInfo();

            Console.WriteLine();
        }
    }
}
