using System;
using System.Collections.Generic;
using System.Threading.Channels;

namespace Koleksiyonlar
{
    class Program
    {
        static void Main(string[] args)
        {
            ////Array / Diziler
            //string[] isimler = new string[] {"Faruk","Kardaş","Engin","Halil"};
            //Console.WriteLine(isimler[0]);
            //Console.WriteLine(isimler[1]);
            //Console.WriteLine(isimler[2]);
            //Console.WriteLine(isimler[3]);


            //isimler = new string[5];
            //isimler[4] = "İlker";
            //Console.WriteLine(isimler[4]);
            //Console.WriteLine(isimler[0]);

            //Collections / Koleksiyonlar

            List<string> customer = new List<string> {"Faruk", "Kardaş", "Ertuğrul", "Aboubakar"};
            customer.Add("Eto");
            Console.WriteLine(customer[0]);
            Console.WriteLine(customer[1]);
            Console.WriteLine(customer[2]);
            Console.WriteLine(customer[3]);
            customer.Add("Sergen");
            Console.WriteLine(customer[4]);
            Console.WriteLine(customer[0]);

            

        }
    }
}
