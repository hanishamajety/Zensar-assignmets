/*3.Create an Interface IStudent with StudentId and Name as Properties, ShowDetails() as its method. 
 * Create 2 classes Dayscholar and Resident that implements the interface Properties and Methods. Test The functionalities.
*/


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3
{
    public interface IStudent
    {
        
        void ShowDetails(int studid, string studname);

    }
    class Dayscholar : IStudent
    {
        public void ShowDetails(int studid, string studname)
        {
            Console.WriteLine($"The person with {studid} and {studname} belongs to DayScholars");
            Console.Read();
        }
    }

    class Resident: IStudent
    {
        public void ShowDetails(int studid, string studname)
        {
            Console.WriteLine($"The person with {studid} and {studname} belongs to Residental");
            Console.Read();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Dayscholar ds = new Dayscholar();
            ds.ShowDetails(501,"Hanisha");
            Resident rs = new Resident();
            rs.ShowDetails(515, "Nisha");
            Console.Read();
        }
    }
}

/*OUTPUT:
The person with 501 and Hanisha belongs to DayScholars                                                                                                                                                                                       
The person with 515 and Nisha belongs to Residental  */