using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace student
{
    class student
    {

        public int sum, RollNo, Class, Semester;
        public string Name, branch;
        public float Average;
        public int[] marks = new int[5];

        public void Studentdetails()
        {
            Console.WriteLine("Enter Student Name: ");
            Name = Console.ReadLine();
            Console.WriteLine("Enter the Rollno: ");
            RollNo = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the class: ");
            Class = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Semester: ");
            Semester = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Branch: ");
            branch = Console.ReadLine();
        }
        public void displayresults()
        {
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"Enter {i + 1} Subject marks: ");
                marks[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < 5; i++)
            {
                sum += marks[i];

            }
            Average = sum / 5;
            Console.WriteLine("The average of a student in all the subjects is: " + Average);
            for (int i = 0; i < 5; i++)
            {
                if (marks[i] < 35)
                {
                    Console.WriteLine("Failed");
                }
                else if (marks[i] > 35 && Average < 50)
                {
                    Console.WriteLine("Failed");
                }

                else
                {
                    Console.WriteLine("Passed");
                }
            }
        }
        public void displayaverage()
        {


            if (Average > 50)
            {
                Console.WriteLine("The student got PASSED by overall average");
            }
            else
            {
                Console.WriteLine("The student got FAILED by overall average");
            }

        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            student stud = new student();
            stud.Studentdetails();
            stud.displayresults();
            stud.displayaverage();
            Console.Read();
        }
    }
}
