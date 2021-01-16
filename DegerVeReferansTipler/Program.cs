using System;

namespace DegerVeReferansTipler
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            int sayi1 = 10;
            int sayi2 = 30;
            sayi1 = sayi2;
            sayi2 = 65;
            int[] sayilar1 = new int[] { 10, 20, 30 }; //new demek heap'te yeni bir adres tut diyor, sayilar1 de açılan yeni adresi tutuyor
            int[] sayilar2 = new int[] { 100, 200, 300 };
            sayilar1 = sayilar2;//burada sayilar2 dizisi için ayrılan adres, sayilar1'in dizisi için tuttuğu adresin yerine geçiyor. Pointer meselesi yani.
            sayilar2[0] = 999;


            Console.WriteLine(sayi1); //cevap nedir? yaz:
            Console.WriteLine(sayilar1[0]); //cevap nedir? yaz:

            //int, decimal, float, double, string = değer tipi
            //array(dizi), class, interface = referans tipi
            //stack = değer tipi olanlar burada saklanıyor bellek açısından. Yani değer atamalarında sadece değeri atıyor ondan önceki veri tutucu ile bağlantıyı koparıyor
            //heap = referans tipi olanlar burada saklanıyor bellek açısından.

            //bellek kullanımının anlatımı pictures dosyasında DeğerVeReferansTipleri.jpeg'de bulabilirsin. 

        }
    }
}
