using System;
using System.Collections.Generic;
using System.Text;

namespace Arayüzler
{
  public  class Arsa : IEmlak,IAdres//Bir class birden fazla interface implemente edebilir.
    {
        public int MetreKare { get; set; }
        public int Fiyat { get; set; }
        public string ImarDurumu { get; set; }//interface sablonları dısında da ozellik eklenebilir.
        public string Il { get; set; }
        public string Ilce { get; set; }
        public string Semt { get; set; }
        public string Adres { get; set; }
        public void Kirala()
        {
            Console.WriteLine("Arsa Kiralandı.");
        }

        public void Sat()
        {
            Console.WriteLine("Arsa Satıldı.");
        }

    }
}
