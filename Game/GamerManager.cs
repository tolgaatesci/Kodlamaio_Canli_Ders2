using System;
using System.Collections.Generic;
using System.Text;

namespace Game
{
    class GamerManager : MethodManager
    {
        List<Gamers> oyuncuListesi = new List<Gamers>();
        public void Ekle(Properties oyuncu)
        {
            oyuncuListesi.Add(Gamers.oyuncu);
            Console.WriteLine(oyuncu.Ad + " adlı " + "Oyuncu eklendi.");
        }

        public void Guncelle(Properties oyuncu)
        {
            //oyuncuListesi.Update(Gamers.oyuncu);
            Console.WriteLine(oyuncu.Ad + " adlı " + "Oyuncu güncellendi.");
        }

        public void Sil(Properties oyuncu)
        {
            oyuncuListesi.Add(Gamers.oyuncu);
            Console.WriteLine(oyuncu.Ad + " adlı " + "Oyuncu silindi.");
        }
    }
}
