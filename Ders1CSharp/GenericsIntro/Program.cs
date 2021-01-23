using System;

namespace GenericsIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            
            MyLists<string> isimler = new MyLists<string>();
            isimler.Add("Engin");

            Console.WriteLine(isimler.Length);

            isimler.Add("Faruk");

            Console.WriteLine(isimler.Length);

            foreach (var item in isimler.Items)
            {
                Console.WriteLine(item);
            }

        }
    }
}
