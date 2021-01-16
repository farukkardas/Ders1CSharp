

using System;
using System.Collections.Generic;
using System.Text;
using Day3Functions;


namespace Day3Functions
{
    public class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product(); // New product is added.
            product1.Name = "Elma";
            product1.Price = 15;
            product1.Description = "Amasya";

            Product product2 = new Product();
            product2.Name = "karpuz";
            product2.Price = 80;
            product2.Description = "Nameana karpuz";

            Product[] products = new Product[] { product1,product2 };

            foreach (var x in products)
            {
                Console.WriteLine(x.Name);
                Console.WriteLine(x.Price);
                Console.WriteLine(x.Description);
                Console.WriteLine("---------");
            }


            Console.WriteLine("----------");
            SepetManager.AddProduct();

        }


    }
}
