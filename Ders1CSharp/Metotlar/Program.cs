using System;

namespace Metotlar
{
    class Program
    {
        static void Main(string[] args)
        {
           
            // İki adet ürün ekledik ve class içindeki özelikleri eklenen ürünlere tanımladık.
            Product urun1 = new Product();
            urun1.Ad = "Elma";
            urun1.Fiyat = 15;
            urun1.Aciklama = "Sulu elma.";

            Product urun2 = new Product();
            urun2.Ad = "Karpuz";
            urun2.Fiyat = 50;
            urun2.Aciklama = "Adana  karpuzu.";

            //Ürünleri bir diziye atadık.
            Product[] urunler = new Product[] { urun1, urun2 };

            // Atadığımız ürünleri foreach döngüsü ile döndürdük.
            foreach (var urun in urunler)
            {
                Console.WriteLine(urun.Ad);
                Console.WriteLine(urun.Fiyat);
                Console.WriteLine(urun.Aciklama);
                Console.WriteLine("-----------------");

            }

            Console.WriteLine("--------Metotlar--------");

            // Sepete ekle methodunu çağırdık içine istediğimiz ürünü ekledik eklediğimiz ürünün parametresini girdik ona göre adını yazdırdı.
            SepetManager sepetManager = new SepetManager();
            sepetManager.Ekle(urun1);
            sepetManager.Ekle(urun2);



        }

    }
}
