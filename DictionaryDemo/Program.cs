using System;
using System.Collections.Generic;

namespace DictionaryDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            
            MyList<int, string> isimler = new MyList<int, string>();
            isimler.Add(1, "Hakan");
            Console.WriteLine(isimler.Length);

            isimler.Add(2, "Engin");
            Console.WriteLine(isimler.Length);

            foreach (var isim in isimler.Value)
            {
                Console.WriteLine(isim);
            }
            Console.WriteLine("----MyDictionary-----");
            MyDictionary<int, string> plakalar = new MyDictionary<int, string>();
            plakalar.Add(01, "Adana");
            Console.WriteLine(plakalar.Length);

            plakalar.Add(73, "Şırnak");
            Console.WriteLine(plakalar.Length);
            foreach (var plaka in plakalar.Value)
            {
                Console.WriteLine(plaka);
            }
            Console.ReadKey();
        }
    }
}
