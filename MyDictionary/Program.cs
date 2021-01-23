using System;
using System.Collections.Generic;

namespace MyDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> ogrenci = new Dictionary<int, string>();
            ogrenci.Add(123, "Tolga");
            ogrenci.Add(456, "Ahmet");
            ogrenci.Add(789, "Mehmet");

            foreach (var ogrenciler in ogrenci)
            {
                Console.WriteLine(ogrenciler);
            }

            Console.WriteLine("--------------------------------------------------------");

            Console.WriteLine(ogrenci.Count);

            Console.WriteLine("--------------------------------------------------------");

            MyDictionary<int, string> ogrenci2 = new MyDictionary<int, string>();
            ogrenci2.Add(123, "Tolga");
            ogrenci2.Add(456, "Ahmet");
            ogrenci2.Add(789, "Mehmet");

            ogrenci2.Goster();

            
        }
    }
}
