using System;

namespace GenericsIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            MyList<string> isimler = new MyList<string>(); //Arkaplanda MyList'deki T string oldu.
            isimler.Add("Engin");
            Console.WriteLine(isimler.Length);
            isimler.Add("Murat");
            Console.WriteLine(isimler.Length);
            Console.WriteLine("--------------------------------------------------------");
            Console.WriteLine(isimler.Items[0]);
            Console.WriteLine(isimler.Items[1]);
            Console.WriteLine("--------------------------------------------------------");
            foreach (var isim in isimler.Items)
            {
                Console.WriteLine(isim);
            }
        }
    }
}
