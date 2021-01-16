using System;

namespace ClassGiris
{

    class Program
    {
        static void Main(string[] args)
        {
            var ad = "Faruk";
            var yas = 22;

            

            //Yeni bir kurs elemanı oluşturduk.
            Kurs kurs1 = new Kurs();
            
            // Kursların elemanlarını ve özelliklerini tanımladık. 
            kurs1.KursAdi = "C# Kursu"; 
            kurs1.Egitmen = "Engin Demiroğ";
            kurs1.IzlenmeOrani = 100;

            Kurs kurs2 = new Kurs();
            kurs2.KursAdi = "C++ Kursu";
            kurs2.Egitmen = "Faruk Kardaş";
            kurs2.IzlenmeOrani = 20;

            Kurs kurs3 = new Kurs();
            kurs3.KursAdi = "Java Kursu";
            kurs3.Egitmen = "Ahmet Mehmet";
            kurs3.IzlenmeOrani = 15;

            ///Kursları manuel olarak yazdırdık.
            
            //Console.WriteLine(kurs1.KursAdi + " : " + kurs1.Egitmen + " : " + kurs1.IzlenmeOrani);
            //Console.WriteLine(kurs2.KursAdi + " : " + kurs2.Egitmen + " : " + kurs2.IzlenmeOrani);
            //Console.WriteLine(kurs3.KursAdi + " : " + kurs3.Egitmen + " : " + kurs3.IzlenmeOrani);

            Kurs[] kurslar = new Kurs[] {kurs1,kurs2,kurs3 }; //Array(dizi) tanımladık içinde farklı öğeler tutabiliyor.

            //Döngü içerisinde yazdırdık.
            foreach (var kloop in kurslar)
            {
                Console.WriteLine(kloop.KursAdi + " : " + kloop.Egitmen + " : " + kloop.IzlenmeOrani);
            }

        }
    }
    class Kurs
    {
        public string KursAdi { get; set; }
        public string Egitmen { get; set; }
        public int IzlenmeOrani { get; set; }
    
    }

}
