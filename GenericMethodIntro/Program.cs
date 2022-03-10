using System;
using System.Collections.Generic;

namespace GenericMethodIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Kitap> kitapListesi = new List<Kitap>();
            List<Yazar> yazarListesi = new List<Yazar>();
            Ekle(ref kitapListesi, new Kitap
            {
                Id = 1,
                Adi = "Serenad",
                Yazari = "Livaneli",
                SayfaSayisi = 400,
                Barkodu = "12344"
                });
            Ekle(ref kitapListesi, new Kitap
            {
                Id = 2,
                Adi = "Veba Geceleri",
                Yazari = "Orhan Pamuk",
                SayfaSayisi = 500,
                Barkodu = "123321"

            });
            Console.WriteLine("-----Kitap Listesi-----");
            foreach (var kitap in kitapListesi)
            {
                Console.WriteLine($"{kitap.Id} - {kitap.Adi} - {kitap.Yazari} - {kitap.SayfaSayisi} - {kitap.Barkodu}");
            }

            Console.WriteLine("-----Yazar Listesi-----");
            Ekle(ref yazarListesi, new Yazar
            {
                Id = 1,
                Adi = "Zülfü Livaneli"
            });
            Ekle(ref yazarListesi, new Yazar {
                Id = 2,
                Adi = "Orhan Pamuk" });
            foreach (var yazar in yazarListesi)
            {
                Console.WriteLine($"{yazar.Id} - {yazar.Adi}");
            }

            Console.ReadKey();
        }
        public static void Ekle<TVeri>(ref List<TVeri> liste,TVeri veri)//Tip bağımsız metot
        {
            liste.Add(veri);
        }
    }
}
