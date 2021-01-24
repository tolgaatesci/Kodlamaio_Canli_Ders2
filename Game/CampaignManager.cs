using System;
using System.Collections.Generic;
using System.Text;

namespace Game
{
    class CampaignManager : MethodManager
    {
        List<Campaigns> kampanyaListesi = new List<Campaigns>();

        public void Ekle(Properties kampanya)
        {
            kampanyaListesi.Add(Campaigns.kampanya);
            Console.WriteLine(kampanya.Ad + " adlı " + "Kampanya eklendi.");

        }

        public void Guncelle(Properties kampanya)
        {
            //kampanyaListesi.Update(Campaigns.kampanya);
            Console.WriteLine(kampanya.Ad + " adlı " + "Kampanya güncellendi.");
        }

        public void Sil(Properties kampanya)
        {
            kampanyaListesi.Remove(Campaigns.kampanya);
            Console.WriteLine(kampanya.Ad + " adlı " + "Kampanya silindi.");

        }

        
    }
}
