using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab03
{
    class Course
    {
        private string courseName;
        private string courseCode;
        private int courseCredit;

        public string CourseName
        {
            set { courseName = value; }
            get { return courseName; }
        }

        public string CourseCode
        {
            set { courseCode = value; }
            get { return courseCode; }
        }

        public int CourseCredit
        {
            set { courseCredit = value; }
            get { return courseCredit; }
        }

        public void ShowCourseInfo()
        {
            Console.WriteLine("Course Name   : " + courseName);
            Console.WriteLine("Course Code   : " + courseCode);
            Console.WriteLine("Course Credit : " + courseCredit);
        }
    }
}
