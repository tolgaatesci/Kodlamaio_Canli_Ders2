using System;
using System.Collections.Generic;
using System.Text;

namespace Game
{
    class Gamers:Properties
    {
        internal static Gamers oyuncu;
        public string SoyAd { get; set; }
        public string Cinsiyet { get; set; }
        public string TcNo { get; set; }
        public string DogumYili { get; set; }
    }
}
