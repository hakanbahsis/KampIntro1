using System;
using System.Collections.Generic;

namespace GenericsIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            SortedList<int, string> kullanicilar = new SortedList<int, string>();
            kullanicilar.Add(0, "hakan");
            kullanicilar.Add(2, "Barış");
            kullanicilar.Add(1, "baran");
            foreach (KeyValuePair<int,string> kullanici in kullanicilar )
            {
                Console.WriteLine("ID = "+kullanici.Key+"\t"+"Value = "+kullanici.Value);        
            }

            Console.WriteLine("Dictionary");

            Dictionary<int, string> dKullanicilar = new Dictionary<int, string>();
            dKullanicilar.Add(0, "abc");
            dKullanicilar.Add(2, "bac");
            dKullanicilar.Add(1, "cba");
            foreach (KeyValuePair<int,string> kullanici in dKullanicilar)
            {
                Console.WriteLine("ID = " + kullanici.Key + "\t" + "Value = " + kullanici.Value);
            }


            Console.ReadKey();
        }
    }
}
