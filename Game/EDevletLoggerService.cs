using System;
using System.Collections.Generic;
using System.Text;

namespace Game
{
    class EDevletLoggerService : ILoggerService
    {
        public void Log()
        {
            throw new NotImplementedException();
        }


        public void KimlikKontrol(Gamers oyuncu)
        {
            Console.WriteLine("E Devlet Servis: " + oyuncu.Ad + " " + oyuncu.SoyAd + "'ın bilgisi doğrudur.");
        }
    }
}
