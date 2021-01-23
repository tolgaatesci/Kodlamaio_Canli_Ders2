using System;
using System.Collections.Generic;

namespace OOP3
{
    class Program
    {
        static void Main(string[] args)
        {
            İhtiyacKrediManager ihtiyacKrediManager = new İhtiyacKrediManager();
            ihtiyacKrediManager.Hesapla();

            TasitKrediManager tasitKrediManager = new TasitKrediManager();
            tasitKrediManager.Hesapla();

            KonutKrediManager konutKrediManager = new KonutKrediManager();
            konutKrediManager.Hesapla();

            Console.WriteLine("-----------------------------------------");

            IKrediBaseManager ihtiyacKrediManager2 = new İhtiyacKrediManager();
            ihtiyacKrediManager.Hesapla();

            IKrediBaseManager tasitKrediManager2 = new TasitKrediManager();
            tasitKrediManager.Hesapla();

            IKrediBaseManager konutKrediManager2 = new KonutKrediManager();
            konutKrediManager.Hesapla();

            Console.WriteLine("-----------------------------------------");

            //ILoggerService databaseLoggerService = new DatabaseLoggerService();
            ILoggerService fileLogerService = new FileLoggerService();

            BasvuruManager basvuruManager = new BasvuruManager();
            basvuruManager.BasvuruYap(konutKrediManager, fileLogerService);
            basvuruManager.BasvuruYap(ihtiyacKrediManager2, new DatabaseLoggerService());//new DatabaseLoggerService() demek yerine yukarıda ILoggerService databaseLoggerService = new DatabaseLoggerService(); yazıp buradaki parantez içine de databaseLoggerService yazabilirim.

            Console.WriteLine("-----------------------------------------");

            List<IKrediBaseManager> krediler = new List<IKrediBaseManager>() {ihtiyacKrediManager2, tasitKrediManager2 };

            basvuruManager.KrediOnBilgilendirmesiYap(krediler);
            Console.WriteLine("-----------------------------------------");
        }
    }
}
