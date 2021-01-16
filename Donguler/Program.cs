using System;

namespace Donguler
{
    class Program
    {
        static void Main(string[] args)
        {
            //array=dizi
            string[] kurslar = new string[] { "Yazılım geliştirici yetiştirme kampı", "Programlamaya başlangıç için temel kurs", "Java", "Python", "C++" };
            for (int i = 0; i < kurslar.Length; i++) //i=i+2, i+=2 şeklinde de yazılabilir.
            {
                Console.WriteLine(kurslar[i]);
            }

            Console.WriteLine("\n");
            Console.WriteLine("For bitti...");
            Console.WriteLine("\n");

            foreach (string kurs in kurslar) //foreach, dizi temelli yapıları tek tek dönmeye yarıyor. Dizilerde kullanılır.
            {                               //kurs, dinamik değişken gibi görev görüyor, yani kurslar dizindeki elemanı dolanırken kurs'a yazıyor.
                Console.WriteLine(kurs);
            }
            Console.WriteLine("\n");
            Console.WriteLine("Sayfa sonu - footer");
            Console.WriteLine("-----------------------------------------------------------------------------------------------------------------------");
        }
    }
}
