using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace casestudy1
{
    class Info1
    {
        public void display(Student s1)
        {
            Console.WriteLine("Student Details:");
            Console.WriteLine("Student ID:" + s1.Id);
            Console.WriteLine("Student Name:" + s1.Name);
            Console.WriteLine("Student DOB:" + s1.DateOfBirth);
        }

        public void display(Course c1)
        {
            Console.WriteLine("Course Details:");
            Console.WriteLine("Course ID:" + c1.CID);
            Console.WriteLine("Course Name:" + c1.CName);
            Console.WriteLine("Course Duration:" + c1.Duration);
            Console.WriteLine("Course Fee:" + c1.Fees);
        }
    }
}
