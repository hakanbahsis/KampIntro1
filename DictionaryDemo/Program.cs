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
            Console.ReadKey();
        }
    }
}
