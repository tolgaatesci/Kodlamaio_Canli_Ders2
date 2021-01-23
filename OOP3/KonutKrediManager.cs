using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class KonutKrediManager : IKrediBaseManager
    {
        public void Hesapla()
        {
            Console.WriteLine("Konut kredisi ödeme planı hesaplandı");
        }

        public void Sorgula()
        {
            throw new NotImplementedException();
        }
    }
}
