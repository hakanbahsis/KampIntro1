using System;

namespace Arayüzler
{
    class Program
    {
        static void Main(string[] args)
        {
            EmlakGetir(new Konut());
            IEmlak emlak = new Arsa();//interfaceler newlenmez.
            emlak.Kirala();



            Console.ReadKey();
        }
        static void EmlakGetir(IEmlak emlak)
        {
            emlak.Kirala();
        }
    }

}
