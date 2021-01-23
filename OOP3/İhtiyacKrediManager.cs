using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class İhtiyacKrediManager : IKrediBaseManager
    {
        public void Hesapla()
        {
            Console.WriteLine("İhtiyaç kredisi ödeme planı hesaplandı");
        }

        public void Sorgula()
        {
            throw new NotImplementedException();
        }
    }
}
