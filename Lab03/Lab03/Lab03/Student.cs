using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab03
{
    class Student
    {
        string name;
        string id;
        string department;
        float cgpa;

        public string name
        {
            set { name = value; }
            get { return name; }
        }
        public string id
        {
            set { id = value; }
            get { return id; }
        }

        public string department
        {
            set { department = value; }
            get { return department; }
        }

        public float cgpa
        {
            set { cgpa = value; }
            get { return cgpa; }
        }

        public void ShowInfo()
        {
            Console.WriteLine("Name : " + name);
            Console.WriteLine("ID : " + id);
            Console.WriteLine("Department : " + department);
            Console.WriteLine("CGPA : " + cgpa);
        }
    }
}
