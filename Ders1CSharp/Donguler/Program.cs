using System;

namespace Donguler
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] kurslar = new string[] { "Yazılım Geliştirme Kampı", 
                "Programlamaya başlangıç içi temel kurs", "Java Programlama","Python" };




            for (int i = 0; i < kurslar.Length; i++)
            {
                Console.WriteLine(kurslar[i]);
            }

            Console.WriteLine("1. for döngüsü bitti.");
            

            foreach (string kurs in kurslar) // Her bir kurslar için dön. (foreach sadece stringlerde çalışıyor.)
            {
                Console.WriteLine(kurs);
            }

            Console.WriteLine("Döngü Bitti.");
        }
    }
}
