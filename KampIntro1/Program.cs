using System;

namespace KampIntro1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-----Kurslar-----");
            Kurslar kurs1 = new Kurslar();
            kurs1.KursAdi = "Java";
            kurs1.Egitmen = "Engin Demiroğ";
            kurs1.IzlenmeOrani = 86;

            Kurslar kurs2 = new Kurslar();
            kurs2.KursAdi = "C#";
            kurs2.Egitmen = "Hakan Bahşiş";
            kurs2.IzlenmeOrani = 54;

            Kurslar[] kurslar = new Kurslar[] { kurs1, kurs2 };

            foreach (Kurslar kurs in kurslar)
            {
                Console.WriteLine(kurs.KursAdi);
                Console.WriteLine(kurs.Egitmen);
                Console.WriteLine(kurs.IzlenmeOrani);
                Console.WriteLine("-----------------------");
            }

            Console.WriteLine("-----Ürünler-----");
            Product product = new Product();
            product.UrunAdi = "Elma";
            product.Aciklama = "Amasya Elması";
            product.Fiyat = 15;
            product.Stok = 1000;

            Product product2 = new Product();
            product2.UrunAdi = "Karpuz";
            product2.Aciklama = "Diyarbakır Karpuzu";
            product2.Fiyat = 6;
            product2.Stok = 2000;

            Product[] urunler = new Product[] { product, product2 };
            foreach (Product urun in urunler)
            {
                Console.WriteLine("Ürün Adı : "+urun.UrunAdi);
                Console.WriteLine("Ürün Açıklaması : "+urun.Aciklama);
                Console.WriteLine("Ürün Fiyatı : "+urun.Fiyat);
                Console.WriteLine("Ürün Stok Adedi : +"+urun.Stok);
                Console.WriteLine("----------------");
            }


            Console.ReadKey();
        }

    }
}
