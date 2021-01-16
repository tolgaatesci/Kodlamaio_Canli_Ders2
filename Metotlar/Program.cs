using System;

namespace Metotlar
{
    class Program
    {
        static void Main(string[] args)
        {
            //metotlar tekrar tekrar kullanabilirliği sağlayan araçlardır yani fonksiyonlardır.
            //clean code - best practice - DRY ( Don't repeat yourself ) bunlar teknikler.
            string UrunAdi = "Elma";
            string Aciklama = "Amasya elması";
            string[] meyveler = new string[] {"Elma", "Karpuz" };
            
            Urun urun1 = new Urun();
            urun1.Adi = "Elma";
            urun1.Fiyati = 15;
            urun1.Aciklama = "Amasya elması";

            Urun urun2 = new Urun();
            urun2.Adi = "Karpuz";
            urun2.Fiyati = 80;
            urun2.Aciklama = "Diyarbakır karpuzu";

            Urun[] urunler = new Urun[] { urun1, urun2 };

            foreach (Urun urun in urunler)
            {
                Console.WriteLine(urun.Adi);
                Console.WriteLine(urun.Fiyati);
                Console.WriteLine(urun.Aciklama);
                Console.WriteLine("---------------------");
                Console.WriteLine("\n");
            }

            Console.WriteLine("-------Metotlar1-------");
            
            //instance - örnek, metodu tanımladık yani sonuçta class o da.
            //encapsulation

            SepetManager sepetManager = new SepetManager();
            sepetManager.Ekle(urun1); //çağırdık bu şekilde 
            sepetManager.Ekle(urun2);

            Console.WriteLine("\n");
            Console.WriteLine("-------Metotlar2-------");

            sepetManager.Ekle2("Armut", "Yeşil armut", 12, 1000);
            sepetManager.Ekle2("Elma", "Yeşil ekma", 16, 2000);
            sepetManager.Ekle2("Karpuz", "Diyarbakır karpuzu", 80, 3000);

        }
    }
}
