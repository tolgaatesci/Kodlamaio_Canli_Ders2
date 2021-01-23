using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class TasitKrediManager : IKrediBaseManager
    {
        public void Hesapla()
        {
            Console.WriteLine("Taşıt kredisi ödeme planı hesaplandı");
        }

        public void Sorgula()
        {
            throw new NotImplementedException();
        }
    }
}
