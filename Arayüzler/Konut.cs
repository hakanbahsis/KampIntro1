using System;
using System.Collections.Generic;
using System.Text;

namespace Arayüzler
{
   public class Konut : IEmlak,IAdres
    {
        public int MetreKare { get; set ; }
        public int Fiyat { get; set; }
        public string Cephe { get; set; }
        public string Il { get; set; }
        public string Ilce { get; set; }
        public string Semt { get; set; }
        public string Adres { get; set; }
        public void Kirala()
        {
            Console.WriteLine("Konut Kiralandı.");
        }

        public void Sat()
        {
            Console.WriteLine("Konut Satıldı.");
        }
        public void GunlukKiralik()
        {
            Console.WriteLine("Konut Günlük Kiralandı.");
        }
        public void DevrenSatilik()
        {
            Console.WriteLine("Konut Devren Satıldı.");
        }
    }
}
