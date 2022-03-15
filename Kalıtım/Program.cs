using System;

namespace Kalıtım
{
    class Program
    {
        static void Main(string[] args)
        {
            Cari musteri = new Cari();
            musteri.Kaydet(musteri);
            musteri.Sil();

            Console.ReadKey();
        }
    }
}
