using System;
using System.Collections.Generic;
using System.Text;

namespace Game
{
    interface ILoggerService
    {
        void Log();
        void KimlikKontrol(Gamers oyuncu);
    }
}
