using System;
using System.Collections.Generic;

namespace OOP3
{
    class Program
    {
        static void Main(string[] args)
        {
            //IhtitacKrediManager ihtitacKrediManager = new IhtitacKrediManager();
            IKrediManager ihtitacKrediManager = new IhtitacKrediManager(); //Kullanılabilir
            //ihtitacKrediManager.Hesapla();
            //TasitKrediManager tasitKrediManager = new TasitKrediManager();
            IKrediManager tasitKrediManager = new TasitKrediManager();
            //tasitKrediManager.Hesapla();
            //KonutKrediManager konutKrediManager = new KonutKrediManager();
            IKrediManager konutKrediManager = new KonutKrediManager();
            //konutKrediManager.Hesapla();
            ILoggerService databaseLoggerService = new DatabaseLoggerServise();
            ILoggerService fileLoggerService = new FileLoggerServise();


            BasvuruManager basvuruManager = new BasvuruManager();
            basvuruManager.BasvuruYap(konutKrediManager,fileLoggerService);

            List<IKrediManager> krediler = new List<IKrediManager>() { ihtitacKrediManager,tasitKrediManager};

           // basvuruManager.KrediOnBilgilendirmesiYap(krediler);


            Console.ReadKey();
        }
    }
}
