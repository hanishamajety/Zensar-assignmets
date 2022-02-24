using Microsoft.OData.Edm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_Assignment
{
    class EmployeeDetails
    {
        public int EmployeeID;
        public string FirstName;
        public string LastName;
        public string Title;
        public Date DOB;
        public Date DOJ;
        public string City;
    }

    class Program
    {
        static void Main(string[] args)
        {
            List<EmployeeDetails> emp = new List<EmployeeDetails>()
            {
                 new EmployeeDetails(){EmployeeID=1001,FirstName="Malcolm  ",LastName="Daruwalla",Title="Manager    ",DOB=DateTime.Parse("16/11/1984"),DOJ=DateTime.Parse("8/6/2011"), City=" Mumbai"},
                 new EmployeeDetails(){EmployeeID=1002,FirstName="Asdin    ",LastName="Dhalla   ",Title="AsstManager",DOB=DateTime.Parse("20/08/1984"),DOJ =DateTime.Parse("7/7/2012"), City=" Mumbai"},
                 new EmployeeDetails(){EmployeeID=1003,FirstName="Madhavi  ",LastName="Oza      ",Title="Consultant ",DOB=DateTime.Parse("14/11/1987"),DOJ=DateTime.Parse("12/4/2015"), City=" Pune"},
                 new EmployeeDetails(){EmployeeID=1004,FirstName="Saba     ",LastName="Shaikh   ",Title="SE         ",DOB=DateTime.Parse("3/6/1990  "),DOJ=DateTime.Parse("2/2/2016"), City=" Pune"},
                 new EmployeeDetails(){EmployeeID=1005,FirstName="Nazia    ",LastName="Shaikh   ",Title="SE         ",DOB=DateTime.Parse("8/3/1991  ") ,DOJ=DateTime.Parse("2/2/2016"), City=" Mumbai"},
                 new EmployeeDetails(){EmployeeID=1006,FirstName="Amit     ",LastName="Pathak   ",Title="Consultant ",DOB=DateTime.Parse("7/11/1989 "),DOJ=DateTime.Parse("8/8/2014"), City=" Chennai"},
                 new EmployeeDetails(){EmployeeID=1007,FirstName="Vijay    ",LastName="Natrajan ",Title="Consultant ",DOB=DateTime.Parse("2/12/1989 "),DOJ=DateTime.Parse("1/6/2015"), City=" Mumbai"},
                 new EmployeeDetails(){EmployeeID=1008,FirstName="Rahul    ",LastName="Dubey    ",Title="Associate  ",DOB=DateTime.Parse("11/11/1993"),DOJ=DateTime.Parse("6/11/2014"), City=" Chennai"},
                 new EmployeeDetails(){EmployeeID=1009,FirstName="Suresh   ",LastName="Mistry   ",Title="Associate  ",DOB=DateTime.Parse("12/8/1992 "),DOJ=DateTime.Parse("3/12/2014"), City=" Chennai"},
                 new EmployeeDetails(){EmployeeID=1010,FirstName="Sumit    ",LastName="Shah     ",Title="Manager    ",DOB=DateTime.Parse("12/4/1991 "),DOJ=DateTime.Parse("2/1/2016"), City=" Pune"},
            };

            Console.WriteLine(" 1.Display detail of all the employee");

            foreach (var i in emp)
            {
                Console.WriteLine($"{i.EmployeeID}      {i.FirstName}      {i.LastName}     {i.Title}       {i.DOB}        {i.DOJ}     {i.City}");
            }
            Console.WriteLine();


            Console.WriteLine("2. the employee whose location is not Mumbai: ");
            Console.WriteLine("");
            var result = from s in emp
                         where !(!(s.City is "Pune") && !(s.City is "Chennai"))
                         select s;
            foreach (var i in result)
            {
                Console.WriteLine($"{i.EmployeeID}   {i.FirstName}   {i.LastName}   {i.Title}   {i.DOB}   {i.DOJ}   {i.City}");
            }

            Console.WriteLine("");


            //}

            //3.the employee whose title is AsstManager
            Console.WriteLine("3.the employee whose title is AsstManager: ");
                Console.WriteLine("");
                var res2 = emp.Where(t => t.Title == "AsstManager").ToList<EmployeeDetails>();
                foreach (var i in res2)
                {
                    Console.WriteLine($"{i.EmployeeID} {i.FirstName} {i.LastName} {i.Title} {i.DOB} {i.DOJ} {i.City}");
                }
                Console.WriteLine();



                //4.the employee whose Last Name start with S
                Console.WriteLine("4.the employee whose Last Name start with S:");
                Console.WriteLine("");
                var res3 = from s in emp
                           where s.LastName.StartsWith("S")
                           select s.LastName;
                foreach (var s in res3)
                {
                    Console.WriteLine(s);
                }
                Console.WriteLine("");


                ////5.the employee who have joined before 1/1/2015
                Console.WriteLine("5.the employee who have joined before 1/1/2015 :");
                Console.WriteLine("");
                var r4 = from d in emp
                         where d.DOJ < Date.Parse(" 1/ 1/2015")
                         select d;
                foreach (var d in r4)
                {
                    Console.WriteLine(d.EmployeeID + "    " + d.FirstName + "   " + d.LastName + "  " + d.DOB + "   " + d.DOJ + "   " + d.City);
                }
                Console.WriteLine("");



                Console.WriteLine("6.the employee whose date of birth is after 1/1/1990 :");
                Console.WriteLine("");
                var r5 = from s in emp
                         where s.DOB > Date.Parse("1/1/1990")
                         select s;
                foreach (var d in r5)
                {
                    Console.WriteLine(d.EmployeeID + "    " + d.FirstName + "   " + d.LastName + "  " + d.DOB + "   " + d.DOJ + "   " + d.City);
                }
                Console.WriteLine("");


                Console.WriteLine("7.the employee whose designation is Consultant and Associate :");
                var r6 = from d in emp
                         where !(!(d.Title is "Consultant ") && !(d.Title is "Associate  "))
                         select d;
                foreach (var d in r6)
                {
                    Console.WriteLine(d.EmployeeID + "    " + d.FirstName + "   " + d.LastName + "  " + d.Title + "    " + d.DOB + "   " + d.DOJ + "   " + d.City);
                }
                Console.WriteLine("");


                Console.WriteLine("8.Display total number of employees :");
                var r7 = emp.Count();
                Console.WriteLine(r7);


                Console.Write("9. Display total number of employees belonging to “Chennai” : ");
                var r8 = (from d in emp
                          where d.City == "Chennai"
                          select d.EmployeeID).Count();
                Console.WriteLine(r8);
                Console.WriteLine(" ");


                Console.WriteLine("10.Display highest employee id from the list\n");
                int r9 = (from e in emp
                          select e.EmployeeID).Max();
                Console.WriteLine("Highest Employee ID 's : {0}", r9);
                Console.WriteLine(" ");

                Console.WriteLine("11.Display a list of all the employee who have joined after 1 / 1 / 2015\n");
                var r10 = from e in emp
                          where e.DOJ > Date.Parse("01/01/2015")
                          select e;
                foreach (var d in r10)
                
                {
                    Console.WriteLine(d.EmployeeID + "    " + d.FirstName + "   " + d.LastName + "  " + d.DOB + "   " + d.DOJ + "   " + d.City);

                }
                Console.Write("12. Display total number of employee whose designation is not “Associate” :");
                var tit = emp.Where(d => d.Title == "Associate  ").Count<EmployeeDetails>();
                Console.WriteLine(tit);
                Console.WriteLine("");

                Console.WriteLine("");
                Console.WriteLine("13. Display total number of employee based on City: ");
                //var tote = emplist.Where(d => d.City == "Chennai" ).Count<Employee>();
                //Console.WriteLine("Chennai: "+ tote);
                //var tota = emplist.Where(d =>  d.City == "Mumbai" ).Count<Employee>();
                //Console.WriteLine("Mumbai: " +tota);
                //var total = emplist.Where(d =>  d.City == "Pune").Count<Employee>();
                //Console.WriteLine("Pune: "+total);

                var myquery13 = from p in emp
                                group p by p.City into g
                                select new { City = g.Key, ProductCount = g.Count() };
                Console.WriteLine("City\t   No.of Employees");
                foreach (var group in myquery13)
                {
                    Console.WriteLine(group.City + "\t\t" + group.ProductCount);
                }

                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("14. Display total number of employee based on city and title : ");
                
                
                var myquery14 = from t in emp
                                group t by t.Title into g
                                select new { Title = g.Key, ProductCount = g.Count() };
                Console.WriteLine("Ttile\t   No.of Employees");
                foreach (var group in myquery14)
                {
                    Console.WriteLine(group.Title + "\t\t" + group.ProductCount);
                }

                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("15. Display total number of employee who is youngest in the list :");
                var yo = emp.Max(x => x.DOB);
                var you = emp.Where(x => x.DOB == yo);

                foreach (var d in you)
                {
                    Console.WriteLine("The youngest Employee Of All the Employees is : {0} {1}", d.FirstName, d.LastName);
                }
                Console.ReadKey();


        }
    }
}


