using System;

namespace Kodlamaio_CanlıDers2
{
    class Program
    {
        static void Main(string[] args)
        {
            string kategoriEtiketi = "Kategoriler"; //type safety = tip güvenliği yani string olarak değişkenimizi belirttik, Pyhton'da gerek yoktu.
            int ogrenciSayisi = 32000;
            double faizOrani = 1.45;
            bool sistemeGirisYapmisMi = false;
            double dolarDun = 7.55;
            double dolarBugun = 7.55;

            if (dolarDun > dolarBugun )
            {
                Console.WriteLine("Azalış butonu");

            }
            else if(dolarDun < dolarBugun)
            {
                Console.WriteLine("Artış butonu");
            }
            else
            {
                Console.WriteLine("Değişmedi butonu");
            }

            
            if (sistemeGirisYapmisMi == true)
            {
                Console.WriteLine("Kullanıcı ayarları butonu");
            }
            else
            {
                Console.WriteLine("Giriş yap butonu");
            }
            //veri tipi = int, double, string
            //do not repeat yourself
            //değer tutucu, alias, değişken = kategoriEtiketi
            Console.WriteLine(kategoriEtiketi);
            Console.WriteLine(" ");
            Console.WriteLine("-----------------------------------------------------------------------------------------------------------------------");
        }
    }
}
