using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab03
{
    class Course
    {
        string courseName;
        string courseCode;
        int courseCredit;

        public string courseName
        {
            set { courseName = value; }
            get { return courseName; }
        }

        public string courseCode
        {
            set { courseCode = value; }
            get { return courseCode; }
        }

        public int courseCredit
        {
            set { courseCredit = value; }
            get { return courseCredit; }
        }


    }
}
