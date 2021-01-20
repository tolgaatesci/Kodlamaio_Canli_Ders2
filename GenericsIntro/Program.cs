using System;

namespace GenericsIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            MyList<string> isimler = new MyList<string>(); //Arkaplanda MyList'deki T string oldu.
            isimler.Add("Engin");
            isimler.Add("Murat");
            Console.WriteLine(isimler[1]);
        }
    }
}
