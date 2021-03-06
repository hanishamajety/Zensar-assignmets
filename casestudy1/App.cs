using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace casestudy1
{
    class App
    {
        public static void Scenario1()
        {
            Console.WriteLine("----------------Scenario  1----------------");
            Info1 info = new Info1();
            Student student = new Student(101, "pavan", "1-2-1998");
            Student student1 = new Student(102, "sdg", "1-2-3456");
            Student student2 = new Student(103, "svdhc", "1-23-4566");
            info.display(student);
            info.display(student1);
            info.display(student2);
        }

        public static void Scenario2()
        {
            Console.WriteLine("----------------Scenario  2----------------");
            Info1 info = new Info1();
            Student[] std = new Student[3];
            std[0] = new Student(101, "pavani", "1-2-1998");
            std[1] = new Student(102, "sdgc", "1-2-3456");
            std[2] = new Student(103, "svdhch", "1-23-4566");
            for (int i = 0; i < std.Length; i++)
            {
                info.display(std[i]);
                Console.WriteLine();
            }
           // Console.ReadLine();
        }
        public static void Scenario3()
        {
            Console.WriteLine("----------------Scenario  3----------------");
            Console.WriteLine("Enter the number of details to be inserted");
            int n = Convert.ToInt32(Console.ReadLine());
            Student[] std = new Student[n];
            for (int i = 0; i < std.Length; i++)
            {
                Console.WriteLine("Enter the Student ID:");
                int Id = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter the Student Name:");
                string Name = Console.ReadLine();
                Console.WriteLine("Enter the Student DateOfBirth:");
                string DateOfBirth = Console.ReadLine();
                Student s1 = new Student(Id, Name, DateOfBirth);
                std[i] = s1;
            }
            foreach (var r in std)
            {
                Console.WriteLine("\nStudent ID:{0}\nStudent Name:{1}\nStudent DOB:{2}\n", r.Id, r.Name, r.DateOfBirth);
            }
        }

        static void CourseScenario1()
        {
                Console.WriteLine("-------------Course Scenario1-------------");
                
                Info1 info = new Info1();
                Course crs = new Course(1,"JS","1 Month",5000);
                Course crs1 = new Course(2, "HTML", "1 Month",5000);
                Course crs2 = new Course(3, "C Sharp", "1 Month",7000);
                info.display(crs);
                Console.WriteLine();
                info.display(crs1);
                Console.WriteLine();
                info.display(crs2);
                Console.WriteLine();
        }
        public static void CourseScenario2()
        {
            Console.WriteLine("---------------Course-Scenario  2----------------");
            Info1 info = new Info1();
            Course[] c1 = new Course[3];
            c1[0] = new Course(4,"C Language","2 Months",8000);
            c1[1] = new Course(5,"R Language","1 Month",4000);
            c1[2] = new Course(6, "Python", "2 Months",5000);
            for (int i = 0; i < c1.Length; i++)
            {
                info.display(c1[i]);
                Console.WriteLine();
            }
            // Console.ReadLine();
        }

        public static void CourseScenario3()
        {
            Console.WriteLine("--------------Course-Scenario  3----------------");
            Console.WriteLine("Enter the number of details to be inserted");
            int n = Convert.ToInt32(Console.ReadLine());
            Course[] c2 = new Course[n];
            for (int i = 0; i < c2.Length; i++)
            {
                Console.WriteLine("Enter Course ID:");
                int Id = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter Course Name:");
                string Name = Console.ReadLine();
                Console.WriteLine("Enter Course Duration:");
                string Duration = Console.ReadLine();
                Console.WriteLine("Enter Course Fee:");
                int fee = int.Parse(Console.ReadLine());
                Course course1 = new Course(Id, Name, Duration, fee);
                c2[i] = course1;
            }
            foreach (var r in c2)
            {
                Console.WriteLine("\nCourse ID:{0}\nCourse Name:{1}\nCourse Duration:{2}\nCourse Fee:{3}\n", r.CID, r.CName, r.Duration, r.Fees);
            }
        }

        static void Main(string[] args)
        {
            //Scenario1();
            //Scenario2();
            //Scenario3();
            //CourseScenario1();
            //CourseScenario2();
            //CourseScenario3();
            AppEngine ae = new AppEngine();

            //Enroll e = new Enroll();
            //ae.introduce();
            //ae.register();
            Institute_Details ID = new Institute_Details();
            ID.showFirstScreen();
            
            //ae.enroll();

            Console.Read();
        }
    }       
}
