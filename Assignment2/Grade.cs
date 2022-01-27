using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    abstract class Grade
    {
        public string name;
        public int studid;
        public float grade;
        abstract public Boolean Ispassed(float grade);
    }
    class undergraduate : Grade
    {
        public override Boolean Ispassed(float grade)
        {
            Console.WriteLine("Enter Name of the Student is:");
            name = Console.ReadLine();
            Console.WriteLine("Student Name:{0}", name);
            Console.WriteLine("Enter Student Id:");
            studid = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("StudentId:{0}", studid);

            if(grade>=70.0)
            {
                Console.WriteLine("Student's Grade is: ");
                return true;
            }

            else
            {
                Console.WriteLine("Student's Grade is: ");
                return false;
            }
        }
    }
    class graduate : Grade
    {
        public override Boolean Ispassed(float grade)
        {
            Console.WriteLine("Enter Name of the Student is:");
            name = Console.ReadLine();
            Console.WriteLine("Student Name:{0}", name);
            Console.WriteLine("Enter Student Id:");
            studid = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("StudentId:{0}", studid);

            if (grade >= 80.0)
            {
                Console.WriteLine("Student's Grade is: ");
                return true;
            }

            else
            {
                Console.WriteLine("Student's Grade is: ");
                return false;
            }
        }
    }

    class Abstract
    {
        public static void Main()
        {
            undergraduate ungrd = new undergraduate();
            Console.WriteLine(ungrd.Ispassed(68.0f));

            graduate grd = new graduate();
            Console.WriteLine(grd.Ispassed(75.0f));

        }
    }
}
