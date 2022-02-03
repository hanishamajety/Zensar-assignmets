/*2.. Create a Class called Products with Productid, Product Name, Price. Accept 10 Products, sort them based on the price, and display the sorted Products*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Assignment4
{
    class Product
    {
        Dictionary<string, double> Productdetails = new Dictionary<string, double>();
        public void elements()
        {
            Console.WriteLine("Enter any 10 Products Details");
            for(int i=0;i<10;i++)
            {
              Productdetails.Add( Console.ReadLine(), double.Parse(Console.ReadLine()));
                
            }
        }
        public void sortelements()
        {
            Console.WriteLine("----Sorted Array----");
            foreach (KeyValuePair<string,double> price in Productdetails.OrderBy(key=>key.Value))
            {
                Console.WriteLine("Product Name: {0} ,Price: {1} ",price.Key,price.Value);
            }
        }
    class product
        {
            static void Main()
            {
                Product p = new Product();
                p.elements();
                p.sortelements();
            }
        }
        
    }

}

/*OUTPUT:
 * Bat           
 * 1000         
 * Shirt
 * 200
 * Helmet
 * 2000
 * Wickets
 * 3000
 * Rope
 * 1000
 * cap
 * 500
 * Shoes
 * 4000
 * Gloves
 * 2000
 * Bag
 * 1000
 * ----Sorted Array---- 
 * Product Name: Ball ,Price: 200
 * Product Name: Shirt ,Price: 200                                                                                     
 * Product Name: cap ,Price: 500                                                                                       
 * Product Name: Bat ,Price: 1000                                                                                      
 * Product Name: Rope ,Price: 1000                                                                                     
 * Product Name: Bag ,Price: 1000                                                                                     
 * Product Name: Helmet ,Price: 2000                                                                                   
 * Product Name: Gloves ,Price: 2000                                                                                   
 * Product Name: Wickets ,Price: 3000                                                              
 * Product Name: Shoes ,Price: 4000 */