using System;
using System.Collections.Generic;

namespace GenericsIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            //TestMethod();

            List<Kitap> kitapListesi = new List<Kitap>();
            //1.Tanımlama Yöntemi
            Kitap kitap1 = new Kitap();
            kitap1.Id = 1;
            kitap1.Adi = "Vadideki Zambak";
            kitap1.Yazari = "Balzac";
            kitap1.SayfaSayisi = 250;
            kitap1.Barkodu = "12345";

            kitapListesi.Add(kitap1);

            //2.Tanımlama Yöntemi
            kitapListesi.Add(new Kitap
            {
                Id = 2,
                Adi="Sefiller",
                Yazari="Victor Hugo",
                SayfaSayisi=500,
                Barkodu="34567"
            });
            //3.Tanımlama Yöntemi
            Ekle(ref kitapListesi, new Kitap
            {
                Id = 3,
                Adi = "Savaş ve Barış",
                Barkodu = "9876",
                Yazari = "Lev Tolstoy",
                SayfaSayisi = 1000
            });


            foreach (var kitap in kitapListesi)
            {
                Console.WriteLine($"{kitap.Id} -  {kitap.Adi} - {kitap.Yazari} - {kitap.SayfaSayisi} - {kitap.Barkodu}");
            }

            
            
            Console.ReadKey();
          
        }

        public static void Ekle<TVeri>(ref List<TVeri> liste,TVeri veri)
        {
            liste.Add(veri);
        }


        private static void TestMethod()
        {
            SortedList<int, string> kullanicilar = new SortedList<int, string>();
            kullanicilar.Add(0, "hakan");
            kullanicilar.Add(2, "Barış");
            kullanicilar.Add(1, "baran");
            foreach (KeyValuePair<int, string> kullanici in kullanicilar)
            {
                Console.WriteLine("ID = " + kullanici.Key + "\t" + "Value = " + kullanici.Value);
            }

            Console.WriteLine("Dictionary");

            Dictionary<int, string> dKullanicilar = new Dictionary<int, string>();
            dKullanicilar.Add(0, "abc");
            dKullanicilar.Add(2, "bac");
            dKullanicilar.Add(1, "cba");
            foreach (KeyValuePair<int, string> kullanici in dKullanicilar)
            {
                Console.WriteLine("ID = " + kullanici.Key + "\t" + "Value = " + kullanici.Value);
            }
        }
    }
}

   

