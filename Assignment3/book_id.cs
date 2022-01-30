/*4. Write a program in C# Sharp to declare a structure called Books with a property, a method to 
 * display the value of Book_id, and a private field called Book_id (int)
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3
{
    struct book
    {
        private int BookId;

        public int n
        {
            get
            {
                return BookId;
            }
            set
            {
                BookId = value;
            }

        }
        public void display()
        {
            Console.WriteLine("Enter the book id : "+n);
        }
    }


    class book_id
    {
        public static void Main()
        {
            book bi = new book();
            bi.n = 112;
            bi.display();
            Console.Read();

        }
    }
}

/*OUTPUT:
 * Enter the book id : 112  */
