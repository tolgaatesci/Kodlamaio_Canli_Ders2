using System;
using System.Collections.Generic;
using System.Text;

namespace Matematik
{
    class DortIslem
    {
        //dortIslem.Topla(2,3);
        public void Topla(int sayi1, int sayi2)//fonksiyonu-metodu kullanabilmek için 2 sayıya gerek var, bu sayıların veri tipleri "int"
        {
            int toplam = sayi1 + sayi2;
            Console.WriteLine("Sonuc : " + toplam); //burada sonuc string ile toplamdan çıkan sayısal değeri string'e çevirip topluyor aslında, o şekilde yazdırıyor.

        }
    }
}
