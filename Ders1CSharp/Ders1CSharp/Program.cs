using System;

namespace Ders1CSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            //Type safety.
            // kategoriEtiketi = alias
            string kategoriEtiketi = "Kategoriler: ";
            double faizOrani= 1.45;
            bool LoginStatus = true;
            double dolarDun = Convert.ToDouble(Console.ReadLine());
            double dolarBugun = Convert.ToDouble(Console.ReadLine());



            if (dolarDun > dolarBugun)
            {
                Console.WriteLine("Dolar düştü.");
            }      

            else if (dolarDun < dolarBugun)
            {
                Console.WriteLine("Dolar Arttı.");
            }
            
            else
            {
                Console.WriteLine("Dolar Değişmedi.");
            }


            





        }
    }
}
